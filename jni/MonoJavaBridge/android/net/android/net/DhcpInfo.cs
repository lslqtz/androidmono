namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class DhcpInfo : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static DhcpInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.DhcpInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.DhcpInfo(@__env); 
			} 
		} 
		protected DhcpInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString4378; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.DhcpInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString4378)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.DhcpInfo.staticClass, _toString4378)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4379; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.DhcpInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel4379, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.DhcpInfo.staticClass, _writeToParcel4379, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4380; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.DhcpInfo)) 
				return @__env.CallIntMethod(this, _describeContents4380); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.DhcpInfo.staticClass, _describeContents4380); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DhcpInfo4381; 
		public DhcpInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.DhcpInfo.staticClass, _DhcpInfo4381, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _ipAddress4382; 
		public int ipAddress
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _gateway4383; 
		public int gateway
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _netmask4384; 
		public int netmask
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _dns14385; 
		public int dns1
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _dns24386; 
		public int dns2
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _serverAddress4387; 
		public int serverAddress
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _leaseDuration4388; 
		public int leaseDuration
		{ 
			get 
			{ 
				return default(int); 
			} 
			set 
			{ 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.DhcpInfo.staticClass = @__class; 
			global::android.net.DhcpInfo._toString4378 = @__env.GetMethodID(global::android.net.DhcpInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.net.DhcpInfo._writeToParcel4379 = @__env.GetMethodID(global::android.net.DhcpInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.net.DhcpInfo._describeContents4380 = @__env.GetMethodID(global::android.net.DhcpInfo.staticClass, "describeContents", "()I"); 
			global::android.net.DhcpInfo._DhcpInfo4381 = @__env.GetMethodID(global::android.net.DhcpInfo.staticClass, "<init>", "()V"); 
		} 
	} 
} 