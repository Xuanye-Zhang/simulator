// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: vehicle_state.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.common
{

    [global::ProtoBuf.ProtoContract()]
    public partial class VehicleState : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public VehicleState()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double x
        {
            get { return __pbn__x ?? 0; }
            set { __pbn__x = value; }
        }
        public bool ShouldSerializex()
        {
            return __pbn__x != null;
        }
        public void Resetx()
        {
            __pbn__x = null;
        }
        private double? __pbn__x;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double y
        {
            get { return __pbn__y ?? 0; }
            set { __pbn__y = value; }
        }
        public bool ShouldSerializey()
        {
            return __pbn__y != null;
        }
        public void Resety()
        {
            __pbn__y = null;
        }
        private double? __pbn__y;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double z
        {
            get { return __pbn__z ?? 0; }
            set { __pbn__z = value; }
        }
        public bool ShouldSerializez()
        {
            return __pbn__z != null;
        }
        public void Resetz()
        {
            __pbn__z = null;
        }
        private double? __pbn__z;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double timestamp
        {
            get { return __pbn__timestamp ?? 0; }
            set { __pbn__timestamp = value; }
        }
        public bool ShouldSerializetimestamp()
        {
            return __pbn__timestamp != null;
        }
        public void Resettimestamp()
        {
            __pbn__timestamp = null;
        }
        private double? __pbn__timestamp;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double roll
        {
            get { return __pbn__roll ?? 0; }
            set { __pbn__roll = value; }
        }
        public bool ShouldSerializeroll()
        {
            return __pbn__roll != null;
        }
        public void Resetroll()
        {
            __pbn__roll = null;
        }
        private double? __pbn__roll;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double pitch
        {
            get { return __pbn__pitch ?? 0; }
            set { __pbn__pitch = value; }
        }
        public bool ShouldSerializepitch()
        {
            return __pbn__pitch != null;
        }
        public void Resetpitch()
        {
            __pbn__pitch = null;
        }
        private double? __pbn__pitch;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double yaw
        {
            get { return __pbn__yaw ?? 0; }
            set { __pbn__yaw = value; }
        }
        public bool ShouldSerializeyaw()
        {
            return __pbn__yaw != null;
        }
        public void Resetyaw()
        {
            __pbn__yaw = null;
        }
        private double? __pbn__yaw;

        [global::ProtoBuf.ProtoMember(8)]
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

        [global::ProtoBuf.ProtoMember(9)]
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

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double linear_velocity
        {
            get { return __pbn__linear_velocity ?? 0; }
            set { __pbn__linear_velocity = value; }
        }
        public bool ShouldSerializelinear_velocity()
        {
            return __pbn__linear_velocity != null;
        }
        public void Resetlinear_velocity()
        {
            __pbn__linear_velocity = null;
        }
        private double? __pbn__linear_velocity;

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double angular_velocity
        {
            get { return __pbn__angular_velocity ?? 0; }
            set { __pbn__angular_velocity = value; }
        }
        public bool ShouldSerializeangular_velocity()
        {
            return __pbn__angular_velocity != null;
        }
        public void Resetangular_velocity()
        {
            __pbn__angular_velocity = null;
        }
        private double? __pbn__angular_velocity;

        [global::ProtoBuf.ProtoMember(12)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double linear_acceleration
        {
            get { return __pbn__linear_acceleration ?? 0; }
            set { __pbn__linear_acceleration = value; }
        }
        public bool ShouldSerializelinear_acceleration()
        {
            return __pbn__linear_acceleration != null;
        }
        public void Resetlinear_acceleration()
        {
            __pbn__linear_acceleration = null;
        }
        private double? __pbn__linear_acceleration;

        [global::ProtoBuf.ProtoMember(13)]
        [global::System.ComponentModel.DefaultValue(global::apollo.canbus.Chassis.GearPosition.GearNeutral)]
        public global::apollo.canbus.Chassis.GearPosition gear
        {
            get { return __pbn__gear ?? global::apollo.canbus.Chassis.GearPosition.GearNeutral; }
            set { __pbn__gear = value; }
        }
        public bool ShouldSerializegear()
        {
            return __pbn__gear != null;
        }
        public void Resetgear()
        {
            __pbn__gear = null;
        }
        private global::apollo.canbus.Chassis.GearPosition? __pbn__gear;

        [global::ProtoBuf.ProtoMember(14)]
        [global::System.ComponentModel.DefaultValue(global::apollo.canbus.Chassis.DrivingMode.CompleteManual)]
        public global::apollo.canbus.Chassis.DrivingMode driving_mode
        {
            get { return __pbn__driving_mode ?? global::apollo.canbus.Chassis.DrivingMode.CompleteManual; }
            set { __pbn__driving_mode = value; }
        }
        public bool ShouldSerializedriving_mode()
        {
            return __pbn__driving_mode != null;
        }
        public void Resetdriving_mode()
        {
            __pbn__driving_mode = null;
        }
        private global::apollo.canbus.Chassis.DrivingMode? __pbn__driving_mode;

        [global::ProtoBuf.ProtoMember(15)]
        public global::apollo.localization.Pose pose { get; set; }

    }

}

#pragma warning restore 0612, 1591, 3021
