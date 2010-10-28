namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ParcelFileDescriptor : java.lang.Object, Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ParcelFileDescriptor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class AutoCloseInputStream : java.io.FileInputStream
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected AutoCloseInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _close10077;
			public override void close()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor.AutoCloseInputStream._close10077);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor.AutoCloseInputStream.staticClass, global::android.os.ParcelFileDescriptor.AutoCloseInputStream._close10077);
			}
			internal static global::MonoJavaBridge.MethodId _AutoCloseInputStream10078;
			public AutoCloseInputStream(android.os.ParcelFileDescriptor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ParcelFileDescriptor.AutoCloseInputStream.staticClass, global::android.os.ParcelFileDescriptor.AutoCloseInputStream._AutoCloseInputStream10078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static AutoCloseInputStream()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.ParcelFileDescriptor.AutoCloseInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/ParcelFileDescriptor$AutoCloseInputStream"));
				global::android.os.ParcelFileDescriptor.AutoCloseInputStream._close10077 = @__env.GetMethodIDNoThrow(global::android.os.ParcelFileDescriptor.AutoCloseInputStream.staticClass, "close", "()V");
				global::android.os.ParcelFileDescriptor.AutoCloseInputStream._AutoCloseInputStream10078 = @__env.GetMethodIDNoThrow(global::android.os.ParcelFileDescriptor.AutoCloseInputStream.staticClass, "<init>", "(Landroid/os/ParcelFileDescriptor;)V");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class AutoCloseOutputStream : java.io.FileOutputStream
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected AutoCloseOutputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _close10079;
			public override void close()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor.AutoCloseOutputStream._close10079);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor.AutoCloseOutputStream.staticClass, global::android.os.ParcelFileDescriptor.AutoCloseOutputStream._close10079);
			}
			internal static global::MonoJavaBridge.MethodId _AutoCloseOutputStream10080;
			public AutoCloseOutputStream(android.os.ParcelFileDescriptor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ParcelFileDescriptor.AutoCloseOutputStream.staticClass, global::android.os.ParcelFileDescriptor.AutoCloseOutputStream._AutoCloseOutputStream10080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			static AutoCloseOutputStream()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.ParcelFileDescriptor.AutoCloseOutputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/ParcelFileDescriptor$AutoCloseOutputStream"));
				global::android.os.ParcelFileDescriptor.AutoCloseOutputStream._close10079 = @__env.GetMethodIDNoThrow(global::android.os.ParcelFileDescriptor.AutoCloseOutputStream.staticClass, "close", "()V");
				global::android.os.ParcelFileDescriptor.AutoCloseOutputStream._AutoCloseOutputStream10080 = @__env.GetMethodIDNoThrow(global::android.os.ParcelFileDescriptor.AutoCloseOutputStream.staticClass, "<init>", "(Landroid/os/ParcelFileDescriptor;)V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize10081;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor._finalize10081);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._finalize10081);
		}
		internal static global::MonoJavaBridge.MethodId _toString10082;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor._toString10082)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._toString10082)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _close10083;
		public virtual void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor._close10083);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._close10083);
		}
		internal static global::MonoJavaBridge.MethodId _open10084;
		public static global::android.os.ParcelFileDescriptor open(java.io.File arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._open10084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.ParcelFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel10085;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor._writeToParcel10085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._writeToParcel10085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents10086;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor._describeContents10086);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._describeContents10086);
		}
		internal static global::MonoJavaBridge.MethodId _fromSocket10087;
		public static global::android.os.ParcelFileDescriptor fromSocket(java.net.Socket arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._fromSocket10087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.ParcelFileDescriptor;
		}
		public new global::java.io.FileDescriptor FileDescriptor
		{
			get
			{
				return getFileDescriptor();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getFileDescriptor10088;
		public virtual global::java.io.FileDescriptor getFileDescriptor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor._getFileDescriptor10088)) as java.io.FileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.io.FileDescriptor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._getFileDescriptor10088)) as java.io.FileDescriptor;
		}
		public new long StatSize
		{
			get
			{
				return getStatSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStatSize10089;
		public virtual long getStatSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor._getStatSize10089);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._getStatSize10089);
		}
		internal static global::MonoJavaBridge.MethodId _ParcelFileDescriptor10090;
		public ParcelFileDescriptor(android.os.ParcelFileDescriptor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._ParcelFileDescriptor10090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int MODE_WORLD_READABLE
		{
			get
			{
				return 1;
			}
		}
		public static int MODE_WORLD_WRITEABLE
		{
			get
			{
				return 2;
			}
		}
		public static int MODE_READ_ONLY
		{
			get
			{
				return 268435456;
			}
		}
		public static int MODE_WRITE_ONLY
		{
			get
			{
				return 536870912;
			}
		}
		public static int MODE_READ_WRITE
		{
			get
			{
				return 805306368;
			}
		}
		public static int MODE_CREATE
		{
			get
			{
				return 134217728;
			}
		}
		public static int MODE_TRUNCATE
		{
			get
			{
				return 67108864;
			}
		}
		public static int MODE_APPEND
		{
			get
			{
				return 33554432;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR10099;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.ParcelFileDescriptor.staticClass, _CREATOR10099)) as android.os.Parcelable_Creator;
			}
		}
		static ParcelFileDescriptor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.ParcelFileDescriptor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/ParcelFileDescriptor"));
			global::android.os.ParcelFileDescriptor._finalize10081 = @__env.GetMethodIDNoThrow(global::android.os.ParcelFileDescriptor.staticClass, "finalize", "()V");
			global::android.os.ParcelFileDescriptor._toString10082 = @__env.GetMethodIDNoThrow(global::android.os.ParcelFileDescriptor.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.ParcelFileDescriptor._close10083 = @__env.GetMethodIDNoThrow(global::android.os.ParcelFileDescriptor.staticClass, "close", "()V");
			global::android.os.ParcelFileDescriptor._open10084 = @__env.GetStaticMethodIDNoThrow(global::android.os.ParcelFileDescriptor.staticClass, "open", "(Ljava/io/File;I)Landroid/os/ParcelFileDescriptor;");
			global::android.os.ParcelFileDescriptor._writeToParcel10085 = @__env.GetMethodIDNoThrow(global::android.os.ParcelFileDescriptor.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.ParcelFileDescriptor._describeContents10086 = @__env.GetMethodIDNoThrow(global::android.os.ParcelFileDescriptor.staticClass, "describeContents", "()I");
			global::android.os.ParcelFileDescriptor._fromSocket10087 = @__env.GetStaticMethodIDNoThrow(global::android.os.ParcelFileDescriptor.staticClass, "fromSocket", "(Ljava/net/Socket;)Landroid/os/ParcelFileDescriptor;");
			global::android.os.ParcelFileDescriptor._getFileDescriptor10088 = @__env.GetMethodIDNoThrow(global::android.os.ParcelFileDescriptor.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			global::android.os.ParcelFileDescriptor._getStatSize10089 = @__env.GetMethodIDNoThrow(global::android.os.ParcelFileDescriptor.staticClass, "getStatSize", "()J");
			global::android.os.ParcelFileDescriptor._ParcelFileDescriptor10090 = @__env.GetMethodIDNoThrow(global::android.os.ParcelFileDescriptor.staticClass, "<init>", "(Landroid/os/ParcelFileDescriptor;)V");
			global::android.os.ParcelFileDescriptor._CREATOR10099 = @__env.GetStaticFieldIDNoThrow(global::android.os.ParcelFileDescriptor.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}