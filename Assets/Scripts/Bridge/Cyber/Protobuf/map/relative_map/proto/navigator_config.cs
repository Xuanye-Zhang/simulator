// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: navigator_config.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.relative_map
{

    [global::ProtoBuf.ProtoContract()]
    public partial class SampleParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SampleParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(3)]
        public double straight_sample_interval
        {
            get { return __pbn__straight_sample_interval ?? 3; }
            set { __pbn__straight_sample_interval = value; }
        }
        public bool ShouldSerializestraight_sample_interval()
        {
            return __pbn__straight_sample_interval != null;
        }
        public void Resetstraight_sample_interval()
        {
            __pbn__straight_sample_interval = null;
        }
        private double? __pbn__straight_sample_interval;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(1)]
        public double small_kappa_sample_interval
        {
            get { return __pbn__small_kappa_sample_interval ?? 1; }
            set { __pbn__small_kappa_sample_interval = value; }
        }
        public bool ShouldSerializesmall_kappa_sample_interval()
        {
            return __pbn__small_kappa_sample_interval != null;
        }
        public void Resetsmall_kappa_sample_interval()
        {
            __pbn__small_kappa_sample_interval = null;
        }
        private double? __pbn__small_kappa_sample_interval;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(0.4)]
        public double middle_kappa_sample_interval
        {
            get { return __pbn__middle_kappa_sample_interval ?? 0.4; }
            set { __pbn__middle_kappa_sample_interval = value; }
        }
        public bool ShouldSerializemiddle_kappa_sample_interval()
        {
            return __pbn__middle_kappa_sample_interval != null;
        }
        public void Resetmiddle_kappa_sample_interval()
        {
            __pbn__middle_kappa_sample_interval = null;
        }
        private double? __pbn__middle_kappa_sample_interval;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(0.1)]
        public double large_kappa_sample_interval
        {
            get { return __pbn__large_kappa_sample_interval ?? 0.1; }
            set { __pbn__large_kappa_sample_interval = value; }
        }
        public bool ShouldSerializelarge_kappa_sample_interval()
        {
            return __pbn__large_kappa_sample_interval != null;
        }
        public void Resetlarge_kappa_sample_interval()
        {
            __pbn__large_kappa_sample_interval = null;
        }
        private double? __pbn__large_kappa_sample_interval;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(0.002)]
        public double small_kappa
        {
            get { return __pbn__small_kappa ?? 0.002; }
            set { __pbn__small_kappa = value; }
        }
        public bool ShouldSerializesmall_kappa()
        {
            return __pbn__small_kappa != null;
        }
        public void Resetsmall_kappa()
        {
            __pbn__small_kappa = null;
        }
        private double? __pbn__small_kappa;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(0.008)]
        public double middle_kappa
        {
            get { return __pbn__middle_kappa ?? 0.008; }
            set { __pbn__middle_kappa = value; }
        }
        public bool ShouldSerializemiddle_kappa()
        {
            return __pbn__middle_kappa != null;
        }
        public void Resetmiddle_kappa()
        {
            __pbn__middle_kappa = null;
        }
        private double? __pbn__middle_kappa;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(0.02)]
        public double large_kappa
        {
            get { return __pbn__large_kappa ?? 0.02; }
            set { __pbn__large_kappa = value; }
        }
        public bool ShouldSerializelarge_kappa()
        {
            return __pbn__large_kappa != null;
        }
        public void Resetlarge_kappa()
        {
            __pbn__large_kappa = null;
        }
        private double? __pbn__large_kappa;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NavigatorConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public NavigatorConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool enable_navigator_downsample
        {
            get { return __pbn__enable_navigator_downsample ?? true; }
            set { __pbn__enable_navigator_downsample = value; }
        }
        public bool ShouldSerializeenable_navigator_downsample()
        {
            return __pbn__enable_navigator_downsample != null;
        }
        public void Resetenable_navigator_downsample()
        {
            __pbn__enable_navigator_downsample = null;
        }
        private bool? __pbn__enable_navigator_downsample;

        [global::ProtoBuf.ProtoMember(2)]
        public SampleParam sample_param { get; set; }

    }

}

#pragma warning restore 0612, 1591, 3021
