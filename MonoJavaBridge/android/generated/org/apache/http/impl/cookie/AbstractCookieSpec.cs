namespace org.apache.http.impl.cookie
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.cookie.AbstractCookieSpec_))]
	public abstract partial class AbstractCookieSpec : java.lang.Object, org.apache.http.cookie.CookieSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractCookieSpec(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33200;
		public abstract global::java.util.List parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1);
		internal static global::MonoJavaBridge.MethodId _match33201;
		public abstract bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1);
		internal static global::MonoJavaBridge.MethodId _getVersion33202;
		public abstract int getVersion();
		internal static global::MonoJavaBridge.MethodId _validate33203;
		public abstract void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1);
		internal static global::MonoJavaBridge.MethodId _formatCookies33204;
		public abstract global::java.util.List formatCookies(java.util.List arg0);
		internal static global::MonoJavaBridge.MethodId _getVersionHeader33205;
		public abstract global::org.apache.http.Header getVersionHeader();
		internal static global::MonoJavaBridge.MethodId _registerAttribHandler33206;
		public virtual void registerAttribHandler(java.lang.String arg0, org.apache.http.cookie.CookieAttributeHandler arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.AbstractCookieSpec._registerAttribHandler33206.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.AbstractCookieSpec._registerAttribHandler33206 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, "registerAttribHandler", "(Ljava/lang/String;Lorg/apache/http/cookie/CookieAttributeHandler;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, global::org.apache.http.impl.cookie.AbstractCookieSpec._registerAttribHandler33206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _findAttribHandler33207;
		protected virtual global::org.apache.http.cookie.CookieAttributeHandler findAttribHandler(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.AbstractCookieSpec._findAttribHandler33207.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.AbstractCookieSpec._findAttribHandler33207 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, "findAttribHandler", "(Ljava/lang/String;)Lorg/apache/http/cookie/CookieAttributeHandler;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.cookie.CookieAttributeHandler>(this, global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, global::org.apache.http.impl.cookie.AbstractCookieSpec._findAttribHandler33207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.cookie.CookieAttributeHandler;
		}
		internal static global::MonoJavaBridge.MethodId _getAttribHandler33208;
		protected virtual global::org.apache.http.cookie.CookieAttributeHandler getAttribHandler(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.AbstractCookieSpec._getAttribHandler33208.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.AbstractCookieSpec._getAttribHandler33208 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, "getAttribHandler", "(Ljava/lang/String;)Lorg/apache/http/cookie/CookieAttributeHandler;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.cookie.CookieAttributeHandler>(this, global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, global::org.apache.http.impl.cookie.AbstractCookieSpec._getAttribHandler33208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.apache.http.cookie.CookieAttributeHandler;
		}
		internal static global::MonoJavaBridge.MethodId _getAttribHandlers33209;
		protected virtual global::java.util.Collection getAttribHandlers()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.AbstractCookieSpec._getAttribHandlers33209.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.AbstractCookieSpec._getAttribHandlers33209 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, "getAttribHandlers", "()Ljava/util/Collection;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, global::org.apache.http.impl.cookie.AbstractCookieSpec._getAttribHandlers33209) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractCookieSpec33210;
		public AbstractCookieSpec() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.AbstractCookieSpec._AbstractCookieSpec33210.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.AbstractCookieSpec._AbstractCookieSpec33210 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.cookie.AbstractCookieSpec.staticClass, global::org.apache.http.impl.cookie.AbstractCookieSpec._AbstractCookieSpec33210);
			Init(@__env, handle);
		}
		static AbstractCookieSpec()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.AbstractCookieSpec.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/AbstractCookieSpec"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.cookie.AbstractCookieSpec))]
	internal sealed partial class AbstractCookieSpec_ : org.apache.http.impl.cookie.AbstractCookieSpec
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractCookieSpec_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parse33211;
		public override global::java.util.List parse(org.apache.http.Header arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.AbstractCookieSpec_._parse33211.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.AbstractCookieSpec_._parse33211 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, "parse", "(Lorg/apache/http/Header;Lorg/apache/http/cookie/CookieOrigin;)Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_._parse33211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _match33212;
		public override bool match(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.AbstractCookieSpec_._match33212.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.AbstractCookieSpec_._match33212 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, "match", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_._match33212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getVersion33213;
		public override int getVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.AbstractCookieSpec_._getVersion33213.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.AbstractCookieSpec_._getVersion33213 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, "getVersion", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_._getVersion33213);
		}
		internal static global::MonoJavaBridge.MethodId _validate33214;
		public override void validate(org.apache.http.cookie.Cookie arg0, org.apache.http.cookie.CookieOrigin arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.AbstractCookieSpec_._validate33214.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.AbstractCookieSpec_._validate33214 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, "validate", "(Lorg/apache/http/cookie/Cookie;Lorg/apache/http/cookie/CookieOrigin;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_._validate33214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _formatCookies33215;
		public override global::java.util.List formatCookies(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.AbstractCookieSpec_._formatCookies33215.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.AbstractCookieSpec_._formatCookies33215 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, "formatCookies", "(Ljava/util/List;)Ljava/util/List;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_._formatCookies33215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _getVersionHeader33216;
		public override global::org.apache.http.Header getVersionHeader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.cookie.AbstractCookieSpec_._getVersionHeader33216.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.cookie.AbstractCookieSpec_._getVersionHeader33216 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass, "getVersionHeader", "()Lorg/apache/http/Header;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.impl.cookie.AbstractCookieSpec_._getVersionHeader33216)) as org.apache.http.Header;
		}
		static AbstractCookieSpec_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.cookie.AbstractCookieSpec_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/cookie/AbstractCookieSpec"));
		}
		internal static void InitJNI()
		{
		}
	}
}
