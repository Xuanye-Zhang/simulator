// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: simple.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.common.util.test
{

    [global::ProtoBuf.ProtoContract()]
    public partial class SimpleMessage : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SimpleMessage()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public int integer
        {
            get { return __pbn__integer.GetValueOrDefault(); }
            set { __pbn__integer = value; }
        }
        public bool ShouldSerializeinteger()
        {
            return __pbn__integer != null;
        }
        public void Resetinteger()
        {
            __pbn__integer = null;
        }
        private int? __pbn__integer;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string text
        {
            get { return __pbn__text ?? ""; }
            set { __pbn__text = value; }
        }
        public bool ShouldSerializetext()
        {
            return __pbn__text != null;
        }
        public void Resettext()
        {
            __pbn__text = null;
        }
        private string __pbn__text;

        [global::ProtoBuf.ProtoMember(3)]
        public global::apollo.common.Header header { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SimpleRepeatedMessage : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SimpleRepeatedMessage()
        {
            message = new global::System.Collections.Generic.List<SimpleMessage>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<SimpleMessage> message { get; private set; }

    }

}

#pragma warning restore 0612, 1591, 3021
