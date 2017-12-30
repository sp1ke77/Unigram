// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLKeyboardButtonSwitchInline : TLKeyboardButtonBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			SamePeer = (1 << 0),
		}

		public bool IsSamePeer { get { return Flags.HasFlag(Flag.SamePeer); } set { Flags = value ? (Flags | Flag.SamePeer) : (Flags & ~Flag.SamePeer); } }

		public Flag Flags { get; set; }
		public String Query { get; set; }

		public TLKeyboardButtonSwitchInline() { }
		public TLKeyboardButtonSwitchInline(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.KeyboardButtonSwitchInline; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Text = from.ReadString();
			Query = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32((Int32)Flags);
			to.WriteString(Text ?? string.Empty);
			to.WriteString(Query ?? string.Empty);
		}
	}
}