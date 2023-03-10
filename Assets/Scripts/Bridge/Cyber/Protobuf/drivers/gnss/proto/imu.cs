// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: imu.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.drivers.gnss
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Imu : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Imu()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::apollo.common.Header header { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public double measurement_time
        {
            get { return __pbn__measurement_time.GetValueOrDefault(); }
            set { __pbn__measurement_time = value; }
        }
        public bool ShouldSerializemeasurement_time()
        {
            return __pbn__measurement_time != null;
        }
        public void Resetmeasurement_time()
        {
            __pbn__measurement_time = null;
        }
        private double? __pbn__measurement_time;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(0f)]
        public float measurement_span
        {
            get { return __pbn__measurement_span ?? 0f; }
            set { __pbn__measurement_span = value; }
        }
        public bool ShouldSerializemeasurement_span()
        {
            return __pbn__measurement_span != null;
        }
        public void Resetmeasurement_span()
        {
            __pbn__measurement_span = null;
        }
        private float? __pbn__measurement_span;

        [global::ProtoBuf.ProtoMember(4)]
        public global::apollo.common.Point3D linear_acceleration { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public global::apollo.common.Point3D angular_velocity { get; set; }

    }

}

#pragma warning restore 0612, 1591, 3021
