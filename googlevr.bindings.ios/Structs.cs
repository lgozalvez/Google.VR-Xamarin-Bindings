using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace googlevr.bindings.ios
{
	public enum gvr_eye : uint
	{
		LeftEye = 0,
		RightEye,
		NumEyes
	}

	public enum gvr_viewer_type : uint
	{
		Cardboard = 0,
		Daydream = 1
	}

	public enum gvr_feature : uint
	{
		AsyncReprojection = 0,
		Multiview = 1,
		ExternalSurface = 2,
		HeadPose6dof = 3,
		HardwareBuffers = 4
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct gvr_version
	{
		public int major;

		public int minor;

		public int patch;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct gvr_sizei
	{
		public int width;

		public int height;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct gvr_recti
	{
		public int left;

		public int right;

		public int bottom;

		public int top;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct gvr_rectf
	{
		public float left;

		public float right;

		public float bottom;

		public float top;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct gvr_vec2f
	{
		public float x;

		public float y;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct gvr_vec3f
	{
		public float x;

		public float y;

		public float z;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct gvr_mat4f
	{
		public float[][] m;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct gvr_quatf
	{
		public float qx;

		public float qy;

		public float qz;

		public float qw;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct gvr_clock_time_point
	{
		public long monotonic_system_time_nanos;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct gvr_value
	{
		public int value_type;

		public uint flags;

		[StructLayout (LayoutKind.Explicit)]
		public struct _
		{
			[FieldOffset (0)]
			public float f;

			[FieldOffset (0)]
			public double d;

			[FieldOffset (0)]
			public int i;

			[FieldOffset (0)]
			public long i64;

			[FieldOffset (0)]
			public uint fl;

			[FieldOffset (0)]
			public ulong fl64;

			[FieldOffset (0)]
			public gvr_sizei si;

			[FieldOffset (0)]
			public gvr_recti ri;

			[FieldOffset (0)]
			public gvr_rectf rf;

			[FieldOffset (0)]
			public gvr_vec2f v2f;

			[FieldOffset (0)]
			public gvr_vec3f v3f;

			[FieldOffset (0)]
			public gvr_quatf qf;

			[FieldOffset (0)]
			public gvr_mat4f m4f;

			[FieldOffset (0)]
			public gvr_clock_time_point t;

			[FieldOffset (0)]
			public byte[] padding;
		}
    }
	
	[StructLayout(LayoutKind.Auto)]
	public struct gvr_context { }

	[StructLayout(LayoutKind.Auto)]
	public struct gvr_properties { }

	[StructLayout(LayoutKind.Auto)]
	public struct gvr_user_prefs { }

	[StructLayout(LayoutKind.Auto)]
	public struct gvr_buffer_viewport_list { }

	[StructLayout(LayoutKind.Auto)]
	public struct gvr_buffer_viewport { }

	[StructLayout(LayoutKind.Auto)]
	public struct gvr_buffer_spec { }

	[StructLayout(LayoutKind.Auto)]
	public struct gvr_swap_chain { }

	[StructLayout(LayoutKind.Auto)]
	public struct gvr_frame { }

	[StructLayout(LayoutKind.Auto)]
	public struct AHardwareBuffer { }

	public enum gvr_recenter_event_type : uint
	{
		Restart = 1,
		Aligned = 2,
		Don = 3
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct gvr_recenter_event_data
	{
		public int recenter_type;

		public uint recenter_event_flags;

		public gvr_mat4f start_space_from_tracking_space_transform;
	}

	[StructLayout (LayoutKind.Sequential)]
	public struct gvr_event
	{
		public gvr_clock_time_point timestamp;

		public int type;

		public uint flags;

		[StructLayout (LayoutKind.Explicit)]
		public struct _
		{
			[FieldOffset (0)]
			public gvr_recenter_event_data recenter_event_data;

			[FieldOffset (0)]
			public byte[] padding;
		}
    }

	public enum gvr_error : uint
	{
		None = 0,
		ControllerCreateFailed = 2,
		NoFrameAvailable = 3,
		NoEventAvailable = 1000000,
		NoPropertyAvailable = 1000001
	}

	//[Verify (InferredFromMemberPrefix)]
	public enum GvrTrackingStatusFlag : uint
	{
		Invalid = (1 << 0),
		Initializing = (1 << 1),
		Has6dof = (1 << 2)
	}

	//[Verify (InferredFromMemberPrefix)]
	public enum GvrControllerEnable : uint
	{
		Orientation = 1 << 0,
		Touch = 1 << 1,
		Gyro = 1 << 2,
		Accel = 1 << 3,
		Gestures = 1 << 4,
		PosePrediction = 1 << 5,
		Position = 1 << 6,
		Battery = 1 << 7,
		ArmModel = 1 << 8
	}

	public enum gvr_controller_api_status : uint
	{
		Ok = 0,
		Unsupported = 1,
		NotAuthorized = 2,
		Unavailable = 3,
		ServiceObsolete = 4,
		ClientObsolete = 5,
		Malfunction = 6
	}

	public enum gvr_controller_connection_state : uint
	{
		Disconnected = 0,
		Scanning = 1,
		Connecting = 2,
		Connected = 3
	}

	public enum gvr_controller_button : uint
	{
		None = 0,
		Click = 1,
		Home = 2,
		App = 3,
		VolumeUp = 4,
		VolumeDown = 5,
		Reserved0 = 6,
		Reserved1 = 7,
		Reserved2 = 8,
		Count = 9
	}

	public enum gvr_controller_battery_level : uint
	{
		Unknown = 0,
		CriticalLow = 1,
		Low = 2,
		Medium = 3,
		AlmostFull = 4,
		Full = 5,
		Count = 6
	}

	public enum gvr_audio_rendering_mode : uint
	{
		StereoPanning = 0,
		BinauralLowQuality = 1,
		BinauralHighQuality = 2
	}

	public enum gvr_audio_material_type : uint
	{
		Transparent = 0,
		AcousticCeilingTiles = 1,
		BrickBare = 2,
		BrickPainted = 3,
		ConcreteBlockCoarse = 4,
		ConcreteBlockPainted = 5,
		CurtainHeavy = 6,
		FiberGlassInsulation = 7,
		GlassThin = 8,
		GlassThick = 9,
		Grass = 10,
		LinoleumOnConcrete = 11,
		Marble = 12,
		Metal = 13,
		ParquetOnConcrete = 14,
		PlasterRough = 15,
		PlasterSmooth = 16,
		PlywoodPanel = 17,
		PolishedConcreteOrTile = 18,
		SheetRock = 19,
		WaterOrIceSurface = 20,
		WoodCeiling = 21,
		WoodPanel = 22
	}

	public enum gvr_audio_distance_rolloff_type : uint
	{
		Logarithmic = 0,
		Linear = 1,
		None = 2
	}

	public enum gvr_audio_surround_format_type : uint
	{
		Invalid = 0,
		SurroundMono = 1,
		SurroundStereo = 2,
		SurroundFiveDotOne = 3,
		SurroundSevenDotOne = 10,
		FirstOrderAmbisonics = 4,
		SecondOrderAmbisonics = 5,
		ThirdOrderAmbisonics = 6,
		FirstOrderAmbisonicsWithNonDiegeticStereo = 7,
		SecondOrderAmbisonicsWithNonDiegeticStereo = 8,
		ThirdOrderAmbisonicsWithNonDiegeticStereo = 9
	}

	public enum gvr_color_format_type : uint
	{
		A8888 = 0,
		GvrColorFormatRgb565 = 1
	}

	public enum gvr_depth_stencil_format_type : uint
	{
		None = 255,
		Depth16 = 0,
		Depth24 = 1,
		Depth24Stencil8 = 2,
		Depth32F = 3,
		Depth32FStencil8 = 4,
		Stencil8 = 5
	}

	public enum gvr_reprojection : uint
	{
		None = 0,
		Full = 1
	}

	public enum gvr_controller_handedness : uint
	{
		RightHanded = 0,
		LeftHanded = 1
	}

	public enum gvr_arm_model_behavior : uint
	{
		SyncGaze = 0,
		FollowGaze = 1,
		IgnoreGaze = 2
	}

	//[Verify (InferredFromMemberPrefix)]
	public enum Gvr
	{
		ExternalSurfaceIdNone = -1,
		BufferIndexExternalSurface = -1,
		AudioInvalidSourceId = -1
	}

	public enum gvr_property_type : uint
	{
		TrackingFloorHeight = 1,
		RecenterTransform = 2,
		SafetyRegion = 3,
		SafetyCylinderEnterRadius = 4,
		SafetyCylinderExitRadius = 5,
		TrackingStatus = 6
	}

	public enum gvr_safety_region_type : uint
	{
		None = 0,
		Cylinder = 1
	}

	public enum gvr_value_type : uint
	{
		None = 0,
		Float = 1,
		Double = 2,
		Int = 3,
		Int64 = 4,
		Flags = 5,
		Sizei = 6,
		Recti = 7,
		Rectf = 8,
		Vec2f = 9,
		Vec3f = 10,
		Quatf = 11,
		Mat4f = 12,
		ClockTimePoint = 13
	}

	public enum gvr_event_type : uint
	{
		Recenter = 1,
		SafetyRegionExit = 2,
		SafetyRegionEnter = 3,
		HeadTrackingResumed = 4,
		HeadTrackingPaused = 5
	}

	static class CFunctions
	{
		// extern gvr_context * gvr_create ();
		[DllImport ("__Internal")]
		
		static extern unsafe gvr_context* gvr_create ();

		// extern gvr_version gvr_get_version ();
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern gvr_version gvr_get_version ();

		// extern const char * gvr_get_version_string ();
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe sbyte* gvr_get_version_string ();

		// extern int32_t gvr_get_error (gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe int gvr_get_error (gvr_context* gvr);

		// extern int32_t gvr_clear_error (gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe int gvr_clear_error (gvr_context* gvr);

		// extern const char * gvr_get_error_string (int32_t error_code);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe sbyte* gvr_get_error_string (int error_code);

		// extern int32_t gvr_poll_event (gvr_context *gvr, gvr_event *event_out);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe int gvr_poll_event (gvr_context* gvr, gvr_event* event_out);

		// extern const gvr_properties * gvr_get_current_properties (gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_properties* gvr_get_current_properties (gvr_context* gvr);

		// extern int32_t gvr_properties_get (const gvr_properties *properties, int32_t property_key, gvr_value *value_out);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe int gvr_properties_get (gvr_properties* properties, int property_key, gvr_value* value_out);

		// extern const gvr_user_prefs * gvr_get_user_prefs (gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_user_prefs* gvr_get_user_prefs (gvr_context* gvr);

		// extern int32_t gvr_user_prefs_get_controller_handedness (const gvr_user_prefs *user_prefs);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe int gvr_user_prefs_get_controller_handedness (gvr_user_prefs* user_prefs);

		// extern void gvr_destroy (gvr_context **gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_destroy (gvr_context** gvr);

		// extern void gvr_initialize_gl (gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_initialize_gl (gvr_context* gvr);

		// extern _Bool gvr_get_async_reprojection_enabled (const gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe bool gvr_get_async_reprojection_enabled (gvr_context* gvr);

		// extern void gvr_get_recommended_buffer_viewports (const gvr_context *gvr, gvr_buffer_viewport_list *viewport_list);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_get_recommended_buffer_viewports (gvr_context* gvr, gvr_buffer_viewport_list* viewport_list);

		// extern void gvr_get_screen_buffer_viewports (const gvr_context *gvr, gvr_buffer_viewport_list *viewport_list);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_get_screen_buffer_viewports (gvr_context* gvr, gvr_buffer_viewport_list* viewport_list);

		// extern gvr_sizei gvr_get_maximum_effective_render_target_size (const gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_sizei gvr_get_maximum_effective_render_target_size (gvr_context* gvr);

		// extern gvr_sizei gvr_get_screen_target_size (const gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_sizei gvr_get_screen_target_size (gvr_context* gvr);

		// extern void gvr_set_surface_size (gvr_context *gvr, gvr_sizei surface_size_pixels);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_set_surface_size (gvr_context* gvr, gvr_sizei surface_size_pixels);

		// extern void gvr_distort_to_screen (gvr_context *gvr, int32_t texture_id, const gvr_buffer_viewport_list *viewport_list, gvr_mat4f head_space_from_start_space, gvr_clock_time_point target_presentation_time);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_distort_to_screen (gvr_context* gvr, int texture_id, gvr_buffer_viewport_list* viewport_list, gvr_mat4f head_space_from_start_space, gvr_clock_time_point target_presentation_time);

		// extern _Bool gvr_is_feature_supported (const gvr_context *gvr, int32_t feature);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe bool gvr_is_feature_supported (gvr_context* gvr, int feature);

		// extern gvr_buffer_viewport * gvr_buffer_viewport_create (gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_buffer_viewport* gvr_buffer_viewport_create (gvr_context* gvr);

		// extern void gvr_buffer_viewport_destroy (gvr_buffer_viewport **viewport);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_viewport_destroy (gvr_buffer_viewport** viewport);

		// extern gvr_rectf gvr_buffer_viewport_get_source_uv (const gvr_buffer_viewport *viewport);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_rectf gvr_buffer_viewport_get_source_uv (gvr_buffer_viewport* viewport);

		// extern void gvr_buffer_viewport_set_source_uv (gvr_buffer_viewport *viewport, gvr_rectf uv);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_viewport_set_source_uv (gvr_buffer_viewport* viewport, gvr_rectf uv);

		// extern gvr_rectf gvr_buffer_viewport_get_source_fov (const gvr_buffer_viewport *viewport);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_rectf gvr_buffer_viewport_get_source_fov (gvr_buffer_viewport* viewport);

		// extern void gvr_buffer_viewport_set_source_fov (gvr_buffer_viewport *viewport, gvr_rectf fov);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_viewport_set_source_fov (gvr_buffer_viewport* viewport, gvr_rectf fov);

		// extern gvr_mat4f gvr_buffer_viewport_get_transform (const gvr_buffer_viewport *viewport);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_mat4f gvr_buffer_viewport_get_transform (gvr_buffer_viewport* viewport);

		// extern void gvr_buffer_viewport_set_transform (gvr_buffer_viewport *viewport, gvr_mat4f transform);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_viewport_set_transform (gvr_buffer_viewport* viewport, gvr_mat4f transform);

		// extern int32_t gvr_buffer_viewport_get_target_eye (const gvr_buffer_viewport *viewport);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe int gvr_buffer_viewport_get_target_eye (gvr_buffer_viewport* viewport);

		// extern void gvr_buffer_viewport_set_target_eye (gvr_buffer_viewport *viewport, int32_t index);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_viewport_set_target_eye (gvr_buffer_viewport* viewport, int index);

		// extern int32_t gvr_buffer_viewport_get_source_buffer_index (const gvr_buffer_viewport *viewport);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe int gvr_buffer_viewport_get_source_buffer_index (gvr_buffer_viewport* viewport);

		// extern void gvr_buffer_viewport_set_source_buffer_index (gvr_buffer_viewport *viewport, int32_t buffer_index);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_viewport_set_source_buffer_index (gvr_buffer_viewport* viewport, int buffer_index);

		// extern int32_t gvr_buffer_viewport_get_external_surface_id (const gvr_buffer_viewport *viewport);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe int gvr_buffer_viewport_get_external_surface_id (gvr_buffer_viewport* viewport);

		// extern void gvr_buffer_viewport_set_external_surface_id (gvr_buffer_viewport *viewport, int32_t external_surface_id);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_viewport_set_external_surface_id (gvr_buffer_viewport* viewport, int external_surface_id);

		// extern int32_t gvr_buffer_viewport_get_reprojection (const gvr_buffer_viewport *viewport);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe int gvr_buffer_viewport_get_reprojection (gvr_buffer_viewport* viewport);

		// extern void gvr_buffer_viewport_set_reprojection (gvr_buffer_viewport *viewport, int32_t reprojection);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_viewport_set_reprojection (gvr_buffer_viewport* viewport, int reprojection);

		// extern void gvr_buffer_viewport_set_source_layer (gvr_buffer_viewport *viewport, int32_t layer_index);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_viewport_set_source_layer (gvr_buffer_viewport* viewport, int layer_index);

		// extern float gvr_buffer_viewport_get_opacity (const gvr_buffer_viewport *viewport);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe float gvr_buffer_viewport_get_opacity (gvr_buffer_viewport* viewport);

		// extern void gvr_buffer_viewport_set_opacity (gvr_buffer_viewport *viewport, float opacity);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_viewport_set_opacity (gvr_buffer_viewport* viewport, float opacity);

		// extern _Bool gvr_buffer_viewport_equal (const gvr_buffer_viewport *a, const gvr_buffer_viewport *b);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe bool gvr_buffer_viewport_equal (gvr_buffer_viewport* a, gvr_buffer_viewport* b);

		// extern gvr_buffer_viewport_list * gvr_buffer_viewport_list_create (const gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_buffer_viewport_list* gvr_buffer_viewport_list_create (gvr_context* gvr);

		// extern void gvr_buffer_viewport_list_destroy (gvr_buffer_viewport_list **viewport_list);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_viewport_list_destroy (gvr_buffer_viewport_list** viewport_list);

		// extern size_t gvr_buffer_viewport_list_get_size (const gvr_buffer_viewport_list *viewport_list);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe nuint gvr_buffer_viewport_list_get_size (gvr_buffer_viewport_list* viewport_list);

		// extern void gvr_buffer_viewport_list_get_item (const gvr_buffer_viewport_list *viewport_list, size_t index, gvr_buffer_viewport *viewport);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_viewport_list_get_item (gvr_buffer_viewport_list* viewport_list, nuint index, gvr_buffer_viewport* viewport);

		// extern void gvr_buffer_viewport_list_set_item (gvr_buffer_viewport_list *viewport_list, size_t index, const gvr_buffer_viewport *viewport);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_viewport_list_set_item (gvr_buffer_viewport_list* viewport_list, nuint index, gvr_buffer_viewport* viewport);

		// extern gvr_buffer_spec * gvr_buffer_spec_create (gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_buffer_spec* gvr_buffer_spec_create (gvr_context* gvr);

		// extern void gvr_buffer_spec_destroy (gvr_buffer_spec **spec);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_spec_destroy (gvr_buffer_spec** spec);

		// extern gvr_sizei gvr_buffer_spec_get_size (const gvr_buffer_spec *spec);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_sizei gvr_buffer_spec_get_size (gvr_buffer_spec* spec);

		// extern void gvr_buffer_spec_set_size (gvr_buffer_spec *spec, gvr_sizei size);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_spec_set_size (gvr_buffer_spec* spec, gvr_sizei size);

		// extern int32_t gvr_buffer_spec_get_samples (const gvr_buffer_spec *spec);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe int gvr_buffer_spec_get_samples (gvr_buffer_spec* spec);

		// extern void gvr_buffer_spec_set_samples (gvr_buffer_spec *spec, int32_t num_samples);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_spec_set_samples (gvr_buffer_spec* spec, int num_samples);

		// extern void gvr_buffer_spec_set_color_format (gvr_buffer_spec *spec, int32_t color_format);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_spec_set_color_format (gvr_buffer_spec* spec, int color_format);

		// extern void gvr_buffer_spec_set_depth_stencil_format (gvr_buffer_spec *spec, int32_t depth_stencil_format);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_spec_set_depth_stencil_format (gvr_buffer_spec* spec, int depth_stencil_format);

		// extern void gvr_buffer_spec_set_multiview_layers (gvr_buffer_spec *spec, int32_t num_layers);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_buffer_spec_set_multiview_layers (gvr_buffer_spec* spec, int num_layers);

		// extern gvr_swap_chain * gvr_swap_chain_create (gvr_context *gvr, const gvr_buffer_spec **buffers, int32_t count);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_swap_chain* gvr_swap_chain_create (gvr_context* gvr, gvr_buffer_spec** buffers, int count);

		// extern void gvr_swap_chain_destroy (gvr_swap_chain **swap_chain);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_swap_chain_destroy (gvr_swap_chain** swap_chain);

		// extern int32_t gvr_swap_chain_get_buffer_count (const gvr_swap_chain *swap_chain);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe int gvr_swap_chain_get_buffer_count (gvr_swap_chain* swap_chain);

		// extern gvr_sizei gvr_swap_chain_get_buffer_size (const gvr_swap_chain *swap_chain, int32_t index);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_sizei gvr_swap_chain_get_buffer_size (gvr_swap_chain* swap_chain, int index);

		// extern void gvr_swap_chain_resize_buffer (gvr_swap_chain *swap_chain, int32_t index, gvr_sizei size);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_swap_chain_resize_buffer (gvr_swap_chain* swap_chain, int index, gvr_sizei size);

		// extern gvr_frame * gvr_swap_chain_acquire_frame (gvr_swap_chain *swap_chain);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_frame* gvr_swap_chain_acquire_frame (gvr_swap_chain* swap_chain);

		// extern void gvr_frame_bind_buffer (gvr_frame *frame, int32_t index);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_frame_bind_buffer (gvr_frame* frame, int index);

		// extern void gvr_frame_unbind (gvr_frame *frame);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_frame_unbind (gvr_frame* frame);

		// extern gvr_sizei gvr_frame_get_buffer_size (const gvr_frame *frame, int32_t index);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_sizei gvr_frame_get_buffer_size (gvr_frame* frame, int index);

		// extern int32_t gvr_frame_get_framebuffer_object (const gvr_frame *frame, int32_t index);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe int gvr_frame_get_framebuffer_object (gvr_frame* frame, int index);

		// extern AHardwareBuffer * gvr_frame_get_hardware_buffer (const gvr_frame *frame, int32_t index);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe AHardwareBuffer* gvr_frame_get_hardware_buffer (gvr_frame* frame, int index);

		// extern void gvr_frame_submit (gvr_frame **frame, const gvr_buffer_viewport_list *list, gvr_mat4f head_space_from_start_space);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_frame_submit (gvr_frame** frame, gvr_buffer_viewport_list* list, gvr_mat4f head_space_from_start_space);

		// extern void gvr_bind_default_framebuffer (gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_bind_default_framebuffer (gvr_context* gvr);

		// extern gvr_clock_time_point gvr_get_time_point_now ();
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern gvr_clock_time_point gvr_get_time_point_now ();

		// extern gvr_mat4f gvr_get_head_space_from_start_space_rotation (const gvr_context *gvr, const gvr_clock_time_point time);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_mat4f gvr_get_head_space_from_start_space_rotation (gvr_context* gvr, gvr_clock_time_point time);

		// extern gvr_mat4f gvr_get_head_space_from_start_space_transform (const gvr_context *gvr, const gvr_clock_time_point time);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_mat4f gvr_get_head_space_from_start_space_transform (gvr_context* gvr, gvr_clock_time_point time);

		// extern gvr_mat4f gvr_apply_neck_model (const gvr_context *gvr, gvr_mat4f head_space_from_start_space_rotation, float factor);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_mat4f gvr_apply_neck_model (gvr_context* gvr, gvr_mat4f head_space_from_start_space_rotation, float factor);

		// extern void gvr_pause_tracking (gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_pause_tracking (gvr_context* gvr);

		// extern void gvr_resume_tracking (gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_resume_tracking (gvr_context* gvr);

		// extern void gvr_reset_tracking (gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_reset_tracking (gvr_context* gvr);

		// extern void gvr_recenter_tracking (gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_recenter_tracking (gvr_context* gvr);

		// extern _Bool gvr_set_default_viewer_profile (gvr_context *gvr, const char *viewer_profile_uri);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe bool gvr_set_default_viewer_profile (gvr_context* gvr, sbyte* viewer_profile_uri);

		// extern void gvr_refresh_viewer_profile (gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_refresh_viewer_profile (gvr_context* gvr);

		// extern const char * gvr_get_viewer_vendor (const gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe sbyte* gvr_get_viewer_vendor (gvr_context* gvr);

		// extern const char * gvr_get_viewer_model (const gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe sbyte* gvr_get_viewer_model (gvr_context* gvr);

		// extern int32_t gvr_get_viewer_type (const gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe int gvr_get_viewer_type (gvr_context* gvr);

		// extern gvr_mat4f gvr_get_eye_from_head_matrix (const gvr_context *gvr, const int32_t eye);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_mat4f gvr_get_eye_from_head_matrix (gvr_context* gvr, int eye);

		// extern gvr_recti gvr_get_window_bounds (const gvr_context *gvr);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe gvr_recti gvr_get_window_bounds (gvr_context* gvr);

		// extern void gvr_compute_distorted_point (const gvr_context *gvr, const int32_t eye, const gvr_vec2f uv_in, gvr_vec2f *uv_out);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void gvr_compute_distorted_point (gvr_context* gvr, int eye, gvr_vec2f uv_in, gvr_vec2f[] uv_out);

		// extern void checkGLError (const char *label);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe void checkGLError (sbyte* label);

		// extern GLuint loadShader (GLenum type, const char *shader_src);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern unsafe uint loadShader (uint type, sbyte* shader_src);

		// extern _Bool checkProgramLinkStatus (GLuint shader_program);
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern bool checkProgramLinkStatus (uint shader_program);
	}

	//[Native]
	//public enum GVREye : nint
	//{
	//	LeftEye = (int) gvr_eye.LeftEye,
	//	RightEye = (int) gvr_eye.RightEye,
	//	CenterEye
	//}

	//[StructLayout (LayoutKind.Sequential)]
	//public struct GVRFieldOfView
	//{
	//	public nfloat left;

	//	public nfloat right;

	//	public nfloat bottom;

	//	public nfloat top;
	//}

//    [Native]
//	public enum GVRMeshType : uint
//	{
//		StereoLeftRight = 0,
//		StereoTopBottom,
//		Monoscopic
//	}

 //   [Native]
	//public enum GVRDisplayMode : nint
	//{
	//	Embedded,
	//	FullscreenMonoscopic,
	//	FullscreenStereoscopic
	//}
}
