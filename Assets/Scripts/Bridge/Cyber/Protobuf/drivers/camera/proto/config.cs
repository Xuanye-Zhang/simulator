// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: config.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.drivers.camera.config
{

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
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string camera_dev
        {
            get { return __pbn__camera_dev ?? ""; }
            set { __pbn__camera_dev = value; }
        }
        public bool ShouldSerializecamera_dev()
        {
            return __pbn__camera_dev != null;
        }
        public void Resetcamera_dev()
        {
            __pbn__camera_dev = null;
        }
        private string __pbn__camera_dev;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string frame_id
        {
            get { return __pbn__frame_id ?? ""; }
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

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(@"yuyv")]
        public string pixel_format
        {
            get { return __pbn__pixel_format ?? @"yuyv"; }
            set { __pbn__pixel_format = value; }
        }
        public bool ShouldSerializepixel_format()
        {
            return __pbn__pixel_format != null;
        }
        public void Resetpixel_format()
        {
            __pbn__pixel_format = null;
        }
        private string __pbn__pixel_format;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(IOMethod.IoMethodUnknown)]
        public IOMethod io_method
        {
            get { return __pbn__io_method ?? IOMethod.IoMethodUnknown; }
            set { __pbn__io_method = value; }
        }
        public bool ShouldSerializeio_method()
        {
            return __pbn__io_method != null;
        }
        public void Resetio_method()
        {
            __pbn__io_method = null;
        }
        private IOMethod? __pbn__io_method;

        [global::ProtoBuf.ProtoMember(5)]
        public uint width
        {
            get { return __pbn__width.GetValueOrDefault(); }
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
        private uint? __pbn__width;

        [global::ProtoBuf.ProtoMember(6)]
        public uint height
        {
            get { return __pbn__height.GetValueOrDefault(); }
            set { __pbn__height = value; }
        }
        public bool ShouldSerializeheight()
        {
            return __pbn__height != null;
        }
        public void Resetheight()
        {
            __pbn__height = null;
        }
        private uint? __pbn__height;

        [global::ProtoBuf.ProtoMember(7)]
        public uint frame_rate
        {
            get { return __pbn__frame_rate.GetValueOrDefault(); }
            set { __pbn__frame_rate = value; }
        }
        public bool ShouldSerializeframe_rate()
        {
            return __pbn__frame_rate != null;
        }
        public void Resetframe_rate()
        {
            __pbn__frame_rate = null;
        }
        private uint? __pbn__frame_rate;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool monochrome
        {
            get { return __pbn__monochrome ?? false; }
            set { __pbn__monochrome = value; }
        }
        public bool ShouldSerializemonochrome()
        {
            return __pbn__monochrome != null;
        }
        public void Resetmonochrome()
        {
            __pbn__monochrome = null;
        }
        private bool? __pbn__monochrome;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(-1)]
        public int brightness
        {
            get { return __pbn__brightness ?? -1; }
            set { __pbn__brightness = value; }
        }
        public bool ShouldSerializebrightness()
        {
            return __pbn__brightness != null;
        }
        public void Resetbrightness()
        {
            __pbn__brightness = null;
        }
        private int? __pbn__brightness;

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue(-1)]
        public int contrast
        {
            get { return __pbn__contrast ?? -1; }
            set { __pbn__contrast = value; }
        }
        public bool ShouldSerializecontrast()
        {
            return __pbn__contrast != null;
        }
        public void Resetcontrast()
        {
            __pbn__contrast = null;
        }
        private int? __pbn__contrast;

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue(-1)]
        public int saturation
        {
            get { return __pbn__saturation ?? -1; }
            set { __pbn__saturation = value; }
        }
        public bool ShouldSerializesaturation()
        {
            return __pbn__saturation != null;
        }
        public void Resetsaturation()
        {
            __pbn__saturation = null;
        }
        private int? __pbn__saturation;

        [global::ProtoBuf.ProtoMember(12)]
        [global::System.ComponentModel.DefaultValue(-1)]
        public int sharpness
        {
            get { return __pbn__sharpness ?? -1; }
            set { __pbn__sharpness = value; }
        }
        public bool ShouldSerializesharpness()
        {
            return __pbn__sharpness != null;
        }
        public void Resetsharpness()
        {
            __pbn__sharpness = null;
        }
        private int? __pbn__sharpness;

        [global::ProtoBuf.ProtoMember(13)]
        [global::System.ComponentModel.DefaultValue(-1)]
        public int gain
        {
            get { return __pbn__gain ?? -1; }
            set { __pbn__gain = value; }
        }
        public bool ShouldSerializegain()
        {
            return __pbn__gain != null;
        }
        public void Resetgain()
        {
            __pbn__gain = null;
        }
        private int? __pbn__gain;

        [global::ProtoBuf.ProtoMember(14)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool auto_focus
        {
            get { return __pbn__auto_focus ?? false; }
            set { __pbn__auto_focus = value; }
        }
        public bool ShouldSerializeauto_focus()
        {
            return __pbn__auto_focus != null;
        }
        public void Resetauto_focus()
        {
            __pbn__auto_focus = null;
        }
        private bool? __pbn__auto_focus;

        [global::ProtoBuf.ProtoMember(15)]
        [global::System.ComponentModel.DefaultValue(-1)]
        public int focus
        {
            get { return __pbn__focus ?? -1; }
            set { __pbn__focus = value; }
        }
        public bool ShouldSerializefocus()
        {
            return __pbn__focus != null;
        }
        public void Resetfocus()
        {
            __pbn__focus = null;
        }
        private int? __pbn__focus;

        [global::ProtoBuf.ProtoMember(16)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool auto_exposure
        {
            get { return __pbn__auto_exposure ?? true; }
            set { __pbn__auto_exposure = value; }
        }
        public bool ShouldSerializeauto_exposure()
        {
            return __pbn__auto_exposure != null;
        }
        public void Resetauto_exposure()
        {
            __pbn__auto_exposure = null;
        }
        private bool? __pbn__auto_exposure;

        [global::ProtoBuf.ProtoMember(17)]
        [global::System.ComponentModel.DefaultValue(100)]
        public int exposure
        {
            get { return __pbn__exposure ?? 100; }
            set { __pbn__exposure = value; }
        }
        public bool ShouldSerializeexposure()
        {
            return __pbn__exposure != null;
        }
        public void Resetexposure()
        {
            __pbn__exposure = null;
        }
        private int? __pbn__exposure;

        [global::ProtoBuf.ProtoMember(18)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool auto_white_balance
        {
            get { return __pbn__auto_white_balance ?? true; }
            set { __pbn__auto_white_balance = value; }
        }
        public bool ShouldSerializeauto_white_balance()
        {
            return __pbn__auto_white_balance != null;
        }
        public void Resetauto_white_balance()
        {
            __pbn__auto_white_balance = null;
        }
        private bool? __pbn__auto_white_balance;

        [global::ProtoBuf.ProtoMember(19)]
        [global::System.ComponentModel.DefaultValue(4000)]
        public int white_balance
        {
            get { return __pbn__white_balance ?? 4000; }
            set { __pbn__white_balance = value; }
        }
        public bool ShouldSerializewhite_balance()
        {
            return __pbn__white_balance != null;
        }
        public void Resetwhite_balance()
        {
            __pbn__white_balance = null;
        }
        private int? __pbn__white_balance;

        [global::ProtoBuf.ProtoMember(20)]
        [global::System.ComponentModel.DefaultValue(3)]
        public uint bytes_per_pixel
        {
            get { return __pbn__bytes_per_pixel ?? 3; }
            set { __pbn__bytes_per_pixel = value; }
        }
        public bool ShouldSerializebytes_per_pixel()
        {
            return __pbn__bytes_per_pixel != null;
        }
        public void Resetbytes_per_pixel()
        {
            __pbn__bytes_per_pixel = null;
        }
        private uint? __pbn__bytes_per_pixel;

        [global::ProtoBuf.ProtoMember(21)]
        [global::System.ComponentModel.DefaultValue(0)]
        public uint trigger_internal
        {
            get { return __pbn__trigger_internal ?? 0; }
            set { __pbn__trigger_internal = value; }
        }
        public bool ShouldSerializetrigger_internal()
        {
            return __pbn__trigger_internal != null;
        }
        public void Resettrigger_internal()
        {
            __pbn__trigger_internal = null;
        }
        private uint? __pbn__trigger_internal;

        [global::ProtoBuf.ProtoMember(22)]
        [global::System.ComponentModel.DefaultValue(30)]
        public uint trigger_fps
        {
            get { return __pbn__trigger_fps ?? 30; }
            set { __pbn__trigger_fps = value; }
        }
        public bool ShouldSerializetrigger_fps()
        {
            return __pbn__trigger_fps != null;
        }
        public void Resettrigger_fps()
        {
            __pbn__trigger_fps = null;
        }
        private uint? __pbn__trigger_fps;

        [global::ProtoBuf.ProtoMember(23)]
        [global::System.ComponentModel.DefaultValue("")]
        public string channel_name
        {
            get { return __pbn__channel_name ?? ""; }
            set { __pbn__channel_name = value; }
        }
        public bool ShouldSerializechannel_name()
        {
            return __pbn__channel_name != null;
        }
        public void Resetchannel_name()
        {
            __pbn__channel_name = null;
        }
        private string __pbn__channel_name;

        [global::ProtoBuf.ProtoMember(24)]
        [global::System.ComponentModel.DefaultValue(2000)]
        public uint device_wait_ms
        {
            get { return __pbn__device_wait_ms ?? 2000; }
            set { __pbn__device_wait_ms = value; }
        }
        public bool ShouldSerializedevice_wait_ms()
        {
            return __pbn__device_wait_ms != null;
        }
        public void Resetdevice_wait_ms()
        {
            __pbn__device_wait_ms = null;
        }
        private uint? __pbn__device_wait_ms;

        [global::ProtoBuf.ProtoMember(25)]
        [global::System.ComponentModel.DefaultValue(200)]
        public uint spin_rate
        {
            get { return __pbn__spin_rate ?? 200; }
            set { __pbn__spin_rate = value; }
        }
        public bool ShouldSerializespin_rate()
        {
            return __pbn__spin_rate != null;
        }
        public void Resetspin_rate()
        {
            __pbn__spin_rate = null;
        }
        private uint? __pbn__spin_rate;

        [global::ProtoBuf.ProtoMember(26)]
        [global::System.ComponentModel.DefaultValue(OutputType.Yuyv)]
        public OutputType output_type
        {
            get { return __pbn__output_type ?? OutputType.Yuyv; }
            set { __pbn__output_type = value; }
        }
        public bool ShouldSerializeoutput_type()
        {
            return __pbn__output_type != null;
        }
        public void Resetoutput_type()
        {
            __pbn__output_type = null;
        }
        private OutputType? __pbn__output_type;

        [global::ProtoBuf.ProtoMember(27)]
        public CompressConfig compress_conf { get; set; }

        [global::ProtoBuf.ProtoContract()]
        public partial class CompressConfig : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            {
                return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
            }
            public CompressConfig()
            {
                OnConstructor();
            }

            partial void OnConstructor();

            [global::ProtoBuf.ProtoMember(1)]
            [global::System.ComponentModel.DefaultValue("")]
            public string output_channel
            {
                get { return __pbn__output_channel ?? ""; }
                set { __pbn__output_channel = value; }
            }
            public bool ShouldSerializeoutput_channel()
            {
                return __pbn__output_channel != null;
            }
            public void Resetoutput_channel()
            {
                __pbn__output_channel = null;
            }
            private string __pbn__output_channel;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue(20)]
            public uint image_pool_size
            {
                get { return __pbn__image_pool_size ?? 20; }
                set { __pbn__image_pool_size = value; }
            }
            public bool ShouldSerializeimage_pool_size()
            {
                return __pbn__image_pool_size != null;
            }
            public void Resetimage_pool_size()
            {
                __pbn__image_pool_size = null;
            }
            private uint? __pbn__image_pool_size;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public enum IOMethod
    {
        [global::ProtoBuf.ProtoEnum(Name = @"IO_METHOD_UNKNOWN")]
        IoMethodUnknown = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"IO_METHOD_READ")]
        IoMethodRead = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"IO_METHOD_MMAP")]
        IoMethodMmap = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"IO_METHOD_USERPTR")]
        IoMethodUserptr = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum OutputType
    {
        [global::ProtoBuf.ProtoEnum(Name = @"YUYV")]
        Yuyv = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"RGB")]
        Rgb = 1,
    }

}

#pragma warning restore 0612, 1591, 3021
