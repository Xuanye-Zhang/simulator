// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: path_decider_info.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.planning
{

    [global::ProtoBuf.ProtoContract()]
    public partial class PathDeciderInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PathDeciderInfo()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(0)]
        public int front_static_obstacle_cycle_counter
        {
            get { return __pbn__front_static_obstacle_cycle_counter ?? 0; }
            set { __pbn__front_static_obstacle_cycle_counter = value; }
        }
        public bool ShouldSerializefront_static_obstacle_cycle_counter()
        {
            return __pbn__front_static_obstacle_cycle_counter != null;
        }
        public void Resetfront_static_obstacle_cycle_counter()
        {
            __pbn__front_static_obstacle_cycle_counter = null;
        }
        private int? __pbn__front_static_obstacle_cycle_counter;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0)]
        public int able_to_use_self_lane_counter
        {
            get { return __pbn__able_to_use_self_lane_counter ?? 0; }
            set { __pbn__able_to_use_self_lane_counter = value; }
        }
        public bool ShouldSerializeable_to_use_self_lane_counter()
        {
            return __pbn__able_to_use_self_lane_counter != null;
        }
        public void Resetable_to_use_self_lane_counter()
        {
            __pbn__able_to_use_self_lane_counter = null;
        }
        private int? __pbn__able_to_use_self_lane_counter;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool is_in_path_lane_borrow_scenario
        {
            get { return __pbn__is_in_path_lane_borrow_scenario ?? false; }
            set { __pbn__is_in_path_lane_borrow_scenario = value; }
        }
        public bool ShouldSerializeis_in_path_lane_borrow_scenario()
        {
            return __pbn__is_in_path_lane_borrow_scenario != null;
        }
        public void Resetis_in_path_lane_borrow_scenario()
        {
            __pbn__is_in_path_lane_borrow_scenario = null;
        }
        private bool? __pbn__is_in_path_lane_borrow_scenario;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string front_static_obstacle_id
        {
            get { return __pbn__front_static_obstacle_id ?? ""; }
            set { __pbn__front_static_obstacle_id = value; }
        }
        public bool ShouldSerializefront_static_obstacle_id()
        {
            return __pbn__front_static_obstacle_id != null;
        }
        public void Resetfront_static_obstacle_id()
        {
            __pbn__front_static_obstacle_id = null;
        }
        private string __pbn__front_static_obstacle_id;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(0)]
        public int decided_side_pass_direction
        {
            get { return __pbn__decided_side_pass_direction ?? 0; }
            set { __pbn__decided_side_pass_direction = value; }
        }
        public bool ShouldSerializedecided_side_pass_direction()
        {
            return __pbn__decided_side_pass_direction != null;
        }
        public void Resetdecided_side_pass_direction()
        {
            __pbn__decided_side_pass_direction = null;
        }
        private int? __pbn__decided_side_pass_direction;

    }

}

#pragma warning restore 0612, 1591, 3021
