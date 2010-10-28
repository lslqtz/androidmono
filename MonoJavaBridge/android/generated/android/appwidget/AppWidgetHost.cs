namespace android.appwidget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AppWidgetHost : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AppWidgetHost(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCreateView2340;
		protected virtual global::android.appwidget.AppWidgetHostView onCreateView(android.content.Context arg0, int arg1, android.appwidget.AppWidgetProviderInfo arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost._onCreateView2340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.appwidget.AppWidgetHostView;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._onCreateView2340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.appwidget.AppWidgetHostView;
		}
		internal static global::MonoJavaBridge.MethodId _createView2341;
		public virtual global::android.appwidget.AppWidgetHostView createView(android.content.Context arg0, int arg1, android.appwidget.AppWidgetProviderInfo arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost._createView2341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.appwidget.AppWidgetHostView;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._createView2341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.appwidget.AppWidgetHostView;
		}
		internal static global::MonoJavaBridge.MethodId _startListening2342;
		public virtual void startListening()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost._startListening2342);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._startListening2342);
		}
		internal static global::MonoJavaBridge.MethodId _stopListening2343;
		public virtual void stopListening()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost._stopListening2343);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._stopListening2343);
		}
		internal static global::MonoJavaBridge.MethodId _allocateAppWidgetId2344;
		public virtual int allocateAppWidgetId()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost._allocateAppWidgetId2344);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._allocateAppWidgetId2344);
		}
		internal static global::MonoJavaBridge.MethodId _deleteAppWidgetId2345;
		public virtual void deleteAppWidgetId(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost._deleteAppWidgetId2345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._deleteAppWidgetId2345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deleteHost2346;
		public virtual void deleteHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost._deleteHost2346);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._deleteHost2346);
		}
		internal static global::MonoJavaBridge.MethodId _deleteAllHosts2347;
		public static void deleteAllHosts()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._deleteAllHosts2347);
		}
		internal static global::MonoJavaBridge.MethodId _onProviderChanged2348;
		protected virtual void onProviderChanged(int arg0, android.appwidget.AppWidgetProviderInfo arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost._onProviderChanged2348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._onProviderChanged2348, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AppWidgetHost2349;
		public AppWidgetHost(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.appwidget.AppWidgetHost.staticClass, global::android.appwidget.AppWidgetHost._AppWidgetHost2349, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AppWidgetHost()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.appwidget.AppWidgetHost.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/appwidget/AppWidgetHost"));
			global::android.appwidget.AppWidgetHost._onCreateView2340 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "onCreateView", "(Landroid/content/Context;ILandroid/appwidget/AppWidgetProviderInfo;)Landroid/appwidget/AppWidgetHostView;");
			global::android.appwidget.AppWidgetHost._createView2341 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "createView", "(Landroid/content/Context;ILandroid/appwidget/AppWidgetProviderInfo;)Landroid/appwidget/AppWidgetHostView;");
			global::android.appwidget.AppWidgetHost._startListening2342 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "startListening", "()V");
			global::android.appwidget.AppWidgetHost._stopListening2343 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "stopListening", "()V");
			global::android.appwidget.AppWidgetHost._allocateAppWidgetId2344 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "allocateAppWidgetId", "()I");
			global::android.appwidget.AppWidgetHost._deleteAppWidgetId2345 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "deleteAppWidgetId", "(I)V");
			global::android.appwidget.AppWidgetHost._deleteHost2346 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "deleteHost", "()V");
			global::android.appwidget.AppWidgetHost._deleteAllHosts2347 = @__env.GetStaticMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "deleteAllHosts", "()V");
			global::android.appwidget.AppWidgetHost._onProviderChanged2348 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "onProviderChanged", "(ILandroid/appwidget/AppWidgetProviderInfo;)V");
			global::android.appwidget.AppWidgetHost._AppWidgetHost2349 = @__env.GetMethodIDNoThrow(global::android.appwidget.AppWidgetHost.staticClass, "<init>", "(Landroid/content/Context;I)V");
		}
		internal static void InitJNI()
		{
		}
	}
}