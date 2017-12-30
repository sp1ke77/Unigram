// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputMediaPhotoExternal : TLInputMediaBase, ITLMessageMediaCaption 
	{
		[Flags]
		public enum Flag : Int32
		{
			TTLSeconds = (1 << 0),
		}

		public bool HasTTLSeconds { get { return Flags.HasFlag(Flag.TTLSeconds); } set { Flags = value ? (Flags | Flag.TTLSeconds) : (Flags & ~Flag.TTLSeconds); } }

		public Flag Flags { get; set; }
		public String Url { get; set; }
		public String Caption { get; set; }
		public Int32? TTLSeconds { get; set; }

		public TLInputMediaPhotoExternal() { }
		public TLInputMediaPhotoExternal(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputMediaPhotoExternal; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Url = from.ReadString();
			Caption = from.ReadString();
			if (HasTTLSeconds) TTLSeconds = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteString(Url ?? string.Empty);
			to.WriteString(Caption ?? string.Empty);
			if (HasTTLSeconds) to.WriteInt32(TTLSeconds.Value);
		}

		private void UpdateFlags()
		{
			HasTTLSeconds = TTLSeconds != null;
		}
	}
}