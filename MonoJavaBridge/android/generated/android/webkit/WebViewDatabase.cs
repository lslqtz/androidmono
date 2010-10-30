namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class WebViewDatabase : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected WebViewDatabase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInstance16460;
		public static global::android.webkit.WebViewDatabase getInstance(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebViewDatabase._getInstance16460.native == global::System.IntPtr.Zero)
				global::android.webkit.WebViewDatabase._getInstance16460 = @__env.GetStaticMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "getInstance", "(Landroid/content/Context;)Landroid/webkit/WebViewDatabase;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._getInstance16460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.webkit.WebViewDatabase;
		}
		internal static global::MonoJavaBridge.MethodId _clearFormData16461;
		public virtual void clearFormData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebViewDatabase._clearFormData16461.native == global::System.IntPtr.Zero)
				global::android.webkit.WebViewDatabase._clearFormData16461 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "clearFormData", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._clearFormData16461);
		}
		internal static global::MonoJavaBridge.MethodId _hasUsernamePassword16462;
		public virtual bool hasUsernamePassword()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebViewDatabase._hasUsernamePassword16462.native == global::System.IntPtr.Zero)
				global::android.webkit.WebViewDatabase._hasUsernamePassword16462 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "hasUsernamePassword", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._hasUsernamePassword16462);
		}
		internal static global::MonoJavaBridge.MethodId _clearUsernamePassword16463;
		public virtual void clearUsernamePassword()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebViewDatabase._clearUsernamePassword16463.native == global::System.IntPtr.Zero)
				global::android.webkit.WebViewDatabase._clearUsernamePassword16463 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "clearUsernamePassword", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._clearUsernamePassword16463);
		}
		internal static global::MonoJavaBridge.MethodId _hasHttpAuthUsernamePassword16464;
		public virtual bool hasHttpAuthUsernamePassword()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebViewDatabase._hasHttpAuthUsernamePassword16464.native == global::System.IntPtr.Zero)
				global::android.webkit.WebViewDatabase._hasHttpAuthUsernamePassword16464 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "hasHttpAuthUsernamePassword", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._hasHttpAuthUsernamePassword16464);
		}
		internal static global::MonoJavaBridge.MethodId _clearHttpAuthUsernamePassword16465;
		public virtual void clearHttpAuthUsernamePassword()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebViewDatabase._clearHttpAuthUsernamePassword16465.native == global::System.IntPtr.Zero)
				global::android.webkit.WebViewDatabase._clearHttpAuthUsernamePassword16465 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "clearHttpAuthUsernamePassword", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._clearHttpAuthUsernamePassword16465);
		}
		internal static global::MonoJavaBridge.MethodId _hasFormData16466;
		public virtual bool hasFormData()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.WebViewDatabase._hasFormData16466.native == global::System.IntPtr.Zero)
				global::android.webkit.WebViewDatabase._hasFormData16466 = @__env.GetMethodIDNoThrow(global::android.webkit.WebViewDatabase.staticClass, "hasFormData", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.webkit.WebViewDatabase.staticClass, global::android.webkit.WebViewDatabase._hasFormData16466);
		}
		static WebViewDatabase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.WebViewDatabase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/WebViewDatabase"));
		}
		internal static void InitJNI()
		{
		}
	}
}
