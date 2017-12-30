// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Upload
{
	public partial class TLUploadCdnFile : TLUploadCdnFileBase 
	{
		public Byte[] Bytes { get; set; }

		public TLUploadCdnFile() { }
		public TLUploadCdnFile(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UploadCdnFile; } }

		public override void Read(TLBinaryReader from)
		{
			Bytes = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteByteArray(Bytes);
		}
	}
}