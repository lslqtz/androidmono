namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicStatusLine : java.lang.Object, StatusLine, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicStatusLine(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString33645;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicStatusLine._toString33645.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicStatusLine._toString33645 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicStatusLine.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BasicStatusLine.staticClass, global::org.apache.http.message.BasicStatusLine._toString33645) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone33646;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicStatusLine._clone33646.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicStatusLine._clone33646 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicStatusLine.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicStatusLine.staticClass, global::org.apache.http.message.BasicStatusLine._clone33646) as java.lang.Object;
		}
		public new global::org.apache.http.ProtocolVersion ProtocolVersion
		{
			get
			{
				return getProtocolVersion();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion33647;
		public virtual global::org.apache.http.ProtocolVersion getProtocolVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicStatusLine._getProtocolVersion33647.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicStatusLine._getProtocolVersion33647 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicStatusLine.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicStatusLine.staticClass, global::org.apache.http.message.BasicStatusLine._getProtocolVersion33647) as org.apache.http.ProtocolVersion;
		}
		public new int StatusCode
		{
			get
			{
				return getStatusCode();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatusCode33648;
		public virtual int getStatusCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicStatusLine._getStatusCode33648.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicStatusLine._getStatusCode33648 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicStatusLine.staticClass, "getStatusCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.apache.http.message.BasicStatusLine.staticClass, global::org.apache.http.message.BasicStatusLine._getStatusCode33648);
		}
		public new global::java.lang.String ReasonPhrase
		{
			get
			{
				return getReasonPhrase();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReasonPhrase33649;
		public virtual global::java.lang.String getReasonPhrase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicStatusLine._getReasonPhrase33649.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicStatusLine._getReasonPhrase33649 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicStatusLine.staticClass, "getReasonPhrase", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BasicStatusLine.staticClass, global::org.apache.http.message.BasicStatusLine._getReasonPhrase33649) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _BasicStatusLine33650;
		public BasicStatusLine(org.apache.http.ProtocolVersion arg0, int arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicStatusLine._BasicStatusLine33650.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicStatusLine._BasicStatusLine33650 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicStatusLine.staticClass, "<init>", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicStatusLine.staticClass, global::org.apache.http.message.BasicStatusLine._BasicStatusLine33650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static BasicStatusLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicStatusLine.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicStatusLine"));
		}
		internal static void InitJNI()
		{
		}
	}
}
