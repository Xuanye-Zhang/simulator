// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: v2x_traffic_light.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.v2x
{

    [global::ProtoBuf.ProtoContract()]
    public partial class SingleTrafficLight : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SingleTrafficLight()
        {
            trafficlight_type = new global::System.Collections.Generic.List<Type>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(Color.Unknown)]
        public Color color
        {
            get { return __pbn__color ?? Color.Unknown; }
            set { __pbn__color = value; }
        }
        public bool ShouldSerializecolor()
        {
            return __pbn__color != null;
        }
        public void Resetcolor()
        {
            __pbn__color = null;
        }
        private Color? __pbn__color;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<Type> trafficlight_type { get; private set; }

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string id
        {
            get { return __pbn__id ?? ""; }
            set { __pbn__id = value; }
        }
        public bool ShouldSerializeid()
        {
            return __pbn__id != null;
        }
        public void Resetid()
        {
            __pbn__id = null;
        }
        private string __pbn__id;

        [global::ProtoBuf.ProtoMember(4)]
        public int color_remaining_time_s
        {
            get { return __pbn__color_remaining_time_s.GetValueOrDefault(); }
            set { __pbn__color_remaining_time_s = value; }
        }
        public bool ShouldSerializecolor_remaining_time_s()
        {
            return __pbn__color_remaining_time_s != null;
        }
        public void Resetcolor_remaining_time_s()
        {
            __pbn__color_remaining_time_s = null;
        }
        private int? __pbn__color_remaining_time_s;

        [global::ProtoBuf.ProtoMember(5)]
        public bool right_turn_light
        {
            get { return __pbn__right_turn_light.GetValueOrDefault(); }
            set { __pbn__right_turn_light = value; }
        }
        public bool ShouldSerializeright_turn_light()
        {
            return __pbn__right_turn_light != null;
        }
        public void Resetright_turn_light()
        {
            __pbn__right_turn_light = null;
        }
        private bool? __pbn__right_turn_light;

        [global::ProtoBuf.ProtoContract()]
        public enum Color
        {
            [global::ProtoBuf.ProtoEnum(Name = @"UNKNOWN")]
            Unknown = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"RED")]
            Red = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"YELLOW")]
            Yellow = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"GREEN")]
            Green = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"BLACK")]
            Black = 4,
            [global::ProtoBuf.ProtoEnum(Name = @"FLASH_GREEN")]
            FlashGreen = 5,
        }

        [global::ProtoBuf.ProtoContract()]
        public enum Type
        {
            [global::ProtoBuf.ProtoEnum(Name = @"STRAIGHT")]
            Straight = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"LEFT")]
            Left = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"RIGHT")]
            Right = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"U_TURN")]
            UTurn = 3,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CurrentLaneTrafficLight : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public CurrentLaneTrafficLight()
        {
            single_traffic_light = new global::System.Collections.Generic.List<SingleTrafficLight>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double gps_x_m
        {
            get { return __pbn__gps_x_m.GetValueOrDefault(); }
            set { __pbn__gps_x_m = value; }
        }
        public bool ShouldSerializegps_x_m()
        {
            return __pbn__gps_x_m != null;
        }
        public void Resetgps_x_m()
        {
            __pbn__gps_x_m = null;
        }
        private double? __pbn__gps_x_m;

        [global::ProtoBuf.ProtoMember(2)]
        public double gps_y_m
        {
            get { return __pbn__gps_y_m.GetValueOrDefault(); }
            set { __pbn__gps_y_m = value; }
        }
        public bool ShouldSerializegps_y_m()
        {
            return __pbn__gps_y_m != null;
        }
        public void Resetgps_y_m()
        {
            __pbn__gps_y_m = null;
        }
        private double? __pbn__gps_y_m;

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<SingleTrafficLight> single_traffic_light { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class IntersectionTrafficLightData : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public IntersectionTrafficLightData()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::apollo.common.Header header { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public CurrentLaneTrafficLight current_lane_trafficlight { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public int intersection_id
        {
            get { return __pbn__intersection_id.GetValueOrDefault(); }
            set { __pbn__intersection_id = value; }
        }
        public bool ShouldSerializeintersection_id()
        {
            return __pbn__intersection_id != null;
        }
        public void Resetintersection_id()
        {
            __pbn__intersection_id = null;
        }
        private int? __pbn__intersection_id;

    }

}

#pragma warning restore 0612, 1591, 3021
