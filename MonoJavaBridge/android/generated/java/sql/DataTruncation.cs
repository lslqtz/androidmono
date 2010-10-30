namespace java.sql
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DataTruncation : java.sql.SQLWarning
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DataTruncation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Index
		{
			get
			{
				return getIndex();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndex24370;
		public virtual int getIndex()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DataTruncation._getIndex24370.native == global::System.IntPtr.Zero)
				global::java.sql.DataTruncation._getIndex24370 = @__env.GetMethodIDNoThrow(global::java.sql.DataTruncation.staticClass, "getIndex", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DataTruncation.staticClass, global::java.sql.DataTruncation._getIndex24370);
		}
		public new bool Parameter
		{
			get
			{
				return getParameter();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameter24371;
		public virtual bool getParameter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DataTruncation._getParameter24371.native == global::System.IntPtr.Zero)
				global::java.sql.DataTruncation._getParameter24371 = @__env.GetMethodIDNoThrow(global::java.sql.DataTruncation.staticClass, "getParameter", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DataTruncation.staticClass, global::java.sql.DataTruncation._getParameter24371);
		}
		public new int DataSize
		{
			get
			{
				return getDataSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDataSize24372;
		public virtual int getDataSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DataTruncation._getDataSize24372.native == global::System.IntPtr.Zero)
				global::java.sql.DataTruncation._getDataSize24372 = @__env.GetMethodIDNoThrow(global::java.sql.DataTruncation.staticClass, "getDataSize", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DataTruncation.staticClass, global::java.sql.DataTruncation._getDataSize24372);
		}
		public new bool Read
		{
			get
			{
				return getRead();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRead24373;
		public virtual bool getRead()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DataTruncation._getRead24373.native == global::System.IntPtr.Zero)
				global::java.sql.DataTruncation._getRead24373 = @__env.GetMethodIDNoThrow(global::java.sql.DataTruncation.staticClass, "getRead", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.DataTruncation.staticClass, global::java.sql.DataTruncation._getRead24373);
		}
		public new int TransferSize
		{
			get
			{
				return getTransferSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTransferSize24374;
		public virtual int getTransferSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DataTruncation._getTransferSize24374.native == global::System.IntPtr.Zero)
				global::java.sql.DataTruncation._getTransferSize24374 = @__env.GetMethodIDNoThrow(global::java.sql.DataTruncation.staticClass, "getTransferSize", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.DataTruncation.staticClass, global::java.sql.DataTruncation._getTransferSize24374);
		}
		internal static global::MonoJavaBridge.MethodId _DataTruncation24375;
		public DataTruncation(int arg0, bool arg1, bool arg2, int arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DataTruncation._DataTruncation24375.native == global::System.IntPtr.Zero)
				global::java.sql.DataTruncation._DataTruncation24375 = @__env.GetMethodIDNoThrow(global::java.sql.DataTruncation.staticClass, "<init>", "(IZZII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.DataTruncation.staticClass, global::java.sql.DataTruncation._DataTruncation24375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DataTruncation24376;
		public DataTruncation(int arg0, bool arg1, bool arg2, int arg3, int arg4, java.lang.Throwable arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.sql.DataTruncation._DataTruncation24376.native == global::System.IntPtr.Zero)
				global::java.sql.DataTruncation._DataTruncation24376 = @__env.GetMethodIDNoThrow(global::java.sql.DataTruncation.staticClass, "<init>", "(IZZIILjava/lang/Throwable;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.sql.DataTruncation.staticClass, global::java.sql.DataTruncation._DataTruncation24376, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			Init(@__env, handle);
		}
		static DataTruncation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.DataTruncation.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/DataTruncation"));
		}
		internal static void InitJNI()
		{
		}
	}
}
