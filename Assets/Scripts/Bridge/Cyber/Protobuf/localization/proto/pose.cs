// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: pose.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.localization
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
        public global::apollo.common.PointENU position { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public global::apollo.common.Quaternion orientation { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public global::apollo.common.Point3D linear_velocity { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public global::apollo.common.Point3D linear_acceleration { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public global::apollo.common.Point3D angular_velocity { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public double heading
        {
            get { return __pbn__heading.GetValueOrDefault(); }
            set { __pbn__heading = value; }
        }
        public bool ShouldSerializeheading()
        {
            return __pbn__heading != null;
        }
        public void Resetheading()
        {
            __pbn__heading = null;
        }
        private double? __pbn__heading;

        [global::ProtoBuf.ProtoMember(7)]
        public global::apollo.common.Point3D linear_acceleration_vrf { get; set; }

        [global::ProtoBuf.ProtoMember(8)]
        public global::apollo.common.Point3D angular_velocity_vrf { get; set; }

        [global::ProtoBuf.ProtoMember(9)]
        public global::apollo.common.Point3D euler_angles { get; set; }

    }

}

#pragma warning restore 0612, 1591, 3021
