namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class IconMarginSpan : java.lang.Object, LeadingMarginSpan, LineHeightSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected IconMarginSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLeadingMargin13489;
		public virtual int getLeadingMargin(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.IconMarginSpan._getLeadingMargin13489.native == global::System.IntPtr.Zero)
				global::android.text.style.IconMarginSpan._getLeadingMargin13489 = @__env.GetMethodIDNoThrow(global::android.text.style.IconMarginSpan.staticClass, "getLeadingMargin", "(Z)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.IconMarginSpan.staticClass, global::android.text.style.IconMarginSpan._getLeadingMargin13489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawLeadingMargin13490;
		public virtual void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.IconMarginSpan._drawLeadingMargin13490.native == global::System.IntPtr.Zero)
				global::android.text.style.IconMarginSpan._drawLeadingMargin13490 = @__env.GetMethodIDNoThrow(global::android.text.style.IconMarginSpan.staticClass, "drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;IIZLandroid/text/Layout;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.IconMarginSpan.staticClass, global::android.text.style.IconMarginSpan._drawLeadingMargin13490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
		}
		public void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, string arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11)
		{
			drawLeadingMargin(arg0, arg1, arg2, arg3, arg4, arg5, arg6, (global::java.lang.CharSequence)(global::java.lang.String)arg7, arg8, arg9, arg10, arg11);
		}
		internal static global::MonoJavaBridge.MethodId _chooseHeight13491;
		public virtual void chooseHeight(java.lang.CharSequence arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Paint.FontMetricsInt arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.IconMarginSpan._chooseHeight13491.native == global::System.IntPtr.Zero)
				global::android.text.style.IconMarginSpan._chooseHeight13491 = @__env.GetMethodIDNoThrow(global::android.text.style.IconMarginSpan.staticClass, "chooseHeight", "(Ljava/lang/CharSequence;IIIILandroid/graphics/Paint$FontMetricsInt;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.IconMarginSpan.staticClass, global::android.text.style.IconMarginSpan._chooseHeight13491, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		public void chooseHeight(string arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Paint.FontMetricsInt arg5)
		{
			chooseHeight((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		internal static global::MonoJavaBridge.MethodId _IconMarginSpan13492;
		public IconMarginSpan(android.graphics.Bitmap arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.IconMarginSpan._IconMarginSpan13492.native == global::System.IntPtr.Zero)
				global::android.text.style.IconMarginSpan._IconMarginSpan13492 = @__env.GetMethodIDNoThrow(global::android.text.style.IconMarginSpan.staticClass, "<init>", "(Landroid/graphics/Bitmap;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.IconMarginSpan.staticClass, global::android.text.style.IconMarginSpan._IconMarginSpan13492, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _IconMarginSpan13493;
		public IconMarginSpan(android.graphics.Bitmap arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.IconMarginSpan._IconMarginSpan13493.native == global::System.IntPtr.Zero)
				global::android.text.style.IconMarginSpan._IconMarginSpan13493 = @__env.GetMethodIDNoThrow(global::android.text.style.IconMarginSpan.staticClass, "<init>", "(Landroid/graphics/Bitmap;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.IconMarginSpan.staticClass, global::android.text.style.IconMarginSpan._IconMarginSpan13493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static IconMarginSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.IconMarginSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/IconMarginSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
