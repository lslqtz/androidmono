namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PrintStreamPrinter : java.lang.Object, Printer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PrintStreamPrinter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _println13830;
		public virtual void println(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.PrintStreamPrinter._println13830.native == global::System.IntPtr.Zero)
				global::android.util.PrintStreamPrinter._println13830 = @__env.GetMethodIDNoThrow(global::android.util.PrintStreamPrinter.staticClass, "println", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.util.PrintStreamPrinter.staticClass, global::android.util.PrintStreamPrinter._println13830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _PrintStreamPrinter13831;
		public PrintStreamPrinter(java.io.PrintStream arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.PrintStreamPrinter._PrintStreamPrinter13831.native == global::System.IntPtr.Zero)
				global::android.util.PrintStreamPrinter._PrintStreamPrinter13831 = @__env.GetMethodIDNoThrow(global::android.util.PrintStreamPrinter.staticClass, "<init>", "(Ljava/io/PrintStream;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.PrintStreamPrinter.staticClass, global::android.util.PrintStreamPrinter._PrintStreamPrinter13831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PrintStreamPrinter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.PrintStreamPrinter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/PrintStreamPrinter"));
		}
		internal static void InitJNI()
		{
		}
	}
}
