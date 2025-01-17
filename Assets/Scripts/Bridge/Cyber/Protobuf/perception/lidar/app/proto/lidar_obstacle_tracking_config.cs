// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: lidar_obstacle_tracking_config.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.lidar
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LidarObstacleTrackingConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LidarObstacleTrackingConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(@"DummyMultiTargetTracker")]
        public string multi_target_tracker
        {
            get { return __pbn__multi_target_tracker ?? @"DummyMultiTargetTracker"; }
            set { __pbn__multi_target_tracker = value; }
        }
        public bool ShouldSerializemulti_target_tracker()
        {
            return __pbn__multi_target_tracker != null;
        }
        public void Resetmulti_target_tracker()
        {
            __pbn__multi_target_tracker = null;
        }
        private string __pbn__multi_target_tracker;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(@"DummyClassifier")]
        public string frame_classifier
        {
            get { return __pbn__frame_classifier ?? @"DummyClassifier"; }
            set { __pbn__frame_classifier = value; }
        }
        public bool ShouldSerializeframe_classifier()
        {
            return __pbn__frame_classifier != null;
        }
        public void Resetframe_classifier()
        {
            __pbn__frame_classifier = null;
        }
        private string __pbn__frame_classifier;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(@"DummyClassifier")]
        public string fusion_classifier
        {
            get { return __pbn__fusion_classifier ?? @"DummyClassifier"; }
            set { __pbn__fusion_classifier = value; }
        }
        public bool ShouldSerializefusion_classifier()
        {
            return __pbn__fusion_classifier != null;
        }
        public void Resetfusion_classifier()
        {
            __pbn__fusion_classifier = null;
        }
        private string __pbn__fusion_classifier;

    }

}

#pragma warning restore 0612, 1591, 3021
