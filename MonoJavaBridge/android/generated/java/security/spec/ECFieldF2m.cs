namespace java.security.spec
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ECFieldF2m : java.lang.Object, ECField
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ECFieldF2m(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals23979;
		public override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECFieldF2m._equals23979.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECFieldF2m._equals23979 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._equals23979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode23980;
		public override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECFieldF2m._hashCode23980.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECFieldF2m._hashCode23980 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "hashCode", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._hashCode23980);
		}
		public new int FieldSize
		{
			get
			{
				return getFieldSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFieldSize23981;
		public virtual int getFieldSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECFieldF2m._getFieldSize23981.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECFieldF2m._getFieldSize23981 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "getFieldSize", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._getFieldSize23981);
		}
		public new int M
		{
			get
			{
				return getM();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getM23982;
		public virtual int getM()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECFieldF2m._getM23982.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECFieldF2m._getM23982 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "getM", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._getM23982);
		}
		public new global::java.math.BigInteger ReductionPolynomial
		{
			get
			{
				return getReductionPolynomial();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReductionPolynomial23983;
		public virtual global::java.math.BigInteger getReductionPolynomial()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECFieldF2m._getReductionPolynomial23983.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECFieldF2m._getReductionPolynomial23983 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "getReductionPolynomial", "()Ljava/math/BigInteger;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._getReductionPolynomial23983) as java.math.BigInteger;
		}
		public new int[] MidTermsOfReductionPolynomial
		{
			get
			{
				return getMidTermsOfReductionPolynomial();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMidTermsOfReductionPolynomial23984;
		public virtual int[] getMidTermsOfReductionPolynomial()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECFieldF2m._getMidTermsOfReductionPolynomial23984.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECFieldF2m._getMidTermsOfReductionPolynomial23984 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "getMidTermsOfReductionPolynomial", "()[I");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._getMidTermsOfReductionPolynomial23984) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _ECFieldF2m23985;
		public ECFieldF2m(int arg0, java.math.BigInteger arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECFieldF2m._ECFieldF2m23985.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECFieldF2m._ECFieldF2m23985 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "<init>", "(ILjava/math/BigInteger;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._ECFieldF2m23985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ECFieldF2m23986;
		public ECFieldF2m(int arg0, int[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECFieldF2m._ECFieldF2m23986.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECFieldF2m._ECFieldF2m23986 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "<init>", "(I[I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._ECFieldF2m23986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ECFieldF2m23987;
		public ECFieldF2m(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.spec.ECFieldF2m._ECFieldF2m23987.native == global::System.IntPtr.Zero)
				global::java.security.spec.ECFieldF2m._ECFieldF2m23987 = @__env.GetMethodIDNoThrow(global::java.security.spec.ECFieldF2m.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.spec.ECFieldF2m.staticClass, global::java.security.spec.ECFieldF2m._ECFieldF2m23987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static ECFieldF2m()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.spec.ECFieldF2m.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/spec/ECFieldF2m"));
		}
		internal static void InitJNI()
		{
		}
	}
}
