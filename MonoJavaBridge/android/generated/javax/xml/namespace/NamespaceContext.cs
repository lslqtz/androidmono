namespace javax.xml.@namespace
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.xml.@namespace.NamespaceContext_))]
	public partial interface NamespaceContext  : global::MonoJavaBridge.IJavaObject 
	{
		global::java.lang.String getPrefix(java.lang.String arg0);
		global::java.lang.String getNamespaceURI(java.lang.String arg0);
		global::java.util.Iterator getPrefixes(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.xml.@namespace.NamespaceContext))]
	internal sealed partial class NamespaceContext_ : java.lang.Object, NamespaceContext
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal NamespaceContext_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getPrefix30819;
		global::java.lang.String javax.xml.@namespace.NamespaceContext.getPrefix(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.@namespace.NamespaceContext_._getPrefix30819.native == global::System.IntPtr.Zero)
				global::javax.xml.@namespace.NamespaceContext_._getPrefix30819 = @__env.GetMethodIDNoThrow(global::javax.xml.@namespace.NamespaceContext_.staticClass, "getPrefix", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.@namespace.NamespaceContext_._getPrefix30819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getNamespaceURI30820;
		global::java.lang.String javax.xml.@namespace.NamespaceContext.getNamespaceURI(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.@namespace.NamespaceContext_._getNamespaceURI30820.native == global::System.IntPtr.Zero)
				global::javax.xml.@namespace.NamespaceContext_._getNamespaceURI30820 = @__env.GetMethodIDNoThrow(global::javax.xml.@namespace.NamespaceContext_.staticClass, "getNamespaceURI", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.@namespace.NamespaceContext_._getNamespaceURI30820, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPrefixes30821;
		global::java.util.Iterator javax.xml.@namespace.NamespaceContext.getPrefixes(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.@namespace.NamespaceContext_._getPrefixes30821.native == global::System.IntPtr.Zero)
				global::javax.xml.@namespace.NamespaceContext_._getPrefixes30821 = @__env.GetMethodIDNoThrow(global::javax.xml.@namespace.NamespaceContext_.staticClass, "getPrefixes", "(Ljava/lang/String;)Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::javax.xml.@namespace.NamespaceContext_._getPrefixes30821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.Iterator;
		}
		static NamespaceContext_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.@namespace.NamespaceContext_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/namespace/NamespaceContext"));
		}
		internal static void InitJNI()
		{
		}
	}
}
