namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Prediction : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Prediction()
		{
			InitJNI();
		}
		protected Prediction(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString3069;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.Prediction._toString3069)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.Prediction.staticClass, global::android.gesture.Prediction._toString3069)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.FieldId _name3070;
		public global::java.lang.String name
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _score3071;
		public double score
		{
			get
			{
				return default(double);
			}
			set
			{
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.Prediction.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/Prediction"));
			global::android.gesture.Prediction._toString3069 = @__env.GetMethodIDNoThrow(global::android.gesture.Prediction.staticClass, "toString", "()Ljava/lang/String;");
		}
	}
}
