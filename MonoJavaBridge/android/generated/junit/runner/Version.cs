namespace junit.runner
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Version : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Version(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _id31471;
		public static global::java.lang.String id()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::junit.runner.Version._id31471.native == global::System.IntPtr.Zero)
				global::junit.runner.Version._id31471 = @__env.GetStaticMethodIDNoThrow(global::junit.runner.Version.staticClass, "id", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(junit.runner.Version.staticClass, global::junit.runner.Version._id31471)) as java.lang.String;
		}
		static Version()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::junit.runner.Version.staticClass = @__env.NewGlobalRef(@__env.FindClass("junit/runner/Version"));
		}
		internal static void InitJNI()
		{
		}
	}
}
