// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: dst_existance_fusion_config.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CameraValidDist : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public CameraValidDist()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string camera_name
        {
            get { return __pbn__camera_name ?? ""; }
            set { __pbn__camera_name = value; }
        }
        public bool ShouldSerializecamera_name()
        {
            return __pbn__camera_name != null;
        }
        public void Resetcamera_name()
        {
            __pbn__camera_name = null;
        }
        private string __pbn__camera_name;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double valid_dist
        {
            get { return __pbn__valid_dist ?? 0; }
            set { __pbn__valid_dist = value; }
        }
        public bool ShouldSerializevalid_dist()
        {
            return __pbn__valid_dist != null;
        }
        public void Resetvalid_dist()
        {
            __pbn__valid_dist = null;
        }
        private double? __pbn__valid_dist;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DstExistanceFusionConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public DstExistanceFusionConfig()
        {
            camera_valid_dist = new global::System.Collections.Generic.List<CameraValidDist>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(4)]
        public double track_object_max_match_distance
        {
            get { return __pbn__track_object_max_match_distance ?? 4; }
            set { __pbn__track_object_max_match_distance = value; }
        }
        public bool ShouldSerializetrack_object_max_match_distance()
        {
            return __pbn__track_object_max_match_distance != null;
        }
        public void Resettrack_object_max_match_distance()
        {
            __pbn__track_object_max_match_distance = null;
        }
        private double? __pbn__track_object_max_match_distance;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<CameraValidDist> camera_valid_dist { get; private set; }

    }

}

#pragma warning restore 0612, 1591, 3021
