namespace javax.xml.datatype
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DatatypeConfigurationException : java.lang.Exception
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DatatypeConfigurationException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _DatatypeConfigurationException30635;
		public DatatypeConfigurationException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30635.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30635 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConfigurationException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeConfigurationException.staticClass, global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30635);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatatypeConfigurationException30636;
		public DatatypeConfigurationException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30636.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30636 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConfigurationException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeConfigurationException.staticClass, global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatatypeConfigurationException30637;
		public DatatypeConfigurationException(java.lang.String arg0, java.lang.Throwable arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30637.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30637 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConfigurationException.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeConfigurationException.staticClass, global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30637, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatatypeConfigurationException30638;
		public DatatypeConfigurationException(java.lang.Throwable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30638.native == global::System.IntPtr.Zero)
				global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30638 = @__env.GetMethodIDNoThrow(global::javax.xml.datatype.DatatypeConfigurationException.staticClass, "<init>", "(Ljava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(javax.xml.datatype.DatatypeConfigurationException.staticClass, global::javax.xml.datatype.DatatypeConfigurationException._DatatypeConfigurationException30638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static DatatypeConfigurationException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.xml.datatype.DatatypeConfigurationException.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/xml/datatype/DatatypeConfigurationException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
