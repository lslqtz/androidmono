namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NoSuchFieldException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NoSuchFieldException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public NoSuchFieldException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NoSuchFieldException._m0.native == global::System.IntPtr.Zero)
				global::java.lang.NoSuchFieldException._m0 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchFieldException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchFieldException.staticClass, global::java.lang.NoSuchFieldException._m0);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public NoSuchFieldException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.NoSuchFieldException._m1.native == global::System.IntPtr.Zero)
				global::java.lang.NoSuchFieldException._m1 = @__env.GetMethodIDNoThrow(global::java.lang.NoSuchFieldException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.NoSuchFieldException.staticClass, global::java.lang.NoSuchFieldException._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static NoSuchFieldException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.NoSuchFieldException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/NoSuchFieldException"));
		}
	}
}
