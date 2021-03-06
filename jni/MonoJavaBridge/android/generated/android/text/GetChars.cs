namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.GetChars_))]
	public interface GetChars : java.lang.CharSequence
	{
		void getChars(int arg0, int arg1, char[] arg2, int arg3);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.GetChars))]
	public sealed partial class GetChars_ : java.lang.Object, GetChars
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GetChars_()
		{
			InitJNI();
		}
		internal GetChars_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getChars7681;
		 void android.text.GetChars.getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.GetChars_._getChars7681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.GetChars_.staticClass, global::android.text.GetChars_._getChars7681, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _toString7682;
		 global::java.lang.String java.lang.CharSequence.toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.GetChars_._toString7682)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.GetChars_.staticClass, global::android.text.GetChars_._toString7682)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length7683;
		 int java.lang.CharSequence.length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.GetChars_._length7683);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.GetChars_.staticClass, global::android.text.GetChars_._length7683);
		}
		internal static global::MonoJavaBridge.MethodId _charAt7684;
		 char java.lang.CharSequence.charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.text.GetChars_._charAt7684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.text.GetChars_.staticClass, global::android.text.GetChars_._charAt7684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence7685;
		 global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.GetChars_._subSequence7685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.GetChars_.staticClass, global::android.text.GetChars_._subSequence7685, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.GetChars_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/GetChars"));
			global::android.text.GetChars_._getChars7681 = @__env.GetMethodIDNoThrow(global::android.text.GetChars_.staticClass, "getChars", "(II[CI)V");
			global::android.text.GetChars_._toString7682 = @__env.GetMethodIDNoThrow(global::android.text.GetChars_.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.GetChars_._length7683 = @__env.GetMethodIDNoThrow(global::android.text.GetChars_.staticClass, "length", "()I");
			global::android.text.GetChars_._charAt7684 = @__env.GetMethodIDNoThrow(global::android.text.GetChars_.staticClass, "charAt", "(I)C");
			global::android.text.GetChars_._subSequence7685 = @__env.GetMethodIDNoThrow(global::android.text.GetChars_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
		}
	}
}
