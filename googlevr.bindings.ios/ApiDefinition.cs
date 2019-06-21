using System;
using AVFoundation;
using CoreGraphics;
using Foundation;
using GLKit;
using ObjCRuntime;
using OpenTK;
using UIKit;

namespace googlevr.bindings.ios
{
    // @interface GVRHeadPose : NSObject
    [BaseType(typeof(NSObject))]
    interface GVRHeadPose
    {
        // @property (readonly, nonatomic) GVREye eye;
        //[Export("eye")]
        //GVREye Eye { get; }

        // @property (readonly, nonatomic) GLKMatrix4 headTransform;
        [Export("headTransform")]
        Matrix4 HeadTransform { get; }

        // @property (readonly, nonatomic) GLKMatrix4 eyeTransform;
        [Export("eyeTransform")]
        Matrix4 EyeTransform { get; }

        // @property (readonly, nonatomic) GLKMatrix4 viewTransform;
        [Export("viewTransform")]
        Matrix4 ViewTransform { get; }

        // @property (readonly, nonatomic) GLKMatrix4 projectionTransform;
        [Export("projectionTransform")]
        Matrix4 ProjectionTransform { get; }

        // @property (readonly, nonatomic) CGRect viewport;
        [Export("viewport")]
        CGRect Viewport { get; }

        // @property (readonly, nonatomic) GVRFieldOfView fieldOfView;
        //[Export("fieldOfView")]
        //GVRFieldOfView FieldOfView { get; }

        // @property (readonly, nonatomic) NSTimeInterval nextFrameTime;
        [Export("nextFrameTime")]
        double NextFrameTime { get; }

        // -(void)setProjectionMatrixWithNear:(CGFloat)near far:(CGFloat)far;
        [Export("setProjectionMatrixWithNear:far:")]
        void SetProjectionMatrixWithNear(nfloat near, nfloat far);

        // -(GLKMatrix4)projectionMatrixWithNear:(CGFloat)near far:(CGFloat)far;
        [Export("projectionMatrixWithNear:far:")]
        Matrix4 ProjectionMatrixWithNear(nfloat near, nfloat far);
    }

    // @interface GVRRenderer : NSObject
    [BaseType(typeof(NSObject))]
    interface GVRRenderer
    {
        // @property (nonatomic) BOOL VRModeEnabled;
        [Export("VRModeEnabled")]
        bool VRModeEnabled { get; set; }

        // -(void)initializeGl;
        [Export("initializeGl")]
        void InitializeGl();

        // -(void)clearGl;
        [Export("clearGl")]
        void ClearGl();

        // -(void)drawFrame:(NSTimeInterval)nextFrameTime;
        [Export("drawFrame:")]
        void DrawFrame(double nextFrameTime);

        // -(void)refresh;
        [Export("refresh")]
        void Refresh();

        // -(void)addToHeadRotationYaw:(CGFloat)yaw andPitch:(CGFloat)pitch;
        [Export("addToHeadRotationYaw:andPitch:")]
        void AddToHeadRotationYaw(nfloat yaw, nfloat pitch);

        // -(void)resetHeadRotation;
        [Export("resetHeadRotation")]
        void ResetHeadRotation();

        // -(void)setSize:(CGSize)size andOrientation:(UIInterfaceOrientation)orientation;
        [Export("setSize:andOrientation:")]
        void SetSize(CGSize size, UIInterfaceOrientation orientation);

        // -(void)pause:(BOOL)pause;
        [Export("pause:")]
        void Pause(bool pause);

        // -(void)update:(GVRHeadPose *)headPose;
        [Export("update:")]
        void Update(GVRHeadPose headPose);

        // -(void)draw:(GVRHeadPose *)headPose;
        [Export("draw:")]
        void Draw(GVRHeadPose headPose);

        // -(BOOL)handleTrigger:(GVRHeadPose *)headPose;
        [Export("handleTrigger")]
        bool HandleTrigger();

        [Export("handleTrigger:")]
        bool HandleTrigger(GVRHeadPose headPose);
    }

    // @protocol GVRRenderObject <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface GVRRenderObject
    {
        // @required @property (readonly, nonatomic) BOOL initialized;
        [Abstract]
        [Export("initialized")]
        bool Initialized { get; }

        // @required @property (nonatomic) BOOL hidden;
        [Abstract]
        [Export("hidden")]
        bool Hidden { get; set; }

        // @required -(void)initializeGl;
        [Abstract]
        [Export("initializeGl")]
        void InitializeGl();

        // @required -(void)draw:(GVRHeadPose *)headPose;
        [Abstract]
        [Export("draw:")]
        void Draw(GVRHeadPose headPose);

        // @optional -(void)clearGl;
        [Export("clearGl")]
        void ClearGl();

        // @optional -(void)update:(GVRHeadPose *)headPose;
        [Export("update:")]
        void Update(GVRHeadPose headPose);

        // @optional -(void)pause:(BOOL)pause;
        [Export("pause:")]
        void Pause(bool pause);

        // @optional -(BOOL)handleTrigger:(GVRHeadPose *)headPose;
        [Export("handleTrigger:")]
        bool HandleTrigger(GVRHeadPose headPose);
    }

    // @interface GVRRenderList : NSObject <GVRRenderObject>
    [BaseType(typeof(NSObject))]
    interface GVRRenderList : GVRRenderObject
    {
        // -(void)addRenderObject:(id<GVRRenderObject>)renderTarget;
        [Export("addRenderObject:")]
        void AddRenderObject(GVRRenderObject renderTarget);

        // -(void)insertRenderObject:(id<GVRRenderObject>)renderTarget atIndex:(NSUInteger)index;
        [Export("insertRenderObject:atIndex:")]
        void InsertRenderObject(GVRRenderObject renderTarget, nuint index);

        // -(void)removeRenderObject:(id<GVRRenderObject>)renderTarget;
        [Export("removeRenderObject:")]
        void RemoveRenderObject(GVRRenderObject renderTarget);

        // -(void)removeRenderObjectAtIndex:(NSUInteger)index;
        [Export("removeRenderObjectAtIndex:")]
        void RemoveRenderObjectAtIndex(nuint index);

        // -(void)removeAll;
        [Export("removeAll")]
        void RemoveAll();

        // -(id<GVRRenderObject>)objectAtIndex:(NSUInteger)index;
        [Export("objectAtIndex:")]
        GVRRenderObject ObjectAtIndex(nuint index);

        // -(NSUInteger)count;
        [Export("count")]
        nuint Count { get; }
    }

    // @interface GVRSceneRenderer : GVRRenderer
    [BaseType(typeof(GVRRenderer))]
    interface GVRSceneRenderer
    {
        // @property (nonatomic) GVRRenderList * renderList;
        [Export("renderList", ArgumentSemantic.Assign)]
        GVRRenderList RenderList { get; set; }

        // @property (nonatomic) BOOL hidesReticle;
        [Export("hidesReticle")]
        bool HidesReticle { get; set; }
    }

    // @interface GVRTextureRenderer : NSObject <GVRRenderObject>
    [BaseType(typeof(NSObject))]
    interface GVRTextureRenderer : GVRRenderObject
    {
        // @property (nonatomic) GLKMatrix4 position;
        [Export("position", ArgumentSemantic.Assign)]
        Matrix4 Position { get; set; }

        // @property (readonly, nonatomic) GLKVector3 aabbMin;
        [Export("aabbMin")]
        Vector3 AabbMin { get; }

        // @property (readonly, nonatomic) GLKVector3 aabbMax;
        [Export("aabbMax")]
        Vector3 AabbMax { get; }

        // -(void)setSphericalMeshOfRadius:(CGFloat)radius latitudes:(NSInteger)latitudes longitudes:(NSInteger)longitudes verticalFov:(NSInteger)verticalFov horizontalFov:(NSInteger)horizontalFov meshType:(GVRMeshType)meshType;
        //[Export("setSphericalMeshOfRadius:latitudes:longitudes:verticalFov:horizontalFov:meshType:")]
//        void SetSphericalMeshOfRadius(nfloat radius, nint latitudes, nint longitudes, nint verticalFov, nint horizontalFov, GVRMeshType meshType);

        // -(void)setQuadMeshOfWidth:(CGFloat)width height:(CGFloat)height meshType:(GVRMeshType)meshType;
        //[Export("setQuadMeshOfWidth:height:meshType:")]
        //void SetQuadMeshOfWidth(nfloat width, nfloat height, GVRMeshType meshType);

        // -(void)setImageTextureId:(GLuint)textureId;
        [Export("setImageTextureId:")]
        void SetImageTextureId(uint textureId);

        // -(void)setVideoYTextureId:(GLuint)yTextureId uvTextureId:(GLuint)uvTextureId colorConversionMatrix:(GLKMatrix4)colorConversionMatrix;
        [Export("setVideoYTextureId:uvTextureId:colorConversionMatrix:")]
        void SetVideoYTextureId(uint yTextureId, uint uvTextureId, Matrix4 colorConversionMatrix);
    }

    // @protocol GVRTextureLoadDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface GVRTextureLoadDelegate
    {
        // @optional -(void)textureRenderer:(GVRTextureRenderer *)textureRenderer didLoadTexture:(GLKTextureInfo *)textureInfo;
        [Export("textureRenderer:didLoadTexture:")]
        void DidLoadTexture(GVRTextureRenderer textureRenderer, GLKTextureInfo textureInfo);

        // @optional -(void)textureRenderer:(GVRTextureRenderer *)textureRenderer failedToLoadTextureWithError:(NSError *)error;
        [Export("textureRenderer:failedToLoadTextureWithError:")]
        void FailedToLoadTextureWithError(GVRTextureRenderer textureRenderer, NSError error);
    }

    // @interface GVRImageRenderer : GVRTextureRenderer
    [BaseType(typeof(GVRTextureRenderer))]
    interface GVRImageRenderer
    {
        [Wrap("WeakLoadDelegate")]
        GVRTextureLoadDelegate LoadDelegate { get; set; }

        // @property (nonatomic, weak) id<GVRTextureLoadDelegate> loadDelegate;
        [NullAllowed, Export("loadDelegate", ArgumentSemantic.Weak)]
        NSObject WeakLoadDelegate { get; set; }

        // -(instancetype)initWithImage:(UIImage *)image;
        [Export("initWithImage:")]
        IntPtr Constructor(UIImage image);

        // -(instancetype)initWithContentsOfFile:(NSString *)path;
        [Export("initWithContentsOfFile:")]
        IntPtr Constructor(string path);

        // -(instancetype)initWithContentsOfURL:(NSURL *)url;
        [Export("initWithContentsOfURL:")]
        IntPtr Constructor(NSUrl url);
    }

    // @protocol GVROverlayViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface GVROverlayViewDelegate
    {
        // @optional -(void)didTapTriggerButton;
        [Export("didTapTriggerButton")]
        void DidTapTriggerButton();

        // @optional -(void)didTapBackButton;
        [Export("didTapBackButton")]
        void DidTapBackButton();

        // @optional -(void)didTapCardboardButton;
        [Export("didTapCardboardButton")]
        void DidTapCardboardButton();

        // @optional -(UIViewController *)presentingViewControllerForSettingsDialog;
        [Export("presentingViewControllerForSettingsDialog")]
        UIViewController PresentingViewControllerForSettingsDialog();

        // @optional -(void)didPresentSettingsDialog:(BOOL)presented;
        [Export("didPresentSettingsDialog:")]
        void DidPresentSettingsDialog(bool presented);

        // @optional -(void)didChangeViewerProfile;
        [Export("didChangeViewerProfile")]
        void DidChangeViewerProfile();

        // @optional -(void)shouldDisableIdleTimer:(BOOL)shouldDisable;
        [Export("shouldDisableIdleTimer:")]
        void ShouldDisableIdleTimer(bool shouldDisable);
    }

    // @interface GVROverlayView : UIView
    [BaseType(typeof(UIView))]
    interface GVROverlayView
    {
        [Wrap("WeakDelegate")]
        GVROverlayViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<GVROverlayViewDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic) BOOL hidesAlignmentMarker;
        [Export("hidesAlignmentMarker")]
        bool HidesAlignmentMarker { get; set; }

        // @property (nonatomic) BOOL hidesBackButton;
        [Export("hidesBackButton")]
        bool HidesBackButton { get; set; }

        // @property (nonatomic) BOOL hidesCardboardButton;
        [Export("hidesCardboardButton")]
        bool HidesCardboardButton { get; set; }

        // @property (nonatomic) BOOL hidesFullscreenButton;
        [Export("hidesFullscreenButton")]
        bool HidesFullscreenButton { get; set; }

        // @property (nonatomic) BOOL hidesSettingsButton;
        [Export("hidesSettingsButton")]
        bool HidesSettingsButton { get; set; }

        // @property (nonatomic) BOOL hidesTransitionView;
        [Export("hidesTransitionView")]
        bool HidesTransitionView { get; set; }

        // @property (nonatomic) BOOL hidesWatermark;
        [Export("hidesWatermark")]
        bool HidesWatermark { get; set; }
    }

    // @interface GVRRendererView : GLKView
    [BaseType(typeof(GLKView))]
    interface GVRRendererView
    {
        // -(instancetype)initWithRenderer:(GVRRenderer *)renderer;
        [Export("initWithRenderer:")]
        IntPtr Constructor(GVRRenderer renderer);

        // @property (readonly, nonatomic) GVRRenderer * renderer;
        [Export("renderer")]
        GVRRenderer Renderer { get; }

        // @property (readonly, nonatomic) GVROverlayView * overlayView;
        [Export("overlayView")]
        GVROverlayView OverlayView { get; }

        // @property (nonatomic) BOOL VRModeEnabled;
        [Export("VRModeEnabled")]
        bool VRModeEnabled { get; set; }

        // @property (nonatomic) BOOL paused;
        [Export("paused")]
        bool Paused { get; set; }
    }

    // @protocol GVRRendererViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface GVRRendererViewControllerDelegate
    {
        // @required -(GVRRenderer *)rendererForDisplayMode:(GVRDisplayMode)displayMode;
        //[Abstract]
        //[Export("rendererForDisplayMode:")]
        //GVRRenderer RendererForDisplayMode(GVRDisplayMode displayMode);

        // @optional -(void)didTapTriggerButton;
        [Export("didTapTriggerButton")]
        void DidTapTriggerButton();

        // @optional -(BOOL)shouldHideTransitionView;
        [Export("shouldHideTransitionView")]
        bool ShouldHideTransitionView { get; }
    }

    // @interface GVRRendererViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface GVRRendererViewController
    {
        // -(instancetype)initWithRenderer:(GVRRenderer *)renderer;
        [Export("initWithRenderer:")]
        IntPtr Constructor(GVRRenderer renderer);

        [Wrap("WeakDelegate")]
        GVRRendererViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<GVRRendererViewControllerDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic) GVRRendererView * rendererView;
        [Export("rendererView")]
        GVRRendererView RendererView { get; }
    }

    // @interface GVRReticleRenderer : NSObject <GVRRenderObject>
    [BaseType(typeof(NSObject))]
    interface GVRReticleRenderer : GVRRenderObject
    {
        // @property (nonatomic) CGFloat depth;
        [Export("depth")]
        nfloat Depth { get; set; }
    }

    // @interface GVRUIViewRenderer : GVRTextureRenderer
    [BaseType(typeof(GVRTextureRenderer))]
    interface GVRUIViewRenderer
    {
        // -(instancetype)initWithView:(UIView *)view;
        [Export("initWithView:")]
        IntPtr Constructor(UIView view);

        // @property (nonatomic) UIView * view;
        [Export("view", ArgumentSemantic.Assign)]
        UIView View { get; set; }
    }

    // @interface GVRVideoRenderer : GVRTextureRenderer
    [BaseType(typeof(GVRTextureRenderer))]
    interface GVRVideoRenderer
    {
        // @property (nonatomic) AVPlayer * player;
        [Export("player", ArgumentSemantic.Assign)]
        AVPlayer Player { get; set; }
    }
}
