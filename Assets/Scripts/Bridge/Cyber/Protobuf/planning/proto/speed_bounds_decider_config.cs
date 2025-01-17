// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: speed_bounds_decider_config.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.planning
{

    [global::ProtoBuf.ProtoContract()]
    public partial class SpeedBoundsDeciderConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SpeedBoundsDeciderConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(7)]
        public double total_time
        {
            get { return __pbn__total_time ?? 7; }
            set { __pbn__total_time = value; }
        }
        public bool ShouldSerializetotal_time()
        {
            return __pbn__total_time != null;
        }
        public void Resettotal_time()
        {
            __pbn__total_time = null;
        }
        private double? __pbn__total_time;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0.1)]
        public double boundary_buffer
        {
            get { return __pbn__boundary_buffer ?? 0.1; }
            set { __pbn__boundary_buffer = value; }
        }
        public bool ShouldSerializeboundary_buffer()
        {
            return __pbn__boundary_buffer != null;
        }
        public void Resetboundary_buffer()
        {
            __pbn__boundary_buffer = null;
        }
        private double? __pbn__boundary_buffer;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(1.2)]
        public double high_speed_centric_acceleration_limit
        {
            get { return __pbn__high_speed_centric_acceleration_limit ?? 1.2; }
            set { __pbn__high_speed_centric_acceleration_limit = value; }
        }
        public bool ShouldSerializehigh_speed_centric_acceleration_limit()
        {
            return __pbn__high_speed_centric_acceleration_limit != null;
        }
        public void Resethigh_speed_centric_acceleration_limit()
        {
            __pbn__high_speed_centric_acceleration_limit = null;
        }
        private double? __pbn__high_speed_centric_acceleration_limit;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(1.4)]
        public double low_speed_centric_acceleration_limit
        {
            get { return __pbn__low_speed_centric_acceleration_limit ?? 1.4; }
            set { __pbn__low_speed_centric_acceleration_limit = value; }
        }
        public bool ShouldSerializelow_speed_centric_acceleration_limit()
        {
            return __pbn__low_speed_centric_acceleration_limit != null;
        }
        public void Resetlow_speed_centric_acceleration_limit()
        {
            __pbn__low_speed_centric_acceleration_limit = null;
        }
        private double? __pbn__low_speed_centric_acceleration_limit;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(20)]
        public double high_speed_threshold
        {
            get { return __pbn__high_speed_threshold ?? 20; }
            set { __pbn__high_speed_threshold = value; }
        }
        public bool ShouldSerializehigh_speed_threshold()
        {
            return __pbn__high_speed_threshold != null;
        }
        public void Resethigh_speed_threshold()
        {
            __pbn__high_speed_threshold = null;
        }
        private double? __pbn__high_speed_threshold;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(7)]
        public double low_speed_threshold
        {
            get { return __pbn__low_speed_threshold ?? 7; }
            set { __pbn__low_speed_threshold = value; }
        }
        public bool ShouldSerializelow_speed_threshold()
        {
            return __pbn__low_speed_threshold != null;
        }
        public void Resetlow_speed_threshold()
        {
            __pbn__low_speed_threshold = null;
        }
        private double? __pbn__low_speed_threshold;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(1e-005)]
        public double minimal_kappa
        {
            get { return __pbn__minimal_kappa ?? 1e-005; }
            set { __pbn__minimal_kappa = value; }
        }
        public bool ShouldSerializeminimal_kappa()
        {
            return __pbn__minimal_kappa != null;
        }
        public void Resetminimal_kappa()
        {
            __pbn__minimal_kappa = null;
        }
        private double? __pbn__minimal_kappa;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(1)]
        public double point_extension
        {
            get { return __pbn__point_extension ?? 1; }
            set { __pbn__point_extension = value; }
        }
        public bool ShouldSerializepoint_extension()
        {
            return __pbn__point_extension != null;
        }
        public void Resetpoint_extension()
        {
            __pbn__point_extension = null;
        }
        private double? __pbn__point_extension;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(2.5)]
        public double lowest_speed
        {
            get { return __pbn__lowest_speed ?? 2.5; }
            set { __pbn__lowest_speed = value; }
        }
        public bool ShouldSerializelowest_speed()
        {
            return __pbn__lowest_speed != null;
        }
        public void Resetlowest_speed()
        {
            __pbn__lowest_speed = null;
        }
        private double? __pbn__lowest_speed;

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue(4)]
        public uint num_points_to_avg_kappa
        {
            get { return __pbn__num_points_to_avg_kappa ?? 4; }
            set { __pbn__num_points_to_avg_kappa = value; }
        }
        public bool ShouldSerializenum_points_to_avg_kappa()
        {
            return __pbn__num_points_to_avg_kappa != null;
        }
        public void Resetnum_points_to_avg_kappa()
        {
            __pbn__num_points_to_avg_kappa = null;
        }
        private uint? __pbn__num_points_to_avg_kappa;

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue(1)]
        public double collision_safety_range
        {
            get { return __pbn__collision_safety_range ?? 1; }
            set { __pbn__collision_safety_range = value; }
        }
        public bool ShouldSerializecollision_safety_range()
        {
            return __pbn__collision_safety_range != null;
        }
        public void Resetcollision_safety_range()
        {
            __pbn__collision_safety_range = null;
        }
        private double? __pbn__collision_safety_range;

        [global::ProtoBuf.ProtoMember(12)]
        public double static_obs_nudge_speed_ratio
        {
            get { return __pbn__static_obs_nudge_speed_ratio.GetValueOrDefault(); }
            set { __pbn__static_obs_nudge_speed_ratio = value; }
        }
        public bool ShouldSerializestatic_obs_nudge_speed_ratio()
        {
            return __pbn__static_obs_nudge_speed_ratio != null;
        }
        public void Resetstatic_obs_nudge_speed_ratio()
        {
            __pbn__static_obs_nudge_speed_ratio = null;
        }
        private double? __pbn__static_obs_nudge_speed_ratio;

        [global::ProtoBuf.ProtoMember(13)]
        public double dynamic_obs_nudge_speed_ratio
        {
            get { return __pbn__dynamic_obs_nudge_speed_ratio.GetValueOrDefault(); }
            set { __pbn__dynamic_obs_nudge_speed_ratio = value; }
        }
        public bool ShouldSerializedynamic_obs_nudge_speed_ratio()
        {
            return __pbn__dynamic_obs_nudge_speed_ratio != null;
        }
        public void Resetdynamic_obs_nudge_speed_ratio()
        {
            __pbn__dynamic_obs_nudge_speed_ratio = null;
        }
        private double? __pbn__dynamic_obs_nudge_speed_ratio;

        [global::ProtoBuf.ProtoMember(14)]
        public double centri_jerk_speed_coeff
        {
            get { return __pbn__centri_jerk_speed_coeff.GetValueOrDefault(); }
            set { __pbn__centri_jerk_speed_coeff = value; }
        }
        public bool ShouldSerializecentri_jerk_speed_coeff()
        {
            return __pbn__centri_jerk_speed_coeff != null;
        }
        public void Resetcentri_jerk_speed_coeff()
        {
            __pbn__centri_jerk_speed_coeff = null;
        }
        private double? __pbn__centri_jerk_speed_coeff;

    }

}

#pragma warning restore 0612, 1591, 3021
