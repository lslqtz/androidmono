namespace org.apache.http
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class HttpException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _HttpException31572;
		public HttpException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpException._HttpException31572.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpException._HttpException31572 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpException.staticClass, global::org.apache.http.HttpException._HttpException31572);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpException31573;
		public HttpException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpException._HttpException31573.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpException._HttpException31573 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpException.staticClass, global::org.apache.http.HttpException._HttpException31573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _HttpException31574;
		public HttpException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpException._HttpException31574.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpException._HttpException31574 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.HttpException.staticClass, global::org.apache.http.HttpException._HttpException31574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static HttpException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpException.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
