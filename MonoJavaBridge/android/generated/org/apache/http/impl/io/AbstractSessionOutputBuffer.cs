namespace org.apache.http.impl.io
{
	[global::MonoJavaBridge.JavaClass(typeof(global::org.apache.http.impl.io.AbstractSessionOutputBuffer_))]
	public abstract partial class AbstractSessionOutputBuffer : java.lang.Object, org.apache.http.io.SessionOutputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AbstractSessionOutputBuffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _write33401;
		public virtual void write(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write33401.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write33401 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "write", "([B)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write33401, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _write33402;
		public virtual void write(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write33402.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write33402 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "write", "([BII)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write33402, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _write33403;
		public virtual void write(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write33403.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write33403 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "write", "(I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._write33403, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _init33404;
		protected virtual void init(java.io.OutputStream arg0, int arg1, org.apache.http.@params.HttpParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.AbstractSessionOutputBuffer._init33404.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.AbstractSessionOutputBuffer._init33404 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "init", "(Ljava/io/OutputStream;ILorg/apache/http/params/HttpParams;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._init33404, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _flush33405;
		public virtual void flush()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.AbstractSessionOutputBuffer._flush33405.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.AbstractSessionOutputBuffer._flush33405 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "flush", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._flush33405);
		}
		internal static global::MonoJavaBridge.MethodId _flushBuffer33406;
		protected virtual void flushBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.AbstractSessionOutputBuffer._flushBuffer33406.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.AbstractSessionOutputBuffer._flushBuffer33406 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "flushBuffer", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._flushBuffer33406);
		}
		internal static global::MonoJavaBridge.MethodId _getMetrics33407;
		public virtual global::org.apache.http.io.HttpTransportMetrics getMetrics()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.AbstractSessionOutputBuffer._getMetrics33407.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.AbstractSessionOutputBuffer._getMetrics33407 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "getMetrics", "()Lorg/apache/http/io/HttpTransportMetrics;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<org.apache.http.io.HttpTransportMetrics>(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._getMetrics33407) as org.apache.http.io.HttpTransportMetrics;
		}
		internal static global::MonoJavaBridge.MethodId _writeLine33408;
		public virtual void writeLine(org.apache.http.util.CharArrayBuffer arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.AbstractSessionOutputBuffer._writeLine33408.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.AbstractSessionOutputBuffer._writeLine33408 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "writeLine", "(Lorg/apache/http/util/CharArrayBuffer;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._writeLine33408, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLine33409;
		public virtual void writeLine(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.AbstractSessionOutputBuffer._writeLine33409.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.AbstractSessionOutputBuffer._writeLine33409 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "writeLine", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._writeLine33409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AbstractSessionOutputBuffer33410;
		public AbstractSessionOutputBuffer() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.impl.io.AbstractSessionOutputBuffer._AbstractSessionOutputBuffer33410.native == global::System.IntPtr.Zero)
				global::org.apache.http.impl.io.AbstractSessionOutputBuffer._AbstractSessionOutputBuffer33410 = @__env.GetMethodIDNoThrow(global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass, global::org.apache.http.impl.io.AbstractSessionOutputBuffer._AbstractSessionOutputBuffer33410);
			Init(@__env, handle);
		}
		static AbstractSessionOutputBuffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractSessionOutputBuffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractSessionOutputBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.impl.io.AbstractSessionOutputBuffer))]
	internal sealed partial class AbstractSessionOutputBuffer_ : org.apache.http.impl.io.AbstractSessionOutputBuffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AbstractSessionOutputBuffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static AbstractSessionOutputBuffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.impl.io.AbstractSessionOutputBuffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/impl/io/AbstractSessionOutputBuffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
