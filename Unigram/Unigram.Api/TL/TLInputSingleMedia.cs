// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputSingleMedia : TLObject 
	{
		public TLInputMediaBase Media { get; set; }
		public Int64 RandomId { get; set; }

		public TLInputSingleMedia() { }
		public TLInputSingleMedia(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputSingleMedia; } }

		public override void Read(TLBinaryReader from)
		{
			Media = TLFactory.Read<TLInputMediaBase>(from);
			RandomId = from.ReadInt64();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Media);
			to.WriteInt64(RandomId);
		}
	}
}