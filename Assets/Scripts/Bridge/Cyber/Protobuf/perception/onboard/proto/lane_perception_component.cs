// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: lane_perception_component.proto

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.onboard
{

    [global::ProtoBuf.ProtoContract()]
    public partial class LaneDetection : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public LaneDetection()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(@"front_6mm,front_12mm")]
        public string camera_names
        {
            get { return __pbn__camera_names ?? @"front_6mm,front_12mm"; }
            set { __pbn__camera_names = value; }
        }
        public bool ShouldSerializecamera_names()
        {
            return __pbn__camera_names != null;
        }
        public void Resetcamera_names()
        {
            __pbn__camera_names = null;
        }
        private string __pbn__camera_names;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(@"/apollo/sensor/camera/front_6mm/image,/apollo/sensor/camera/front_12mm/image")]
        public string input_camera_channel_names
        {
            get { return __pbn__input_camera_channel_names ?? @"/apollo/sensor/camera/front_6mm/image,/apollo/sensor/camera/front_12mm/image"; }
            set { __pbn__input_camera_channel_names = value; }
        }
        public bool ShouldSerializeinput_camera_channel_names()
        {
            return __pbn__input_camera_channel_names != null;
        }
        public void Resetinput_camera_channel_names()
        {
            __pbn__input_camera_channel_names = null;
        }
        private string __pbn__input_camera_channel_names;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double timestamp_offset
        {
            get { return __pbn__timestamp_offset ?? 0; }
            set { __pbn__timestamp_offset = value; }
        }
        public bool ShouldSerializetimestamp_offset()
        {
            return __pbn__timestamp_offset != null;
        }
        public void Resettimestamp_offset()
        {
            __pbn__timestamp_offset = null;
        }
        private double? __pbn__timestamp_offset;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(@"conf/perception/camera")]
        public string camera_lane_perception_conf_dir
        {
            get { return __pbn__camera_lane_perception_conf_dir ?? @"conf/perception/camera"; }
            set { __pbn__camera_lane_perception_conf_dir = value; }
        }
        public bool ShouldSerializecamera_lane_perception_conf_dir()
        {
            return __pbn__camera_lane_perception_conf_dir != null;
        }
        public void Resetcamera_lane_perception_conf_dir()
        {
            __pbn__camera_lane_perception_conf_dir = null;
        }
        private string __pbn__camera_lane_perception_conf_dir;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(@"lane.pt")]
        public string camera_lane_perception_conf_file
        {
            get { return __pbn__camera_lane_perception_conf_file ?? @"lane.pt"; }
            set { __pbn__camera_lane_perception_conf_file = value; }
        }
        public bool ShouldSerializecamera_lane_perception_conf_file()
        {
            return __pbn__camera_lane_perception_conf_file != null;
        }
        public void Resetcamera_lane_perception_conf_file()
        {
            __pbn__camera_lane_perception_conf_file = null;
        }
        private string __pbn__camera_lane_perception_conf_file;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(20)]
        public int frame_capacity
        {
            get { return __pbn__frame_capacity ?? 20; }
            set { __pbn__frame_capacity = value; }
        }
        public bool ShouldSerializeframe_capacity()
        {
            return __pbn__frame_capacity != null;
        }
        public void Resetframe_capacity()
        {
            __pbn__frame_capacity = null;
        }
        private int? __pbn__frame_capacity;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(3)]
        public int image_channel_num
        {
            get { return __pbn__image_channel_num ?? 3; }
            set { __pbn__image_channel_num = value; }
        }
        public bool ShouldSerializeimage_channel_num()
        {
            return __pbn__image_channel_num != null;
        }
        public void Resetimage_channel_num()
        {
            __pbn__image_channel_num = null;
        }
        private int? __pbn__image_channel_num;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool enable_undistortion
        {
            get { return __pbn__enable_undistortion ?? false; }
            set { __pbn__enable_undistortion = value; }
        }
        public bool ShouldSerializeenable_undistortion()
        {
            return __pbn__enable_undistortion != null;
        }
        public void Resetenable_undistortion()
        {
            __pbn__enable_undistortion = null;
        }
        private bool? __pbn__enable_undistortion;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool enable_visualization
        {
            get { return __pbn__enable_visualization ?? false; }
            set { __pbn__enable_visualization = value; }
        }
        public bool ShouldSerializeenable_visualization()
        {
            return __pbn__enable_visualization != null;
        }
        public void Resetenable_visualization()
        {
            __pbn__enable_visualization = null;
        }
        private bool? __pbn__enable_visualization;

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue(@"/perception/lanes")]
        public string output_lanes_channel_name
        {
            get { return __pbn__output_lanes_channel_name ?? @"/perception/lanes"; }
            set { __pbn__output_lanes_channel_name = value; }
        }
        public bool ShouldSerializeoutput_lanes_channel_name()
        {
            return __pbn__output_lanes_channel_name != null;
        }
        public void Resetoutput_lanes_channel_name()
        {
            __pbn__output_lanes_channel_name = null;
        }
        private string __pbn__output_lanes_channel_name;

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue(0)]
        public double default_camera_pitch
        {
            get { return __pbn__default_camera_pitch ?? 0; }
            set { __pbn__default_camera_pitch = value; }
        }
        public bool ShouldSerializedefault_camera_pitch()
        {
            return __pbn__default_camera_pitch != null;
        }
        public void Resetdefault_camera_pitch()
        {
            __pbn__default_camera_pitch = null;
        }
        private double? __pbn__default_camera_pitch;

        [global::ProtoBuf.ProtoMember(12)]
        [global::System.ComponentModel.DefaultValue(1.5)]
        public double default_camera_height
        {
            get { return __pbn__default_camera_height ?? 1.5; }
            set { __pbn__default_camera_height = value; }
        }
        public bool ShouldSerializedefault_camera_height()
        {
            return __pbn__default_camera_height != null;
        }
        public void Resetdefault_camera_height()
        {
            __pbn__default_camera_height = null;
        }
        private double? __pbn__default_camera_height;

        [global::ProtoBuf.ProtoMember(13)]
        [global::System.ComponentModel.DefaultValue(@"front_6mm")]
        public string lane_calibration_working_sensor_name
        {
            get { return __pbn__lane_calibration_working_sensor_name ?? @"front_6mm"; }
            set { __pbn__lane_calibration_working_sensor_name = value; }
        }
        public bool ShouldSerializelane_calibration_working_sensor_name()
        {
            return __pbn__lane_calibration_working_sensor_name != null;
        }
        public void Resetlane_calibration_working_sensor_name()
        {
            __pbn__lane_calibration_working_sensor_name = null;
        }
        private string __pbn__lane_calibration_working_sensor_name;

        [global::ProtoBuf.ProtoMember(14)]
        [global::System.ComponentModel.DefaultValue(@"LaneLineCalibrator")]
        public string calibrator_method
        {
            get { return __pbn__calibrator_method ?? @"LaneLineCalibrator"; }
            set { __pbn__calibrator_method = value; }
        }
        public bool ShouldSerializecalibrator_method()
        {
            return __pbn__calibrator_method != null;
        }
        public void Resetcalibrator_method()
        {
            __pbn__calibrator_method = null;
        }
        private string __pbn__calibrator_method;

        [global::ProtoBuf.ProtoMember(15)]
        [global::System.ComponentModel.DefaultValue(@"OnlineCalibrationService")]
        public string calib_service_name
        {
            get { return __pbn__calib_service_name ?? @"OnlineCalibrationService"; }
            set { __pbn__calib_service_name = value; }
        }
        public bool ShouldSerializecalib_service_name()
        {
            return __pbn__calib_service_name != null;
        }
        public void Resetcalib_service_name()
        {
            __pbn__calib_service_name = null;
        }
        private string __pbn__calib_service_name;

        [global::ProtoBuf.ProtoMember(16)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool run_calib_service
        {
            get { return __pbn__run_calib_service ?? true; }
            set { __pbn__run_calib_service = value; }
        }
        public bool ShouldSerializerun_calib_service()
        {
            return __pbn__run_calib_service != null;
        }
        public void Resetrun_calib_service()
        {
            __pbn__run_calib_service = null;
        }
        private bool? __pbn__run_calib_service;

        [global::ProtoBuf.ProtoMember(17)]
        [global::System.ComponentModel.DefaultValue(0.1)]
        public double ts_diff
        {
            get { return __pbn__ts_diff ?? 0.1; }
            set { __pbn__ts_diff = value; }
        }
        public bool ShouldSerializets_diff()
        {
            return __pbn__ts_diff != null;
        }
        public void Resetts_diff()
        {
            __pbn__ts_diff = null;
        }
        private double? __pbn__ts_diff;

        [global::ProtoBuf.ProtoMember(18)]
        [global::System.ComponentModel.DefaultValue(@"/apollo/debug_output")]
        public string visual_debug_folder
        {
            get { return __pbn__visual_debug_folder ?? @"/apollo/debug_output"; }
            set { __pbn__visual_debug_folder = value; }
        }
        public bool ShouldSerializevisual_debug_folder()
        {
            return __pbn__visual_debug_folder != null;
        }
        public void Resetvisual_debug_folder()
        {
            __pbn__visual_debug_folder = null;
        }
        private string __pbn__visual_debug_folder;

        [global::ProtoBuf.ProtoMember(19)]
        [global::System.ComponentModel.DefaultValue(@"front_6mm")]
        public string visual_camera
        {
            get { return __pbn__visual_camera ?? @"front_6mm"; }
            set { __pbn__visual_camera = value; }
        }
        public bool ShouldSerializevisual_camera()
        {
            return __pbn__visual_camera != null;
        }
        public void Resetvisual_camera()
        {
            __pbn__visual_camera = null;
        }
        private string __pbn__visual_camera;

        [global::ProtoBuf.ProtoMember(20)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool write_visual_img
        {
            get { return __pbn__write_visual_img ?? false; }
            set { __pbn__write_visual_img = value; }
        }
        public bool ShouldSerializewrite_visual_img()
        {
            return __pbn__write_visual_img != null;
        }
        public void Resetwrite_visual_img()
        {
            __pbn__write_visual_img = null;
        }
        private bool? __pbn__write_visual_img;

    }

}

#pragma warning restore 0612, 1591, 3021
