namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PixelXorXfermode : android.graphics.Xfermode
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PixelXorXfermode(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _PixelXorXfermode5618;
		public PixelXorXfermode(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.PixelXorXfermode._PixelXorXfermode5618.native == global::System.IntPtr.Zero)
				global::android.graphics.PixelXorXfermode._PixelXorXfermode5618 = @__env.GetMethodIDNoThrow(global::android.graphics.PixelXorXfermode.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.PixelXorXfermode.staticClass, global::android.graphics.PixelXorXfermode._PixelXorXfermode5618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PixelXorXfermode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.PixelXorXfermode.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/PixelXorXfermode"));
		}
		internal static void InitJNI()
		{
		}
	}
}
