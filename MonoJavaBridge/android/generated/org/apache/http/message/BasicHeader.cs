namespace org.apache.http.message
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class BasicHeader : java.lang.Object, Header, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected BasicHeader(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString33505;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeader._toString33505.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeader._toString33505 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeader.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BasicHeader.staticClass, global::org.apache.http.message.BasicHeader._toString33505) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone33506;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeader._clone33506.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeader._clone33506 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeader.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.apache.http.message.BasicHeader.staticClass, global::org.apache.http.message.BasicHeader._clone33506) as java.lang.Object;
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName33507;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeader._getName33507.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeader._getName33507 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeader.staticClass, "getName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BasicHeader.staticClass, global::org.apache.http.message.BasicHeader._getName33507) as java.lang.String;
		}
		public new global::java.lang.String Value
		{
			get
			{
				return getValue();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getValue33508;
		public virtual global::java.lang.String getValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeader._getValue33508.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeader._getValue33508 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeader.staticClass, "getValue", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.apache.http.message.BasicHeader.staticClass, global::org.apache.http.message.BasicHeader._getValue33508) as java.lang.String;
		}
		public new global::org.apache.http.HeaderElement[] Elements
		{
			get
			{
				return getElements();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getElements33509;
		public virtual global::org.apache.http.HeaderElement[] getElements()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeader._getElements33509.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeader._getElements33509 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeader.staticClass, "getElements", "()[Lorg/apache/http/HeaderElement;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<org.apache.http.HeaderElement>(this, global::org.apache.http.message.BasicHeader.staticClass, global::org.apache.http.message.BasicHeader._getElements33509) as org.apache.http.HeaderElement[];
		}
		internal static global::MonoJavaBridge.MethodId _BasicHeader33510;
		public BasicHeader(java.lang.String arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.message.BasicHeader._BasicHeader33510.native == global::System.IntPtr.Zero)
				global::org.apache.http.message.BasicHeader._BasicHeader33510 = @__env.GetMethodIDNoThrow(global::org.apache.http.message.BasicHeader.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.apache.http.message.BasicHeader.staticClass, global::org.apache.http.message.BasicHeader._BasicHeader33510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static BasicHeader()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.message.BasicHeader.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/message/BasicHeader"));
		}
		internal static void InitJNI()
		{
		}
	}
}
