namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CycleInterpolator : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CycleInterpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolation15676;
		public virtual float getInterpolation(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.CycleInterpolator._getInterpolation15676.native == global::System.IntPtr.Zero)
				global::android.view.animation.CycleInterpolator._getInterpolation15676 = @__env.GetMethodIDNoThrow(global::android.view.animation.CycleInterpolator.staticClass, "getInterpolation", "(F)F");
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.view.animation.CycleInterpolator.staticClass, global::android.view.animation.CycleInterpolator._getInterpolation15676, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _CycleInterpolator15677;
		public CycleInterpolator(float arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.CycleInterpolator._CycleInterpolator15677.native == global::System.IntPtr.Zero)
				global::android.view.animation.CycleInterpolator._CycleInterpolator15677 = @__env.GetMethodIDNoThrow(global::android.view.animation.CycleInterpolator.staticClass, "<init>", "(F)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.CycleInterpolator.staticClass, global::android.view.animation.CycleInterpolator._CycleInterpolator15677, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _CycleInterpolator15678;
		public CycleInterpolator(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.animation.CycleInterpolator._CycleInterpolator15678.native == global::System.IntPtr.Zero)
				global::android.view.animation.CycleInterpolator._CycleInterpolator15678 = @__env.GetMethodIDNoThrow(global::android.view.animation.CycleInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.CycleInterpolator.staticClass, global::android.view.animation.CycleInterpolator._CycleInterpolator15678, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static CycleInterpolator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.CycleInterpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/CycleInterpolator"));
		}
		internal static void InitJNI()
		{
		}
	}
}
