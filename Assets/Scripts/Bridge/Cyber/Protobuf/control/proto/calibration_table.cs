// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: calibration_table.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.control.calibrationtable
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ControlCalibrationTable : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ControlCalibrationTable()
        {
            calibration = new global::System.Collections.Generic.List<ControlCalibrationInfo>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<ControlCalibrationInfo> calibration { get; private set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ControlCalibrationInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ControlCalibrationInfo()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double speed
        {
            get { return __pbn__speed.GetValueOrDefault(); }
            set { __pbn__speed = value; }
        }
        public bool ShouldSerializespeed()
        {
            return __pbn__speed != null;
        }
        public void Resetspeed()
        {
            __pbn__speed = null;
        }
        private double? __pbn__speed;

        [global::ProtoBuf.ProtoMember(2)]
        public double acceleration
        {
            get { return __pbn__acceleration.GetValueOrDefault(); }
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

        [global::ProtoBuf.ProtoMember(3)]
        public double command
        {
            get { return __pbn__command.GetValueOrDefault(); }
            set { __pbn__command = value; }
        }
        public bool ShouldSerializecommand()
        {
            return __pbn__command != null;
        }
        public void Resetcommand()
        {
            __pbn__command = null;
        }
        private double? __pbn__command;

    }

}

#pragma warning restore 0612, 1591, 3021
