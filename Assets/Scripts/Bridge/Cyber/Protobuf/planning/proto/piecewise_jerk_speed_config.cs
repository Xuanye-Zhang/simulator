// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: piecewise_jerk_speed_config.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.planning
{

    [global::ProtoBuf.ProtoContract()]
    public partial class PiecewiseJerkSpeedConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PiecewiseJerkSpeedConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(1)]
        public double acc_weight
        {
            get { return __pbn__acc_weight ?? 1; }
            set { __pbn__acc_weight = value; }
        }
        public bool ShouldSerializeacc_weight()
        {
            return __pbn__acc_weight != null;
        }
        public void Resetacc_weight()
        {
            __pbn__acc_weight = null;
        }
        private double? __pbn__acc_weight;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(10)]
        public double jerk_weight
        {
            get { return __pbn__jerk_weight ?? 10; }
            set { __pbn__jerk_weight = value; }
        }
        public bool ShouldSerializejerk_weight()
        {
            return __pbn__jerk_weight != null;
        }
        public void Resetjerk_weight()
        {
            __pbn__jerk_weight = null;
        }
        private double? __pbn__jerk_weight;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(1000)]
        public double dkappa_penalty_weight
        {
            get { return __pbn__dkappa_penalty_weight ?? 1000; }
            set { __pbn__dkappa_penalty_weight = value; }
        }
        public bool ShouldSerializedkappa_penalty_weight()
        {
            return __pbn__dkappa_penalty_weight != null;
        }
        public void Resetdkappa_penalty_weight()
        {
            __pbn__dkappa_penalty_weight = null;
        }
        private double? __pbn__dkappa_penalty_weight;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(10)]
        public double ref_s_weight
        {
            get { return __pbn__ref_s_weight ?? 10; }
            set { __pbn__ref_s_weight = value; }
        }
        public bool ShouldSerializeref_s_weight()
        {
            return __pbn__ref_s_weight != null;
        }
        public void Resetref_s_weight()
        {
            __pbn__ref_s_weight = null;
        }
        private double? __pbn__ref_s_weight;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(10)]
        public double ref_v_weight
        {
            get { return __pbn__ref_v_weight ?? 10; }
            set { __pbn__ref_v_weight = value; }
        }
        public bool ShouldSerializeref_v_weight()
        {
            return __pbn__ref_v_weight != null;
        }
        public void Resetref_v_weight()
        {
            __pbn__ref_v_weight = null;
        }
        private double? __pbn__ref_v_weight;

    }

}

#pragma warning restore 0612, 1591, 3021
