namespace java.io
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UTFDataFormatException : java.io.IOException
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UTFDataFormatException(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _UTFDataFormatException19631;
		public UTFDataFormatException() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.UTFDataFormatException._UTFDataFormatException19631.native == global::System.IntPtr.Zero)
				global::java.io.UTFDataFormatException._UTFDataFormatException19631 = @__env.GetMethodIDNoThrow(global::java.io.UTFDataFormatException.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.UTFDataFormatException.staticClass, global::java.io.UTFDataFormatException._UTFDataFormatException19631);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _UTFDataFormatException19632;
		public UTFDataFormatException(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.io.UTFDataFormatException._UTFDataFormatException19632.native == global::System.IntPtr.Zero)
				global::java.io.UTFDataFormatException._UTFDataFormatException19632 = @__env.GetMethodIDNoThrow(global::java.io.UTFDataFormatException.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.io.UTFDataFormatException.staticClass, global::java.io.UTFDataFormatException._UTFDataFormatException19632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static UTFDataFormatException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.io.UTFDataFormatException.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/io/UTFDataFormatException"));
		}
		internal static void InitJNI()
		{
		}
	}
}
