namespace java.util.logging
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class LoggingPermission : java.security.BasicPermission
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LoggingPermission(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public LoggingPermission(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.logging.LoggingPermission._m0.native == global::System.IntPtr.Zero)
				global::java.util.logging.LoggingPermission._m0 = @__env.GetMethodIDNoThrow(global::java.util.logging.LoggingPermission.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.logging.LoggingPermission.staticClass, global::java.util.logging.LoggingPermission._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static LoggingPermission()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.logging.LoggingPermission.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/logging/LoggingPermission"));
		}
	}
}
