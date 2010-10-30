namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HeaderElementIterator_))]
	public partial interface HeaderElementIterator : java.util.Iterator
	{
		bool hasNext();
		global::org.apache.http.HeaderElement nextElement();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HeaderElementIterator))]
	internal sealed partial class HeaderElementIterator_ : java.lang.Object, HeaderElementIterator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HeaderElementIterator_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasNext31506;
		bool org.apache.http.HeaderElementIterator.hasNext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HeaderElementIterator_._hasNext31506.native == global::System.IntPtr.Zero)
				global::org.apache.http.HeaderElementIterator_._hasNext31506 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElementIterator_.staticClass, "hasNext", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HeaderElementIterator_._hasNext31506);
		}
		internal static global::MonoJavaBridge.MethodId _nextElement31507;
		global::org.apache.http.HeaderElement org.apache.http.HeaderElementIterator.nextElement()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HeaderElementIterator_._nextElement31507.native == global::System.IntPtr.Zero)
				global::org.apache.http.HeaderElementIterator_._nextElement31507 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElementIterator_.staticClass, "nextElement", "()Lorg/apache/http/HeaderElement;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderElement>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElementIterator_._nextElement31507)) as org.apache.http.HeaderElement;
		}
		internal static global::MonoJavaBridge.MethodId _hasNext31508;
		bool java.util.Iterator.hasNext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HeaderElementIterator_._hasNext31508.native == global::System.IntPtr.Zero)
				global::org.apache.http.HeaderElementIterator_._hasNext31508 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElementIterator_.staticClass, "hasNext", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HeaderElementIterator_._hasNext31508);
		}
		internal static global::MonoJavaBridge.MethodId _next31509;
		global::java.lang.Object java.util.Iterator.next()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HeaderElementIterator_._next31509.native == global::System.IntPtr.Zero)
				global::org.apache.http.HeaderElementIterator_._next31509 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElementIterator_.staticClass, "next", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HeaderElementIterator_._next31509)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _remove31510;
		void java.util.Iterator.remove()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HeaderElementIterator_._remove31510.native == global::System.IntPtr.Zero)
				global::org.apache.http.HeaderElementIterator_._remove31510 = @__env.GetMethodIDNoThrow(global::org.apache.http.HeaderElementIterator_.staticClass, "remove", "()V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HeaderElementIterator_._remove31510);
		}
		static HeaderElementIterator_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HeaderElementIterator_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HeaderElementIterator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
