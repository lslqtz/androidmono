namespace android.webkit
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JsResult : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JsResult(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _cancel16056;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.JsResult._cancel16056.native == global::System.IntPtr.Zero)
				global::android.webkit.JsResult._cancel16056 = @__env.GetMethodIDNoThrow(global::android.webkit.JsResult.staticClass, "cancel", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.JsResult.staticClass, global::android.webkit.JsResult._cancel16056);
		}
		internal static global::MonoJavaBridge.MethodId _confirm16057;
		public virtual void confirm()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.JsResult._confirm16057.native == global::System.IntPtr.Zero)
				global::android.webkit.JsResult._confirm16057 = @__env.GetMethodIDNoThrow(global::android.webkit.JsResult.staticClass, "confirm", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.JsResult.staticClass, global::android.webkit.JsResult._confirm16057);
		}
		internal static global::MonoJavaBridge.MethodId _wakeUp16058;
		protected virtual void wakeUp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.webkit.JsResult._wakeUp16058.native == global::System.IntPtr.Zero)
				global::android.webkit.JsResult._wakeUp16058 = @__env.GetMethodIDNoThrow(global::android.webkit.JsResult.staticClass, "wakeUp", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.webkit.JsResult.staticClass, global::android.webkit.JsResult._wakeUp16058);
		}
		static JsResult()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.webkit.JsResult.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/webkit/JsResult"));
		}
		internal static void InitJNI()
		{
		}
	}
}
