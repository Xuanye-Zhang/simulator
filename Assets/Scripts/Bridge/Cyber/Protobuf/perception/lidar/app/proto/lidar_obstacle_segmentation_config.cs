// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: lidar_obstacle_segmentation_config.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.lidar
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LidarObstacleSegmentationConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LidarObstacleSegmentationConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(@"DummySegmentation")]
        public string segmentor
        {
            get { return __pbn__segmentor ?? @"DummySegmentation"; }
            set { __pbn__segmentor = value; }
        }
        public bool ShouldSerializesegmentor()
        {
            return __pbn__segmentor != null;
        }
        public void Resetsegmentor()
        {
            __pbn__segmentor = null;
        }
        private string __pbn__segmentor;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool use_map_manager
        {
            get { return __pbn__use_map_manager ?? true; }
            set { __pbn__use_map_manager = value; }
        }
        public bool ShouldSerializeuse_map_manager()
        {
            return __pbn__use_map_manager != null;
        }
        public void Resetuse_map_manager()
        {
            __pbn__use_map_manager = null;
        }
        private bool? __pbn__use_map_manager;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool use_object_filter_bank
        {
            get { return __pbn__use_object_filter_bank ?? true; }
            set { __pbn__use_object_filter_bank = value; }
        }
        public bool ShouldSerializeuse_object_filter_bank()
        {
            return __pbn__use_object_filter_bank != null;
        }
        public void Resetuse_object_filter_bank()
        {
            __pbn__use_object_filter_bank = null;
        }
        private bool? __pbn__use_object_filter_bank;

    }

}

#pragma warning restore 0612, 1591, 3021
