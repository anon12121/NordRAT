using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Server.StreamLibrary
{
	// Token: 0x02000011 RID: 17
	public class UnsafeStreamCodec : IDisposable
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00009836 File Offset: 0x00007A36
		// (set) Token: 0x0600006F RID: 111 RVA: 0x0000983E File Offset: 0x00007A3E
		internal Size Resolution { get; private set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00009847 File Offset: 0x00007A47
		// (set) Token: 0x06000071 RID: 113 RVA: 0x0000984F File Offset: 0x00007A4F
		internal Size CheckBlock { get; private set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00009858 File Offset: 0x00007A58
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00009860 File Offset: 0x00007A60
		internal int ImageQuality
		{
			get
			{
				return this._imageQuality;
			}
			private set
			{
				object imageProcessLock = this._imageProcessLock;
				lock (imageProcessLock)
				{
					this._imageQuality = value;
					if (this._jpgCompression != null)
					{
						this._jpgCompression.Dispose();
					}
					this._jpgCompression = new JpgCompression((long)this._imageQuality);
				}
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000098C8 File Offset: 0x00007AC8
		internal UnsafeStreamCodec(int imageQuality)
		{
			this.ImageQuality = imageQuality;
			this.CheckBlock = new Size(50, 1);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000098F0 File Offset: 0x00007AF0
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000098FF File Offset: 0x00007AFF
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this._decodedBitmap != null)
				{
					this._decodedBitmap.Dispose();
				}
				if (this._jpgCompression != null)
				{
					this._jpgCompression.Dispose();
				}
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000992C File Offset: 0x00007B2C
		internal unsafe void CodeImage(IntPtr scan0, Rectangle scanArea, Size imageSize, PixelFormat format, Stream outStream)
		{
			object imageProcessLock = this._imageProcessLock;
			lock (imageProcessLock)
			{
				byte* ptr;
				if (IntPtr.Size == 8)
				{
					ptr = scan0.ToInt64();
				}
				else
				{
					ptr = scan0.ToInt32();
				}
				if (!outStream.CanWrite)
				{
					throw new Exception("Must have access to Write in the Stream");
				}
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				if (format <= PixelFormat.Format32bppRgb)
				{
					if (format == PixelFormat.Format24bppRgb || format == PixelFormat.Format32bppRgb)
					{
						num3 = 3;
						goto IL_97;
					}
				}
				else if (format == PixelFormat.Format32bppPArgb || format == PixelFormat.Format32bppArgb)
				{
					num3 = 4;
					goto IL_97;
				}
				throw new NotSupportedException(format.ToString());
				IL_97:
				num = imageSize.Width * num3;
				num2 = num * imageSize.Height;
				if (this._encodeBuffer == null)
				{
					this._encodedFormat = format;
					this._encodedWidth = imageSize.Width;
					this._encodedHeight = imageSize.Height;
					this._encodeBuffer = new byte[num2];
					byte[] array;
					byte* value;
					if ((array = this._encodeBuffer) == null || array.Length == 0)
					{
						value = null;
					}
					else
					{
						value = &array[0];
					}
					byte[] array2 = null;
					using (Bitmap bitmap = new Bitmap(imageSize.Width, imageSize.Height, num, format, scan0))
					{
						array2 = this._jpgCompression.Compress(bitmap);
					}
					outStream.Write(BitConverter.GetBytes(array2.Length), 0, 4);
					outStream.Write(array2, 0, array2.Length);
					NativeMethods.memcpy(new IntPtr((void*)value), scan0, (uint)num2);
					array = null;
				}
				else
				{
					if (this._encodedFormat != format)
					{
						throw new Exception("PixelFormat is not equal to previous Bitmap");
					}
					if (this._encodedWidth != imageSize.Width || this._encodedHeight != imageSize.Height)
					{
						throw new Exception("Bitmap width/height are not equal to previous bitmap");
					}
					long position = outStream.Position;
					outStream.Write(new byte[4], 0, 4);
					long num4 = 0L;
					List<Rectangle> list = new List<Rectangle>();
					Size size = new Size(scanArea.Width, this.CheckBlock.Height);
					Size size2 = new Size(scanArea.Width % this.CheckBlock.Width, scanArea.Height % this.CheckBlock.Height);
					int num5 = scanArea.Height - size2.Height;
					int num6 = scanArea.Width - size2.Width;
					Rectangle rectangle = default(Rectangle);
					List<Rectangle> list2 = new List<Rectangle>();
					size = new Size(scanArea.Width, size.Height);
					byte[] array;
					byte* ptr2;
					if ((array = this._encodeBuffer) == null || array.Length == 0)
					{
						ptr2 = null;
					}
					else
					{
						ptr2 = &array[0];
					}
					for (int num7 = scanArea.Y; num7 != scanArea.Height; num7 += size.Height)
					{
						if (num7 == num5)
						{
							size = new Size(scanArea.Width, size2.Height);
						}
						rectangle = new Rectangle(scanArea.X, num7, scanArea.Width, size.Height);
						int num8 = num7 * num + scanArea.X * num3;
						if (NativeMethods.memcmp(ptr2 + num8, ptr + num8, (uint)num) != 0)
						{
							int index = list.Count - 1;
							if (list.Count != 0 && list[index].Y + list[index].Height == rectangle.Y)
							{
								rectangle = new Rectangle(list[index].X, list[index].Y, list[index].Width, list[index].Height + rectangle.Height);
								list[index] = rectangle;
							}
							else
							{
								list.Add(rectangle);
							}
						}
					}
					for (int i = 0; i < list.Count; i++)
					{
						size = new Size(this.CheckBlock.Width, list[i].Height);
						for (int num9 = scanArea.X; num9 != scanArea.Width; num9 += size.Width)
						{
							if (num9 == num6)
							{
								size = new Size(size2.Width, list[i].Height);
							}
							rectangle = new Rectangle(num9, list[i].Y, size.Width, list[i].Height);
							bool flag2 = false;
							uint count = (uint)(num3 * rectangle.Width);
							for (int j = 0; j < rectangle.Height; j++)
							{
								int num10 = num * (rectangle.Y + j) + num3 * rectangle.X;
								if (NativeMethods.memcmp(ptr2 + num10, ptr + num10, count) != 0)
								{
									flag2 = true;
								}
								NativeMethods.memcpy((void*)(ptr2 + num10), (void*)(ptr + num10), count);
							}
							if (flag2)
							{
								int index = list2.Count - 1;
								if (list2.Count > 0 && list2[index].X + list2[index].Width == rectangle.X)
								{
									Rectangle rectangle2 = list2[index];
									int width = rectangle.Width + rectangle2.Width;
									rectangle = new Rectangle(rectangle2.X, rectangle2.Y, width, rectangle2.Height);
									list2[index] = rectangle;
								}
								else
								{
									list2.Add(rectangle);
								}
							}
						}
					}
					array = null;
					for (int k = 0; k < list2.Count; k++)
					{
						Rectangle rectangle3 = list2[k];
						int num11 = num3 * rectangle3.Width;
						Bitmap bitmap2 = null;
						BitmapData bitmapData = null;
						long num14;
						try
						{
							bitmap2 = new Bitmap(rectangle3.Width, rectangle3.Height, format);
							bitmapData = bitmap2.LockBits(new Rectangle(0, 0, bitmap2.Width, bitmap2.Height), ImageLockMode.ReadWrite, bitmap2.PixelFormat);
							int l = 0;
							int num12 = 0;
							while (l < rectangle3.Height)
							{
								int num13 = num * (rectangle3.Y + l) + num3 * rectangle3.X;
								NativeMethods.memcpy((void*)((byte*)bitmapData.Scan0.ToPointer() + num12), (void*)(ptr + num13), (uint)num11);
								num12 += num11;
								l++;
							}
							outStream.Write(BitConverter.GetBytes(rectangle3.X), 0, 4);
							outStream.Write(BitConverter.GetBytes(rectangle3.Y), 0, 4);
							outStream.Write(BitConverter.GetBytes(rectangle3.Width), 0, 4);
							outStream.Write(BitConverter.GetBytes(rectangle3.Height), 0, 4);
							outStream.Write(new byte[4], 0, 4);
							num14 = outStream.Length;
							long position2 = outStream.Position;
							this._jpgCompression.Compress(bitmap2, ref outStream);
							num14 = outStream.Position - num14;
							outStream.Position = position2 - 4L;
							outStream.Write(BitConverter.GetBytes(num14), 0, 4);
							outStream.Position += num14;
						}
						finally
						{
							bitmap2.UnlockBits(bitmapData);
							bitmap2.Dispose();
						}
						num4 += num14 + 20L;
					}
					outStream.Position = position;
					outStream.Write(BitConverter.GetBytes(num4), 0, 4);
				}
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000A0EC File Offset: 0x000082EC
		internal unsafe Bitmap DecodeData(IntPtr codecBuffer, uint length)
		{
			if (length < 4U)
			{
				return this._decodedBitmap;
			}
			int num = *(int*)((void*)codecBuffer);
			if (this._decodedBitmap == null)
			{
				byte[] array = new byte[num];
				byte[] array2;
				byte* value;
				if ((array2 = array) == null || array2.Length == 0)
				{
					value = null;
				}
				else
				{
					value = &array2[0];
				}
				NativeMethods.memcpy(new IntPtr((void*)value), new IntPtr(codecBuffer.ToInt32() + 4), (uint)num);
				array2 = null;
				this._decodedBitmap = (Bitmap)Image.FromStream(new MemoryStream(array));
				return this._decodedBitmap;
			}
			return this._decodedBitmap;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000A174 File Offset: 0x00008374
		internal Bitmap DecodeData(Stream inStream)
		{
			byte[] array = new byte[4];
			inStream.Read(array, 0, 4);
			int i = BitConverter.ToInt32(array, 0);
			if (this._decodedBitmap == null)
			{
				array = new byte[i];
				inStream.Read(array, 0, array.Length);
				this._decodedBitmap = (Bitmap)Image.FromStream(new MemoryStream(array));
				return this._decodedBitmap;
			}
			using (Graphics graphics = Graphics.FromImage(this._decodedBitmap))
			{
				while (i > 0)
				{
					byte[] array2 = new byte[20];
					inStream.Read(array2, 0, array2.Length);
					Rectangle rectangle = new Rectangle(BitConverter.ToInt32(array2, 0), BitConverter.ToInt32(array2, 4), BitConverter.ToInt32(array2, 8), BitConverter.ToInt32(array2, 12));
					int num = BitConverter.ToInt32(array2, 16);
					byte[] array3 = new byte[num];
					inStream.Read(array3, 0, array3.Length);
					using (MemoryStream memoryStream = new MemoryStream(array3))
					{
						using (Bitmap bitmap = (Bitmap)Image.FromStream(memoryStream))
						{
							graphics.DrawImage(bitmap, rectangle.Location);
						}
					}
					i -= num + 20;
				}
			}
			this.Resolution = this._decodedBitmap.Size;
			return this._decodedBitmap;
		}

		// Token: 0x040000B3 RID: 179
		private int _imageQuality;

		// Token: 0x040000B4 RID: 180
		private byte[] _encodeBuffer;

		// Token: 0x040000B5 RID: 181
		private Bitmap _decodedBitmap;

		// Token: 0x040000B6 RID: 182
		private PixelFormat _encodedFormat;

		// Token: 0x040000B7 RID: 183
		private int _encodedWidth;

		// Token: 0x040000B8 RID: 184
		private int _encodedHeight;

		// Token: 0x040000B9 RID: 185
		private readonly object _imageProcessLock = new object();

		// Token: 0x040000BA RID: 186
		private JpgCompression _jpgCompression;
	}
}
