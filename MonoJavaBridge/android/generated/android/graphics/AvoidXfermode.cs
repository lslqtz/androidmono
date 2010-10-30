namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AvoidXfermode : android.graphics.Xfermode
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AvoidXfermode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Mode : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Mode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values5009;
			public static global::android.graphics.AvoidXfermode.Mode[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.AvoidXfermode.Mode._values5009.native == global::System.IntPtr.Zero)
					global::android.graphics.AvoidXfermode.Mode._values5009 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.AvoidXfermode.Mode.staticClass, "values", "()[Landroid/graphics/AvoidXfermode/Mode;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.graphics.AvoidXfermode.Mode>(@__env.CallStaticObjectMethod(android.graphics.AvoidXfermode.Mode.staticClass, global::android.graphics.AvoidXfermode.Mode._values5009)) as android.graphics.AvoidXfermode.Mode[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5010;
			public static global::android.graphics.AvoidXfermode.Mode valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.graphics.AvoidXfermode.Mode._valueOf5010.native == global::System.IntPtr.Zero)
					global::android.graphics.AvoidXfermode.Mode._valueOf5010 = @__env.GetStaticMethodIDNoThrow(global::android.graphics.AvoidXfermode.Mode.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/AvoidXfermode$Mode;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.AvoidXfermode.Mode>(@__env.CallStaticObjectMethod(android.graphics.AvoidXfermode.Mode.staticClass, global::android.graphics.AvoidXfermode.Mode._valueOf5010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.AvoidXfermode.Mode;
			}
			internal static global::MonoJavaBridge.FieldId _AVOID5011;
			public static global::android.graphics.AvoidXfermode.Mode AVOID
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.AvoidXfermode.Mode>(@__env.GetStaticObjectField(global::android.graphics.AvoidXfermode.Mode.staticClass, _AVOID5011)) as android.graphics.AvoidXfermode.Mode;
				}
			}
			internal static global::MonoJavaBridge.FieldId _TARGET5012;
			public static global::android.graphics.AvoidXfermode.Mode TARGET
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.graphics.AvoidXfermode.Mode>(@__env.GetStaticObjectField(global::android.graphics.AvoidXfermode.Mode.staticClass, _TARGET5012)) as android.graphics.AvoidXfermode.Mode;
				}
			}
			static Mode()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.graphics.AvoidXfermode.Mode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/AvoidXfermode$Mode"));
				global::android.graphics.AvoidXfermode.Mode._AVOID5011 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.AvoidXfermode.Mode.staticClass, "AVOID", "Landroid/graphics/AvoidXfermode$Mode;");
				global::android.graphics.AvoidXfermode.Mode._TARGET5012 = @__env.GetStaticFieldIDNoThrow(global::android.graphics.AvoidXfermode.Mode.staticClass, "TARGET", "Landroid/graphics/AvoidXfermode$Mode;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _AvoidXfermode5013;
		public AvoidXfermode(int arg0, int arg1, android.graphics.AvoidXfermode.Mode arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.AvoidXfermode._AvoidXfermode5013.native == global::System.IntPtr.Zero)
				global::android.graphics.AvoidXfermode._AvoidXfermode5013 = @__env.GetMethodIDNoThrow(global::android.graphics.AvoidXfermode.staticClass, "<init>", "(IILandroid/graphics/AvoidXfermode$Mode;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.AvoidXfermode.staticClass, global::android.graphics.AvoidXfermode._AvoidXfermode5013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static AvoidXfermode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.AvoidXfermode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/AvoidXfermode"));
		}
		internal static void InitJNI()
		{
		}
	}
}
