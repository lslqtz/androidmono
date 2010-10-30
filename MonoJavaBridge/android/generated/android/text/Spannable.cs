namespace android.text
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.Spannable_))]
	public partial interface Spannable : Spanned
	{
		void setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3);
		void removeSpan(java.lang.Object arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.Spannable))]
	internal sealed partial class Spannable_ : java.lang.Object, Spannable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Spannable_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setSpan12933;
		void android.text.Spannable.setSpan(java.lang.Object arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Spannable_._setSpan12933.native == global::System.IntPtr.Zero)
				global::android.text.Spannable_._setSpan12933 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "setSpan", "(Ljava/lang/Object;III)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.text.Spannable_._setSpan12933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _removeSpan12934;
		void android.text.Spannable.removeSpan(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Spannable_._removeSpan12934.native == global::System.IntPtr.Zero)
				global::android.text.Spannable_._removeSpan12934 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "removeSpan", "(Ljava/lang/Object;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::android.text.Spannable_._removeSpan12934, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpans12935;
		global::java.lang.Object[] android.text.Spanned.getSpans(int arg0, int arg1, java.lang.Class arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Spannable_._getSpans12935.native == global::System.IntPtr.Zero)
				global::android.text.Spannable_._getSpans12935 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "getSpans", "(IILjava/lang/Class;)[Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Spannable_._getSpans12935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _getSpanStart12936;
		int android.text.Spanned.getSpanStart(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Spannable_._getSpanStart12936.native == global::System.IntPtr.Zero)
				global::android.text.Spannable_._getSpanStart12936 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "getSpanStart", "(Ljava/lang/Object;)I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spannable_._getSpanStart12936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanEnd12937;
		int android.text.Spanned.getSpanEnd(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Spannable_._getSpanEnd12937.native == global::System.IntPtr.Zero)
				global::android.text.Spannable_._getSpanEnd12937 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "getSpanEnd", "(Ljava/lang/Object;)I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spannable_._getSpanEnd12937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getSpanFlags12938;
		int android.text.Spanned.getSpanFlags(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Spannable_._getSpanFlags12938.native == global::System.IntPtr.Zero)
				global::android.text.Spannable_._getSpanFlags12938 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "getSpanFlags", "(Ljava/lang/Object;)I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spannable_._getSpanFlags12938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _nextSpanTransition12939;
		int android.text.Spanned.nextSpanTransition(int arg0, int arg1, java.lang.Class arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Spannable_._nextSpanTransition12939.native == global::System.IntPtr.Zero)
				global::android.text.Spannable_._nextSpanTransition12939 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "nextSpanTransition", "(IILjava/lang/Class;)I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spannable_._nextSpanTransition12939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _toString12940;
		global::java.lang.String java.lang.CharSequence.toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Spannable_._toString12940.native == global::System.IntPtr.Zero)
				global::android.text.Spannable_._toString12940 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Spannable_._toString12940)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _length12941;
		int java.lang.CharSequence.length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Spannable_._length12941.native == global::System.IntPtr.Zero)
				global::android.text.Spannable_._length12941 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "length", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::android.text.Spannable_._length12941);
		}
		internal static global::MonoJavaBridge.MethodId _charAt12942;
		char java.lang.CharSequence.charAt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Spannable_._charAt12942.native == global::System.IntPtr.Zero)
				global::android.text.Spannable_._charAt12942 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "charAt", "(I)C");
			return @__env.CallCharMethod(this.JvmHandle, global::android.text.Spannable_._charAt12942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _subSequence12943;
		global::java.lang.CharSequence java.lang.CharSequence.subSequence(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.Spannable_._subSequence12943.native == global::System.IntPtr.Zero)
				global::android.text.Spannable_._subSequence12943 = @__env.GetMethodIDNoThrow(global::android.text.Spannable_.staticClass, "subSequence", "(II)Ljava/lang/CharSequence;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Spannable_._subSequence12943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.CharSequence;
		}
		static Spannable_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Spannable_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Spannable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
