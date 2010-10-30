namespace android.bluetooth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BluetoothSocket : java.lang.Object, java.io.Closeable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal BluetoothSocket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _close2553;
		public void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.bluetooth.BluetoothSocket._close2553.native == global::System.IntPtr.Zero)
				global::android.bluetooth.BluetoothSocket._close2553 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothSocket.staticClass, "close", "()V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._close2553);
		}
		public new global::java.io.InputStream InputStream
		{
			get
			{
				return getInputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getInputStream2554;
		public global::java.io.InputStream getInputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.bluetooth.BluetoothSocket._getInputStream2554.native == global::System.IntPtr.Zero)
				global::android.bluetooth.BluetoothSocket._getInputStream2554 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothSocket.staticClass, "getInputStream", "()Ljava/io/InputStream;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._getInputStream2554)) as java.io.InputStream;
		}
		internal static global::MonoJavaBridge.MethodId _connect2555;
		public void connect()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.bluetooth.BluetoothSocket._connect2555.native == global::System.IntPtr.Zero)
				global::android.bluetooth.BluetoothSocket._connect2555 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothSocket.staticClass, "connect", "()V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._connect2555);
		}
		public new global::java.io.OutputStream OutputStream
		{
			get
			{
				return getOutputStream();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOutputStream2556;
		public global::java.io.OutputStream getOutputStream()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.bluetooth.BluetoothSocket._getOutputStream2556.native == global::System.IntPtr.Zero)
				global::android.bluetooth.BluetoothSocket._getOutputStream2556 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothSocket.staticClass, "getOutputStream", "()Ljava/io/OutputStream;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._getOutputStream2556)) as java.io.OutputStream;
		}
		public new global::android.bluetooth.BluetoothDevice RemoteDevice
		{
			get
			{
				return getRemoteDevice();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRemoteDevice2557;
		public global::android.bluetooth.BluetoothDevice getRemoteDevice()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.bluetooth.BluetoothSocket._getRemoteDevice2557.native == global::System.IntPtr.Zero)
				global::android.bluetooth.BluetoothSocket._getRemoteDevice2557 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothSocket.staticClass, "getRemoteDevice", "()Landroid/bluetooth/BluetoothDevice;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.bluetooth.BluetoothDevice>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothSocket.staticClass, global::android.bluetooth.BluetoothSocket._getRemoteDevice2557)) as android.bluetooth.BluetoothDevice;
		}
		static BluetoothSocket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.bluetooth.BluetoothSocket.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/bluetooth/BluetoothSocket"));
		}
		internal static void InitJNI()
		{
		}
	}
}
