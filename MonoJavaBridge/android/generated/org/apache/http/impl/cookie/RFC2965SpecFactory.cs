namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RFC2965SpecFactory : java.lang.Object, org.apache.http.cookie.CookieSpecFactory
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RFC2965SpecFactory(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _newInstance33364;
		public virtual global::org.apache.http.cookie.CookieSpec newInstance(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.RFC2965SpecFactory._newInstance33364.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.RFC2965SpecFactory._newInstance33364 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965SpecFactory.staticClass, "newInstance", "(Lorg/apache/http/params/HttpParams;)Lorg/apache/http/cookie/CookieSpec;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.cookie.CookieSpec>(this, global::org.apache.http.impl.cookie.RFC2965SpecFactory.staticClass, global::org.apache.http.impl.cookie.RFC2965SpecFactory._newInstance33364, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.cookie.CookieSpec;
		}
		internal static global::MonoJavaBridge.MethodId _RFC2965SpecFactory33365;
		public RFC2965SpecFactory() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.RFC2965SpecFactory._RFC2965SpecFactory33365.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.RFC2965SpecFactory._RFC2965SpecFactory33365 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2965SpecFactory.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.RFC2965SpecFactory.staticClass, global::org.apache.http.impl.cookie.RFC2965SpecFactory._RFC2965SpecFactory33365);
			Init(@__env, handle);
		}
		static RFC2965SpecFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.RFC2965SpecFactory.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/RFC2965SpecFactory"));
		}
		internal static void InitJNI()
		{
		}
	}
}
