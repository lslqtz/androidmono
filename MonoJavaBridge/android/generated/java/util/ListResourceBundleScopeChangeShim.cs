namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.ListResourceBundleScopeChangeShim_))]
	public abstract partial class ListResourceBundleScopeChangeShim : java.util.ResourceBundle
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ListResourceBundleScopeChangeShim(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _handleGetObject26448;
		protected override global::java.lang.Object handleGetObject(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ListResourceBundleScopeChangeShim._handleGetObject26448.native == global::System.IntPtr.Zero)
				global::java.util.ListResourceBundleScopeChangeShim._handleGetObject26448 = @__env.GetMethodIDNoThrow(global::java.util.ListResourceBundleScopeChangeShim.staticClass, "handleGetObject", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.util.ListResourceBundleScopeChangeShim.staticClass, global::java.util.ListResourceBundleScopeChangeShim._handleGetObject26448, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		static ListResourceBundleScopeChangeShim()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ListResourceBundleScopeChangeShim.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ListResourceBundleScopeChangeShim"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.ListResourceBundleScopeChangeShim))]
	internal sealed partial class ListResourceBundleScopeChangeShim_ : java.util.ListResourceBundleScopeChangeShim
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ListResourceBundleScopeChangeShim_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getKeys26449;
		public override global::java.util.Enumeration getKeys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.ListResourceBundleScopeChangeShim_._getKeys26449.native == global::System.IntPtr.Zero)
				global::java.util.ListResourceBundleScopeChangeShim_._getKeys26449 = @__env.GetMethodIDNoThrow(global::java.util.ListResourceBundleScopeChangeShim_.staticClass, "getKeys", "()Ljava/util/Enumeration;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.ListResourceBundleScopeChangeShim_._getKeys26449)) as java.util.Enumeration;
		}
		static ListResourceBundleScopeChangeShim_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.ListResourceBundleScopeChangeShim_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/ListResourceBundleScopeChangeShim"));
		}
		internal static void InitJNI()
		{
		}
	}
}
