// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: detection3d.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.common
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Pose : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Pose()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Point3D position { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public Quaternion orientation { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class BoundingBox3D : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public BoundingBox3D()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Pose position { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public Vector3 size { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Detection3D : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Detection3D()
        {
            label = "";
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Header header { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public uint id { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string label { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public double score { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public BoundingBox3D bbox { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public Twist velocity { get; set; }

    }

}

#pragma warning restore 0612, 1591, 3021
