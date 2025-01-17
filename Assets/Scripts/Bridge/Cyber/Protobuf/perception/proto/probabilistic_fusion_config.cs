// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: probabilistic_fusion_config.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.fusion
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ProbabilisticFusionConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ProbabilisticFusionConfig()
        {
            prohibition_sensors = new global::System.Collections.Generic.List<string>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool use_lidar
        {
            get { return __pbn__use_lidar ?? true; }
            set { __pbn__use_lidar = value; }
        }
        public bool ShouldSerializeuse_lidar()
        {
            return __pbn__use_lidar != null;
        }
        public void Resetuse_lidar()
        {
            __pbn__use_lidar = null;
        }
        private bool? __pbn__use_lidar;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool use_radar
        {
            get { return __pbn__use_radar ?? true; }
            set { __pbn__use_radar = value; }
        }
        public bool ShouldSerializeuse_radar()
        {
            return __pbn__use_radar != null;
        }
        public void Resetuse_radar()
        {
            __pbn__use_radar = null;
        }
        private bool? __pbn__use_radar;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool use_camera
        {
            get { return __pbn__use_camera ?? true; }
            set { __pbn__use_camera = value; }
        }
        public bool ShouldSerializeuse_camera()
        {
            return __pbn__use_camera != null;
        }
        public void Resetuse_camera()
        {
            __pbn__use_camera = null;
        }
        private bool? __pbn__use_camera;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(@"PbfTracker")]
        public string tracker_method
        {
            get { return __pbn__tracker_method ?? @"PbfTracker"; }
            set { __pbn__tracker_method = value; }
        }
        public bool ShouldSerializetracker_method()
        {
            return __pbn__tracker_method != null;
        }
        public void Resettracker_method()
        {
            __pbn__tracker_method = null;
        }
        private string __pbn__tracker_method;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(@"HMAssociation")]
        public string data_association_method
        {
            get { return __pbn__data_association_method ?? @"HMAssociation"; }
            set { __pbn__data_association_method = value; }
        }
        public bool ShouldSerializedata_association_method()
        {
            return __pbn__data_association_method != null;
        }
        public void Resetdata_association_method()
        {
            __pbn__data_association_method = null;
        }
        private string __pbn__data_association_method;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(@"PbfGatekeeper")]
        public string gate_keeper_method
        {
            get { return __pbn__gate_keeper_method ?? @"PbfGatekeeper"; }
            set { __pbn__gate_keeper_method = value; }
        }
        public bool ShouldSerializegate_keeper_method()
        {
            return __pbn__gate_keeper_method != null;
        }
        public void Resetgate_keeper_method()
        {
            __pbn__gate_keeper_method = null;
        }
        private string __pbn__gate_keeper_method;

        [global::ProtoBuf.ProtoMember(7)]
        public global::System.Collections.Generic.List<string> prohibition_sensors { get; private set; }

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(0.25)]
        public double max_lidar_invisible_period
        {
            get { return __pbn__max_lidar_invisible_period ?? 0.25; }
            set { __pbn__max_lidar_invisible_period = value; }
        }
        public bool ShouldSerializemax_lidar_invisible_period()
        {
            return __pbn__max_lidar_invisible_period != null;
        }
        public void Resetmax_lidar_invisible_period()
        {
            __pbn__max_lidar_invisible_period = null;
        }
        private double? __pbn__max_lidar_invisible_period;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(0.5)]
        public double max_radar_invisible_period
        {
            get { return __pbn__max_radar_invisible_period ?? 0.5; }
            set { __pbn__max_radar_invisible_period = value; }
        }
        public bool ShouldSerializemax_radar_invisible_period()
        {
            return __pbn__max_radar_invisible_period != null;
        }
        public void Resetmax_radar_invisible_period()
        {
            __pbn__max_radar_invisible_period = null;
        }
        private double? __pbn__max_radar_invisible_period;

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue(0.75)]
        public double max_camera_invisible_period
        {
            get { return __pbn__max_camera_invisible_period ?? 0.75; }
            set { __pbn__max_camera_invisible_period = value; }
        }
        public bool ShouldSerializemax_camera_invisible_period()
        {
            return __pbn__max_camera_invisible_period != null;
        }
        public void Resetmax_camera_invisible_period()
        {
            __pbn__max_camera_invisible_period = null;
        }
        private double? __pbn__max_camera_invisible_period;

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue(50)]
        public long max_cached_frame_num
        {
            get { return __pbn__max_cached_frame_num ?? 50; }
            set { __pbn__max_cached_frame_num = value; }
        }
        public bool ShouldSerializemax_cached_frame_num()
        {
            return __pbn__max_cached_frame_num != null;
        }
        public void Resetmax_cached_frame_num()
        {
            __pbn__max_cached_frame_num = null;
        }
        private long? __pbn__max_cached_frame_num;

    }

}

#pragma warning restore 0612, 1591, 3021
