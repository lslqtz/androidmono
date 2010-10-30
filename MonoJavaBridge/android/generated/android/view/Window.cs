namespace android.view
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.Window_))]
	public abstract partial class Window : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Window(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.Window.Callback_))]
		public partial interface Callback  : global::MonoJavaBridge.IJavaObject 
		{
			void onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0);
			void onContentChanged();
			void onWindowFocusChanged(bool arg0);
			void onAttachedToWindow();
			void onDetachedFromWindow();
			bool dispatchKeyEvent(android.view.KeyEvent arg0);
			bool dispatchTouchEvent(android.view.MotionEvent arg0);
			bool dispatchTrackballEvent(android.view.MotionEvent arg0);
			bool dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0);
			global::android.view.View onCreatePanelView(int arg0);
			bool onCreatePanelMenu(int arg0, android.view.Menu arg1);
			bool onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2);
			bool onMenuOpened(int arg0, android.view.Menu arg1);
			bool onMenuItemSelected(int arg0, android.view.MenuItem arg1);
			void onPanelClosed(int arg0, android.view.Menu arg1);
			bool onSearchRequested();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.Window.Callback))]
		internal sealed partial class Callback_ : java.lang.Object, Callback
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Callback_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onWindowAttributesChanged15243;
			void android.view.Window.Callback.onWindowAttributesChanged(android.view.WindowManager_LayoutParams arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Window.Callback_._onWindowAttributesChanged15243.native == global::System.IntPtr.Zero)
					global::android.view.Window.Callback_._onWindowAttributesChanged15243 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onWindowAttributesChanged", "(Landroid/view/WindowManager$LayoutParams;)V");
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onWindowAttributesChanged15243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onContentChanged15244;
			void android.view.Window.Callback.onContentChanged()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Window.Callback_._onContentChanged15244.native == global::System.IntPtr.Zero)
					global::android.view.Window.Callback_._onContentChanged15244 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onContentChanged", "()V");
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onContentChanged15244);
			}
			internal static global::MonoJavaBridge.MethodId _onWindowFocusChanged15245;
			void android.view.Window.Callback.onWindowFocusChanged(bool arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Window.Callback_._onWindowFocusChanged15245.native == global::System.IntPtr.Zero)
					global::android.view.Window.Callback_._onWindowFocusChanged15245 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onWindowFocusChanged", "(Z)V");
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onWindowFocusChanged15245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onAttachedToWindow15246;
			void android.view.Window.Callback.onAttachedToWindow()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Window.Callback_._onAttachedToWindow15246.native == global::System.IntPtr.Zero)
					global::android.view.Window.Callback_._onAttachedToWindow15246 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onAttachedToWindow", "()V");
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onAttachedToWindow15246);
			}
			internal static global::MonoJavaBridge.MethodId _onDetachedFromWindow15247;
			void android.view.Window.Callback.onDetachedFromWindow()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Window.Callback_._onDetachedFromWindow15247.native == global::System.IntPtr.Zero)
					global::android.view.Window.Callback_._onDetachedFromWindow15247 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onDetachedFromWindow", "()V");
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onDetachedFromWindow15247);
			}
			internal static global::MonoJavaBridge.MethodId _dispatchKeyEvent15248;
			bool android.view.Window.Callback.dispatchKeyEvent(android.view.KeyEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Window.Callback_._dispatchKeyEvent15248.native == global::System.IntPtr.Zero)
					global::android.view.Window.Callback_._dispatchKeyEvent15248 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "dispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._dispatchKeyEvent15248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchTouchEvent15249;
			bool android.view.Window.Callback.dispatchTouchEvent(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Window.Callback_._dispatchTouchEvent15249.native == global::System.IntPtr.Zero)
					global::android.view.Window.Callback_._dispatchTouchEvent15249 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "dispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._dispatchTouchEvent15249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchTrackballEvent15250;
			bool android.view.Window.Callback.dispatchTrackballEvent(android.view.MotionEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Window.Callback_._dispatchTrackballEvent15250.native == global::System.IntPtr.Zero)
					global::android.view.Window.Callback_._dispatchTrackballEvent15250 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "dispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._dispatchTrackballEvent15250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _dispatchPopulateAccessibilityEvent15251;
			bool android.view.Window.Callback.dispatchPopulateAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Window.Callback_._dispatchPopulateAccessibilityEvent15251.native == global::System.IntPtr.Zero)
					global::android.view.Window.Callback_._dispatchPopulateAccessibilityEvent15251 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "dispatchPopulateAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)Z");
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._dispatchPopulateAccessibilityEvent15251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _onCreatePanelView15252;
			global::android.view.View android.view.Window.Callback.onCreatePanelView(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Window.Callback_._onCreatePanelView15252.native == global::System.IntPtr.Zero)
					global::android.view.Window.Callback_._onCreatePanelView15252 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onCreatePanelView", "(I)Landroid/view/View;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window.Callback_._onCreatePanelView15252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.View;
			}
			internal static global::MonoJavaBridge.MethodId _onCreatePanelMenu15253;
			bool android.view.Window.Callback.onCreatePanelMenu(int arg0, android.view.Menu arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Window.Callback_._onCreatePanelMenu15253.native == global::System.IntPtr.Zero)
					global::android.view.Window.Callback_._onCreatePanelMenu15253 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onCreatePanelMenu", "(ILandroid/view/Menu;)Z");
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onCreatePanelMenu15253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onPreparePanel15254;
			bool android.view.Window.Callback.onPreparePanel(int arg0, android.view.View arg1, android.view.Menu arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Window.Callback_._onPreparePanel15254.native == global::System.IntPtr.Zero)
					global::android.view.Window.Callback_._onPreparePanel15254 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onPreparePanel", "(ILandroid/view/View;Landroid/view/Menu;)Z");
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onPreparePanel15254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _onMenuOpened15255;
			bool android.view.Window.Callback.onMenuOpened(int arg0, android.view.Menu arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Window.Callback_._onMenuOpened15255.native == global::System.IntPtr.Zero)
					global::android.view.Window.Callback_._onMenuOpened15255 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onMenuOpened", "(ILandroid/view/Menu;)Z");
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onMenuOpened15255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onMenuItemSelected15256;
			bool android.view.Window.Callback.onMenuItemSelected(int arg0, android.view.MenuItem arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Window.Callback_._onMenuItemSelected15256.native == global::System.IntPtr.Zero)
					global::android.view.Window.Callback_._onMenuItemSelected15256 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onMenuItemSelected", "(ILandroid/view/MenuItem;)Z");
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onMenuItemSelected15256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onPanelClosed15257;
			void android.view.Window.Callback.onPanelClosed(int arg0, android.view.Menu arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Window.Callback_._onPanelClosed15257.native == global::System.IntPtr.Zero)
					global::android.view.Window.Callback_._onPanelClosed15257 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onPanelClosed", "(ILandroid/view/Menu;)V");
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window.Callback_._onPanelClosed15257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onSearchRequested15258;
			bool android.view.Window.Callback.onSearchRequested()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.Window.Callback_._onSearchRequested15258.native == global::System.IntPtr.Zero)
					global::android.view.Window.Callback_._onSearchRequested15258 = @__env.GetMethodIDNoThrow(global::android.view.Window.Callback_.staticClass, "onSearchRequested", "()Z");
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window.Callback_._onSearchRequested15258);
			}
			static Callback_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.Window.Callback_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Window$Callback"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext15259;
		public virtual global::android.content.Context getContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._getContext15259.native == global::System.IntPtr.Zero)
				global::android.view.Window._getContext15259 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getContext", "()Landroid/content/Context;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.Window.staticClass, global::android.view.Window._getContext15259) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _getAttributes15260;
		public virtual global::android.view.WindowManager_LayoutParams getAttributes()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._getAttributes15260.native == global::System.IntPtr.Zero)
				global::android.view.Window._getAttributes15260 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getAttributes", "()Landroid/view/WindowManager$LayoutParams;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.Window.staticClass, global::android.view.Window._getAttributes15260) as android.view.WindowManager_LayoutParams;
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged15261;
		public abstract void onConfigurationChanged(android.content.res.Configuration arg0);
		internal static global::MonoJavaBridge.MethodId _setType15262;
		public virtual void setType(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._setType15262.native == global::System.IntPtr.Zero)
				global::android.view.Window._setType15262 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setType", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setType15262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFlags15263;
		public virtual void setFlags(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._setFlags15263.native == global::System.IntPtr.Zero)
				global::android.view.Window._setFlags15263 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFlags", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setFlags15263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addFlags15264;
		public virtual void addFlags(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._addFlags15264.native == global::System.IntPtr.Zero)
				global::android.view.Window._addFlags15264 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "addFlags", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._addFlags15264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCallback15265;
		public virtual void setCallback(android.view.Window.Callback arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._setCallback15265.native == global::System.IntPtr.Zero)
				global::android.view.Window._setCallback15265 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setCallback", "(Landroid/view/Window$Callback;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setCallback15265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getWindowManager15266;
		public virtual global::android.view.WindowManager getWindowManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._getWindowManager15266.native == global::System.IntPtr.Zero)
				global::android.view.Window._getWindowManager15266 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getWindowManager", "()Landroid/view/WindowManager;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.WindowManager>(this, global::android.view.Window.staticClass, global::android.view.Window._getWindowManager15266) as android.view.WindowManager;
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentFocus15267;
		public abstract global::android.view.View getCurrentFocus();
		internal static global::MonoJavaBridge.MethodId _findViewById15268;
		public virtual global::android.view.View findViewById(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._findViewById15268.native == global::System.IntPtr.Zero)
				global::android.view.Window._findViewById15268 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "findViewById", "(I)Landroid/view/View;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.Window.staticClass, global::android.view.Window._findViewById15268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setContentView15269;
		public abstract void setContentView(int arg0);
		internal static global::MonoJavaBridge.MethodId _setContentView15270;
		public abstract void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		internal static global::MonoJavaBridge.MethodId _setContentView15271;
		public abstract void setContentView(android.view.View arg0);
		internal static global::MonoJavaBridge.MethodId _addContentView15272;
		public abstract void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1);
		internal static global::MonoJavaBridge.MethodId _takeKeyEvents15273;
		public abstract void takeKeyEvents(bool arg0);
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableResource15274;
		public abstract void setFeatureDrawableResource(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableUri15275;
		public abstract void setFeatureDrawableUri(int arg0, android.net.Uri arg1);
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawable15276;
		public abstract void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1);
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableAlpha15277;
		public abstract void setFeatureDrawableAlpha(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _getLayoutInflater15278;
		public abstract global::android.view.LayoutInflater getLayoutInflater();
		internal static global::MonoJavaBridge.MethodId _setTitle15279;
		public abstract void setTitle(java.lang.CharSequence arg0);
		internal static global::MonoJavaBridge.MethodId _setTitleColor15280;
		public abstract void setTitleColor(int arg0);
		internal static global::MonoJavaBridge.MethodId _setVolumeControlStream15281;
		public abstract void setVolumeControlStream(int arg0);
		internal static global::MonoJavaBridge.MethodId _getVolumeControlStream15282;
		public abstract int getVolumeControlStream();
		internal static global::MonoJavaBridge.MethodId _getWindowStyle15283;
		public virtual global::android.content.res.TypedArray getWindowStyle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._getWindowStyle15283.native == global::System.IntPtr.Zero)
				global::android.view.Window._getWindowStyle15283 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getWindowStyle", "()Landroid/content/res/TypedArray;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.Window.staticClass, global::android.view.Window._getWindowStyle15283) as android.content.res.TypedArray;
		}
		internal static global::MonoJavaBridge.MethodId _setContainer15284;
		public virtual void setContainer(android.view.Window arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._setContainer15284.native == global::System.IntPtr.Zero)
				global::android.view.Window._setContainer15284 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setContainer", "(Landroid/view/Window;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setContainer15284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getContainer15285;
		public virtual global::android.view.Window getContainer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._getContainer15285.native == global::System.IntPtr.Zero)
				global::android.view.Window._getContainer15285 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getContainer", "()Landroid/view/Window;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.Window.staticClass, global::android.view.Window._getContainer15285) as android.view.Window;
		}
		internal static global::MonoJavaBridge.MethodId _hasChildren15286;
		public virtual bool hasChildren()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._hasChildren15286.native == global::System.IntPtr.Zero)
				global::android.view.Window._hasChildren15286 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "hasChildren", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window.staticClass, global::android.view.Window._hasChildren15286);
		}
		internal static global::MonoJavaBridge.MethodId _setWindowManager15287;
		public virtual void setWindowManager(android.view.WindowManager arg0, android.os.IBinder arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._setWindowManager15287.native == global::System.IntPtr.Zero)
				global::android.view.Window._setWindowManager15287 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setWindowManager", "(Landroid/view/WindowManager;Landroid/os/IBinder;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setWindowManager15287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getCallback15288;
		public virtual global::android.view.Window.Callback getCallback()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._getCallback15288.native == global::System.IntPtr.Zero)
				global::android.view.Window._getCallback15288 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getCallback", "()Landroid/view/Window$Callback;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.Window.Callback>(this, global::android.view.Window.staticClass, global::android.view.Window._getCallback15288) as android.view.Window.Callback;
		}
		internal static global::MonoJavaBridge.MethodId _isFloating15289;
		public abstract bool isFloating();
		internal static global::MonoJavaBridge.MethodId _setLayout15290;
		public virtual void setLayout(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._setLayout15290.native == global::System.IntPtr.Zero)
				global::android.view.Window._setLayout15290 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setLayout", "(II)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setLayout15290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setGravity15291;
		public virtual void setGravity(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._setGravity15291.native == global::System.IntPtr.Zero)
				global::android.view.Window._setGravity15291 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setGravity", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setGravity15291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFormat15292;
		public virtual void setFormat(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._setFormat15292.native == global::System.IntPtr.Zero)
				global::android.view.Window._setFormat15292 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setFormat", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setFormat15292, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setWindowAnimations15293;
		public virtual void setWindowAnimations(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._setWindowAnimations15293.native == global::System.IntPtr.Zero)
				global::android.view.Window._setWindowAnimations15293 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setWindowAnimations", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setWindowAnimations15293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSoftInputMode15294;
		public virtual void setSoftInputMode(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._setSoftInputMode15294.native == global::System.IntPtr.Zero)
				global::android.view.Window._setSoftInputMode15294 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setSoftInputMode", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setSoftInputMode15294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearFlags15295;
		public virtual void clearFlags(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._clearFlags15295.native == global::System.IntPtr.Zero)
				global::android.view.Window._clearFlags15295 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "clearFlags", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._clearFlags15295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAttributes15296;
		public virtual void setAttributes(android.view.WindowManager_LayoutParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._setAttributes15296.native == global::System.IntPtr.Zero)
				global::android.view.Window._setAttributes15296 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setAttributes", "(Landroid/view/WindowManager$LayoutParams;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setAttributes15296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getForcedWindowFlags15297;
		protected virtual int getForcedWindowFlags()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._getForcedWindowFlags15297.native == global::System.IntPtr.Zero)
				global::android.view.Window._getForcedWindowFlags15297 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getForcedWindowFlags", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Window.staticClass, global::android.view.Window._getForcedWindowFlags15297);
		}
		internal static global::MonoJavaBridge.MethodId _hasSoftInputMode15298;
		protected virtual bool hasSoftInputMode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._hasSoftInputMode15298.native == global::System.IntPtr.Zero)
				global::android.view.Window._hasSoftInputMode15298 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "hasSoftInputMode", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window.staticClass, global::android.view.Window._hasSoftInputMode15298);
		}
		internal static global::MonoJavaBridge.MethodId _requestFeature15299;
		public virtual bool requestFeature(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._requestFeature15299.native == global::System.IntPtr.Zero)
				global::android.view.Window._requestFeature15299 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "requestFeature", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window.staticClass, global::android.view.Window._requestFeature15299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _makeActive15300;
		public virtual void makeActive()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._makeActive15300.native == global::System.IntPtr.Zero)
				global::android.view.Window._makeActive15300 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "makeActive", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._makeActive15300);
		}
		internal static global::MonoJavaBridge.MethodId _isActive15301;
		public virtual bool isActive()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._isActive15301.native == global::System.IntPtr.Zero)
				global::android.view.Window._isActive15301 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "isActive", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.Window.staticClass, global::android.view.Window._isActive15301);
		}
		internal static global::MonoJavaBridge.MethodId _openPanel15302;
		public abstract void openPanel(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _closePanel15303;
		public abstract void closePanel(int arg0);
		internal static global::MonoJavaBridge.MethodId _togglePanel15304;
		public abstract void togglePanel(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _performPanelShortcut15305;
		public abstract bool performPanelShortcut(int arg0, int arg1, android.view.KeyEvent arg2, int arg3);
		internal static global::MonoJavaBridge.MethodId _performPanelIdentifierAction15306;
		public abstract bool performPanelIdentifierAction(int arg0, int arg1, int arg2);
		internal static global::MonoJavaBridge.MethodId _closeAllPanels15307;
		public abstract void closeAllPanels();
		internal static global::MonoJavaBridge.MethodId _performContextMenuIdentifierAction15308;
		public abstract bool performContextMenuIdentifierAction(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawableResource15309;
		public virtual void setBackgroundDrawableResource(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._setBackgroundDrawableResource15309.native == global::System.IntPtr.Zero)
				global::android.view.Window._setBackgroundDrawableResource15309 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setBackgroundDrawableResource", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setBackgroundDrawableResource15309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable15310;
		public abstract void setBackgroundDrawable(android.graphics.drawable.Drawable arg0);
		internal static global::MonoJavaBridge.MethodId _setFeatureInt15311;
		public abstract void setFeatureInt(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _superDispatchKeyEvent15312;
		public abstract bool superDispatchKeyEvent(android.view.KeyEvent arg0);
		internal static global::MonoJavaBridge.MethodId _superDispatchTouchEvent15313;
		public abstract bool superDispatchTouchEvent(android.view.MotionEvent arg0);
		internal static global::MonoJavaBridge.MethodId _superDispatchTrackballEvent15314;
		public abstract bool superDispatchTrackballEvent(android.view.MotionEvent arg0);
		internal static global::MonoJavaBridge.MethodId _getDecorView15315;
		public abstract global::android.view.View getDecorView();
		internal static global::MonoJavaBridge.MethodId _peekDecorView15316;
		public abstract global::android.view.View peekDecorView();
		internal static global::MonoJavaBridge.MethodId _saveHierarchyState15317;
		public abstract global::android.os.Bundle saveHierarchyState();
		internal static global::MonoJavaBridge.MethodId _restoreHierarchyState15318;
		public abstract void restoreHierarchyState(android.os.Bundle arg0);
		internal static global::MonoJavaBridge.MethodId _onActive15319;
		protected abstract void onActive();
		internal static global::MonoJavaBridge.MethodId _getFeatures15320;
		protected virtual int getFeatures()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._getFeatures15320.native == global::System.IntPtr.Zero)
				global::android.view.Window._getFeatures15320 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getFeatures", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Window.staticClass, global::android.view.Window._getFeatures15320);
		}
		internal static global::MonoJavaBridge.MethodId _getLocalFeatures15321;
		protected virtual int getLocalFeatures()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._getLocalFeatures15321.native == global::System.IntPtr.Zero)
				global::android.view.Window._getLocalFeatures15321 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "getLocalFeatures", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.Window.staticClass, global::android.view.Window._getLocalFeatures15321);
		}
		internal static global::MonoJavaBridge.MethodId _setDefaultWindowFormat15322;
		protected virtual void setDefaultWindowFormat(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._setDefaultWindowFormat15322.native == global::System.IntPtr.Zero)
				global::android.view.Window._setDefaultWindowFormat15322 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "setDefaultWindowFormat", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.Window.staticClass, global::android.view.Window._setDefaultWindowFormat15322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setChildDrawable15323;
		public abstract void setChildDrawable(int arg0, android.graphics.drawable.Drawable arg1);
		internal static global::MonoJavaBridge.MethodId _setChildInt15324;
		public abstract void setChildInt(int arg0, int arg1);
		internal static global::MonoJavaBridge.MethodId _isShortcutKey15325;
		public abstract bool isShortcutKey(int arg0, android.view.KeyEvent arg1);
		internal static global::MonoJavaBridge.MethodId _Window15326;
		public Window(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window._Window15326.native == global::System.IntPtr.Zero)
				global::android.view.Window._Window15326 = @__env.GetMethodIDNoThrow(global::android.view.Window.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.Window.staticClass, global::android.view.Window._Window15326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int FEATURE_OPTIONS_PANEL
		{
			get
			{
				return 0;
			}
		}
		public static int FEATURE_NO_TITLE
		{
			get
			{
				return 1;
			}
		}
		public static int FEATURE_PROGRESS
		{
			get
			{
				return 2;
			}
		}
		public static int FEATURE_LEFT_ICON
		{
			get
			{
				return 3;
			}
		}
		public static int FEATURE_RIGHT_ICON
		{
			get
			{
				return 4;
			}
		}
		public static int FEATURE_INDETERMINATE_PROGRESS
		{
			get
			{
				return 5;
			}
		}
		public static int FEATURE_CONTEXT_MENU
		{
			get
			{
				return 6;
			}
		}
		public static int FEATURE_CUSTOM_TITLE
		{
			get
			{
				return 7;
			}
		}
		public static int PROGRESS_VISIBILITY_ON
		{
			get
			{
				return -1;
			}
		}
		public static int PROGRESS_VISIBILITY_OFF
		{
			get
			{
				return -2;
			}
		}
		public static int PROGRESS_INDETERMINATE_ON
		{
			get
			{
				return -3;
			}
		}
		public static int PROGRESS_INDETERMINATE_OFF
		{
			get
			{
				return -4;
			}
		}
		public static int PROGRESS_START
		{
			get
			{
				return 0;
			}
		}
		public static int PROGRESS_END
		{
			get
			{
				return 10000;
			}
		}
		public static int PROGRESS_SECONDARY_START
		{
			get
			{
				return 20000;
			}
		}
		public static int PROGRESS_SECONDARY_END
		{
			get
			{
				return 30000;
			}
		}
		public static int ID_ANDROID_CONTENT
		{
			get
			{
				return 16908290;
			}
		}
		static Window()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.Window.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Window"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.Window))]
	internal sealed partial class Window_ : android.view.Window
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Window_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onConfigurationChanged15344;
		public override void onConfigurationChanged(android.content.res.Configuration arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._onConfigurationChanged15344.native == global::System.IntPtr.Zero)
				global::android.view.Window_._onConfigurationChanged15344 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._onConfigurationChanged15344, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getCurrentFocus15345;
		public override global::android.view.View getCurrentFocus()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._getCurrentFocus15345.native == global::System.IntPtr.Zero)
				global::android.view.Window_._getCurrentFocus15345 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "getCurrentFocus", "()Landroid/view/View;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._getCurrentFocus15345)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _setContentView15346;
		public override void setContentView(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._setContentView15346.native == global::System.IntPtr.Zero)
				global::android.view.Window_._setContentView15346 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setContentView", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setContentView15346, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView15347;
		public override void setContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._setContentView15347.native == global::System.IntPtr.Zero)
				global::android.view.Window_._setContentView15347 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setContentView15347, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setContentView15348;
		public override void setContentView(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._setContentView15348.native == global::System.IntPtr.Zero)
				global::android.view.Window_._setContentView15348 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setContentView", "(Landroid/view/View;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setContentView15348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addContentView15349;
		public override void addContentView(android.view.View arg0, android.view.ViewGroup.LayoutParams arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._addContentView15349.native == global::System.IntPtr.Zero)
				global::android.view.Window_._addContentView15349 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "addContentView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._addContentView15349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _takeKeyEvents15350;
		public override void takeKeyEvents(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._takeKeyEvents15350.native == global::System.IntPtr.Zero)
				global::android.view.Window_._takeKeyEvents15350 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "takeKeyEvents", "(Z)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._takeKeyEvents15350, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableResource15351;
		public override void setFeatureDrawableResource(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._setFeatureDrawableResource15351.native == global::System.IntPtr.Zero)
				global::android.view.Window_._setFeatureDrawableResource15351 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureDrawableResource", "(II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureDrawableResource15351, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableUri15352;
		public override void setFeatureDrawableUri(int arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._setFeatureDrawableUri15352.native == global::System.IntPtr.Zero)
				global::android.view.Window_._setFeatureDrawableUri15352 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureDrawableUri", "(ILandroid/net/Uri;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureDrawableUri15352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawable15353;
		public override void setFeatureDrawable(int arg0, android.graphics.drawable.Drawable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._setFeatureDrawable15353.native == global::System.IntPtr.Zero)
				global::android.view.Window_._setFeatureDrawable15353 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureDrawable15353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureDrawableAlpha15354;
		public override void setFeatureDrawableAlpha(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._setFeatureDrawableAlpha15354.native == global::System.IntPtr.Zero)
				global::android.view.Window_._setFeatureDrawableAlpha15354 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureDrawableAlpha", "(II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureDrawableAlpha15354, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutInflater15355;
		public override global::android.view.LayoutInflater getLayoutInflater()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._getLayoutInflater15355.native == global::System.IntPtr.Zero)
				global::android.view.Window_._getLayoutInflater15355 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "getLayoutInflater", "()Landroid/view/LayoutInflater;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._getLayoutInflater15355)) as android.view.LayoutInflater;
		}
		internal static global::MonoJavaBridge.MethodId _setTitle15356;
		public override void setTitle(java.lang.CharSequence arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._setTitle15356.native == global::System.IntPtr.Zero)
				global::android.view.Window_._setTitle15356 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setTitle", "(Ljava/lang/CharSequence;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setTitle15356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setTitle(string arg0)
		{
			setTitle((global::java.lang.CharSequence)(global::java.lang.String)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _setTitleColor15357;
		public override void setTitleColor(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._setTitleColor15357.native == global::System.IntPtr.Zero)
				global::android.view.Window_._setTitleColor15357 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setTitleColor", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setTitleColor15357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVolumeControlStream15358;
		public override void setVolumeControlStream(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._setVolumeControlStream15358.native == global::System.IntPtr.Zero)
				global::android.view.Window_._setVolumeControlStream15358 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setVolumeControlStream", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setVolumeControlStream15358, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getVolumeControlStream15359;
		public override int getVolumeControlStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._getVolumeControlStream15359.native == global::System.IntPtr.Zero)
				global::android.view.Window_._getVolumeControlStream15359 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "getVolumeControlStream", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.view.Window_._getVolumeControlStream15359);
		}
		internal static global::MonoJavaBridge.MethodId _isFloating15360;
		public override bool isFloating()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._isFloating15360.native == global::System.IntPtr.Zero)
				global::android.view.Window_._isFloating15360 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "isFloating", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._isFloating15360);
		}
		internal static global::MonoJavaBridge.MethodId _openPanel15361;
		public override void openPanel(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._openPanel15361.native == global::System.IntPtr.Zero)
				global::android.view.Window_._openPanel15361 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "openPanel", "(ILandroid/view/KeyEvent;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._openPanel15361, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _closePanel15362;
		public override void closePanel(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._closePanel15362.native == global::System.IntPtr.Zero)
				global::android.view.Window_._closePanel15362 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "closePanel", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._closePanel15362, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _togglePanel15363;
		public override void togglePanel(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._togglePanel15363.native == global::System.IntPtr.Zero)
				global::android.view.Window_._togglePanel15363 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "togglePanel", "(ILandroid/view/KeyEvent;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._togglePanel15363, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _performPanelShortcut15364;
		public override bool performPanelShortcut(int arg0, int arg1, android.view.KeyEvent arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._performPanelShortcut15364.native == global::System.IntPtr.Zero)
				global::android.view.Window_._performPanelShortcut15364 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "performPanelShortcut", "(IILandroid/view/KeyEvent;I)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._performPanelShortcut15364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _performPanelIdentifierAction15365;
		public override bool performPanelIdentifierAction(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._performPanelIdentifierAction15365.native == global::System.IntPtr.Zero)
				global::android.view.Window_._performPanelIdentifierAction15365 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "performPanelIdentifierAction", "(III)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._performPanelIdentifierAction15365, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _closeAllPanels15366;
		public override void closeAllPanels()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._closeAllPanels15366.native == global::System.IntPtr.Zero)
				global::android.view.Window_._closeAllPanels15366 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "closeAllPanels", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._closeAllPanels15366);
		}
		internal static global::MonoJavaBridge.MethodId _performContextMenuIdentifierAction15367;
		public override bool performContextMenuIdentifierAction(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._performContextMenuIdentifierAction15367.native == global::System.IntPtr.Zero)
				global::android.view.Window_._performContextMenuIdentifierAction15367 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "performContextMenuIdentifierAction", "(II)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._performContextMenuIdentifierAction15367, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBackgroundDrawable15368;
		public override void setBackgroundDrawable(android.graphics.drawable.Drawable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._setBackgroundDrawable15368.native == global::System.IntPtr.Zero)
				global::android.view.Window_._setBackgroundDrawable15368 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setBackgroundDrawable15368, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setFeatureInt15369;
		public override void setFeatureInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._setFeatureInt15369.native == global::System.IntPtr.Zero)
				global::android.view.Window_._setFeatureInt15369 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setFeatureInt", "(II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setFeatureInt15369, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _superDispatchKeyEvent15370;
		public override bool superDispatchKeyEvent(android.view.KeyEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._superDispatchKeyEvent15370.native == global::System.IntPtr.Zero)
				global::android.view.Window_._superDispatchKeyEvent15370 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "superDispatchKeyEvent", "(Landroid/view/KeyEvent;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._superDispatchKeyEvent15370, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _superDispatchTouchEvent15371;
		public override bool superDispatchTouchEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._superDispatchTouchEvent15371.native == global::System.IntPtr.Zero)
				global::android.view.Window_._superDispatchTouchEvent15371 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "superDispatchTouchEvent", "(Landroid/view/MotionEvent;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._superDispatchTouchEvent15371, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _superDispatchTrackballEvent15372;
		public override bool superDispatchTrackballEvent(android.view.MotionEvent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._superDispatchTrackballEvent15372.native == global::System.IntPtr.Zero)
				global::android.view.Window_._superDispatchTrackballEvent15372 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "superDispatchTrackballEvent", "(Landroid/view/MotionEvent;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._superDispatchTrackballEvent15372, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDecorView15373;
		public override global::android.view.View getDecorView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._getDecorView15373.native == global::System.IntPtr.Zero)
				global::android.view.Window_._getDecorView15373 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "getDecorView", "()Landroid/view/View;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._getDecorView15373)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _peekDecorView15374;
		public override global::android.view.View peekDecorView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._peekDecorView15374.native == global::System.IntPtr.Zero)
				global::android.view.Window_._peekDecorView15374 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "peekDecorView", "()Landroid/view/View;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._peekDecorView15374)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _saveHierarchyState15375;
		public override global::android.os.Bundle saveHierarchyState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._saveHierarchyState15375.native == global::System.IntPtr.Zero)
				global::android.view.Window_._saveHierarchyState15375 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "saveHierarchyState", "()Landroid/os/Bundle;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.Window_._saveHierarchyState15375)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _restoreHierarchyState15376;
		public override void restoreHierarchyState(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._restoreHierarchyState15376.native == global::System.IntPtr.Zero)
				global::android.view.Window_._restoreHierarchyState15376 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "restoreHierarchyState", "(Landroid/os/Bundle;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._restoreHierarchyState15376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onActive15377;
		protected override void onActive()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._onActive15377.native == global::System.IntPtr.Zero)
				global::android.view.Window_._onActive15377 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "onActive", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._onActive15377);
		}
		internal static global::MonoJavaBridge.MethodId _setChildDrawable15378;
		public override void setChildDrawable(int arg0, android.graphics.drawable.Drawable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._setChildDrawable15378.native == global::System.IntPtr.Zero)
				global::android.view.Window_._setChildDrawable15378 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setChildDrawable", "(ILandroid/graphics/drawable/Drawable;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setChildDrawable15378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setChildInt15379;
		public override void setChildInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._setChildInt15379.native == global::System.IntPtr.Zero)
				global::android.view.Window_._setChildInt15379 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "setChildInt", "(II)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.view.Window_._setChildInt15379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isShortcutKey15380;
		public override bool isShortcutKey(int arg0, android.view.KeyEvent arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.Window_._isShortcutKey15380.native == global::System.IntPtr.Zero)
				global::android.view.Window_._isShortcutKey15380 = @__env.GetMethodIDNoThrow(global::android.view.Window_.staticClass, "isShortcutKey", "(ILandroid/view/KeyEvent;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.Window_._isShortcutKey15380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static Window_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.Window_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/Window"));
		}
		internal static void InitJNI()
		{
		}
	}
}
