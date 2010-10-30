namespace android.text.style
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DrawableMarginSpan : java.lang.Object, LeadingMarginSpan, LineHeightSpan
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DrawableMarginSpan(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getLeadingMargin13468;
		public virtual int getLeadingMargin(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.DrawableMarginSpan._getLeadingMargin13468.native == global::System.IntPtr.Zero)
				global::android.text.style.DrawableMarginSpan._getLeadingMargin13468 = @__env.GetMethodIDNoThrow(global::android.text.style.DrawableMarginSpan.staticClass, "getLeadingMargin", "(Z)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.text.style.DrawableMarginSpan.staticClass, global::android.text.style.DrawableMarginSpan._getLeadingMargin13468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _drawLeadingMargin13469;
		public virtual void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, java.lang.CharSequence arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.DrawableMarginSpan._drawLeadingMargin13469.native == global::System.IntPtr.Zero)
				global::android.text.style.DrawableMarginSpan._drawLeadingMargin13469 = @__env.GetMethodIDNoThrow(global::android.text.style.DrawableMarginSpan.staticClass, "drawLeadingMargin", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;IIIIILjava/lang/CharSequence;IIZLandroid/text/Layout;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.DrawableMarginSpan.staticClass, global::android.text.style.DrawableMarginSpan._drawLeadingMargin13469, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg10), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg11));
		}
		public void drawLeadingMargin(android.graphics.Canvas arg0, android.graphics.Paint arg1, int arg2, int arg3, int arg4, int arg5, int arg6, string arg7, int arg8, int arg9, bool arg10, android.text.Layout arg11)
		{
			drawLeadingMargin(arg0, arg1, arg2, arg3, arg4, arg5, arg6, (global::java.lang.CharSequence)(global::java.lang.String)arg7, arg8, arg9, arg10, arg11);
		}
		internal static global::MonoJavaBridge.MethodId _chooseHeight13470;
		public virtual void chooseHeight(java.lang.CharSequence arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Paint.FontMetricsInt arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.DrawableMarginSpan._chooseHeight13470.native == global::System.IntPtr.Zero)
				global::android.text.style.DrawableMarginSpan._chooseHeight13470 = @__env.GetMethodIDNoThrow(global::android.text.style.DrawableMarginSpan.staticClass, "chooseHeight", "(Ljava/lang/CharSequence;IIIILandroid/graphics/Paint$FontMetricsInt;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.text.style.DrawableMarginSpan.staticClass, global::android.text.style.DrawableMarginSpan._chooseHeight13470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		public void chooseHeight(string arg0, int arg1, int arg2, int arg3, int arg4, android.graphics.Paint.FontMetricsInt arg5)
		{
			chooseHeight((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3, arg4, arg5);
		}
		internal static global::MonoJavaBridge.MethodId _DrawableMarginSpan13471;
		public DrawableMarginSpan(android.graphics.drawable.Drawable arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.DrawableMarginSpan._DrawableMarginSpan13471.native == global::System.IntPtr.Zero)
				global::android.text.style.DrawableMarginSpan._DrawableMarginSpan13471 = @__env.GetMethodIDNoThrow(global::android.text.style.DrawableMarginSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.DrawableMarginSpan.staticClass, global::android.text.style.DrawableMarginSpan._DrawableMarginSpan13471, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DrawableMarginSpan13472;
		public DrawableMarginSpan(android.graphics.drawable.Drawable arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.style.DrawableMarginSpan._DrawableMarginSpan13472.native == global::System.IntPtr.Zero)
				global::android.text.style.DrawableMarginSpan._DrawableMarginSpan13472 = @__env.GetMethodIDNoThrow(global::android.text.style.DrawableMarginSpan.staticClass, "<init>", "(Landroid/graphics/drawable/Drawable;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.style.DrawableMarginSpan.staticClass, global::android.text.style.DrawableMarginSpan._DrawableMarginSpan13472, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static DrawableMarginSpan()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.style.DrawableMarginSpan.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/style/DrawableMarginSpan"));
		}
		internal static void InitJNI()
		{
		}
	}
}
