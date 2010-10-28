namespace java.nio.charset.spi
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.charset.spi.CharsetProvider_))]
	public abstract partial class CharsetProvider : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CharsetProvider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _charsetForName22823;
		public abstract global::java.nio.charset.Charset charsetForName(java.lang.String arg0);
		internal static global::MonoJavaBridge.MethodId _charsets22824;
		public abstract global::java.util.Iterator charsets();
		internal static global::MonoJavaBridge.MethodId _CharsetProvider22825;
		protected CharsetProvider() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.nio.charset.spi.CharsetProvider.staticClass, global::java.nio.charset.spi.CharsetProvider._CharsetProvider22825);
			Init(@__env, handle);
		}
		static CharsetProvider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.spi.CharsetProvider.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/spi/CharsetProvider"));
			global::java.nio.charset.spi.CharsetProvider._charsetForName22823 = @__env.GetMethodIDNoThrow(global::java.nio.charset.spi.CharsetProvider.staticClass, "charsetForName", "(Ljava/lang/String;)Ljava/nio/charset/Charset;");
			global::java.nio.charset.spi.CharsetProvider._charsets22824 = @__env.GetMethodIDNoThrow(global::java.nio.charset.spi.CharsetProvider.staticClass, "charsets", "()Ljava/util/Iterator;");
			global::java.nio.charset.spi.CharsetProvider._CharsetProvider22825 = @__env.GetMethodIDNoThrow(global::java.nio.charset.spi.CharsetProvider.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.charset.spi.CharsetProvider))]
	internal sealed partial class CharsetProvider_ : java.nio.charset.spi.CharsetProvider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal CharsetProvider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _charsetForName22826;
		public override global::java.nio.charset.Charset charsetForName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.spi.CharsetProvider_._charsetForName22826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.Charset;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.spi.CharsetProvider_.staticClass, global::java.nio.charset.spi.CharsetProvider_._charsetForName22826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.nio.charset.Charset;
		}
		internal static global::MonoJavaBridge.MethodId _charsets22827;
		public override global::java.util.Iterator charsets()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.charset.spi.CharsetProvider_._charsets22827)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.nio.charset.spi.CharsetProvider_.staticClass, global::java.nio.charset.spi.CharsetProvider_._charsets22827)) as java.util.Iterator;
		}
		static CharsetProvider_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.charset.spi.CharsetProvider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/charset/spi/CharsetProvider"));
			global::java.nio.charset.spi.CharsetProvider_._charsetForName22826 = @__env.GetMethodIDNoThrow(global::java.nio.charset.spi.CharsetProvider_.staticClass, "charsetForName", "(Ljava/lang/String;)Ljava/nio/charset/Charset;");
			global::java.nio.charset.spi.CharsetProvider_._charsets22827 = @__env.GetMethodIDNoThrow(global::java.nio.charset.spi.CharsetProvider_.staticClass, "charsets", "()Ljava/util/Iterator;");
		}
		internal static void InitJNI()
		{
		}
	}
}