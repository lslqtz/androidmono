namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AlteredCharSequence : java.lang.Object, java.lang.CharSequence, GetChars
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AlteredCharSequence()
		{
			InitJNI();
		}
		protected AlteredCharSequence(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString7585;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.AlteredCharSequence._toString7585)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._toString7585)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length7586;
		public virtual int length() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.text.AlteredCharSequence._length7586);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._length7586);
		}
		internal static global::MonoJavaBridge.MethodId _charAt7587;
		public virtual char charAt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.text.AlteredCharSequence._charAt7587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._charAt7587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChars7588;
		public virtual void getChars(int arg0, int arg1, char[] arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.text.AlteredCharSequence._getChars7588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._getChars7588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence7589;
		public virtual global::java.lang.CharSequence subSequence(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.AlteredCharSequence._subSequence7589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._subSequence7589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _make7590;
		public static global::android.text.AlteredCharSequence make(java.lang.CharSequence arg0, char[] arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.AlteredCharSequence.staticClass, global::android.text.AlteredCharSequence._make7590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.text.AlteredCharSequence;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.AlteredCharSequence.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/AlteredCharSequence"));
			global::android.text.AlteredCharSequence._toString7585 = @__env.GetMethodIDNoThrow(global::android.text.AlteredCharSequence.staticClass, "toString", "()Ljava/lang/String;");
			global::android.text.AlteredCharSequence._length7586 = @__env.GetMethodIDNoThrow(global::android.text.AlteredCharSequence.staticClass, "length", "()I");
			global::android.text.AlteredCharSequence._charAt7587 = @__env.GetMethodIDNoThrow(global::android.text.AlteredCharSequence.staticClass, "charAt", "(I)C");
			global::android.text.AlteredCharSequence._getChars7588 = @__env.GetMethodIDNoThrow(global::android.text.AlteredCharSequence.staticClass, "getChars", "(II[CI)V");
			global::android.text.AlteredCharSequence._subSequence7589 = @__env.GetMethodIDNoThrow(global::android.text.AlteredCharSequence.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			global::android.text.AlteredCharSequence._make7590 = @__env.GetStaticMethodIDNoThrow(global::android.text.AlteredCharSequence.staticClass, "make", "(Ljava/lang/CharSequence;[CII)Landroid/text/AlteredCharSequence;");
		}
	}
}
