namespace org.json
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JSONTokener : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JSONTokener(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString34137;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._toString34137.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._toString34137 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._toString34137) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next34138;
		public virtual global::java.lang.String next(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._next34138.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._next34138 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "next", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._next34138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _next34139;
		public virtual char next()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._next34139.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._next34139 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "next", "()C");
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._next34139);
		}
		internal static global::MonoJavaBridge.MethodId _next34140;
		public virtual char next(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._next34140.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._next34140 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "next", "(C)C");
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._next34140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _more34141;
		public virtual bool more()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._more34141.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._more34141 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "more", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._more34141);
		}
		internal static global::MonoJavaBridge.MethodId _nextValue34142;
		public virtual global::java.lang.Object nextValue()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._nextValue34142.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._nextValue34142 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextValue", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextValue34142) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _nextString34143;
		public virtual global::java.lang.String nextString(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._nextString34143.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._nextString34143 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextString", "(C)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextString34143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _syntaxError34144;
		public virtual global::org.json.JSONException syntaxError(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._syntaxError34144.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._syntaxError34144 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "syntaxError", "(Ljava/lang/String;)Lorg/json/JSONException;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._syntaxError34144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONException;
		}
		internal static global::MonoJavaBridge.MethodId _nextClean34145;
		public virtual char nextClean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._nextClean34145.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._nextClean34145 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextClean", "()C");
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextClean34145);
		}
		internal static global::MonoJavaBridge.MethodId _nextTo34146;
		public virtual global::java.lang.String nextTo(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._nextTo34146.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._nextTo34146 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextTo", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextTo34146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _nextTo34147;
		public virtual global::java.lang.String nextTo(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._nextTo34147.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._nextTo34147 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "nextTo", "(C)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._nextTo34147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _skipPast34148;
		public virtual void skipPast(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._skipPast34148.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._skipPast34148 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "skipPast", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._skipPast34148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skipTo34149;
		public virtual char skipTo(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._skipTo34149.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._skipTo34149 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "skipTo", "(C)C");
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._skipTo34149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _back34150;
		public virtual void back()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._back34150.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._back34150 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "back", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::org.json.JSONTokener.staticClass, global::org.json.JSONTokener._back34150);
		}
		internal static global::MonoJavaBridge.MethodId _dehexchar34151;
		public static int dehexchar(char arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._dehexchar34151.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._dehexchar34151 = @__env.GetStaticMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "dehexchar", "(C)I");
			return @__env.CallStaticIntMethod(org.json.JSONTokener.staticClass, global::org.json.JSONTokener._dehexchar34151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _JSONTokener34152;
		public JSONTokener(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONTokener._JSONTokener34152.native == global::System.IntPtr.Zero)
				global::org.json.JSONTokener._JSONTokener34152 = @__env.GetMethodIDNoThrow(global::org.json.JSONTokener.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONTokener.staticClass, global::org.json.JSONTokener._JSONTokener34152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static JSONTokener()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONTokener.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONTokener"));
		}
		internal static void InitJNI()
		{
		}
	}
}
