// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: config.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.drivers.gnss.config
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Stream : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Stream()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(Format.Unknown)]
        public Format format
        {
            get { return __pbn__format ?? Format.Unknown; }
            set { __pbn__format = value; }
        }
        public bool ShouldSerializeformat()
        {
            return __pbn__format != null;
        }
        public void Resetformat()
        {
            __pbn__format = null;
        }
        private Format? __pbn__format;

        [global::ProtoBuf.ProtoMember(2)]
        public Serial serial
        {
            get { return __pbn__type.Is(2) ? ((Serial)__pbn__type.Object) : default(Serial); }
            set { __pbn__type = new global::ProtoBuf.DiscriminatedUnionObject(2, value); }
        }
        public bool ShouldSerializeserial()
        {
            return __pbn__type.Is(2);
        }
        public void Resetserial()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__type, 2);
        }

        private global::ProtoBuf.DiscriminatedUnionObject __pbn__type;

        [global::ProtoBuf.ProtoMember(3)]
        public Tcp tcp
        {
            get { return __pbn__type.Is(3) ? ((Tcp)__pbn__type.Object) : default(Tcp); }
            set { __pbn__type = new global::ProtoBuf.DiscriminatedUnionObject(3, value); }
        }
        public bool ShouldSerializetcp()
        {
            return __pbn__type.Is(3);
        }
        public void Resettcp()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__type, 3);
        }

        [global::ProtoBuf.ProtoMember(4)]
        public Udp udp
        {
            get { return __pbn__type.Is(4) ? ((Udp)__pbn__type.Object) : default(Udp); }
            set { __pbn__type = new global::ProtoBuf.DiscriminatedUnionObject(4, value); }
        }
        public bool ShouldSerializeudp()
        {
            return __pbn__type.Is(4);
        }
        public void Resetudp()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__type, 4);
        }

        [global::ProtoBuf.ProtoMember(5)]
        public Ntrip ntrip
        {
            get { return __pbn__type.Is(5) ? ((Ntrip)__pbn__type.Object) : default(Ntrip); }
            set { __pbn__type = new global::ProtoBuf.DiscriminatedUnionObject(5, value); }
        }
        public bool ShouldSerializentrip()
        {
            return __pbn__type.Is(5);
        }
        public void Resetntrip()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__type, 5);
        }

        [global::ProtoBuf.ProtoMember(6)]
        public bool push_location
        {
            get { return __pbn__push_location.GetValueOrDefault(); }
            set { __pbn__push_location = value; }
        }
        public bool ShouldSerializepush_location()
        {
            return __pbn__push_location != null;
        }
        public void Resetpush_location()
        {
            __pbn__push_location = null;
        }
        private bool? __pbn__push_location;

        [global::ProtoBuf.ProtoContract()]
        public partial class Serial : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
            }
            public Serial()
            {
                OnConstructor();
            }

            partial void OnConstructor();

            [global::ProtoBuf.ProtoMember(1)]
            public byte[] device
            {
                get { return __pbn__device; }
                set { __pbn__device = value; }
            }
            public bool ShouldSerializedevice()
            {
                return __pbn__device != null;
            }
            public void Resetdevice()
            {
                __pbn__device = null;
            }
            private byte[] __pbn__device;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue(9600)]
            public int baud_rate
            {
                get { return __pbn__baud_rate ?? 9600; }
                set { __pbn__baud_rate = value; }
            }
            public bool ShouldSerializebaud_rate()
            {
                return __pbn__baud_rate != null;
            }
            public void Resetbaud_rate()
            {
                __pbn__baud_rate = null;
            }
            private int? __pbn__baud_rate;

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class Tcp : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
            }
            public Tcp()
            {
                OnConstructor();
            }

            partial void OnConstructor();

            [global::ProtoBuf.ProtoMember(1)]
            public byte[] address
            {
                get { return __pbn__address; }
                set { __pbn__address = value; }
            }
            public bool ShouldSerializeaddress()
            {
                return __pbn__address != null;
            }
            public void Resetaddress()
            {
                __pbn__address = null;
            }
            private byte[] __pbn__address;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue(3001)]
            public int port
            {
                get { return __pbn__port ?? 3001; }
                set { __pbn__port = value; }
            }
            public bool ShouldSerializeport()
            {
                return __pbn__port != null;
            }
            public void Resetport()
            {
                __pbn__port = null;
            }
            private int? __pbn__port;

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class Udp : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
            }
            public Udp()
            {
                OnConstructor();
            }

            partial void OnConstructor();

            [global::ProtoBuf.ProtoMember(1)]
            public byte[] address
            {
                get { return __pbn__address; }
                set { __pbn__address = value; }
            }
            public bool ShouldSerializeaddress()
            {
                return __pbn__address != null;
            }
            public void Resetaddress()
            {
                __pbn__address = null;
            }
            private byte[] __pbn__address;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue(3001)]
            public int port
            {
                get { return __pbn__port ?? 3001; }
                set { __pbn__port = value; }
            }
            public bool ShouldSerializeport()
            {
                return __pbn__port != null;
            }
            public void Resetport()
            {
                __pbn__port = null;
            }
            private int? __pbn__port;

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class Ntrip : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
            }
            public Ntrip()
            {
                OnConstructor();
            }

            partial void OnConstructor();

            [global::ProtoBuf.ProtoMember(1)]
            public byte[] address
            {
                get { return __pbn__address; }
                set { __pbn__address = value; }
            }
            public bool ShouldSerializeaddress()
            {
                return __pbn__address != null;
            }
            public void Resetaddress()
            {
                __pbn__address = null;
            }
            private byte[] __pbn__address;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue(2101)]
            public int port
            {
                get { return __pbn__port ?? 2101; }
                set { __pbn__port = value; }
            }
            public bool ShouldSerializeport()
            {
                return __pbn__port != null;
            }
            public void Resetport()
            {
                __pbn__port = null;
            }
            private int? __pbn__port;

            [global::ProtoBuf.ProtoMember(3)]
            public byte[] mount_point
            {
                get { return __pbn__mount_point; }
                set { __pbn__mount_point = value; }
            }
            public bool ShouldSerializemount_point()
            {
                return __pbn__mount_point != null;
            }
            public void Resetmount_point()
            {
                __pbn__mount_point = null;
            }
            private byte[] __pbn__mount_point;

            [global::ProtoBuf.ProtoMember(4)]
            public byte[] user
            {
                get { return __pbn__user; }
                set { __pbn__user = value; }
            }
            public bool ShouldSerializeuser()
            {
                return __pbn__user != null;
            }
            public void Resetuser()
            {
                __pbn__user = null;
            }
            private byte[] __pbn__user;

            [global::ProtoBuf.ProtoMember(5)]
            public byte[] password
            {
                get { return __pbn__password; }
                set { __pbn__password = value; }
            }
            public bool ShouldSerializepassword()
            {
                return __pbn__password != null;
            }
            public void Resetpassword()
            {
                __pbn__password = null;
            }
            private byte[] __pbn__password;

            [global::ProtoBuf.ProtoMember(6)]
            [global::System.ComponentModel.DefaultValue(30)]
            public uint timeout_s
            {
                get { return __pbn__timeout_s ?? 30; }
                set { __pbn__timeout_s = value; }
            }
            public bool ShouldSerializetimeout_s()
            {
                return __pbn__timeout_s != null;
            }
            public void Resettimeout_s()
            {
                __pbn__timeout_s = null;
            }
            private uint? __pbn__timeout_s;

        }

        [global::ProtoBuf.ProtoContract()]
        public enum Format
        {
            [global::ProtoBuf.ProtoEnum(Name = @"UNKNOWN")]
            Unknown = 0,
            [global::ProtoBuf.ProtoEnum(Name = @"NMEA")]
            Nmea = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"RTCM_V2")]
            RtcmV2 = 2,
            [global::ProtoBuf.ProtoEnum(Name = @"RTCM_V3")]
            RtcmV3 = 3,
            [global::ProtoBuf.ProtoEnum(Name = @"NOVATEL_TEXT")]
            NovatelText = 10,
            [global::ProtoBuf.ProtoEnum(Name = @"NOVATEL_BINARY")]
            NovatelBinary = 11,
            [global::ProtoBuf.ProtoEnum(Name = @"UBLOX_TEXT")]
            UbloxText = 20,
            [global::ProtoBuf.ProtoEnum(Name = @"UBLOX_BINARY")]
            UbloxBinary = 21,
            [global::ProtoBuf.ProtoEnum(Name = @"NEWTONM2_TEXT")]
            Newtonm2Text = 30,
            [global::ProtoBuf.ProtoEnum(Name = @"NEWTONM2_BINARY")]
            Newtonm2Binary = 31,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NovatelConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public NovatelConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(5)]
        public int imu_orientation
        {
            get { return __pbn__imu_orientation ?? 5; }
            set { __pbn__imu_orientation = value; }
        }
        public bool ShouldSerializeimu_orientation()
        {
            return __pbn__imu_orientation != null;
        }
        public void Resetimu_orientation()
        {
            __pbn__imu_orientation = null;
        }
        private int? __pbn__imu_orientation;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NewtonM2Config : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public NewtonM2Config()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(5)]
        public int imu_orientation
        {
            get { return __pbn__imu_orientation ?? 5; }
            set { __pbn__imu_orientation = value; }
        }
        public bool ShouldSerializeimu_orientation()
        {
            return __pbn__imu_orientation != null;
        }
        public void Resetimu_orientation()
        {
            __pbn__imu_orientation = null;
        }
        private int? __pbn__imu_orientation;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class UbloxConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public UbloxConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class TF : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public TF()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(@"world")]
        public string frame_id
        {
            get { return __pbn__frame_id ?? @"world"; }
            set { __pbn__frame_id = value; }
        }
        public bool ShouldSerializeframe_id()
        {
            return __pbn__frame_id != null;
        }
        public void Resetframe_id()
        {
            __pbn__frame_id = null;
        }
        private string __pbn__frame_id;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(@"novatel")]
        public string child_frame_id
        {
            get { return __pbn__child_frame_id ?? @"novatel"; }
            set { __pbn__child_frame_id = value; }
        }
        public bool ShouldSerializechild_frame_id()
        {
            return __pbn__child_frame_id != null;
        }
        public void Resetchild_frame_id()
        {
            __pbn__child_frame_id = null;
        }
        private string __pbn__child_frame_id;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool enable
        {
            get { return __pbn__enable ?? false; }
            set { __pbn__enable = value; }
        }
        public bool ShouldSerializeenable()
        {
            return __pbn__enable != null;
        }
        public void Resetenable()
        {
            __pbn__enable = null;
        }
        private bool? __pbn__enable;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Config : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Config()
        {
            login_commands = new global::System.Collections.Generic.List<byte[]>();
            logout_commands = new global::System.Collections.Generic.List<byte[]>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public Stream data { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public Stream command { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public Stream rtk_from { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public Stream rtk_to { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public global::System.Collections.Generic.List<byte[]> login_commands { get; private set; }

        [global::ProtoBuf.ProtoMember(6)]
        public global::System.Collections.Generic.List<byte[]> logout_commands { get; private set; }

        [global::ProtoBuf.ProtoMember(7)]
        public NovatelConfig novatel_config
        {
            get { return __pbn__device_config.Is(7) ? ((NovatelConfig)__pbn__device_config.Object) : default(NovatelConfig); }
            set { __pbn__device_config = new global::ProtoBuf.DiscriminatedUnionObject(7, value); }
        }
        public bool ShouldSerializenovatel_config()
        {
            return __pbn__device_config.Is(7);
        }
        public void Resetnovatel_config()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__device_config, 7);
        }

        private global::ProtoBuf.DiscriminatedUnionObject __pbn__device_config;

        [global::ProtoBuf.ProtoMember(8)]
        public UbloxConfig ublox_config
        {
            get { return __pbn__device_config.Is(8) ? ((UbloxConfig)__pbn__device_config.Object) : default(UbloxConfig); }
            set { __pbn__device_config = new global::ProtoBuf.DiscriminatedUnionObject(8, value); }
        }
        public bool ShouldSerializeublox_config()
        {
            return __pbn__device_config.Is(8);
        }
        public void Resetublox_config()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__device_config, 8);
        }

        [global::ProtoBuf.ProtoMember(15)]
        public NewtonM2Config newtonm2_config
        {
            get { return __pbn__device_config.Is(15) ? ((NewtonM2Config)__pbn__device_config.Object) : default(NewtonM2Config); }
            set { __pbn__device_config = new global::ProtoBuf.DiscriminatedUnionObject(15, value); }
        }
        public bool ShouldSerializenewtonm2_config()
        {
            return __pbn__device_config.Is(15);
        }
        public void Resetnewtonm2_config()
        {
            global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__device_config, 15);
        }

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(RtkSolutionType.RtkReceiverSolution)]
        public RtkSolutionType rtk_solution_type
        {
            get { return __pbn__rtk_solution_type ?? RtkSolutionType.RtkReceiverSolution; }
            set { __pbn__rtk_solution_type = value; }
        }
        public bool ShouldSerializertk_solution_type()
        {
            return __pbn__rtk_solution_type != null;
        }
        public void Resetrtk_solution_type()
        {
            __pbn__rtk_solution_type = null;
        }
        private RtkSolutionType? __pbn__rtk_solution_type;

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue(ImuType.ImarFsas)]
        public ImuType imu_type
        {
            get { return __pbn__imu_type ?? ImuType.ImarFsas; }
            set { __pbn__imu_type = value; }
        }
        public bool ShouldSerializeimu_type()
        {
            return __pbn__imu_type != null;
        }
        public void Resetimu_type()
        {
            __pbn__imu_type = null;
        }
        private ImuType? __pbn__imu_type;

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue("")]
        public string proj4_text
        {
            get { return __pbn__proj4_text ?? ""; }
            set { __pbn__proj4_text = value; }
        }
        public bool ShouldSerializeproj4_text()
        {
            return __pbn__proj4_text != null;
        }
        public void Resetproj4_text()
        {
            __pbn__proj4_text = null;
        }
        private string __pbn__proj4_text;

        [global::ProtoBuf.ProtoMember(12)]
        public TF tf { get; set; }

        [global::ProtoBuf.ProtoMember(13)]
        [global::System.ComponentModel.DefaultValue("")]
        public string wheel_parameters
        {
            get { return __pbn__wheel_parameters ?? ""; }
            set { __pbn__wheel_parameters = value; }
        }
        public bool ShouldSerializewheel_parameters()
        {
            return __pbn__wheel_parameters != null;
        }
        public void Resetwheel_parameters()
        {
            __pbn__wheel_parameters = null;
        }
        private string __pbn__wheel_parameters;

        [global::ProtoBuf.ProtoMember(14)]
        [global::System.ComponentModel.DefaultValue("")]
        public string gpsbin_folder
        {
            get { return __pbn__gpsbin_folder ?? ""; }
            set { __pbn__gpsbin_folder = value; }
        }
        public bool ShouldSerializegpsbin_folder()
        {
            return __pbn__gpsbin_folder != null;
        }
        public void Resetgpsbin_folder()
        {
            __pbn__gpsbin_folder = null;
        }
        private string __pbn__gpsbin_folder;

        [global::ProtoBuf.ProtoContract()]
        public enum RtkSolutionType
        {
            [global::ProtoBuf.ProtoEnum(Name = @"RTK_RECEIVER_SOLUTION")]
            RtkReceiverSolution = 1,
            [global::ProtoBuf.ProtoEnum(Name = @"RTK_SOFTWARE_SOLUTION")]
            RtkSoftwareSolution = 2,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public enum ImuType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"IMAR_FSAS")]
        ImarFsas = 13,
        [global::ProtoBuf.ProtoEnum(Name = @"ISA100C")]
        Isa100c = 26,
        [global::ProtoBuf.ProtoEnum(Name = @"ADIS16488")]
        Adis16488 = 31,
        [global::ProtoBuf.ProtoEnum(Name = @"STIM300")]
        Stim300 = 32,
        [global::ProtoBuf.ProtoEnum(Name = @"ISA100")]
        Isa100 = 34,
        [global::ProtoBuf.ProtoEnum(Name = @"ISA100_400HZ")]
        Isa100400hz = 38,
        [global::ProtoBuf.ProtoEnum(Name = @"ISA100C_400HZ")]
        Isa100c400hz = 39,
        [global::ProtoBuf.ProtoEnum(Name = @"CPT_XW5651")]
        CptXw5651 = 40,
        [global::ProtoBuf.ProtoEnum(Name = @"G320N")]
        G320n = 41,
        [global::ProtoBuf.ProtoEnum(Name = @"UM442")]
        Um442 = 42,
        [global::ProtoBuf.ProtoEnum(Name = @"IAM20680")]
        Iam20680 = 57,
    }

}

#pragma warning restore 0612, 1591, 3021
