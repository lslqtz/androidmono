namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Visibility : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Visibility()
		{
			InitJNI();
		}
		protected Visibility(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _visibilityTest6121;
		public static int visibilityTest(float[] arg0, int arg1, float[] arg2, int arg3, char[] arg4, int arg5, int arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.Visibility.staticClass, global::android.opengl.Visibility._visibilityTest6121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _frustumCullSpheres6122;
		public static int frustumCullSpheres(float[] arg0, int arg1, float[] arg2, int arg3, int arg4, int[] arg5, int arg6, int arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.opengl.Visibility.staticClass, global::android.opengl.Visibility._frustumCullSpheres6122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7));
		}
		internal static global::MonoJavaBridge.MethodId _computeBoundingSphere6123;
		public static void computeBoundingSphere(float[] arg0, int arg1, int arg2, float[] arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.opengl.Visibility.staticClass, global::android.opengl.Visibility._computeBoundingSphere6123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _Visibility6124;
		public Visibility()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.Visibility.staticClass, global::android.opengl.Visibility._Visibility6124);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.Visibility.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/Visibility"));
			global::android.opengl.Visibility._visibilityTest6121 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Visibility.staticClass, "visibilityTest", "([FI[FI[CII)I");
			global::android.opengl.Visibility._frustumCullSpheres6122 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Visibility.staticClass, "frustumCullSpheres", "([FI[FII[III)I");
			global::android.opengl.Visibility._computeBoundingSphere6123 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.Visibility.staticClass, "computeBoundingSphere", "([FII[FI)V");
			global::android.opengl.Visibility._Visibility6124 = @__env.GetMethodIDNoThrow(global::android.opengl.Visibility.staticClass, "<init>", "()V");
		}
	}
}
