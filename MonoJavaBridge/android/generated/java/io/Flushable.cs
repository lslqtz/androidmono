namespace java.io
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.io.Flushable_))]
	public partial interface Flushable  : global::MonoJavaBridge.IJavaObject 
	{
		void flush();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.io.Flushable))]
	internal sealed partial class Flushable_ : java.lang.Object, Flushable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Flushable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _flush19089;
		void java.io.Flushable.flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.Flushable_._flush19089.native == global::System.IntPtr.Zero)
				global::java.io.Flushable_._flush19089 = @__env.GetMethodIDNoThrow(global::java.io.Flushable_.staticClass, "flush", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::java.io.Flushable_._flush19089);
		}
		static Flushable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.Flushable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/Flushable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
