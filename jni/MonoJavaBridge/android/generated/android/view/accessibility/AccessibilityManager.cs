namespace android.view.accessibility
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class AccessibilityManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccessibilityManager()
		{
			InitJNI();
		}
		internal AccessibilityManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _interrupt9884;
		public void interrupt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager._interrupt9884);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager.staticClass, global::android.view.accessibility.AccessibilityManager._interrupt9884);
		}
		internal static global::MonoJavaBridge.MethodId _isEnabled9885;
		public bool isEnabled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager._isEnabled9885);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager.staticClass, global::android.view.accessibility.AccessibilityManager._isEnabled9885);
		}
		internal static global::MonoJavaBridge.MethodId _sendAccessibilityEvent9886;
		public void sendAccessibilityEvent(android.view.accessibility.AccessibilityEvent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager._sendAccessibilityEvent9886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager.staticClass, global::android.view.accessibility.AccessibilityManager._sendAccessibilityEvent9886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getAccessibilityServiceList9887;
		public global::java.util.List getAccessibilityServiceList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager._getAccessibilityServiceList9887)) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.accessibility.AccessibilityManager.staticClass, global::android.view.accessibility.AccessibilityManager._getAccessibilityServiceList9887)) as java.util.List;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.accessibility.AccessibilityManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/accessibility/AccessibilityManager"));
			global::android.view.accessibility.AccessibilityManager._interrupt9884 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityManager.staticClass, "interrupt", "()V");
			global::android.view.accessibility.AccessibilityManager._isEnabled9885 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityManager.staticClass, "isEnabled", "()Z");
			global::android.view.accessibility.AccessibilityManager._sendAccessibilityEvent9886 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityManager.staticClass, "sendAccessibilityEvent", "(Landroid/view/accessibility/AccessibilityEvent;)V");
			global::android.view.accessibility.AccessibilityManager._getAccessibilityServiceList9887 = @__env.GetMethodIDNoThrow(global::android.view.accessibility.AccessibilityManager.staticClass, "getAccessibilityServiceList", "()Ljava/util/List;");
		}
	}
}
