// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: semantic_map_config.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.prediction
{

    [global::ProtoBuf.ProtoContract()]
    public partial class SemanticMapConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SemanticMapConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::apollo.common.Point3D base_point { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public int dim_x
        {
            get { return __pbn__dim_x.GetValueOrDefault(); }
            set { __pbn__dim_x = value; }
        }
        public bool ShouldSerializedim_x()
        {
            return __pbn__dim_x != null;
        }
        public void Resetdim_x()
        {
            __pbn__dim_x = null;
        }
        private int? __pbn__dim_x;

        [global::ProtoBuf.ProtoMember(3)]
        public int dim_y
        {
            get { return __pbn__dim_y.GetValueOrDefault(); }
            set { __pbn__dim_y = value; }
        }
        public bool ShouldSerializedim_y()
        {
            return __pbn__dim_y != null;
        }
        public void Resetdim_y()
        {
            __pbn__dim_y = null;
        }
        private int? __pbn__dim_y;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(0.1)]
        public double resolution
        {
            get { return __pbn__resolution ?? 0.1; }
            set { __pbn__resolution = value; }
        }
        public bool ShouldSerializeresolution()
        {
            return __pbn__resolution != null;
        }
        public void Resetresolution()
        {
            __pbn__resolution = null;
        }
        private double? __pbn__resolution;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(100)]
        public double observation_range
        {
            get { return __pbn__observation_range ?? 100; }
            set { __pbn__observation_range = value; }
        }
        public bool ShouldSerializeobservation_range()
        {
            return __pbn__observation_range != null;
        }
        public void Resetobservation_range()
        {
            __pbn__observation_range = null;
        }
        private double? __pbn__observation_range;

    }

}

#pragma warning restore 0612, 1591, 3021
