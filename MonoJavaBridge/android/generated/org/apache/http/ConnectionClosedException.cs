namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ConnectionClosedException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ConnectionClosedException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _ConnectionClosedException31490;
		public ConnectionClosedException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.ConnectionClosedException._ConnectionClosedException31490.native == global::System.IntPtr.Zero)
				global::org.apache.http.ConnectionClosedException._ConnectionClosedException31490 = @__env.GetMethodIDNoThrow(global::org.apache.http.ConnectionClosedException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.ConnectionClosedException.staticClass, global::org.apache.http.ConnectionClosedException._ConnectionClosedException31490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ConnectionClosedException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.ConnectionClosedException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/ConnectionClosedException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
