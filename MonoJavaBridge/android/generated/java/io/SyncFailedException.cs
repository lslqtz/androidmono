namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncFailedException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SyncFailedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public SyncFailedException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.SyncFailedException._m0.native == global::System.IntPtr.Zero)
				global::java.io.SyncFailedException._m0 = @__env.GetMethodIDNoThrow(global::java.io.SyncFailedException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.SyncFailedException.staticClass, global::java.io.SyncFailedException._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static SyncFailedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.SyncFailedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/SyncFailedException"));
		}
	}
}
