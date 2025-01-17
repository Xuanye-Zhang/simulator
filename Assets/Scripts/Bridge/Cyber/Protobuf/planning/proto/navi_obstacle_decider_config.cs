// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: navi_obstacle_decider_config.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.planning
{

    [global::ProtoBuf.ProtoContract()]
    public partial class NaviObstacleDeciderConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public NaviObstacleDeciderConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(0.2)]
        public double min_nudge_distance
        {
            get { return __pbn__min_nudge_distance ?? 0.2; }
            set { __pbn__min_nudge_distance = value; }
        }
        public bool ShouldSerializemin_nudge_distance()
        {
            return __pbn__min_nudge_distance != null;
        }
        public void Resetmin_nudge_distance()
        {
            __pbn__min_nudge_distance = null;
        }
        private double? __pbn__min_nudge_distance;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(1.2)]
        public double max_nudge_distance
        {
            get { return __pbn__max_nudge_distance ?? 1.2; }
            set { __pbn__max_nudge_distance = value; }
        }
        public bool ShouldSerializemax_nudge_distance()
        {
            return __pbn__max_nudge_distance != null;
        }
        public void Resetmax_nudge_distance()
        {
            __pbn__max_nudge_distance = null;
        }
        private double? __pbn__max_nudge_distance;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(16.667)]
        public double max_allow_nudge_speed
        {
            get { return __pbn__max_allow_nudge_speed ?? 16.667; }
            set { __pbn__max_allow_nudge_speed = value; }
        }
        public bool ShouldSerializemax_allow_nudge_speed()
        {
            return __pbn__max_allow_nudge_speed != null;
        }
        public void Resetmax_allow_nudge_speed()
        {
            __pbn__max_allow_nudge_speed = null;
        }
        private double? __pbn__max_allow_nudge_speed;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(0.2)]
        public double safe_distance
        {
            get { return __pbn__safe_distance ?? 0.2; }
            set { __pbn__safe_distance = value; }
        }
        public bool ShouldSerializesafe_distance()
        {
            return __pbn__safe_distance != null;
        }
        public void Resetsafe_distance()
        {
            __pbn__safe_distance = null;
        }
        private double? __pbn__safe_distance;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(0.05)]
        public double nudge_allow_tolerance
        {
            get { return __pbn__nudge_allow_tolerance ?? 0.05; }
            set { __pbn__nudge_allow_tolerance = value; }
        }
        public bool ShouldSerializenudge_allow_tolerance()
        {
            return __pbn__nudge_allow_tolerance != null;
        }
        public void Resetnudge_allow_tolerance()
        {
            __pbn__nudge_allow_tolerance = null;
        }
        private double? __pbn__nudge_allow_tolerance;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(3)]
        public uint cycles_number
        {
            get { return __pbn__cycles_number ?? 3; }
            set { __pbn__cycles_number = value; }
        }
        public bool ShouldSerializecycles_number()
        {
            return __pbn__cycles_number != null;
        }
        public void Resetcycles_number()
        {
            __pbn__cycles_number = null;
        }
        private uint? __pbn__cycles_number;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(2)]
        public double judge_dis_coeff
        {
            get { return __pbn__judge_dis_coeff ?? 2; }
            set { __pbn__judge_dis_coeff = value; }
        }
        public bool ShouldSerializejudge_dis_coeff()
        {
            return __pbn__judge_dis_coeff != null;
        }
        public void Resetjudge_dis_coeff()
        {
            __pbn__judge_dis_coeff = null;
        }
        private double? __pbn__judge_dis_coeff;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(30)]
        public double basis_dis_value
        {
            get { return __pbn__basis_dis_value ?? 30; }
            set { __pbn__basis_dis_value = value; }
        }
        public bool ShouldSerializebasis_dis_value()
        {
            return __pbn__basis_dis_value != null;
        }
        public void Resetbasis_dis_value()
        {
            __pbn__basis_dis_value = null;
        }
        private double? __pbn__basis_dis_value;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(0.5)]
        public double lateral_velocity_value
        {
            get { return __pbn__lateral_velocity_value ?? 0.5; }
            set { __pbn__lateral_velocity_value = value; }
        }
        public bool ShouldSerializelateral_velocity_value()
        {
            return __pbn__lateral_velocity_value != null;
        }
        public void Resetlateral_velocity_value()
        {
            __pbn__lateral_velocity_value = null;
        }
        private double? __pbn__lateral_velocity_value;

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue(1)]
        public double speed_decider_detect_range
        {
            get { return __pbn__speed_decider_detect_range ?? 1; }
            set { __pbn__speed_decider_detect_range = value; }
        }
        public bool ShouldSerializespeed_decider_detect_range()
        {
            return __pbn__speed_decider_detect_range != null;
        }
        public void Resetspeed_decider_detect_range()
        {
            __pbn__speed_decider_detect_range = null;
        }
        private double? __pbn__speed_decider_detect_range;

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue(100)]
        public uint max_keep_nudge_cycles
        {
            get { return __pbn__max_keep_nudge_cycles ?? 100; }
            set { __pbn__max_keep_nudge_cycles = value; }
        }
        public bool ShouldSerializemax_keep_nudge_cycles()
        {
            return __pbn__max_keep_nudge_cycles != null;
        }
        public void Resetmax_keep_nudge_cycles()
        {
            __pbn__max_keep_nudge_cycles = null;
        }
        private uint? __pbn__max_keep_nudge_cycles;

    }

}

#pragma warning restore 0612, 1591, 3021
