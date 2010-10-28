namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnticipateInterpolator : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AnticipateInterpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolation15664;
		public virtual float getInterpolation(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.AnticipateInterpolator._getInterpolation15664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.AnticipateInterpolator.staticClass, global::android.view.animation.AnticipateInterpolator._getInterpolation15664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AnticipateInterpolator15665;
		public AnticipateInterpolator() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnticipateInterpolator.staticClass, global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator15665);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnticipateInterpolator15666;
		public AnticipateInterpolator(float arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnticipateInterpolator.staticClass, global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator15666, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AnticipateInterpolator15667;
		public AnticipateInterpolator(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AnticipateInterpolator.staticClass, global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator15667, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static AnticipateInterpolator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AnticipateInterpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AnticipateInterpolator"));
			global::android.view.animation.AnticipateInterpolator._getInterpolation15664 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnticipateInterpolator.staticClass, "getInterpolation", "(F)F");
			global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator15665 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnticipateInterpolator.staticClass, "<init>", "()V");
			global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator15666 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnticipateInterpolator.staticClass, "<init>", "(F)V");
			global::android.view.animation.AnticipateInterpolator._AnticipateInterpolator15667 = @__env.GetMethodIDNoThrow(global::android.view.animation.AnticipateInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}