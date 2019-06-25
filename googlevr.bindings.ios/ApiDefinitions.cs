using System;
using CoreGraphics;
using Foundation;
using GLKit;
using GVRKit;
using ObjCRuntime;
using OpenGLES;
using OpenTK;
using UIKit;

namespace GVRKit
{
	// @interface GVRAudioEngine : NSObject
//	[BaseType (typeof(NSObject))]
//	interface GVRAudioEngine
//	{
//		// -(id)initWithRenderingMode:(renderingMode)rendering_mode;
//		[Export ("initWithRenderingMode:")]
//		IntPtr Constructor (renderingMode rendering_mode);
//
//		// -(_Bool)start;
//		[Export ("start")]
//		//[Verify (MethodToProperty)]
//		bool Start { get; }
//
//		// -(void)stop;
//		[Export ("stop")]
//		void Stop ();
//
//		// -(void)update;
//		[Export ("update")]
//		void Update ();
//
//		// -(void)enableStereoSpeakerMode:(_Bool)enable;
//		[Export ("enableStereoSpeakerMode:")]
//		void EnableStereoSpeakerMode (bool enable);
//
//		// -(_Bool)preloadSoundFile:(const NSString *)filename;
//		[Export ("preloadSoundFile:")]
//		bool PreloadSoundFile (string filename);
//
//		// -(void)unloadSoundFile:(const NSString *)filename;
//		[Export ("unloadSoundFile:")]
//		void UnloadSoundFile (string filename);
//
//		// -(int)createSoundObject:(const NSString *)filename;
//		[Export ("createSoundObject:")]
//		int CreateSoundObject (string filename);
//
//		// -(int)createSoundfield:(const NSString *)filename;
//		[Export ("createSoundfield:")]
//		int CreateSoundfield (string filename);
//
//		// -(int)createStereoSound:(const NSString *)filename;
//		[Export ("createStereoSound:")]
//		int CreateStereoSound (string filename);
//
//		// -(void)playSound:(int)sourceId loopingEnabled:(_Bool)loopingEnabled;
//		[Export ("playSound:loopingEnabled:")]
//		void PlaySound (int sourceId, bool loopingEnabled);
//
//		// -(void)pauseSound:(int)sourceId;
//		[Export ("pauseSound:")]
//		void PauseSound (int sourceId);
//
//		// -(void)resumeSound:(int)sourceId;
//		[Export ("resumeSound:")]
//		void ResumeSound (int sourceId);
//
//		// -(void)stopSound:(int)sourceId;
//		[Export ("stopSound:")]
//		void StopSound (int sourceId);
//
//		// -(_Bool)isSoundPlaying:(int)sourceId;
//		[Export ("isSoundPlaying:")]
//		bool IsSoundPlaying (int sourceId);
//
//		// -(_Bool)isSourceIdValid:(int)sourceId;
//		[Export ("isSourceIdValid:")]
//		bool IsSourceIdValid (int sourceId);
//
//		// -(void)setSoundObjectPosition:(int)soundObjectId x:(float)x y:(float)y z:(float)z;
//		[Export ("setSoundObjectPosition:x:y:z:")]
//		void SetSoundObjectPosition (int soundObjectId, float x, float y, float z);
//
//		// -(void)setSoundObjectDistanceRolloffModel:(int)soundObjectId rolloffModel:(distanceRolloffModel)rolloffModel minDistance:(float)minDistance maxDistance:(float)maxDistance;
//		[Export ("setSoundObjectDistanceRolloffModel:rolloffModel:minDistance:maxDistance:")]
//		void SetSoundObjectDistanceRolloffModel (int soundObjectId, distanceRolloffModel rolloffModel, float minDistance, float maxDistance);
//
//		// -(void)setSoundfieldRotation:(int)soundfieldId x:(float)x y:(float)y z:(float)z w:(float)w;
//		[Export ("setSoundfieldRotation:x:y:z:w:")]
//		void SetSoundfieldRotation (int soundfieldId, float x, float y, float z, float w);
//
//		// -(void)setSoundVolume:(int)sourceId volume:(float)volume;
//		[Export ("setSoundVolume:volume:")]
//		void SetSoundVolume (int sourceId, float volume);
//
//		// -(void)setHeadPosition:(float)x y:(float)y z:(float)z;
//		[Export ("setHeadPosition:y:z:")]
//		void SetHeadPosition (float x, float y, float z);
//
//		// -(void)setHeadRotation:(float)x y:(float)y z:(float)z w:(float)w;
//		[Export ("setHeadRotation:y:z:w:")]
//		void SetHeadRotation (float x, float y, float z, float w);
//
//		// -(void)enableRoom:(_Bool)enable;
//		[Export ("enableRoom:")]
//		void EnableRoom (bool enable);
//
//		// -(void)setRoomProperties:(float)size_x size_y:(float)size_y size_z:(float)size_z wall_material:(materialName)wall_material ceiling_material:(materialName)ceiling_material floor_material:(materialName)floor_material;
//		[Export ("setRoomProperties:size_y:size_z:wall_material:ceiling_material:floor_material:")]
//		void SetRoomProperties (float size_x, float size_y, float size_z, materialName wall_material, materialName ceiling_material, materialName floor_material);
//
//		// -(void)setRoomReverbAdjustments:(float)gain timeAdjust:(float)timeAdjust brightnessAdjust:(float)brightnessAdjust;
//		[Export ("setRoomReverbAdjustments:timeAdjust:brightnessAdjust:")]
//		void SetRoomReverbAdjustments (float gain, float timeAdjust, float brightnessAdjust);
//	}

	// @interface GVRHeadTransform : NSObject
	[BaseType (typeof(NSObject))]
	interface GVRHeadTransform
	{
		// -(CGRect)viewportForEye:(GVREye)eye;
		[Export ("viewportForEye:")]
		CGRect ViewportForEye (GVREye eye);

		// -(GLKMatrix4)projectionMatrixForEye:(GVREye)eye near:(CGFloat)near far:(CGFloat)far;
		[Export ("projectionMatrixForEye:near:far:")]
		Matrix4 ProjectionMatrixForEye (GVREye eye, nfloat near, nfloat far);

		// -(GLKMatrix4)eyeFromHeadMatrix:(GVREye)eye;
		[Export ("eyeFromHeadMatrix:")]
		Matrix4 EyeFromHeadMatrix (GVREye eye);

		// -(GLKMatrix4)headPoseInStartSpace;
		[Export ("headPoseInStartSpace")]
		//[Verify (MethodToProperty)]
		Matrix4 HeadPoseInStartSpace { get; }

		// -(GVRFieldOfView)fieldOfViewForEye:(GVREye)eye;
		[Export ("fieldOfViewForEye:")]
		GVRFieldOfView FieldOfViewForEye (GVREye eye);
	}

	// @protocol GVRCardboardViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface GVRCardboardViewDelegate
	{
		// @optional -(void)cardboardView:(GVRCardboardView *)cardboardView didFireEvent:(GVRUserEvent)event;
		[Export ("cardboardView:didFireEvent:")]
		void DidFireEvent (GVRCardboardView cardboardView, GVRUserEvent @event);

		// @optional -(void)cardboardView:(GVRCardboardView *)cardboardView willStartDrawing:(GVRHeadTransform *)headTransform;
		[Export ("cardboardView:willStartDrawing:")]
		void WillStartDrawing (GVRCardboardView cardboardView, GVRHeadTransform headTransform);

		// @optional -(void)cardboardView:(GVRCardboardView *)cardboardView prepareDrawFrame:(GVRHeadTransform *)headTransform;
		[Export ("cardboardView:prepareDrawFrame:")]
		void PrepareDrawFrame (GVRCardboardView cardboardView, GVRHeadTransform headTransform);

		// @required -(void)cardboardView:(GVRCardboardView *)cardboardView drawEye:(GVREye)eye withHeadTransform:(GVRHeadTransform *)headTransform;
		[Abstract]
		[Export ("cardboardView:drawEye:withHeadTransform:")]
		void DrawEye (GVRCardboardView cardboardView, GVREye eye, GVRHeadTransform headTransform);

		// @optional -(void)cardboardView:(GVRCardboardView *)cardboardView shouldPauseDrawing:(BOOL)pause;
		[Export ("cardboardView:shouldPauseDrawing:")]
		void ShouldPauseDrawing (GVRCardboardView cardboardView, bool pause);
	}

	// @interface GVRCardboardView : UIView
	[BaseType (typeof(UIView))]
	interface GVRCardboardView
	{
		// -(instancetype)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		[Wrap ("WeakDelegate")]
		GVRCardboardViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<GVRCardboardViewDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic) EAGLContext * context;
		[Export ("context", ArgumentSemantic.Assign)]
		EAGLContext Context { get; set; }

		// @property (nonatomic) BOOL vrModeEnabled;
		[Export ("vrModeEnabled")]
		bool VrModeEnabled { get; set; }

		// @property (nonatomic) BOOL hidesTransitionView;
		[Export ("hidesTransitionView")]
		bool HidesTransitionView { get; set; }

		// -(void)render;
		[Export ("render")]
		void Render ();

		// +(void)setViewerParamsFromUrl:(NSURL *)url withCompletion:(void (^)(BOOL, NSError *))completion;
		[Static]
		[Export ("setViewerParamsFromUrl:withCompletion:")]
		void SetViewerParamsFromUrl (NSUrl url, Action<bool, NSError> completion);
	}

	// @protocol GVROverlayViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface GVROverlayViewDelegate
	{
		// @optional -(void)didTapTriggerButton;
		[Export ("didTapTriggerButton")]
		void DidTapTriggerButton ();

		// @optional -(void)didTapBackButton;
		[Export ("didTapBackButton")]
		void DidTapBackButton ();

		// @optional -(void)didTapCardboardButton;
		[Export ("didTapCardboardButton")]
		void DidTapCardboardButton ();

		// @optional -(UIViewController *)presentingViewControllerForSettingsDialog;
		[Export ("presentingViewControllerForSettingsDialog")]
		//[Verify (MethodToProperty)]
		UIViewController PresentingViewControllerForSettingsDialog { get; }

		// @optional -(void)didPresentSettingsDialog:(BOOL)presented;
		[Export ("didPresentSettingsDialog:")]
		void DidPresentSettingsDialog (bool presented);

		// @optional -(void)didChangeViewerProfile;
		[Export ("didChangeViewerProfile")]
		void DidChangeViewerProfile ();

		// @optional -(void)shouldDisableIdleTimer:(BOOL)shouldDisable;
		[Export ("shouldDisableIdleTimer:")]
		void ShouldDisableIdleTimer (bool shouldDisable);
	}

	// @interface GVROverlayView : UIView
	[BaseType (typeof(UIView))]
	interface GVROverlayView
	{
		[Wrap ("WeakDelegate")]
		GVROverlayViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<GVROverlayViewDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic) BOOL hidesAlignmentMarker;
		[Export ("hidesAlignmentMarker")]
		bool HidesAlignmentMarker { get; set; }

		// @property (nonatomic) BOOL hidesBackButton;
		[Export ("hidesBackButton")]
		bool HidesBackButton { get; set; }

		// @property (nonatomic) BOOL hidesCardboardButton;
		[Export ("hidesCardboardButton")]
		bool HidesCardboardButton { get; set; }

		// @property (nonatomic) BOOL hidesFullscreenButton;
		[Export ("hidesFullscreenButton")]
		bool HidesFullscreenButton { get; set; }

		// @property (nonatomic) BOOL hidesSettingsButton;
		[Export ("hidesSettingsButton")]
		bool HidesSettingsButton { get; set; }

		// @property (nonatomic) BOOL hidesTransitionView;
		[Export ("hidesTransitionView")]
		bool HidesTransitionView { get; set; }

		// @property (nonatomic) BOOL hidesWatermark;
		[Export ("hidesWatermark")]
		bool HidesWatermark { get; set; }
	}

	// @interface GVRWidgetView : UIView
	[BaseType (typeof(UIView))]
	interface GVRWidgetView
	{
		[Wrap ("WeakDelegate")]
		GVRWidgetViewDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<GVRWidgetViewDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic) BOOL enableFullscreenButton;
		[Export ("enableFullscreenButton")]
		bool EnableFullscreenButton { get; set; }

		// @property (nonatomic) BOOL enableCardboardButton;
		[Export ("enableCardboardButton")]
		bool EnableCardboardButton { get; set; }

		// @property (nonatomic) BOOL enableInfoButton;
		[Export ("enableInfoButton")]
		bool EnableInfoButton { get; set; }

		// @property (nonatomic) BOOL hidesTransitionView;
		[Export ("hidesTransitionView")]
		bool HidesTransitionView { get; set; }

		// @property (nonatomic) BOOL enableTouchTracking;
		[Export ("enableTouchTracking")]
		bool EnableTouchTracking { get; set; }

		// @property (readonly, nonatomic) GVRHeadRotation headRotation;
		[Export ("headRotation")]
		GVRHeadRotation HeadRotation { get; }

		// @property (nonatomic) GVRWidgetDisplayMode displayMode;
		[Export ("displayMode", ArgumentSemantic.Assign)]
		GVRWidgetDisplayMode DisplayMode { get; set; }

		// +(void)setViewerParamsFromUrl:(NSURL *)url withCompletion:(void (^)(BOOL, NSError *))completion;
		[Static]
		[Export ("setViewerParamsFromUrl:withCompletion:")]
		void SetViewerParamsFromUrl (NSUrl url, Action<bool, NSError> completion);
	}

	// @protocol GVRWidgetViewDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface GVRWidgetViewDelegate
	{
		// @optional -(void)widgetViewDidTap:(GVRWidgetView *)widgetView;
		[Export ("widgetViewDidTap:")]
		void WidgetViewDidTap (GVRWidgetView widgetView);

		// @optional -(void)widgetView:(GVRWidgetView *)widgetView didChangeDisplayMode:(GVRWidgetDisplayMode)displayMode;
		[Export ("widgetView:didChangeDisplayMode:")]
		void WidgetView (GVRWidgetView widgetView, GVRWidgetDisplayMode displayMode);

		// @optional -(void)widgetView:(GVRWidgetView *)widgetView didLoadContent:(id)content;
		[Export ("widgetView:didLoadContent:")]
		void WidgetView (GVRWidgetView widgetView, NSObject content);

		// @optional -(void)widgetView:(GVRWidgetView *)widgetView didFailToLoadContent:(id)content withErrorMessage:(NSString *)errorMessage;
		[Export ("widgetView:didFailToLoadContent:withErrorMessage:")]
		void WidgetView (GVRWidgetView widgetView, NSObject content, string errorMessage);
	}

	// @interface GVRPanoramaView : GVRWidgetView
	[BaseType (typeof(GVRWidgetView))]
	interface GVRPanoramaView
	{
		// -(void)loadImage:(UIImage *)image;
		[Export ("loadImage:")]
		void LoadImage (UIImage image);

		// -(void)loadImage:(UIImage *)image ofType:(GVRPanoramaImageType)imageType;
		[Export ("loadImage:ofType:")]
		void LoadImage (UIImage image, GVRPanoramaImageType imageType);
	}

	// @interface GVRVideoView : GVRWidgetView
	[BaseType (typeof(GVRWidgetView))]
	interface GVRVideoView
	{
		// -(void)loadFromUrl:(NSURL *)videoUrl;
		[Export ("loadFromUrl:")]
		void LoadFromUrl (NSUrl videoUrl);

		// -(void)loadFromUrl:(NSURL *)videoUrl ofType:(GVRVideoType)videoType;
		[Export ("loadFromUrl:ofType:")]
		void LoadFromUrl (NSUrl videoUrl, GVRVideoType videoType);

		// -(void)pause;
		[Export ("pause")]
		void Pause ();

		// -(void)play;
		[Export ("play")]
		void Play ();

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(NSTimeInterval)duration;
		[Export ("duration")]
		//[Verify (MethodToProperty)]
		double Duration { get; }

		// -(NSTimeInterval)playableDuration;
		[Export ("playableDuration")]
		//[Verify (MethodToProperty)]
		double PlayableDuration { get; }

		// -(void)seekTo:(NSTimeInterval)position;
		[Export ("seekTo:")]
		void SeekTo (double position);

		// @property (nonatomic) float volume;
		[Export ("volume")]
		float Volume { get; set; }
	}

	// @protocol GVRVideoViewDelegate <GVRWidgetViewDelegate>
	[Protocol, Model]
	interface GVRVideoViewDelegate : GVRWidgetViewDelegate
	{
		// @required -(void)videoView:(GVRVideoView *)videoView didUpdatePosition:(NSTimeInterval)position;
		[Abstract]
		[Export ("videoView:didUpdatePosition:")]
		void DidUpdatePosition (GVRVideoView videoView, double position);
	}
}
