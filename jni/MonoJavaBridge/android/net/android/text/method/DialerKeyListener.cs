namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DialerKeyListener : android.text.method.NumberKeyListener
	{ 
		internal new static global::java.lang.Class staticClass; 
		static DialerKeyListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.method.DialerKeyListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.method.DialerKeyListener(@__env); 
			} 
		} 
		protected DialerKeyListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance6783; 
		public static android.text.method.DialerKeyListener getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.DialerKeyListener>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.DialerKeyListener.staticClass, _getInstance6783)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _lookup6784; 
		protected override int lookup(android.view.KeyEvent arg0, android.text.Spannable arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.DialerKeyListener)) 
				return @__env.CallIntMethod(this, _lookup6784, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.method.DialerKeyListener.staticClass, _lookup6784, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInputType6785; 
		public override int getInputType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.method.DialerKeyListener)) 
				return @__env.CallIntMethod(this, _getInputType6785); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.method.DialerKeyListener.staticClass, _getInputType6785); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAcceptedChars6786; 
		protected override char[] getAcceptedChars() 
		{ 
			if (GetType() == typeof(android.text.method.DialerKeyListener)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getAcceptedChars6786)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.method.DialerKeyListener.staticClass, _getAcceptedChars6786)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DialerKeyListener6787; 
		public DialerKeyListener()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.method.DialerKeyListener.staticClass, _DialerKeyListener6787, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CHARACTERS6788; 
		public static char[] CHARACTERS
		{ 
			get 
			{ 
				return default(char[]); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.DialerKeyListener.staticClass = @__class; 
			global::android.text.method.DialerKeyListener._getInstance6783 = @__env.GetStaticMethodID(global::android.text.method.DialerKeyListener.staticClass, "getInstance", "()Landroid/text/method/DialerKeyListener;"); 
			global::android.text.method.DialerKeyListener._lookup6784 = @__env.GetMethodID(global::android.text.method.DialerKeyListener.staticClass, "lookup", "(Landroid/view/KeyEvent;Landroid/text/Spannable;)I"); 
			global::android.text.method.DialerKeyListener._getInputType6785 = @__env.GetMethodID(global::android.text.method.DialerKeyListener.staticClass, "getInputType", "()I"); 
			global::android.text.method.DialerKeyListener._getAcceptedChars6786 = @__env.GetMethodID(global::android.text.method.DialerKeyListener.staticClass, "getAcceptedChars", "()[C"); 
			global::android.text.method.DialerKeyListener._DialerKeyListener6787 = @__env.GetMethodID(global::android.text.method.DialerKeyListener.staticClass, "<init>", "()V"); 
		} 
	} 
} 