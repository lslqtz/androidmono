namespace org.apache.http.impl.client
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DefaultProxyAuthenticationHandler : org.apache.http.impl.client.AbstractAuthenticationHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DefaultProxyAuthenticationHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _isAuthenticationRequested32908;
		public override bool isAuthenticationRequested(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler._isAuthenticationRequested32908.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler._isAuthenticationRequested32908 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler.staticClass, "isAuthenticationRequested", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler.staticClass, global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler._isAuthenticationRequested32908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChallenges32909;
		public override global::java.util.Map getChallenges(org.apache.http.HttpResponse arg0, org.apache.http.protocol.HttpContext arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler._getChallenges32909.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler._getChallenges32909 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler.staticClass, "getChallenges", "(Lorg/apache/http/HttpResponse;Lorg/apache/http/protocol/HttpContext;)Ljava/util/Map;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler.staticClass, global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler._getChallenges32909, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _DefaultProxyAuthenticationHandler32910;
		public DefaultProxyAuthenticationHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler._DefaultProxyAuthenticationHandler32910.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler._DefaultProxyAuthenticationHandler32910 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.client.DefaultProxyAuthenticationHandler.staticClass, global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler._DefaultProxyAuthenticationHandler32910);
			Init(@__env, handle);
		}
		static DefaultProxyAuthenticationHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.client.DefaultProxyAuthenticationHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/client/DefaultProxyAuthenticationHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
