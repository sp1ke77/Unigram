// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInvoice : TLObject 
	{
		[Flags]
		public enum Flag : Int32
		{
			Test = (1 << 0),
			NameRequested = (1 << 1),
			PhoneRequested = (1 << 2),
			EmailRequested = (1 << 3),
			ShippingAddressRequested = (1 << 4),
			Flexible = (1 << 5),
			PhoneToProvider = (1 << 6),
			EmailToProvider = (1 << 7),
		}

		public bool IsTest { get { return Flags.HasFlag(Flag.Test); } set { Flags = value ? (Flags | Flag.Test) : (Flags & ~Flag.Test); } }
		public bool IsNameRequested { get { return Flags.HasFlag(Flag.NameRequested); } set { Flags = value ? (Flags | Flag.NameRequested) : (Flags & ~Flag.NameRequested); } }
		public bool IsPhoneRequested { get { return Flags.HasFlag(Flag.PhoneRequested); } set { Flags = value ? (Flags | Flag.PhoneRequested) : (Flags & ~Flag.PhoneRequested); } }
		public bool IsEmailRequested { get { return Flags.HasFlag(Flag.EmailRequested); } set { Flags = value ? (Flags | Flag.EmailRequested) : (Flags & ~Flag.EmailRequested); } }
		public bool IsShippingAddressRequested { get { return Flags.HasFlag(Flag.ShippingAddressRequested); } set { Flags = value ? (Flags | Flag.ShippingAddressRequested) : (Flags & ~Flag.ShippingAddressRequested); } }
		public bool IsFlexible { get { return Flags.HasFlag(Flag.Flexible); } set { Flags = value ? (Flags | Flag.Flexible) : (Flags & ~Flag.Flexible); } }
		public bool IsPhoneToProvider { get { return Flags.HasFlag(Flag.PhoneToProvider); } set { Flags = value ? (Flags | Flag.PhoneToProvider) : (Flags & ~Flag.PhoneToProvider); } }
		public bool IsEmailToProvider { get { return Flags.HasFlag(Flag.EmailToProvider); } set { Flags = value ? (Flags | Flag.EmailToProvider) : (Flags & ~Flag.EmailToProvider); } }

		public Flag Flags { get; set; }
		public String Currency { get; set; }
		public TLVector<TLLabeledPrice> Prices { get; set; }

		public TLInvoice() { }
		public TLInvoice(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.Invoice; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Currency = from.ReadString();
			Prices = TLFactory.Read<TLVector<TLLabeledPrice>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32((Int32)Flags);
			to.WriteString(Currency ?? string.Empty);
			to.WriteObject(Prices);
		}
	}
}