namespace javax.microedition.khronos.egl
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::javax.microedition.khronos.egl.EGL10_))]
	public interface EGL10 : EGL
	{
		bool eglChooseConfig(javax.microedition.khronos.egl.EGLDisplay arg0, int[] arg1, javax.microedition.khronos.egl.EGLConfig[] arg2, int arg3, int[] arg4);
		bool eglCopyBuffers(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, java.lang.Object arg2);
		global::javax.microedition.khronos.egl.EGLContext eglCreateContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, javax.microedition.khronos.egl.EGLContext arg2, int[] arg3);
		global::javax.microedition.khronos.egl.EGLSurface eglCreatePbufferSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, int[] arg2);
		global::javax.microedition.khronos.egl.EGLSurface eglCreatePixmapSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, java.lang.Object arg2, int[] arg3);
		global::javax.microedition.khronos.egl.EGLSurface eglCreateWindowSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, java.lang.Object arg2, int[] arg3);
		bool eglDestroyContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLContext arg1);
		bool eglDestroySurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1);
		bool eglGetConfigAttrib(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, int arg2, int[] arg3);
		bool eglGetConfigs(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig[] arg1, int arg2, int[] arg3);
		global::javax.microedition.khronos.egl.EGLContext eglGetCurrentContext();
		global::javax.microedition.khronos.egl.EGLDisplay eglGetCurrentDisplay();
		global::javax.microedition.khronos.egl.EGLSurface eglGetCurrentSurface(int arg0);
		global::javax.microedition.khronos.egl.EGLDisplay eglGetDisplay(java.lang.Object arg0);
		int eglGetError();
		bool eglInitialize(javax.microedition.khronos.egl.EGLDisplay arg0, int[] arg1);
		bool eglMakeCurrent(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, javax.microedition.khronos.egl.EGLSurface arg2, javax.microedition.khronos.egl.EGLContext arg3);
		bool eglQueryContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLContext arg1, int arg2, int[] arg3);
		global::java.lang.String eglQueryString(javax.microedition.khronos.egl.EGLDisplay arg0, int arg1);
		bool eglQuerySurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, int arg2, int[] arg3);
		bool eglSwapBuffers(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1);
		bool eglTerminate(javax.microedition.khronos.egl.EGLDisplay arg0);
		bool eglWaitGL();
		bool eglWaitNative(int arg0, java.lang.Object arg1);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::javax.microedition.khronos.egl.EGL10))]
	public sealed partial class EGL10_ : java.lang.Object, EGL10
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static EGL10_()
		{
			InitJNI();
		}
		internal EGL10_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _eglChooseConfig15796;
		 bool javax.microedition.khronos.egl.EGL10.eglChooseConfig(javax.microedition.khronos.egl.EGLDisplay arg0, int[] arg1, javax.microedition.khronos.egl.EGLConfig[] arg2, int arg3, int[] arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglChooseConfig15796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglChooseConfig15796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _eglCopyBuffers15797;
		 bool javax.microedition.khronos.egl.EGL10.eglCopyBuffers(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, java.lang.Object arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglCopyBuffers15797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglCopyBuffers15797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _eglCreateContext15798;
		 global::javax.microedition.khronos.egl.EGLContext javax.microedition.khronos.egl.EGL10.eglCreateContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, javax.microedition.khronos.egl.EGLContext arg2, int[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglCreateContext15798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglCreateContext15798, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLContext;
		}
		internal static global::MonoJavaBridge.MethodId _eglCreatePbufferSurface15799;
		 global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglCreatePbufferSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, int[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglCreatePbufferSurface15799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.microedition.khronos.egl.EGLSurface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglCreatePbufferSurface15799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as javax.microedition.khronos.egl.EGLSurface;
		}
		internal static global::MonoJavaBridge.MethodId _eglCreatePixmapSurface15800;
		 global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglCreatePixmapSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, java.lang.Object arg2, int[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglCreatePixmapSurface15800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLSurface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglCreatePixmapSurface15800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLSurface;
		}
		internal static global::MonoJavaBridge.MethodId _eglCreateWindowSurface15801;
		 global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglCreateWindowSurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, java.lang.Object arg2, int[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglCreateWindowSurface15801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLSurface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglCreateWindowSurface15801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as javax.microedition.khronos.egl.EGLSurface;
		}
		internal static global::MonoJavaBridge.MethodId _eglDestroyContext15802;
		 bool javax.microedition.khronos.egl.EGL10.eglDestroyContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLContext arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglDestroyContext15802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglDestroyContext15802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _eglDestroySurface15803;
		 bool javax.microedition.khronos.egl.EGL10.eglDestroySurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglDestroySurface15803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglDestroySurface15803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _eglGetConfigAttrib15804;
		 bool javax.microedition.khronos.egl.EGL10.eglGetConfigAttrib(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig arg1, int arg2, int[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglGetConfigAttrib15804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglGetConfigAttrib15804, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _eglGetConfigs15805;
		 bool javax.microedition.khronos.egl.EGL10.eglGetConfigs(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLConfig[] arg1, int arg2, int[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglGetConfigs15805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglGetConfigs15805, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _eglGetCurrentContext15806;
		 global::javax.microedition.khronos.egl.EGLContext javax.microedition.khronos.egl.EGL10.eglGetCurrentContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentContext15806)) as javax.microedition.khronos.egl.EGLContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentContext15806)) as javax.microedition.khronos.egl.EGLContext;
		}
		internal static global::MonoJavaBridge.MethodId _eglGetCurrentDisplay15807;
		 global::javax.microedition.khronos.egl.EGLDisplay javax.microedition.khronos.egl.EGL10.eglGetCurrentDisplay() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentDisplay15807)) as javax.microedition.khronos.egl.EGLDisplay;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentDisplay15807)) as javax.microedition.khronos.egl.EGLDisplay;
		}
		internal static global::MonoJavaBridge.MethodId _eglGetCurrentSurface15808;
		 global::javax.microedition.khronos.egl.EGLSurface javax.microedition.khronos.egl.EGL10.eglGetCurrentSurface(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentSurface15808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.microedition.khronos.egl.EGLSurface;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentSurface15808, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.microedition.khronos.egl.EGLSurface;
		}
		internal static global::MonoJavaBridge.MethodId _eglGetDisplay15809;
		 global::javax.microedition.khronos.egl.EGLDisplay javax.microedition.khronos.egl.EGL10.eglGetDisplay(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglGetDisplay15809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.microedition.khronos.egl.EGLDisplay;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglGetDisplay15809, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as javax.microedition.khronos.egl.EGLDisplay;
		}
		internal static global::MonoJavaBridge.MethodId _eglGetError15810;
		 int javax.microedition.khronos.egl.EGL10.eglGetError() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglGetError15810);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglGetError15810);
		}
		internal static global::MonoJavaBridge.MethodId _eglInitialize15811;
		 bool javax.microedition.khronos.egl.EGL10.eglInitialize(javax.microedition.khronos.egl.EGLDisplay arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglInitialize15811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglInitialize15811, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _eglMakeCurrent15812;
		 bool javax.microedition.khronos.egl.EGL10.eglMakeCurrent(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, javax.microedition.khronos.egl.EGLSurface arg2, javax.microedition.khronos.egl.EGLContext arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglMakeCurrent15812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglMakeCurrent15812, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _eglQueryContext15813;
		 bool javax.microedition.khronos.egl.EGL10.eglQueryContext(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLContext arg1, int arg2, int[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglQueryContext15813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglQueryContext15813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _eglQueryString15814;
		 global::java.lang.String javax.microedition.khronos.egl.EGL10.eglQueryString(javax.microedition.khronos.egl.EGLDisplay arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglQueryString15814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglQueryString15814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _eglQuerySurface15815;
		 bool javax.microedition.khronos.egl.EGL10.eglQuerySurface(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1, int arg2, int[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglQuerySurface15815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglQuerySurface15815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _eglSwapBuffers15816;
		 bool javax.microedition.khronos.egl.EGL10.eglSwapBuffers(javax.microedition.khronos.egl.EGLDisplay arg0, javax.microedition.khronos.egl.EGLSurface arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglSwapBuffers15816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglSwapBuffers15816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _eglTerminate15817;
		 bool javax.microedition.khronos.egl.EGL10.eglTerminate(javax.microedition.khronos.egl.EGLDisplay arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglTerminate15817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglTerminate15817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _eglWaitGL15818;
		 bool javax.microedition.khronos.egl.EGL10.eglWaitGL() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglWaitGL15818);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglWaitGL15818);
		}
		internal static global::MonoJavaBridge.MethodId _eglWaitNative15819;
		 bool javax.microedition.khronos.egl.EGL10.eglWaitNative(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_._eglWaitNative15819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::javax.microedition.khronos.egl.EGL10_.staticClass, global::javax.microedition.khronos.egl.EGL10_._eglWaitNative15819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::javax.microedition.khronos.egl.EGL10_.staticClass = @__env.NewGlobalRef(@__env.FindClass("javax/microedition/khronos/egl/EGL10"));
			global::javax.microedition.khronos.egl.EGL10_._eglChooseConfig15796 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglChooseConfig", "(Ljavax/microedition/khronos/egl/EGLDisplay;[I[Ljavax/microedition/khronos/egl/EGLConfig;I[I)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglCopyBuffers15797 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglCopyBuffers", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;Ljava/lang/Object;)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglCreateContext15798 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglCreateContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljavax/microedition/khronos/egl/EGLContext;[I)Ljavax/microedition/khronos/egl/EGLContext;");
			global::javax.microedition.khronos.egl.EGL10_._eglCreatePbufferSurface15799 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglCreatePbufferSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;[I)Ljavax/microedition/khronos/egl/EGLSurface;");
			global::javax.microedition.khronos.egl.EGL10_._eglCreatePixmapSurface15800 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglCreatePixmapSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljava/lang/Object;[I)Ljavax/microedition/khronos/egl/EGLSurface;");
			global::javax.microedition.khronos.egl.EGL10_._eglCreateWindowSurface15801 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglCreateWindowSurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;Ljava/lang/Object;[I)Ljavax/microedition/khronos/egl/EGLSurface;");
			global::javax.microedition.khronos.egl.EGL10_._eglDestroyContext15802 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglDestroyContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLContext;)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglDestroySurface15803 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglDestroySurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglGetConfigAttrib15804 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglGetConfigAttrib", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLConfig;I[I)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglGetConfigs15805 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglGetConfigs", "(Ljavax/microedition/khronos/egl/EGLDisplay;[Ljavax/microedition/khronos/egl/EGLConfig;I[I)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentContext15806 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglGetCurrentContext", "()Ljavax/microedition/khronos/egl/EGLContext;");
			global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentDisplay15807 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglGetCurrentDisplay", "()Ljavax/microedition/khronos/egl/EGLDisplay;");
			global::javax.microedition.khronos.egl.EGL10_._eglGetCurrentSurface15808 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglGetCurrentSurface", "(I)Ljavax/microedition/khronos/egl/EGLSurface;");
			global::javax.microedition.khronos.egl.EGL10_._eglGetDisplay15809 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglGetDisplay", "(Ljava/lang/Object;)Ljavax/microedition/khronos/egl/EGLDisplay;");
			global::javax.microedition.khronos.egl.EGL10_._eglGetError15810 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglGetError", "()I");
			global::javax.microedition.khronos.egl.EGL10_._eglInitialize15811 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglInitialize", "(Ljavax/microedition/khronos/egl/EGLDisplay;[I)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglMakeCurrent15812 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglMakeCurrent", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;Ljavax/microedition/khronos/egl/EGLSurface;Ljavax/microedition/khronos/egl/EGLContext;)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglQueryContext15813 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglQueryContext", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLContext;I[I)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglQueryString15814 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglQueryString", "(Ljavax/microedition/khronos/egl/EGLDisplay;I)Ljava/lang/String;");
			global::javax.microedition.khronos.egl.EGL10_._eglQuerySurface15815 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglQuerySurface", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;I[I)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglSwapBuffers15816 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglSwapBuffers", "(Ljavax/microedition/khronos/egl/EGLDisplay;Ljavax/microedition/khronos/egl/EGLSurface;)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglTerminate15817 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglTerminate", "(Ljavax/microedition/khronos/egl/EGLDisplay;)Z");
			global::javax.microedition.khronos.egl.EGL10_._eglWaitGL15818 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglWaitGL", "()Z");
			global::javax.microedition.khronos.egl.EGL10_._eglWaitNative15819 = @__env.GetMethodIDNoThrow(global::javax.microedition.khronos.egl.EGL10_.staticClass, "eglWaitNative", "(ILjava/lang/Object;)Z");
		}
	}
}
