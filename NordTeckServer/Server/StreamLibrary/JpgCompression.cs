using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Server.StreamLibrary
{
	// Token: 0x0200000F RID: 15
	public class JpgCompression : IDisposable
	{
		// Token: 0x06000065 RID: 101 RVA: 0x0000970C File Offset: 0x0000790C
		public JpgCompression(long quality)
		{
			EncoderParameter encoderParameter = new EncoderParameter(Encoder.Quality, quality);
			this._encoderInfo = this.GetEncoderInfo("image/jpeg");
			this._encoderParams = new EncoderParameters(2);
			this._encoderParams.Param[0] = encoderParameter;
			this._encoderParams.Param[1] = new EncoderParameter(Encoder.Compression, 5L);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000976F File Offset: 0x0000796F
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000977E File Offset: 0x0000797E
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this._encoderParams != null)
			{
				this._encoderParams.Dispose();
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00009798 File Offset: 0x00007998
		public byte[] Compress(Bitmap bmp)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				bmp.Save(memoryStream, this._encoderInfo, this._encoderParams);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000097E4 File Offset: 0x000079E4
		public void Compress(Bitmap bmp, ref Stream targetStream)
		{
			bmp.Save(targetStream, this._encoderInfo, this._encoderParams);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000097FC File Offset: 0x000079FC
		private ImageCodecInfo GetEncoderInfo(string mimeType)
		{
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			int num = imageEncoders.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (imageEncoders[i].MimeType == mimeType)
				{
					return imageEncoders[i];
				}
			}
			return null;
		}

		// Token: 0x040000AF RID: 175
		private readonly ImageCodecInfo _encoderInfo;

		// Token: 0x040000B0 RID: 176
		private readonly EncoderParameters _encoderParams;
	}
}
