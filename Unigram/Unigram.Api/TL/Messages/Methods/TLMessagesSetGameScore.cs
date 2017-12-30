// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.setGameScore.
	/// Returns <see cref="Telegram.Api.TL.TLUpdatesBase"/>
	/// </summary>
	public partial class TLMessagesSetGameScore : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			EditMessage = (1 << 0),
			Force = (1 << 1),
		}

		public bool IsEditMessage { get { return Flags.HasFlag(Flag.EditMessage); } set { Flags = value ? (Flags | Flag.EditMessage) : (Flags & ~Flag.EditMessage); } }
		public bool IsForce { get { return Flags.HasFlag(Flag.Force); } set { Flags = value ? (Flags | Flag.Force) : (Flags & ~Flag.Force); } }

		public Flag Flags { get; set; }
		public TLInputPeerBase Peer { get; set; }
		public Int32 Id { get; set; }
		public TLInputUserBase UserId { get; set; }
		public Int32 Score { get; set; }

		public TLMessagesSetGameScore() { }
		public TLMessagesSetGameScore(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesSetGameScore; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			Id = from.ReadInt32();
			UserId = TLFactory.Read<TLInputUserBase>(from);
			Score = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32((Int32)Flags);
			to.WriteObject(Peer);
			to.WriteInt32(Id);
			to.WriteObject(UserId);
			to.WriteInt32(Score);
		}
	}
}