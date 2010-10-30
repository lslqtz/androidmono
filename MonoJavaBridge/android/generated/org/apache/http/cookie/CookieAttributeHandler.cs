namespace org.apache.http.cookie
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.cookie.CookieAttributeHandler_))]
	public partial interface CookieAttributeHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1);
		bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1);
		void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.cookie.CookieAttributeHandler))]
	internal sealed partial class CookieAttributeHandler_ : java.lang.Object, CookieAttributeHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CookieAttributeHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse32404;
		void org.apache.http.cookie.CookieAttributeHandler.parse(org.apache.http.cookie.SetCookie arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.cookie.CookieAttributeHandler_._parse32404.native == global::System.IntPtr.Zero)
				global::org.apache.http.cookie.CookieAttributeHandler_._parse32404 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieAttributeHandler_.staticClass, "parse", "(Lorg/apache/http/cookie/SetCookie;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.CookieAttributeHandler_._parse32404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _match32405;
		bool org.apache.http.cookie.CookieAttributeHandler.match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.cookie.CookieAttributeHandler_._match32405.native == global::System.IntPtr.Zero)
				global::org.apache.http.cookie.CookieAttributeHandler_._match32405 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieAttributeHandler_.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.cookie.CookieAttributeHandler_._match32405, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _validate32406;
		void org.apache.http.cookie.CookieAttributeHandler.validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.cookie.CookieAttributeHandler_._validate32406.native == global::System.IntPtr.Zero)
				global::org.apache.http.cookie.CookieAttributeHandler_._validate32406 = @__env.GetMethodIDNoThrow(global::org.apache.http.cookie.CookieAttributeHandler_.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.cookie.CookieAttributeHandler_._validate32406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static CookieAttributeHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.cookie.CookieAttributeHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/cookie/CookieAttributeHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
