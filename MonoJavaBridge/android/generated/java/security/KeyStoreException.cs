namespace java.security
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class KeyStoreException : java.security.GeneralSecurityException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected KeyStoreException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreException23119;
		public KeyStoreException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStoreException._KeyStoreException23119.native == global::System.IntPtr.Zero)
				global::java.security.KeyStoreException._KeyStoreException23119 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._KeyStoreException23119);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreException23120;
		public KeyStoreException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStoreException._KeyStoreException23120.native == global::System.IntPtr.Zero)
				global::java.security.KeyStoreException._KeyStoreException23120 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._KeyStoreException23120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreException23121;
		public KeyStoreException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStoreException._KeyStoreException23121.native == global::System.IntPtr.Zero)
				global::java.security.KeyStoreException._KeyStoreException23121 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._KeyStoreException23121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _KeyStoreException23122;
		public KeyStoreException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.KeyStoreException._KeyStoreException23122.native == global::System.IntPtr.Zero)
				global::java.security.KeyStoreException._KeyStoreException23122 = @__env.GetMethodIDNoThrow(global::java.security.KeyStoreException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.KeyStoreException.staticClass, global::java.security.KeyStoreException._KeyStoreException23122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static KeyStoreException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.KeyStoreException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/KeyStoreException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
