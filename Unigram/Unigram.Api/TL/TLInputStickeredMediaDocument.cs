// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputStickeredMediaDocument : TLInputStickeredMediaBase 
	{
		public TLInputDocumentBase Id { get; set; }

		public TLInputStickeredMediaDocument() { }
		public TLInputStickeredMediaDocument(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputStickeredMediaDocument; } }

		public override void Read(TLBinaryReader from)
		{
			Id = TLFactory.Read<TLInputDocumentBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Id);
		}
	}
}