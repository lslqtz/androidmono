namespace java.security.spec
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.security.spec.ECField_))]
	public partial interface ECField  : global::MonoJavaBridge.IJavaObject 
	{
		int getFieldSize();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.spec.ECField))]
	internal sealed partial class ECField_ : java.lang.Object, ECField
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ECField_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getFieldSize23978;
		int java.security.spec.ECField.getFieldSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.security.spec.ECField_._getFieldSize23978);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.security.spec.ECField_.staticClass, global::java.security.spec.ECField_._getFieldSize23978);
		}
		static ECField_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECField_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECField"));
			global::java.security.spec.ECField_._getFieldSize23978 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECField_.staticClass, "getFieldSize", "()I");
		}
		internal static void InitJNI()
		{
		}
	}
}