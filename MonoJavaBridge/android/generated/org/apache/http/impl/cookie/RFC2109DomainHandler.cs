namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class RFC2109DomainHandler : java.lang.Object, org.apache.http.cookie.CookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RFC2109DomainHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33321;
		public virtual void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.RFC2109DomainHandler._parse33321.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.RFC2109DomainHandler._parse33321 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass, global::org.apache.http.impl.cookie.RFC2109DomainHandler._parse33321, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _match33322;
		public virtual bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.RFC2109DomainHandler._match33322.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.RFC2109DomainHandler._match33322 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass, global::org.apache.http.impl.cookie.RFC2109DomainHandler._match33322, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _validate33323;
		public virtual void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.RFC2109DomainHandler._validate33323.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.RFC2109DomainHandler._validate33323 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass, global::org.apache.http.impl.cookie.RFC2109DomainHandler._validate33323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _RFC2109DomainHandler33324;
		public RFC2109DomainHandler() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.RFC2109DomainHandler._RFC2109DomainHandler33324.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.RFC2109DomainHandler._RFC2109DomainHandler33324 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass, global::org.apache.http.impl.cookie.RFC2109DomainHandler._RFC2109DomainHandler33324);
			Init(@__env, handle);
		}
		static RFC2109DomainHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.RFC2109DomainHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/RFC2109DomainHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
