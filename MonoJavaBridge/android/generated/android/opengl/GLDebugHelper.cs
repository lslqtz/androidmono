namespace android.opengl
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GLDebugHelper : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GLDebugHelper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _wrap8143;
		public static global::javax.microedition.khronos.opengles.GL wrap(javax.microedition.khronos.opengles.GL arg0, int arg1, java.io.Writer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLDebugHelper._wrap8143.native == global::System.IntPtr.Zero)
				global::android.opengl.GLDebugHelper._wrap8143 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLDebugHelper.staticClass, "wrap", "(Ljavax/microedition/khronos/opengles/GL;ILjava/io/Writer;)Ljavax/microedition/khronos/opengles/GL;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.microedition.khronos.opengles.GL>(@__env.CallStaticObjectMethod(android.opengl.GLDebugHelper.staticClass, global::android.opengl.GLDebugHelper._wrap8143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.microedition.khronos.opengles.GL;
		}
		internal static global::MonoJavaBridge.MethodId _wrap8144;
		public static global::javax.microedition.khronos.egl.EGL wrap(javax.microedition.khronos.egl.EGL arg0, int arg1, java.io.Writer arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLDebugHelper._wrap8144.native == global::System.IntPtr.Zero)
				global::android.opengl.GLDebugHelper._wrap8144 = @__env.GetStaticMethodIDNoThrow(global::android.opengl.GLDebugHelper.staticClass, "wrap", "(Ljavax/microedition/khronos/egl/EGL;ILjava/io/Writer;)Ljavax/microedition/khronos/egl/EGL;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::javax.microedition.khronos.egl.EGL>(@__env.CallStaticObjectMethod(android.opengl.GLDebugHelper.staticClass, global::android.opengl.GLDebugHelper._wrap8144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.microedition.khronos.egl.EGL;
		}
		internal static global::MonoJavaBridge.MethodId _GLDebugHelper8145;
		public GLDebugHelper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.opengl.GLDebugHelper._GLDebugHelper8145.native == global::System.IntPtr.Zero)
				global::android.opengl.GLDebugHelper._GLDebugHelper8145 = @__env.GetMethodIDNoThrow(global::android.opengl.GLDebugHelper.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.opengl.GLDebugHelper.staticClass, global::android.opengl.GLDebugHelper._GLDebugHelper8145);
			Init(@__env, handle);
		}
		public static int CONFIG_CHECK_GL_ERROR
		{
			get
			{
				return 1;
			}
		}
		public static int CONFIG_CHECK_THREAD
		{
			get
			{
				return 2;
			}
		}
		public static int CONFIG_LOG_ARGUMENT_NAMES
		{
			get
			{
				return 4;
			}
		}
		public static int ERROR_WRONG_THREAD
		{
			get
			{
				return 28672;
			}
		}
		static GLDebugHelper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.opengl.GLDebugHelper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/opengl/GLDebugHelper"));
		}
		internal static void InitJNI()
		{
		}
	}
}
