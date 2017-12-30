// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLChannel : TLChatBase 
	{
		[Flags]
		public enum Flag : Int32
		{
			Creator = (1 << 0),
			Left = (1 << 2),
			Editor = (1 << 3),
			Broadcast = (1 << 5),
			Verified = (1 << 7),
			MegaGroup = (1 << 8),
			Restricted = (1 << 9),
			Democracy = (1 << 10),
			Signatures = (1 << 11),
			Min = (1 << 12),
			AccessHash = (1 << 13),
			Username = (1 << 6),
			RestrictionReason = (1 << 9),
			AdminRights = (1 << 14),
			BannedRights = (1 << 15),
			ParticipantsCount = (1 << 17),
		}

		public bool IsCreator { get { return Flags.HasFlag(Flag.Creator); } set { Flags = value ? (Flags | Flag.Creator) : (Flags & ~Flag.Creator); } }
		public bool IsLeft { get { return Flags.HasFlag(Flag.Left); } set { Flags = value ? (Flags | Flag.Left) : (Flags & ~Flag.Left); } }
		public bool IsEditor { get { return Flags.HasFlag(Flag.Editor); } set { Flags = value ? (Flags | Flag.Editor) : (Flags & ~Flag.Editor); } }
		public bool IsBroadcast { get { return Flags.HasFlag(Flag.Broadcast); } set { Flags = value ? (Flags | Flag.Broadcast) : (Flags & ~Flag.Broadcast); } }
		public bool IsVerified { get { return Flags.HasFlag(Flag.Verified); } set { Flags = value ? (Flags | Flag.Verified) : (Flags & ~Flag.Verified); } }
		public bool IsMegaGroup { get { return Flags.HasFlag(Flag.MegaGroup); } set { Flags = value ? (Flags | Flag.MegaGroup) : (Flags & ~Flag.MegaGroup); } }
		public bool IsRestricted { get { return Flags.HasFlag(Flag.Restricted); } set { Flags = value ? (Flags | Flag.Restricted) : (Flags & ~Flag.Restricted); } }
		public bool IsDemocracy { get { return Flags.HasFlag(Flag.Democracy); } set { Flags = value ? (Flags | Flag.Democracy) : (Flags & ~Flag.Democracy); } }
		public bool IsSignatures { get { return Flags.HasFlag(Flag.Signatures); } set { Flags = value ? (Flags | Flag.Signatures) : (Flags & ~Flag.Signatures); } }
		public bool IsMin { get { return Flags.HasFlag(Flag.Min); } set { Flags = value ? (Flags | Flag.Min) : (Flags & ~Flag.Min); } }
		public bool HasAccessHash { get { return Flags.HasFlag(Flag.AccessHash); } set { Flags = value ? (Flags | Flag.AccessHash) : (Flags & ~Flag.AccessHash); } }
		public bool HasUsername { get { return Flags.HasFlag(Flag.Username); } set { Flags = value ? (Flags | Flag.Username) : (Flags & ~Flag.Username); } }
		public bool HasRestrictionReason { get { return Flags.HasFlag(Flag.RestrictionReason); } set { Flags = value ? (Flags | Flag.RestrictionReason) : (Flags & ~Flag.RestrictionReason); } }
		public bool HasAdminRights { get { return Flags.HasFlag(Flag.AdminRights); } set { Flags = value ? (Flags | Flag.AdminRights) : (Flags & ~Flag.AdminRights); } }
		public bool HasBannedRights { get { return Flags.HasFlag(Flag.BannedRights); } set { Flags = value ? (Flags | Flag.BannedRights) : (Flags & ~Flag.BannedRights); } }
		public bool HasParticipantsCount { get { return Flags.HasFlag(Flag.ParticipantsCount); } set { Flags = value ? (Flags | Flag.ParticipantsCount) : (Flags & ~Flag.ParticipantsCount); } }

		public Flag Flags { get; set; }
		public Int64? AccessHash { get; set; }
		public String Title { get; set; }
		public String Username { get; set; }
		public TLChatPhotoBase Photo { get; set; }
		public Int32 Date { get; set; }
		public Int32 Version { get; set; }
		public String RestrictionReason { get; set; }
		public TLChannelAdminRights AdminRights { get; set; }
		public TLChannelBannedRights BannedRights { get; set; }
		public Int32? ParticipantsCount { get; set; }

		public TLChannel() { }
		public TLChannel(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.Channel; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Id = from.ReadInt32();
			if (HasAccessHash) AccessHash = from.ReadInt64();
			Title = from.ReadString();
			if (HasUsername) Username = from.ReadString();
			Photo = TLFactory.Read<TLChatPhotoBase>(from);
			Date = from.ReadInt32();
			Version = from.ReadInt32();
			if (HasRestrictionReason) RestrictionReason = from.ReadString();
			if (HasAdminRights) AdminRights = TLFactory.Read<TLChannelAdminRights>(from);
			if (HasBannedRights) BannedRights = TLFactory.Read<TLChannelBannedRights>(from);
			if (HasParticipantsCount) ParticipantsCount = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteInt32(Id);
			if (HasAccessHash) to.WriteInt64(AccessHash.Value);
			to.WriteString(Title ?? string.Empty);
			if (HasUsername) to.WriteString(Username ?? string.Empty);
			to.WriteObject(Photo);
			to.WriteInt32(Date);
			to.WriteInt32(Version);
			if (HasRestrictionReason) to.WriteString(RestrictionReason ?? string.Empty);
			if (HasAdminRights) to.WriteObject(AdminRights);
			if (HasBannedRights) to.WriteObject(BannedRights);
			if (HasParticipantsCount) to.WriteInt32(ParticipantsCount.Value);
		}

		private void UpdateFlags()
		{
			HasAccessHash = AccessHash != null;
			HasUsername = Username != null;
			HasRestrictionReason = RestrictionReason != null;
			HasAdminRights = AdminRights != null;
			HasBannedRights = BannedRights != null;
			HasParticipantsCount = ParticipantsCount != null;
		}
	}
}