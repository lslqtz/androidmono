namespace org.apache.http.conn
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicManagedEntity : org.apache.http.entity.HttpEntityWrapper, ConnectionReleaseTrigger, EofSensorWatcher
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicManagedEntity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.io.InputStream Content
		{
			get
			{
				return getContent();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContent32065;
		public override global::java.io.InputStream getContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._getContent32065)) as java.io.InputStream;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._getContent32065)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32066;
		public override void writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._writeTo32066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._writeTo32066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isRepeatable32067;
		public override bool isRepeatable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._isRepeatable32067);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._isRepeatable32067);
		}
		internal static global::MonoJavaBridge.MethodId _releaseConnection32068;
		public virtual void releaseConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._releaseConnection32068);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._releaseConnection32068);
		}
		internal static global::MonoJavaBridge.MethodId _consumeContent32069;
		public override void consumeContent()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._consumeContent32069);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._consumeContent32069);
		}
		internal static global::MonoJavaBridge.MethodId _abortConnection32070;
		public virtual void abortConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._abortConnection32070);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._abortConnection32070);
		}
		internal static global::MonoJavaBridge.MethodId _eofDetected32071;
		public virtual bool eofDetected(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._eofDetected32071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._eofDetected32071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _streamClosed32072;
		public virtual bool streamClosed(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._streamClosed32072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._streamClosed32072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _streamAbort32073;
		public virtual bool streamAbort(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._streamAbort32073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._streamAbort32073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _releaseManagedConnection32074;
		protected virtual void releaseManagedConnection()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity._releaseManagedConnection32074);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._releaseManagedConnection32074);
		}
		internal static global::MonoJavaBridge.MethodId _BasicManagedEntity32075;
		public BasicManagedEntity(org.apache.http.HttpEntity arg0, org.apache.http.conn.ManagedClientConnection arg1, bool arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.conn.BasicManagedEntity.staticClass, global::org.apache.http.conn.BasicManagedEntity._BasicManagedEntity32075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static BasicManagedEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.conn.BasicManagedEntity.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/conn/BasicManagedEntity"));
			global::org.apache.http.conn.BasicManagedEntity._getContent32065 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "getContent", "()Ljava/io/InputStream;");
			global::org.apache.http.conn.BasicManagedEntity._writeTo32066 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			global::org.apache.http.conn.BasicManagedEntity._isRepeatable32067 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "isRepeatable", "()Z");
			global::org.apache.http.conn.BasicManagedEntity._releaseConnection32068 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "releaseConnection", "()V");
			global::org.apache.http.conn.BasicManagedEntity._consumeContent32069 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "consumeContent", "()V");
			global::org.apache.http.conn.BasicManagedEntity._abortConnection32070 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "abortConnection", "()V");
			global::org.apache.http.conn.BasicManagedEntity._eofDetected32071 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "eofDetected", "(Ljava/io/InputStream;)Z");
			global::org.apache.http.conn.BasicManagedEntity._streamClosed32072 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "streamClosed", "(Ljava/io/InputStream;)Z");
			global::org.apache.http.conn.BasicManagedEntity._streamAbort32073 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "streamAbort", "(Ljava/io/InputStream;)Z");
			global::org.apache.http.conn.BasicManagedEntity._releaseManagedConnection32074 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "releaseManagedConnection", "()V");
			global::org.apache.http.conn.BasicManagedEntity._BasicManagedEntity32075 = @__env.GetMethodIDNoThrow(global::org.apache.http.conn.BasicManagedEntity.staticClass, "<init>", "(Lorg/apache/http/HttpEntity;Lorg/apache/http/conn/ManagedClientConnection;Z)V");
		}
		internal static void InitJNI()
		{
		}
	}
}