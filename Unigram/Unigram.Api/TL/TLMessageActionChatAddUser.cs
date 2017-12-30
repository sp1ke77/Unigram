// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLMessageActionChatAddUser : TLMessageActionBase 
	{
		public TLVector<Int32> Users { get; set; }

		public TLMessageActionChatAddUser() { }
		public TLMessageActionChatAddUser(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageActionChatAddUser; } }

		public override void Read(TLBinaryReader from)
		{
			Users = TLFactory.Read<TLVector<Int32>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Users);
		}
	}
}