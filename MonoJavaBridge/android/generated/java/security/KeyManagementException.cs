namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyManagementException : java.security.KeyException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyManagementException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _KeyManagementException23033;
		public KeyManagementException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyManagementException.staticClass, global::java.security.KeyManagementException._KeyManagementException23033);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyManagementException23034;
		public KeyManagementException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyManagementException.staticClass, global::java.security.KeyManagementException._KeyManagementException23034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyManagementException23035;
		public KeyManagementException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyManagementException.staticClass, global::java.security.KeyManagementException._KeyManagementException23035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyManagementException23036;
		public KeyManagementException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyManagementException.staticClass, global::java.security.KeyManagementException._KeyManagementException23036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static KeyManagementException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyManagementException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyManagementException"));
			global::java.security.KeyManagementException._KeyManagementException23033 = @__env.GetMethodIDNoThrow(global::java.security.KeyManagementException.staticClass, "<init>", "()V");
			global::java.security.KeyManagementException._KeyManagementException23034 = @__env.GetMethodIDNoThrow(global::java.security.KeyManagementException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::java.security.KeyManagementException._KeyManagementException23035 = @__env.GetMethodIDNoThrow(global::java.security.KeyManagementException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::java.security.KeyManagementException._KeyManagementException23036 = @__env.GetMethodIDNoThrow(global::java.security.KeyManagementException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}