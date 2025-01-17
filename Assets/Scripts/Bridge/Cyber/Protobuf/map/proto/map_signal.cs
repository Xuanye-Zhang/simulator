// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: map_signal.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.hdmap
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Subsignal : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Subsignal()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Id id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(Type.Unknown)]
        public Type type
        {
            get { return __pbn__type ?? Type.Unknown; }
            set { __pbn__type = value; }
        }
        public bool ShouldSerializetype()
        {
            return __pbn__type != null;
        }
        public void Resettype()
        {
            __pbn__type = null;
        }
        private Type? __pbn__type;

        [global::ProtoBuf.ProtoMember(3)]
        public global::apollo.common.PointENU location { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public enum Type
        {
            [global::ProtoBuf.ProtoEnum(Name = @"UNKNOWN")]
            Unknown = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"CIRCLE")]
            Circle = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"ARROW_LEFT")]
            ArrowLeft = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"ARROW_FORWARD")]
            ArrowForward = 4,
            [global::ProtoBuf.ProtoEnum(Name = @"ARROW_RIGHT")]
            ArrowRight = 5,
            [global::ProtoBuf.ProtoEnum(Name = @"ARROW_LEFT_AND_FORWARD")]
            ArrowLeftAndForward = 6,
            [global::ProtoBuf.ProtoEnum(Name = @"ARROW_RIGHT_AND_FORWARD")]
            ArrowRightAndForward = 7,
            [global::ProtoBuf.ProtoEnum(Name = @"ARROW_U_TURN")]
            ArrowUTurn = 8,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SignInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SignInfo()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(Type.None)]
        public Type type
        {
            get { return __pbn__type ?? Type.None; }
            set { __pbn__type = value; }
        }
        public bool ShouldSerializetype()
        {
            return __pbn__type != null;
        }
        public void Resettype()
        {
            __pbn__type = null;
        }
        private Type? __pbn__type;

        [global::ProtoBuf.ProtoContract()]
        public enum Type
        {
            None = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"NO_RIGHT_TURN_ON_RED")]
            NoRightTurnOnRed = 1,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Signal : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Signal()
        {
            subsignal = new global::System.Collections.Generic.List<Subsignal>();
            overlap_id = new global::System.Collections.Generic.List<Id>();
            stop_line = new global::System.Collections.Generic.List<Curve>();
            sign_info = new global::System.Collections.Generic.List<SignInfo>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Id id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public Polygon boundary { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<Subsignal> subsignal { get; private set; }

        [global::ProtoBuf.ProtoMember(4)]
        public global::System.Collections.Generic.List<Id> overlap_id { get; private set; }

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(Type.Unknown)]
        public Type type
        {
            get { return __pbn__type ?? Type.Unknown; }
            set { __pbn__type = value; }
        }
        public bool ShouldSerializetype()
        {
            return __pbn__type != null;
        }
        public void Resettype()
        {
            __pbn__type = null;
        }
        private Type? __pbn__type;

        [global::ProtoBuf.ProtoMember(6)]
        public global::System.Collections.Generic.List<Curve> stop_line { get; private set; }

        [global::ProtoBuf.ProtoMember(7)]
        public global::System.Collections.Generic.List<SignInfo> sign_info { get; private set; }

        [global::ProtoBuf.ProtoContract()]
        public enum Type
        {
            [global::ProtoBuf.ProtoEnum(Name = @"UNKNOWN")]
            Unknown = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"MIX_2_HORIZONTAL")]
            Mix2Horizontal = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"MIX_2_VERTICAL")]
            Mix2Vertical = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"MIX_3_HORIZONTAL")]
            Mix3Horizontal = 4,
            [global::ProtoBuf.ProtoEnum(Name = @"MIX_3_VERTICAL")]
            Mix3Vertical = 5,
            [global::ProtoBuf.ProtoEnum(Name = @"SINGLE")]
            Single = 6,
        }

    }

}

#pragma warning restore 0612, 1591, 3021
