namespace java.util.concurrent
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.util.concurrent.Callable_))]
	public partial interface Callable  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.Object call();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.concurrent.Callable))]
	internal sealed partial class Callable_ : java.lang.Object, Callable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Callable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _call27102;
		global::java.lang.Object java.util.concurrent.Callable.call()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.concurrent.Callable_._call27102.native == global::System.IntPtr.Zero)
				global::java.util.concurrent.Callable_._call27102 = @__env.GetMethodIDNoThrow(global::java.util.concurrent.Callable_.staticClass, "call", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.concurrent.Callable_._call27102)) as java.lang.Object;
		}
		static Callable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.concurrent.Callable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/concurrent/Callable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
