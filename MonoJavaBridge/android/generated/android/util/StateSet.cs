namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StateSet : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StateSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _dump13878;
		public static global::java.lang.String dump(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.StateSet._dump13878.native == global::System.IntPtr.Zero)
				global::android.util.StateSet._dump13878 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "dump", "([I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.util.StateSet.staticClass, global::android.util.StateSet._dump13878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isWildCard13879;
		public static bool isWildCard(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.StateSet._isWildCard13879.native == global::System.IntPtr.Zero)
				global::android.util.StateSet._isWildCard13879 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "isWildCard", "([I)Z");
			return @__env.CallStaticBooleanMethod(android.util.StateSet.staticClass, global::android.util.StateSet._isWildCard13879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stateSetMatches13880;
		public static bool stateSetMatches(int[] arg0, int[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.StateSet._stateSetMatches13880.native == global::System.IntPtr.Zero)
				global::android.util.StateSet._stateSetMatches13880 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "stateSetMatches", "([I[I)Z");
			return @__env.CallStaticBooleanMethod(android.util.StateSet.staticClass, global::android.util.StateSet._stateSetMatches13880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stateSetMatches13881;
		public static bool stateSetMatches(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.StateSet._stateSetMatches13881.native == global::System.IntPtr.Zero)
				global::android.util.StateSet._stateSetMatches13881 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "stateSetMatches", "([II)Z");
			return @__env.CallStaticBooleanMethod(android.util.StateSet.staticClass, global::android.util.StateSet._stateSetMatches13881, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _trimStateSet13882;
		public static int[] trimStateSet(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.StateSet._trimStateSet13882.native == global::System.IntPtr.Zero)
				global::android.util.StateSet._trimStateSet13882 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "trimStateSet", "([II)[I");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.util.StateSet.staticClass, global::android.util.StateSet._trimStateSet13882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _StateSet13883;
		public StateSet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.StateSet._StateSet13883.native == global::System.IntPtr.Zero)
				global::android.util.StateSet._StateSet13883 = @__env.GetMethodIDNoThrow(global::android.util.StateSet.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.StateSet.staticClass, global::android.util.StateSet._StateSet13883);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _WILD_CARD13884;
		public static int[] WILD_CARD
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.GetStaticObjectField(global::android.util.StateSet.staticClass, _WILD_CARD13884)) as int[];
			}
		}
		static StateSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.StateSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/StateSet"));
			global::android.util.StateSet._WILD_CARD13884 = @__env.GetStaticFieldIDNoThrow(global::android.util.StateSet.staticClass, "WILD_CARD", "[I");
		}
		internal static void InitJNI()
		{
		}
	}
}
