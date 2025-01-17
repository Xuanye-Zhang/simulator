// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: map_overlap.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.hdmap
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LaneOverlapInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LaneOverlapInfo()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double start_s
        {
            get { return __pbn__start_s.GetValueOrDefault(); }
            set { __pbn__start_s = value; }
        }
        public bool ShouldSerializestart_s()
        {
            return __pbn__start_s != null;
        }
        public void Resetstart_s()
        {
            __pbn__start_s = null;
        }
        private double? __pbn__start_s;

        [global::ProtoBuf.ProtoMember(2)]
        public double end_s
        {
            get { return __pbn__end_s.GetValueOrDefault(); }
            set { __pbn__end_s = value; }
        }
        public bool ShouldSerializeend_s()
        {
            return __pbn__end_s != null;
        }
        public void Resetend_s()
        {
            __pbn__end_s = null;
        }
        private double? __pbn__end_s;

        [global::ProtoBuf.ProtoMember(3)]
        public bool is_merge
        {
            get { return __pbn__is_merge.GetValueOrDefault(); }
            set { __pbn__is_merge = value; }
        }
        public bool ShouldSerializeis_merge()
        {
            return __pbn__is_merge != null;
        }
        public void Resetis_merge()
        {
            __pbn__is_merge = null;
        }
        private bool? __pbn__is_merge;

        [global::ProtoBuf.ProtoMember(4)]
        public Id region_overlap_id { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SignalOverlapInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SignalOverlapInfo()
        {
            OnConstructor();
        }

        partial void OnConstructor();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class StopSignOverlapInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public StopSignOverlapInfo()
        {
            OnConstructor();
        }

        partial void OnConstructor();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CrosswalkOverlapInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public CrosswalkOverlapInfo()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Id region_overlap_id { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class JunctionOverlapInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public JunctionOverlapInfo()
        {
            OnConstructor();
        }

        partial void OnConstructor();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class YieldOverlapInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public YieldOverlapInfo()
        {
            OnConstructor();
        }

        partial void OnConstructor();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ClearAreaOverlapInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ClearAreaOverlapInfo()
        {
            OnConstructor();
        }

        partial void OnConstructor();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SpeedBumpOverlapInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SpeedBumpOverlapInfo()
        {
            OnConstructor();
        }

        partial void OnConstructor();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ParkingSpaceOverlapInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ParkingSpaceOverlapInfo()
        {
            OnConstructor();
        }

        partial void OnConstructor();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PNCJunctionOverlapInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PNCJunctionOverlapInfo()
        {
            OnConstructor();
        }

        partial void OnConstructor();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class RegionOverlapInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public RegionOverlapInfo()
        {
            polygon = new global::System.Collections.Generic.List<Polygon>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Id id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<Polygon> polygon { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ObjectOverlapInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ObjectOverlapInfo()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Id id { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public LaneOverlapInfo lane_overlap_info
        {
            get { return __pbn__overlap_info.Is(3) ? ((LaneOverlapInfo)__pbn__overlap_info.Object) : default(LaneOverlapInfo); }
            set { __pbn__overlap_info = new global::ProtoBuf.DiscriminatedUnionObject(3, value); }
        }
        public bool ShouldSerializelane_overlap_info()
        {
            return __pbn__overlap_info.Is(3);
        }
        public void Resetlane_overlap_info()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__overlap_info, 3);
        }

        private global::ProtoBuf.DiscriminatedUnionObject __pbn__overlap_info;

        [global::ProtoBuf.ProtoMember(4)]
        public SignalOverlapInfo signal_overlap_info
        {
            get { return __pbn__overlap_info.Is(4) ? ((SignalOverlapInfo)__pbn__overlap_info.Object) : default(SignalOverlapInfo); }
            set { __pbn__overlap_info = new global::ProtoBuf.DiscriminatedUnionObject(4, value); }
        }
        public bool ShouldSerializesignal_overlap_info()
        {
            return __pbn__overlap_info.Is(4);
        }
        public void Resetsignal_overlap_info()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__overlap_info, 4);
        }

        [global::ProtoBuf.ProtoMember(5)]
        public StopSignOverlapInfo stop_sign_overlap_info
        {
            get { return __pbn__overlap_info.Is(5) ? ((StopSignOverlapInfo)__pbn__overlap_info.Object) : default(StopSignOverlapInfo); }
            set { __pbn__overlap_info = new global::ProtoBuf.DiscriminatedUnionObject(5, value); }
        }
        public bool ShouldSerializestop_sign_overlap_info()
        {
            return __pbn__overlap_info.Is(5);
        }
        public void Resetstop_sign_overlap_info()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__overlap_info, 5);
        }

        [global::ProtoBuf.ProtoMember(6)]
        public CrosswalkOverlapInfo crosswalk_overlap_info
        {
            get { return __pbn__overlap_info.Is(6) ? ((CrosswalkOverlapInfo)__pbn__overlap_info.Object) : default(CrosswalkOverlapInfo); }
            set { __pbn__overlap_info = new global::ProtoBuf.DiscriminatedUnionObject(6, value); }
        }
        public bool ShouldSerializecrosswalk_overlap_info()
        {
            return __pbn__overlap_info.Is(6);
        }
        public void Resetcrosswalk_overlap_info()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__overlap_info, 6);
        }

        [global::ProtoBuf.ProtoMember(7)]
        public JunctionOverlapInfo junction_overlap_info
        {
            get { return __pbn__overlap_info.Is(7) ? ((JunctionOverlapInfo)__pbn__overlap_info.Object) : default(JunctionOverlapInfo); }
            set { __pbn__overlap_info = new global::ProtoBuf.DiscriminatedUnionObject(7, value); }
        }
        public bool ShouldSerializejunction_overlap_info()
        {
            return __pbn__overlap_info.Is(7);
        }
        public void Resetjunction_overlap_info()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__overlap_info, 7);
        }

        [global::ProtoBuf.ProtoMember(8)]
        public YieldOverlapInfo yield_sign_overlap_info
        {
            get { return __pbn__overlap_info.Is(8) ? ((YieldOverlapInfo)__pbn__overlap_info.Object) : default(YieldOverlapInfo); }
            set { __pbn__overlap_info = new global::ProtoBuf.DiscriminatedUnionObject(8, value); }
        }
        public bool ShouldSerializeyield_sign_overlap_info()
        {
            return __pbn__overlap_info.Is(8);
        }
        public void Resetyield_sign_overlap_info()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__overlap_info, 8);
        }

        [global::ProtoBuf.ProtoMember(9)]
        public ClearAreaOverlapInfo clear_area_overlap_info
        {
            get { return __pbn__overlap_info.Is(9) ? ((ClearAreaOverlapInfo)__pbn__overlap_info.Object) : default(ClearAreaOverlapInfo); }
            set { __pbn__overlap_info = new global::ProtoBuf.DiscriminatedUnionObject(9, value); }
        }
        public bool ShouldSerializeclear_area_overlap_info()
        {
            return __pbn__overlap_info.Is(9);
        }
        public void Resetclear_area_overlap_info()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__overlap_info, 9);
        }

        [global::ProtoBuf.ProtoMember(10)]
        public SpeedBumpOverlapInfo speed_bump_overlap_info
        {
            get { return __pbn__overlap_info.Is(10) ? ((SpeedBumpOverlapInfo)__pbn__overlap_info.Object) : default(SpeedBumpOverlapInfo); }
            set { __pbn__overlap_info = new global::ProtoBuf.DiscriminatedUnionObject(10, value); }
        }
        public bool ShouldSerializespeed_bump_overlap_info()
        {
            return __pbn__overlap_info.Is(10);
        }
        public void Resetspeed_bump_overlap_info()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__overlap_info, 10);
        }

        [global::ProtoBuf.ProtoMember(11)]
        public ParkingSpaceOverlapInfo parking_space_overlap_info
        {
            get { return __pbn__overlap_info.Is(11) ? ((ParkingSpaceOverlapInfo)__pbn__overlap_info.Object) : default(ParkingSpaceOverlapInfo); }
            set { __pbn__overlap_info = new global::ProtoBuf.DiscriminatedUnionObject(11, value); }
        }
        public bool ShouldSerializeparking_space_overlap_info()
        {
            return __pbn__overlap_info.Is(11);
        }
        public void Resetparking_space_overlap_info()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__overlap_info, 11);
        }

        [global::ProtoBuf.ProtoMember(12)]
        public PNCJunctionOverlapInfo pnc_junction_overlap_info
        {
            get { return __pbn__overlap_info.Is(12) ? ((PNCJunctionOverlapInfo)__pbn__overlap_info.Object) : default(PNCJunctionOverlapInfo); }
            set { __pbn__overlap_info = new global::ProtoBuf.DiscriminatedUnionObject(12, value); }
        }
        public bool ShouldSerializepnc_junction_overlap_info()
        {
            return __pbn__overlap_info.Is(12);
        }
        public void Resetpnc_junction_overlap_info()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__overlap_info, 12);
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Overlap : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Overlap()
        {
            @object = new global::System.Collections.Generic.List<ObjectOverlapInfo>();
            region_overlap = new global::System.Collections.Generic.List<RegionOverlapInfo>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Id id { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<ObjectOverlapInfo> @object { get; private set; }

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<RegionOverlapInfo> region_overlap { get; private set; }

    }

}

#pragma warning restore 0612, 1591, 3021
