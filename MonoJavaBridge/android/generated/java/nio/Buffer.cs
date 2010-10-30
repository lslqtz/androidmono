namespace java.nio
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.nio.Buffer_))]
	public abstract partial class Buffer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Buffer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _limit21995;
		public virtual int limit()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.Buffer._limit21995.native == global::System.IntPtr.Zero)
				global::java.nio.Buffer._limit21995 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "limit", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._limit21995);
		}
		internal static global::MonoJavaBridge.MethodId _limit21996;
		public virtual global::java.nio.Buffer limit(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.Buffer._limit21996.native == global::System.IntPtr.Zero)
				global::java.nio.Buffer._limit21996 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "limit", "(I)Ljava/nio/Buffer;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._limit21996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _clear21997;
		public virtual global::java.nio.Buffer clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.Buffer._clear21997.native == global::System.IntPtr.Zero)
				global::java.nio.Buffer._clear21997 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "clear", "()Ljava/nio/Buffer;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._clear21997) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _remaining21998;
		public virtual int remaining()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.Buffer._remaining21998.native == global::System.IntPtr.Zero)
				global::java.nio.Buffer._remaining21998 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "remaining", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._remaining21998);
		}
		internal static global::MonoJavaBridge.MethodId _hasArray21999;
		public abstract bool hasArray();
		internal static global::MonoJavaBridge.MethodId _array22000;
		public abstract global::java.lang.Object array();
		internal static global::MonoJavaBridge.MethodId _position22001;
		public virtual global::java.nio.Buffer position(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.Buffer._position22001.native == global::System.IntPtr.Zero)
				global::java.nio.Buffer._position22001 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "position", "(I)Ljava/nio/Buffer;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._position22001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _position22002;
		public virtual int position()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.Buffer._position22002.native == global::System.IntPtr.Zero)
				global::java.nio.Buffer._position22002 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "position", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._position22002);
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22003;
		public abstract int arrayOffset();
		internal static global::MonoJavaBridge.MethodId _capacity22004;
		public virtual int capacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.Buffer._capacity22004.native == global::System.IntPtr.Zero)
				global::java.nio.Buffer._capacity22004 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "capacity", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._capacity22004);
		}
		internal static global::MonoJavaBridge.MethodId _mark22005;
		public virtual global::java.nio.Buffer mark()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.Buffer._mark22005.native == global::System.IntPtr.Zero)
				global::java.nio.Buffer._mark22005 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "mark", "()Ljava/nio/Buffer;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._mark22005) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _reset22006;
		public virtual global::java.nio.Buffer reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.Buffer._reset22006.native == global::System.IntPtr.Zero)
				global::java.nio.Buffer._reset22006 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "reset", "()Ljava/nio/Buffer;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._reset22006) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _flip22007;
		public virtual global::java.nio.Buffer flip()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.Buffer._flip22007.native == global::System.IntPtr.Zero)
				global::java.nio.Buffer._flip22007 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "flip", "()Ljava/nio/Buffer;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._flip22007) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _rewind22008;
		public virtual global::java.nio.Buffer rewind()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.Buffer._rewind22008.native == global::System.IntPtr.Zero)
				global::java.nio.Buffer._rewind22008 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "rewind", "()Ljava/nio/Buffer;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._rewind22008) as java.nio.Buffer;
		}
		internal static global::MonoJavaBridge.MethodId _hasRemaining22009;
		public virtual bool hasRemaining()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.Buffer._hasRemaining22009.native == global::System.IntPtr.Zero)
				global::java.nio.Buffer._hasRemaining22009 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer.staticClass, "hasRemaining", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.nio.Buffer.staticClass, global::java.nio.Buffer._hasRemaining22009);
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22010;
		public abstract bool isReadOnly();
		static Buffer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.Buffer.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/Buffer"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.nio.Buffer))]
	internal sealed partial class Buffer_ : java.nio.Buffer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Buffer_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _hasArray22011;
		public override bool hasArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.Buffer_._hasArray22011.native == global::System.IntPtr.Zero)
				global::java.nio.Buffer_._hasArray22011 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "hasArray", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.Buffer_._hasArray22011);
		}
		internal static global::MonoJavaBridge.MethodId _array22012;
		public override global::java.lang.Object array()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.Buffer_._array22012.native == global::System.IntPtr.Zero)
				global::java.nio.Buffer_._array22012 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "array", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.nio.Buffer_._array22012)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _arrayOffset22013;
		public override int arrayOffset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.Buffer_._arrayOffset22013.native == global::System.IntPtr.Zero)
				global::java.nio.Buffer_._arrayOffset22013 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "arrayOffset", "()I");
			return @__env.CallIntMethod(this.JvmHandle, global::java.nio.Buffer_._arrayOffset22013);
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly22014;
		public override bool isReadOnly()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.nio.Buffer_._isReadOnly22014.native == global::System.IntPtr.Zero)
				global::java.nio.Buffer_._isReadOnly22014 = @__env.GetMethodIDNoThrow(global::java.nio.Buffer_.staticClass, "isReadOnly", "()Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::java.nio.Buffer_._isReadOnly22014);
		}
		static Buffer_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.nio.Buffer_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/nio/Buffer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
