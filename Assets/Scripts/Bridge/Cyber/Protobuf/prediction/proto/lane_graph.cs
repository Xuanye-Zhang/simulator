// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: lane_graph.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.prediction
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LanePoint : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LanePoint()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::apollo.common.Point3D position { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double heading
        {
            get { return __pbn__heading ?? 0; }
            set { __pbn__heading = value; }
        }
        public bool ShouldSerializeheading()
        {
            return __pbn__heading != null;
        }
        public void Resetheading()
        {
            __pbn__heading = null;
        }
        private double? __pbn__heading;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double width
        {
            get { return __pbn__width ?? 0; }
            set { __pbn__width = value; }
        }
        public bool ShouldSerializewidth()
        {
            return __pbn__width != null;
        }
        public void Resetwidth()
        {
            __pbn__width = null;
        }
        private double? __pbn__width;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double relative_s
        {
            get { return __pbn__relative_s ?? 0; }
            set { __pbn__relative_s = value; }
        }
        public bool ShouldSerializerelative_s()
        {
            return __pbn__relative_s != null;
        }
        public void Resetrelative_s()
        {
            __pbn__relative_s = null;
        }
        private double? __pbn__relative_s;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double relative_l
        {
            get { return __pbn__relative_l ?? 0; }
            set { __pbn__relative_l = value; }
        }
        public bool ShouldSerializerelative_l()
        {
            return __pbn__relative_l != null;
        }
        public void Resetrelative_l()
        {
            __pbn__relative_l = null;
        }
        private double? __pbn__relative_l;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double angle_diff
        {
            get { return __pbn__angle_diff ?? 0; }
            set { __pbn__angle_diff = value; }
        }
        public bool ShouldSerializeangle_diff()
        {
            return __pbn__angle_diff != null;
        }
        public void Resetangle_diff()
        {
            __pbn__angle_diff = null;
        }
        private double? __pbn__angle_diff;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double kappa
        {
            get { return __pbn__kappa ?? 0; }
            set { __pbn__kappa = value; }
        }
        public bool ShouldSerializekappa()
        {
            return __pbn__kappa != null;
        }
        public void Resetkappa()
        {
            __pbn__kappa = null;
        }
        private double? __pbn__kappa;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(ScenarioType.UrbanRoad)]
        public ScenarioType scenario_type
        {
            get { return __pbn__scenario_type ?? ScenarioType.UrbanRoad; }
            set { __pbn__scenario_type = value; }
        }
        public bool ShouldSerializescenario_type()
        {
            return __pbn__scenario_type != null;
        }
        public void Resetscenario_type()
        {
            __pbn__scenario_type = null;
        }
        private ScenarioType? __pbn__scenario_type;

        [global::ProtoBuf.ProtoMember(9)]
        public double speed_limit
        {
            get { return __pbn__speed_limit.GetValueOrDefault(); }
            set { __pbn__speed_limit = value; }
        }
        public bool ShouldSerializespeed_limit()
        {
            return __pbn__speed_limit != null;
        }
        public void Resetspeed_limit()
        {
            __pbn__speed_limit = null;
        }
        private double? __pbn__speed_limit;

        [global::ProtoBuf.ProtoContract()]
        public enum ScenarioType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"URBAN_ROAD")]
            UrbanRoad = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"JUNCTION")]
            Junction = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"HIGHWAY")]
            Highway = 2,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LaneSegment : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LaneSegment()
        {
            lane_point = new global::System.Collections.Generic.List<LanePoint>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string lane_id
        {
            get { return __pbn__lane_id ?? ""; }
            set { __pbn__lane_id = value; }
        }
        public bool ShouldSerializelane_id()
        {
            return __pbn__lane_id != null;
        }
        public void Resetlane_id()
        {
            __pbn__lane_id = null;
        }
        private string __pbn__lane_id;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double start_s
        {
            get { return __pbn__start_s ?? 0; }
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

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double end_s
        {
            get { return __pbn__end_s ?? 0; }
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

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(0)]
        public uint lane_turn_type
        {
            get { return __pbn__lane_turn_type ?? 0; }
            set { __pbn__lane_turn_type = value; }
        }
        public bool ShouldSerializelane_turn_type()
        {
            return __pbn__lane_turn_type != null;
        }
        public void Resetlane_turn_type()
        {
            __pbn__lane_turn_type = null;
        }
        private uint? __pbn__lane_turn_type;

        [global::ProtoBuf.ProtoMember(5)]
        public global::System.Collections.Generic.List<LanePoint> lane_point { get; private set; }

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double adc_s
        {
            get { return __pbn__adc_s ?? 0; }
            set { __pbn__adc_s = value; }
        }
        public bool ShouldSerializeadc_s()
        {
            return __pbn__adc_s != null;
        }
        public void Resetadc_s()
        {
            __pbn__adc_s = null;
        }
        private double? __pbn__adc_s;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(0)]
        public int adc_lane_point_idx
        {
            get { return __pbn__adc_lane_point_idx ?? 0; }
            set { __pbn__adc_lane_point_idx = value; }
        }
        public bool ShouldSerializeadc_lane_point_idx()
        {
            return __pbn__adc_lane_point_idx != null;
        }
        public void Resetadc_lane_point_idx()
        {
            __pbn__adc_lane_point_idx = null;
        }
        private int? __pbn__adc_lane_point_idx;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double total_length
        {
            get { return __pbn__total_length ?? 0; }
            set { __pbn__total_length = value; }
        }
        public bool ShouldSerializetotal_length()
        {
            return __pbn__total_length != null;
        }
        public void Resettotal_length()
        {
            __pbn__total_length = null;
        }
        private double? __pbn__total_length;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NearbyObstacle : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public NearbyObstacle()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public int id
        {
            get { return __pbn__id.GetValueOrDefault(); }
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
        private int? __pbn__id;

        [global::ProtoBuf.ProtoMember(2)]
        public double s
        {
            get { return __pbn__s.GetValueOrDefault(); }
            set { __pbn__s = value; }
        }
        public bool ShouldSerializes()
        {
            return __pbn__s != null;
        }
        public void Resets()
        {
            __pbn__s = null;
        }
        private double? __pbn__s;

        [global::ProtoBuf.ProtoMember(3)]
        public double l
        {
            get { return __pbn__l.GetValueOrDefault(); }
            set { __pbn__l = value; }
        }
        public bool ShouldSerializel()
        {
            return __pbn__l != null;
        }
        public void Resetl()
        {
            __pbn__l = null;
        }
        private double? __pbn__l;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class StopSign : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public StopSign()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string stop_sign_id
        {
            get { return __pbn__stop_sign_id ?? ""; }
            set { __pbn__stop_sign_id = value; }
        }
        public bool ShouldSerializestop_sign_id()
        {
            return __pbn__stop_sign_id != null;
        }
        public void Resetstop_sign_id()
        {
            __pbn__stop_sign_id = null;
        }
        private string __pbn__stop_sign_id;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string lane_id
        {
            get { return __pbn__lane_id ?? ""; }
            set { __pbn__lane_id = value; }
        }
        public bool ShouldSerializelane_id()
        {
            return __pbn__lane_id != null;
        }
        public void Resetlane_id()
        {
            __pbn__lane_id = null;
        }
        private string __pbn__lane_id;

        [global::ProtoBuf.ProtoMember(3)]
        public double lane_s
        {
            get { return __pbn__lane_s.GetValueOrDefault(); }
            set { __pbn__lane_s = value; }
        }
        public bool ShouldSerializelane_s()
        {
            return __pbn__lane_s != null;
        }
        public void Resetlane_s()
        {
            __pbn__lane_s = null;
        }
        private double? __pbn__lane_s;

        [global::ProtoBuf.ProtoMember(4)]
        public double lane_sequence_s
        {
            get { return __pbn__lane_sequence_s.GetValueOrDefault(); }
            set { __pbn__lane_sequence_s = value; }
        }
        public bool ShouldSerializelane_sequence_s()
        {
            return __pbn__lane_sequence_s != null;
        }
        public void Resetlane_sequence_s()
        {
            __pbn__lane_sequence_s = null;
        }
        private double? __pbn__lane_sequence_s;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LaneSequence : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LaneSequence()
        {
            lane_segment = new global::System.Collections.Generic.List<LaneSegment>();
            path_point = new global::System.Collections.Generic.List<global::apollo.common.PathPoint>();
            nearby_obstacle = new global::System.Collections.Generic.List<NearbyObstacle>();
            curr_lane_point = new global::System.Collections.Generic.List<LanePoint>();
            left_neighbor_point = new global::System.Collections.Generic.List<LanePoint>();
            right_neighbor_point = new global::System.Collections.Generic.List<LanePoint>();
            left_nearby_obstacle = new global::System.Collections.Generic.List<NearbyObstacle>();
            right_nearby_obstacle = new global::System.Collections.Generic.List<NearbyObstacle>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public int lane_sequence_id
        {
            get { return __pbn__lane_sequence_id.GetValueOrDefault(); }
            set { __pbn__lane_sequence_id = value; }
        }
        public bool ShouldSerializelane_sequence_id()
        {
            return __pbn__lane_sequence_id != null;
        }
        public void Resetlane_sequence_id()
        {
            __pbn__lane_sequence_id = null;
        }
        private int? __pbn__lane_sequence_id;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<LaneSegment> lane_segment { get; private set; }

        [global::ProtoBuf.ProtoMember(23)]
        [global::System.ComponentModel.DefaultValue(0)]
        public int adc_lane_segment_idx
        {
            get { return __pbn__adc_lane_segment_idx ?? 0; }
            set { __pbn__adc_lane_segment_idx = value; }
        }
        public bool ShouldSerializeadc_lane_segment_idx()
        {
            return __pbn__adc_lane_segment_idx != null;
        }
        public void Resetadc_lane_segment_idx()
        {
            __pbn__adc_lane_segment_idx = null;
        }
        private int? __pbn__adc_lane_segment_idx;

        [global::ProtoBuf.ProtoMember(8)]
        public global::System.Collections.Generic.List<global::apollo.common.PathPoint> path_point { get; private set; }

        [global::ProtoBuf.ProtoMember(22)]
        [global::System.ComponentModel.DefaultValue(global::apollo.hdmap.Lane.LaneType.None)]
        public global::apollo.hdmap.Lane.LaneType lane_type
        {
            get { return __pbn__lane_type ?? global::apollo.hdmap.Lane.LaneType.None; }
            set { __pbn__lane_type = value; }
        }
        public bool ShouldSerializelane_type()
        {
            return __pbn__lane_type != null;
        }
        public void Resetlane_type()
        {
            __pbn__lane_type = null;
        }
        private global::apollo.hdmap.Lane.LaneType? __pbn__lane_type;

        [global::ProtoBuf.ProtoMember(17)]
        public double lane_s
        {
            get { return __pbn__lane_s.GetValueOrDefault(); }
            set { __pbn__lane_s = value; }
        }
        public bool ShouldSerializelane_s()
        {
            return __pbn__lane_s != null;
        }
        public void Resetlane_s()
        {
            __pbn__lane_s = null;
        }
        private double? __pbn__lane_s;

        [global::ProtoBuf.ProtoMember(18)]
        public double lane_l
        {
            get { return __pbn__lane_l.GetValueOrDefault(); }
            set { __pbn__lane_l = value; }
        }
        public bool ShouldSerializelane_l()
        {
            return __pbn__lane_l != null;
        }
        public void Resetlane_l()
        {
            __pbn__lane_l = null;
        }
        private double? __pbn__lane_l;

        [global::ProtoBuf.ProtoMember(10)]
        public bool vehicle_on_lane
        {
            get { return __pbn__vehicle_on_lane.GetValueOrDefault(); }
            set { __pbn__vehicle_on_lane = value; }
        }
        public bool ShouldSerializevehicle_on_lane()
        {
            return __pbn__vehicle_on_lane != null;
        }
        public void Resetvehicle_on_lane()
        {
            __pbn__vehicle_on_lane = null;
        }
        private bool? __pbn__vehicle_on_lane;

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<NearbyObstacle> nearby_obstacle { get; private set; }

        [global::ProtoBuf.ProtoMember(20)]
        public StopSign stop_sign { get; set; }

        [global::ProtoBuf.ProtoMember(21)]
        public int right_of_way
        {
            get { return __pbn__right_of_way.GetValueOrDefault(); }
            set { __pbn__right_of_way = value; }
        }
        public bool ShouldSerializeright_of_way()
        {
            return __pbn__right_of_way != null;
        }
        public void Resetright_of_way()
        {
            __pbn__right_of_way = null;
        }
        private int? __pbn__right_of_way;

        [global::ProtoBuf.ProtoMember(4)]
        public Features features { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(0)]
        public int label
        {
            get { return __pbn__label ?? 0; }
            set { __pbn__label = value; }
        }
        public bool ShouldSerializelabel()
        {
            return __pbn__label != null;
        }
        public void Resetlabel()
        {
            __pbn__label = null;
        }
        private int? __pbn__label;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double probability
        {
            get { return __pbn__probability ?? 0; }
            set { __pbn__probability = value; }
        }
        public bool ShouldSerializeprobability()
        {
            return __pbn__probability != null;
        }
        public void Resetprobability()
        {
            __pbn__probability = null;
        }
        private double? __pbn__probability;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double acceleration
        {
            get { return __pbn__acceleration ?? 0; }
            set { __pbn__acceleration = value; }
        }
        public bool ShouldSerializeacceleration()
        {
            return __pbn__acceleration != null;
        }
        public void Resetacceleration()
        {
            __pbn__acceleration = null;
        }
        private double? __pbn__acceleration;

        [global::ProtoBuf.ProtoMember(16)]
        public double time_to_lane_center
        {
            get { return __pbn__time_to_lane_center.GetValueOrDefault(); }
            set { __pbn__time_to_lane_center = value; }
        }
        public bool ShouldSerializetime_to_lane_center()
        {
            return __pbn__time_to_lane_center != null;
        }
        public void Resettime_to_lane_center()
        {
            __pbn__time_to_lane_center = null;
        }
        private double? __pbn__time_to_lane_center;

        [global::ProtoBuf.ProtoMember(19)]
        public double time_to_lane_edge
        {
            get { return __pbn__time_to_lane_edge.GetValueOrDefault(); }
            set { __pbn__time_to_lane_edge = value; }
        }
        public bool ShouldSerializetime_to_lane_edge()
        {
            return __pbn__time_to_lane_edge != null;
        }
        public void Resettime_to_lane_edge()
        {
            __pbn__time_to_lane_edge = null;
        }
        private double? __pbn__time_to_lane_edge;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(BehaviorType.NotGotoLane)]
        public BehaviorType behavior_type
        {
            get { return __pbn__behavior_type ?? BehaviorType.NotGotoLane; }
            set { __pbn__behavior_type = value; }
        }
        public bool ShouldSerializebehavior_type()
        {
            return __pbn__behavior_type != null;
        }
        public void Resetbehavior_type()
        {
            __pbn__behavior_type = null;
        }
        private BehaviorType? __pbn__behavior_type;

        [global::ProtoBuf.ProtoMember(11)]
        public global::System.Collections.Generic.List<LanePoint> curr_lane_point { get; private set; }

        [global::ProtoBuf.ProtoMember(12)]
        public global::System.Collections.Generic.List<LanePoint> left_neighbor_point { get; private set; }

        [global::ProtoBuf.ProtoMember(13)]
        public global::System.Collections.Generic.List<LanePoint> right_neighbor_point { get; private set; }

        [global::ProtoBuf.ProtoMember(14)]
        public global::System.Collections.Generic.List<NearbyObstacle> left_nearby_obstacle { get; private set; }

        [global::ProtoBuf.ProtoMember(15)]
        public global::System.Collections.Generic.List<NearbyObstacle> right_nearby_obstacle { get; private set; }

        [global::ProtoBuf.ProtoContract()]
        public partial class Features : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
            }
            public Features()
            {
                OnConstructor();
            }

            partial void OnConstructor();

            [global::ProtoBuf.ProtoMember(1)]
            public double[] mlp_features { get; set; }

        }

        [global::ProtoBuf.ProtoContract()]
        public enum BehaviorType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"NOT_GOTO_LANE")]
            NotGotoLane = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"CONSTANT_SPEED")]
            ConstantSpeed = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"SMALL_ACCELERATION")]
            SmallAcceleration = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"LARGE_ACCELERATION")]
            LargeAcceleration = 4,
            [global::ProtoBuf.ProtoEnum(Name = @"SMALL_DECELERATION")]
            SmallDeceleration = 5,
            [global::ProtoBuf.ProtoEnum(Name = @"LARGE_DECELERATION")]
            LargeDeceleration = 6,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LaneGraph : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LaneGraph()
        {
            lane_sequence = new global::System.Collections.Generic.List<LaneSequence>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<LaneSequence> lane_sequence { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class LaneObstacle : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LaneObstacle()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public int obstacle_id
        {
            get { return __pbn__obstacle_id.GetValueOrDefault(); }
            set { __pbn__obstacle_id = value; }
        }
        public bool ShouldSerializeobstacle_id()
        {
            return __pbn__obstacle_id != null;
        }
        public void Resetobstacle_id()
        {
            __pbn__obstacle_id = null;
        }
        private int? __pbn__obstacle_id;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string lane_id
        {
            get { return __pbn__lane_id ?? ""; }
            set { __pbn__lane_id = value; }
        }
        public bool ShouldSerializelane_id()
        {
            return __pbn__lane_id != null;
        }
        public void Resetlane_id()
        {
            __pbn__lane_id = null;
        }
        private string __pbn__lane_id;

        [global::ProtoBuf.ProtoMember(3)]
        public double lane_s
        {
            get { return __pbn__lane_s.GetValueOrDefault(); }
            set { __pbn__lane_s = value; }
        }
        public bool ShouldSerializelane_s()
        {
            return __pbn__lane_s != null;
        }
        public void Resetlane_s()
        {
            __pbn__lane_s = null;
        }
        private double? __pbn__lane_s;

        [global::ProtoBuf.ProtoMember(4)]
        public double lane_l
        {
            get { return __pbn__lane_l.GetValueOrDefault(); }
            set { __pbn__lane_l = value; }
        }
        public bool ShouldSerializelane_l()
        {
            return __pbn__lane_l != null;
        }
        public void Resetlane_l()
        {
            __pbn__lane_l = null;
        }
        private double? __pbn__lane_l;

    }

}

#pragma warning restore 0612, 1591, 3021
