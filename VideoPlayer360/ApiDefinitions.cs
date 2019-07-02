using System;
using AVFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using SceneKit;
using SpriteKit;
using UIKit;

namespace Swifty360Player
{
	// @interface Swifty360CameraController : NSObject <UIGestureRecognizerDelegate>
	[BaseType (typeof(NSObject), Name = "_TtC15Swifty360Player25Swifty360CameraController")]
	[DisableDefaultCtor]
	interface Swifty360CameraController : IUIGestureRecognizerDelegate
	{
	}

	// @interface Swifty360CameraPanGestureRecognizer : UIPanGestureRecognizer
	[BaseType (typeof(UIPanGestureRecognizer), Name = "_TtC15Swifty360Player35Swifty360CameraPanGestureRecognizer")]
	interface Swifty360CameraPanGestureRecognizer
	{
		// -(instancetype _Nonnull)initWithTarget:(id _Nullable)target action:(SEL _Nullable)action __attribute__((objc_designated_initializer));
		[Export ("initWithTarget:action:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] NSObject target, [NullAllowed] Selector action);
	}

	// @interface Swifty360PlayerScene : SCNScene
	[BaseType (typeof(SCNScene), Name = "_TtC15Swifty360Player20Swifty360PlayerScene")]
	[DisableDefaultCtor]
	interface Swifty360PlayerScene
	{
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export ("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor (NSCoder aDecoder);
	}

	// @interface Swifty360View : UIView
	[BaseType (typeof(UIView), Name = "_TtC15Swifty360Player13Swifty360View")]
	interface Swifty360View
	{
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export ("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor (NSCoder aDecoder);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();
	}

	// @interface Swifty360Player_Swift_230 (Swifty360View) <SCNSceneRendererDelegate>
	[Category]
	[BaseType (typeof(Swifty360View))]
	interface Swifty360View_Swifty360Player_Swift_230 : Swifty360ViewController
    {
		// -(void)renderer:(id<SCNSceneRenderer> _Nonnull)renderer updateAtTime:(NSTimeInterval)time;
		[Export ("renderer:updateAtTime:")]
		void Renderer (SCNSceneRenderer renderer, double time);
	}

	// @interface Swifty360ViewController : UIViewController
	[BaseType (typeof(UIViewController), Name = "_TtC15Swifty360Player23Swifty360ViewController")]
	interface Swifty360ViewController
	{
		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export ("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor (NSCoder aDecoder);

		// -(void)viewDidLoad;
		[Export ("viewDidLoad")]
		void ViewDidLoad ();

		// -(void)viewDidLayoutSubviews;
		[Export ("viewDidLayoutSubviews")]
		void ViewDidLayoutSubviews ();

		// -(void)viewWillAppear:(BOOL)animated;
		[Export ("viewWillAppear:")]
		void ViewWillAppear (bool animated);

		// -(void)viewDidDisappear:(BOOL)animated;
		[Export ("viewDidDisappear:")]
		void ViewDidDisappear (bool animated);

		// -(void)viewWillTransitionToSize:(CGSize)size withTransitionCoordinator:(id<UIViewControllerTransitionCoordinator> _Nonnull)coordinator;
		[Export ("viewWillTransitionToSize:withTransitionCoordinator:")]
		void ViewWillTransitionToSize (CGSize size, IUIViewControllerTransitionCoordinator coordinator);
	}

	// @interface Swifty360Player_Swift_251 (Swifty360ViewController) <SCNSceneRendererDelegate>
	[Category]
	[BaseType (typeof(Swifty360ViewController))]
	interface Swifty360ViewController_Swifty360Player_Swift_251 : Swifty360ViewController
    {
		// -(void)renderer:(id<SCNSceneRenderer> _Nonnull)renderer updateAtTime:(NSTimeInterval)time;
		[Export ("renderer:updateAtTime:")]
		void Renderer (SCNSceneRenderer renderer, double time);
	}

	// @interface SwiftySKVideoNode : SKVideoNode
	[BaseType (typeof(SKVideoNode), Name = "_TtC15Swifty360Player17SwiftySKVideoNode")]
	interface SwiftySKVideoNode
	{
		// -(instancetype _Nonnull)initWithAVPlayer:(AVPlayer * _Nonnull)player __attribute__((objc_designated_initializer));
		[Export ("initWithAVPlayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (AVPlayer player);

		// -(instancetype _Nonnull)initWithFileNamed:(NSString * _Nonnull)videoFile __attribute__((availability(ios, introduced=8.0))) __attribute__((objc_designated_initializer));
		[iOS (8,0)]
		[Export ("initWithFileNamed:")]
		[DesignatedInitializer]
		IntPtr Constructor (string videoFile);

		// -(instancetype _Nonnull)initWithURL:(NSURL * _Nonnull)url __attribute__((availability(ios, introduced=8.0))) __attribute__((objc_designated_initializer));
		[iOS (8,0)]
		[Export ("initWithURL:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSUrl url);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		//[Export ("initWithCoder:")]
		//[DesignatedInitializer]
		//IntPtr Constructor (NSCoder aDecoder);
	}

    // @interface VRVideoView : UIViewController
    [BaseType(typeof(UIViewController),Name = "_TtC12VRVideoSwift11VRVideoView")]
    interface VRVideoView
    {
        // -(instancetype _Nonnull)initWithShow:(NSURL * _Nonnull)url in:(CGRect)frame autoPlay:(BOOL)autoPlay __attribute__((objc_designated_initializer));
        [Export("initWithShow:in:autoPlay:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSUrl url, CGRect frame, bool autoPlay);

        // -(void)viewDidLoad;
        [Export("viewDidLoad")]
        void ViewDidLoad();

        // -(void)viewDidLayoutSubviews;
        [Export("viewDidLayoutSubviews")]
        void ViewDidLayoutSubviews();

        // -(BOOL)shouldHideTransitionView __attribute__((warn_unused_result));
        [Export("shouldHideTransitionView")]
        bool ShouldHideTransitionView { get; }

        // -(void)viewWillAppear:(BOOL)animated;
        [Export("viewWillAppear:")]
        void ViewWillAppear(bool animated);

        // -(void)play;
        [Export("play")]
        void Play();

        // -(void)pause;
        [Export("pause")]
        void Pause();

        // -(void)rotateBy:(float)angle;
        [Export("rotateBy:")]
        void RotateBy(float angle);
    }
}
