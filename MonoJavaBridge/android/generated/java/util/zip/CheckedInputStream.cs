namespace java.util.zip
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CheckedInputStream : java.io.FilterInputStream
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CheckedInputStream(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _read28339;
		public override int read()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.CheckedInputStream._read28339.native == global::System.IntPtr.Zero)
				global::java.util.zip.CheckedInputStream._read28339 = @__env.GetMethodIDNoThrow(global::java.util.zip.CheckedInputStream.staticClass, "read", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.CheckedInputStream.staticClass, global::java.util.zip.CheckedInputStream._read28339);
		}
		internal static global::MonoJavaBridge.MethodId _read28340;
		public override int read(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.CheckedInputStream._read28340.native == global::System.IntPtr.Zero)
				global::java.util.zip.CheckedInputStream._read28340 = @__env.GetMethodIDNoThrow(global::java.util.zip.CheckedInputStream.staticClass, "read", "([BII)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.util.zip.CheckedInputStream.staticClass, global::java.util.zip.CheckedInputStream._read28340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _skip28341;
		public override long skip(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.CheckedInputStream._skip28341.native == global::System.IntPtr.Zero)
				global::java.util.zip.CheckedInputStream._skip28341 = @__env.GetMethodIDNoThrow(global::java.util.zip.CheckedInputStream.staticClass, "skip", "(J)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.util.zip.CheckedInputStream.staticClass, global::java.util.zip.CheckedInputStream._skip28341, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.zip.Checksum Checksum
		{
			get
			{
				return getChecksum();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChecksum28342;
		public virtual global::java.util.zip.Checksum getChecksum()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.CheckedInputStream._getChecksum28342.native == global::System.IntPtr.Zero)
				global::java.util.zip.CheckedInputStream._getChecksum28342 = @__env.GetMethodIDNoThrow(global::java.util.zip.CheckedInputStream.staticClass, "getChecksum", "()Ljava/util/zip/Checksum;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.zip.Checksum>(this, global::java.util.zip.CheckedInputStream.staticClass, global::java.util.zip.CheckedInputStream._getChecksum28342) as java.util.zip.Checksum;
		}
		internal static global::MonoJavaBridge.MethodId _CheckedInputStream28343;
		public CheckedInputStream(java.io.InputStream arg0, java.util.zip.Checksum arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.util.zip.CheckedInputStream._CheckedInputStream28343.native == global::System.IntPtr.Zero)
				global::java.util.zip.CheckedInputStream._CheckedInputStream28343 = @__env.GetMethodIDNoThrow(global::java.util.zip.CheckedInputStream.staticClass, "<init>", "(Ljava/io/InputStream;Ljava/util/zip/Checksum;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.zip.CheckedInputStream.staticClass, global::java.util.zip.CheckedInputStream._CheckedInputStream28343, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static CheckedInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.zip.CheckedInputStream.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/zip/CheckedInputStream"));
		}
		internal static void InitJNI()
		{
		}
	}
}
