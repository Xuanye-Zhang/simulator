// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: measure.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.localization
{

    [global::ProtoBuf.ProtoContract()]
    public partial class IntegMeasure : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public IntegMeasure()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::apollo.common.Header header { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(MeasureType.GnssPosOnly)]
        public MeasureType measure_type
        {
            get { return __pbn__measure_type ?? MeasureType.GnssPosOnly; }
            set { __pbn__measure_type = value; }
        }
        public bool ShouldSerializemeasure_type()
        {
            return __pbn__measure_type != null;
        }
        public void Resetmeasure_type()
        {
            __pbn__measure_type = null;
        }
        private MeasureType? __pbn__measure_type;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(FrameType.Enu)]
        public FrameType frame_type
        {
            get { return __pbn__frame_type ?? FrameType.Enu; }
            set { __pbn__frame_type = value; }
        }
        public bool ShouldSerializeframe_type()
        {
            return __pbn__frame_type != null;
        }
        public void Resetframe_type()
        {
            __pbn__frame_type = null;
        }
        private FrameType? __pbn__frame_type;

        [global::ProtoBuf.ProtoMember(4)]
        public global::apollo.common.Point3D position { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public global::apollo.common.Point3D velocity { get; set; }

        [global::ProtoBuf.ProtoMember(6)]
        public double yaw
        {
            get { return __pbn__yaw.GetValueOrDefault(); }
            set { __pbn__yaw = value; }
        }
        public bool ShouldSerializeyaw()
        {
            return __pbn__yaw != null;
        }
        public void Resetyaw()
        {
            __pbn__yaw = null;
        }
        private double? __pbn__yaw;

        [global::ProtoBuf.ProtoMember(7)]
        public int zone_id
        {
            get { return __pbn__zone_id.GetValueOrDefault(); }
            set { __pbn__zone_id = value; }
        }
        public bool ShouldSerializezone_id()
        {
            return __pbn__zone_id != null;
        }
        public void Resetzone_id()
        {
            __pbn__zone_id = null;
        }
        private int? __pbn__zone_id;

        [global::ProtoBuf.ProtoMember(8)]
        public bool is_have_variance
        {
            get { return __pbn__is_have_variance.GetValueOrDefault(); }
            set { __pbn__is_have_variance = value; }
        }
        public bool ShouldSerializeis_have_variance()
        {
            return __pbn__is_have_variance != null;
        }
        public void Resetis_have_variance()
        {
            __pbn__is_have_variance = null;
        }
        private bool? __pbn__is_have_variance;

        [global::ProtoBuf.ProtoMember(9)]
        public bool is_gnss_double_antenna
        {
            get { return __pbn__is_gnss_double_antenna.GetValueOrDefault(); }
            set { __pbn__is_gnss_double_antenna = value; }
        }
        public bool ShouldSerializeis_gnss_double_antenna()
        {
            return __pbn__is_gnss_double_antenna != null;
        }
        public void Resetis_gnss_double_antenna()
        {
            __pbn__is_gnss_double_antenna = null;
        }
        private bool? __pbn__is_gnss_double_antenna;

        [global::ProtoBuf.ProtoMember(10, IsPacked = true)]
        public double[] measure_covar { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public enum MeasureType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"GNSS_POS_ONLY")]
            GnssPosOnly = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"GNSS_POS_VEL")]
            GnssPosVel = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"GNSS_POS_XY")]
            GnssPosXy = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"GNSS_VEL_ONLY")]
            GnssVelOnly = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"POINT_CLOUD_POS")]
            PointCloudPos = 4,
            [global::ProtoBuf.ProtoEnum(Name = @"ODOMETER_VEL_ONLY")]
            OdometerVelOnly = 5,
            [global::ProtoBuf.ProtoEnum(Name = @"VEHICLE_CONSTRAINT")]
            VehicleConstraint = 6,
        }

        [global::ProtoBuf.ProtoContract()]
        public enum FrameType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"ENU")]
            Enu = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"ECEF")]
            Ecef = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"UTM")]
            Utm = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"ODOMETER")]
            Odometer = 3,
        }

    }

}

#pragma warning restore 0612, 1591, 3021
