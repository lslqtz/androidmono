namespace org.apache.http.client.methods
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.client.methods.HttpRequestBase_))]
	public abstract partial class HttpRequestBase : org.apache.http.message.AbstractHttpMessage, HttpUriRequest, AbortableHttpRequest, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected HttpRequestBase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone31946;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpRequestBase._clone31946.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpRequestBase._clone31946 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpRequestBase.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.client.methods.HttpRequestBase.staticClass, global::org.apache.http.client.methods.HttpRequestBase._clone31946) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getMethod31947;
		public abstract global::java.lang.String getMethod();
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion31948;
		public override global::org.apache.http.ProtocolVersion getProtocolVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpRequestBase._getProtocolVersion31948.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpRequestBase._getProtocolVersion31948 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpRequestBase.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.client.methods.HttpRequestBase.staticClass, global::org.apache.http.client.methods.HttpRequestBase._getProtocolVersion31948) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _getURI31949;
		public virtual global::java.net.URI getURI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpRequestBase._getURI31949.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpRequestBase._getURI31949 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpRequestBase.staticClass, "getURI", "()Ljava/net/URI;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.net.URI>(this, global::org.apache.http.client.methods.HttpRequestBase.staticClass, global::org.apache.http.client.methods.HttpRequestBase._getURI31949) as java.net.URI;
		}
		internal static global::MonoJavaBridge.MethodId _abort31950;
		public virtual void abort()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpRequestBase._abort31950.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpRequestBase._abort31950 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpRequestBase.staticClass, "abort", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpRequestBase.staticClass, global::org.apache.http.client.methods.HttpRequestBase._abort31950);
		}
		internal static global::MonoJavaBridge.MethodId _isAborted31951;
		public virtual bool isAborted()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpRequestBase._isAborted31951.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpRequestBase._isAborted31951 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpRequestBase.staticClass, "isAborted", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.apache.http.client.methods.HttpRequestBase.staticClass, global::org.apache.http.client.methods.HttpRequestBase._isAborted31951);
		}
		internal static global::MonoJavaBridge.MethodId _getRequestLine31952;
		public virtual global::org.apache.http.RequestLine getRequestLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpRequestBase._getRequestLine31952.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpRequestBase._getRequestLine31952 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpRequestBase.staticClass, "getRequestLine", "()Lorg/apache/http/RequestLine;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.RequestLine>(this, global::org.apache.http.client.methods.HttpRequestBase.staticClass, global::org.apache.http.client.methods.HttpRequestBase._getRequestLine31952) as org.apache.http.RequestLine;
		}
		internal static global::MonoJavaBridge.MethodId _setConnectionRequest31953;
		public virtual void setConnectionRequest(org.apache.http.conn.ClientConnectionRequest arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpRequestBase._setConnectionRequest31953.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpRequestBase._setConnectionRequest31953 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpRequestBase.staticClass, "setConnectionRequest", "(Lorg/apache/http/conn/ClientConnectionRequest;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpRequestBase.staticClass, global::org.apache.http.client.methods.HttpRequestBase._setConnectionRequest31953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setReleaseTrigger31954;
		public virtual void setReleaseTrigger(org.apache.http.conn.ConnectionReleaseTrigger arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpRequestBase._setReleaseTrigger31954.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpRequestBase._setReleaseTrigger31954 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpRequestBase.staticClass, "setReleaseTrigger", "(Lorg/apache/http/conn/ConnectionReleaseTrigger;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpRequestBase.staticClass, global::org.apache.http.client.methods.HttpRequestBase._setReleaseTrigger31954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setURI31955;
		public virtual void setURI(java.net.URI arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpRequestBase._setURI31955.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpRequestBase._setURI31955 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpRequestBase.staticClass, "setURI", "(Ljava/net/URI;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.client.methods.HttpRequestBase.staticClass, global::org.apache.http.client.methods.HttpRequestBase._setURI31955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _HttpRequestBase31956;
		public HttpRequestBase() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpRequestBase._HttpRequestBase31956.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpRequestBase._HttpRequestBase31956 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpRequestBase.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.client.methods.HttpRequestBase.staticClass, global::org.apache.http.client.methods.HttpRequestBase._HttpRequestBase31956);
			Init(@__env, handle);
		}
		static HttpRequestBase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpRequestBase.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpRequestBase"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.client.methods.HttpRequestBase))]
	internal sealed partial class HttpRequestBase_ : org.apache.http.client.methods.HttpRequestBase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpRequestBase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getMethod31957;
		public override global::java.lang.String getMethod()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.client.methods.HttpRequestBase_._getMethod31957.native == global::System.IntPtr.Zero)
				global::org.apache.http.client.methods.HttpRequestBase_._getMethod31957 = @__env.GetMethodIDNoThrow(global::org.apache.http.client.methods.HttpRequestBase_.staticClass, "getMethod", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.client.methods.HttpRequestBase_._getMethod31957)) as java.lang.String;
		}
		static HttpRequestBase_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.client.methods.HttpRequestBase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/client/methods/HttpRequestBase"));
		}
		internal static void InitJNI()
		{
		}
	}
}
