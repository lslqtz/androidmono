namespace org.apache.http.entity
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.entity.ContentProducer_))]
	public partial interface ContentProducer  : global::MonoJavaBridge.IJavaObject 
	{
		void writeTo(java.io.OutputStream arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.entity.ContentProducer))]
	internal sealed partial class ContentProducer_ : java.lang.Object, ContentProducer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ContentProducer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeTo32532;
		void org.apache.http.entity.ContentProducer.writeTo(java.io.OutputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.entity.ContentProducer_._writeTo32532.native == global::System.IntPtr.Zero)
				global::org.apache.http.entity.ContentProducer_._writeTo32532 = @__env.GetMethodIDNoThrow(global::org.apache.http.entity.ContentProducer_.staticClass, "writeTo", "(Ljava/io/OutputStream;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.entity.ContentProducer_._writeTo32532, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static ContentProducer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.entity.ContentProducer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/entity/ContentProducer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
