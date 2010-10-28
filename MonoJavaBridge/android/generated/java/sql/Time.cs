namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Time : java.util.Date
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Time(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString25095;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.Time._toString25095)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._toString25095)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _valueOf25096;
		public static global::java.sql.Time valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.sql.Time.staticClass, global::java.sql.Time._valueOf25096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.Time;
		}
		internal static global::MonoJavaBridge.MethodId _setTime25097;
		public override void setTime(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Time._setTime25097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._setTime25097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Year
		{
			get
			{
				return getYear();
			}
			set
			{
				setYear(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getYear25098;
		public override int getYear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Time._getYear25098);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._getYear25098);
		}
		public new int Month
		{
			get
			{
				return getMonth();
			}
			set
			{
				setMonth(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMonth25099;
		public override int getMonth()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Time._getMonth25099);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._getMonth25099);
		}
		public new int Date
		{
			get
			{
				return getDate();
			}
			set
			{
				setDate(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDate25100;
		public override int getDate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Time._getDate25100);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._getDate25100);
		}
		internal static global::MonoJavaBridge.MethodId _setDate25101;
		public override void setDate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Time._setDate25101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._setDate25101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setMonth25102;
		public override void setMonth(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Time._setMonth25102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._setMonth25102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setYear25103;
		public override void setYear(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.Time._setYear25103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._setYear25103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Day
		{
			get
			{
				return getDay();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDay25104;
		public override int getDay()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.Time._getDay25104);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.Time.staticClass, global::java.sql.Time._getDay25104);
		}
		internal static global::MonoJavaBridge.MethodId _Time25105;
		public Time(int arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Time.staticClass, global::java.sql.Time._Time25105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Time25106;
		public Time(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.Time.staticClass, global::java.sql.Time._Time25106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static Time()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.Time.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/Time"));
			global::java.sql.Time._toString25095 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "toString", "()Ljava/lang/String;");
			global::java.sql.Time._valueOf25096 = @__env.GetStaticMethodIDNoThrow(global::java.sql.Time.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/sql/Time;");
			global::java.sql.Time._setTime25097 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "setTime", "(J)V");
			global::java.sql.Time._getYear25098 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "getYear", "()I");
			global::java.sql.Time._getMonth25099 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "getMonth", "()I");
			global::java.sql.Time._getDate25100 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "getDate", "()I");
			global::java.sql.Time._setDate25101 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "setDate", "(I)V");
			global::java.sql.Time._setMonth25102 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "setMonth", "(I)V");
			global::java.sql.Time._setYear25103 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "setYear", "(I)V");
			global::java.sql.Time._getDay25104 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "getDay", "()I");
			global::java.sql.Time._Time25105 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "<init>", "(III)V");
			global::java.sql.Time._Time25106 = @__env.GetMethodIDNoThrow(global::java.sql.Time.staticClass, "<init>", "(J)V");
		}
		internal static void InitJNI()
		{
		}
	}
}