// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.forwardMessages.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
	public partial class TLMessagesForwardMessages : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			Silent = (1 << 5),
			Background = (1 << 6),
			WithMyScore = (1 << 8),
			Grouped = (1 << 9),
		}

		public bool IsSilent { get { return Flags.HasFlag(Flag.Silent); } set { Flags = value ? (Flags | Flag.Silent) : (Flags & ~Flag.Silent); } }
		public bool IsBackground { get { return Flags.HasFlag(Flag.Background); } set { Flags = value ? (Flags | Flag.Background) : (Flags & ~Flag.Background); } }
		public bool IsWithMyScore { get { return Flags.HasFlag(Flag.WithMyScore); } set { Flags = value ? (Flags | Flag.WithMyScore) : (Flags & ~Flag.WithMyScore); } }
		public bool IsGrouped { get { return Flags.HasFlag(Flag.Grouped); } set { Flags = value ? (Flags | Flag.Grouped) : (Flags & ~Flag.Grouped); } }

		public Flag Flags { get; set; }
		public TLInputPeerBase FromPeer { get; set; }
		public TLVector<Int32> Id { get; set; }
		public TLVector<Int64> RandomId { get; set; }
		public TLInputPeerBase ToPeer { get; set; }

		public TLMessagesForwardMessages() { }
		public TLMessagesForwardMessages(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesForwardMessages; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			FromPeer = TLFactory.Read<TLInputPeerBase>(from);
			Id = TLFactory.Read<TLVector<Int32>>(from);
			RandomId = TLFactory.Read<TLVector<Int64>>(from);
			ToPeer = TLFactory.Read<TLInputPeerBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32((Int32)Flags);
			to.WriteObject(FromPeer);
			to.WriteObject(Id);
			to.WriteObject(RandomId);
			to.WriteObject(ToPeer);
		}
	}
}