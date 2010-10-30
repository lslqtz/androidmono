namespace org.json
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JSONObject : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JSONObject(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get34081;
		public virtual global::java.lang.Object get(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._get34081.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._get34081 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._get34081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put34082;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._put34082.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._put34082 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;D)Lorg/json/JSONObject;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._put34082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _put34083;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._put34083.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._put34083 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;Z)Lorg/json/JSONObject;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._put34083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _put34084;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._put34084.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._put34084 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;I)Lorg/json/JSONObject;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._put34084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _put34085;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._put34085.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._put34085 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;J)Lorg/json/JSONObject;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._put34085, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _put34086;
		public virtual global::org.json.JSONObject put(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._put34086.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._put34086 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "put", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._put34086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _toString34087;
		public virtual global::java.lang.String toString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._toString34087.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._toString34087 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "toString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._toString34087, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString34088;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._toString34088.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._toString34088 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._toString34088) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean34089;
		public virtual bool getBoolean(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._getBoolean34089.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._getBoolean34089 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getBoolean34089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt34090;
		public virtual int getInt(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._getInt34090.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._getInt34090 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getInt", "(Ljava/lang/String;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getInt34090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong34091;
		public virtual long getLong(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._getLong34091.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._getLong34091 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getLong", "(Ljava/lang/String;)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getLong34091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble34092;
		public virtual double getDouble(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._getDouble34092.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._getDouble34092 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getDouble", "(Ljava/lang/String;)D");
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getDouble34092, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _length34093;
		public virtual int length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._length34093.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._length34093 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "length", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._length34093);
		}
		internal static global::MonoJavaBridge.MethodId _remove34094;
		public virtual global::java.lang.Object remove(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._remove34094.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._remove34094 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "remove", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._remove34094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _keys34095;
		public virtual global::java.util.Iterator keys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._keys34095.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._keys34095 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "keys", "()Ljava/util/Iterator;");
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Iterator>(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._keys34095) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _names34096;
		public virtual global::org.json.JSONArray names()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._names34096.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._names34096 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "names", "()Lorg/json/JSONArray;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._names34096) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _quote34097;
		public static global::java.lang.String quote(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._quote34097.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._quote34097 = @__env.GetStaticMethodIDNoThrow(global::org.json.JSONObject.staticClass, "quote", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.json.JSONObject.staticClass, global::org.json.JSONObject._quote34097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getString34098;
		public virtual global::java.lang.String getString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._getString34098.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._getString34098 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getString34098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _has34099;
		public virtual bool has(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._has34099.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._has34099 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "has", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._has34099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isNull34100;
		public virtual bool isNull(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._isNull34100.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._isNull34100 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "isNull", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._isNull34100, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _opt34101;
		public virtual global::java.lang.Object opt(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._opt34101.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._opt34101 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "opt", "(Ljava/lang/String;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._opt34101, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _optBoolean34102;
		public virtual bool optBoolean(java.lang.String arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._optBoolean34102.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._optBoolean34102 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optBoolean", "(Ljava/lang/String;Z)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optBoolean34102, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optBoolean34103;
		public virtual bool optBoolean(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._optBoolean34103.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._optBoolean34103 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optBoolean", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optBoolean34103, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optDouble34104;
		public virtual double optDouble(java.lang.String arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._optDouble34104.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._optDouble34104 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optDouble", "(Ljava/lang/String;D)D");
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optDouble34104, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optDouble34105;
		public virtual double optDouble(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._optDouble34105.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._optDouble34105 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optDouble", "(Ljava/lang/String;)D");
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optDouble34105, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optInt34106;
		public virtual int optInt(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._optInt34106.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._optInt34106 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optInt", "(Ljava/lang/String;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optInt34106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optInt34107;
		public virtual int optInt(java.lang.String arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._optInt34107.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._optInt34107 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optInt", "(Ljava/lang/String;I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optInt34107, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optLong34108;
		public virtual long optLong(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._optLong34108.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._optLong34108 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optLong", "(Ljava/lang/String;)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optLong34108, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _optLong34109;
		public virtual long optLong(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._optLong34109.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._optLong34109 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optLong", "(Ljava/lang/String;J)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optLong34109, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _optString34110;
		public virtual global::java.lang.String optString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._optString34110.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._optString34110 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optString", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optString34110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _optString34111;
		public virtual global::java.lang.String optString(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._optString34111.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._optString34111 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optString34111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getJSONArray34112;
		public virtual global::org.json.JSONArray getJSONArray(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._getJSONArray34112.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._getJSONArray34112 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getJSONArray", "(Ljava/lang/String;)Lorg/json/JSONArray;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getJSONArray34112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _optJSONArray34113;
		public virtual global::org.json.JSONArray optJSONArray(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._optJSONArray34113.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._optJSONArray34113 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optJSONArray", "(Ljava/lang/String;)Lorg/json/JSONArray;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optJSONArray34113, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _getJSONObject34114;
		public virtual global::org.json.JSONObject getJSONObject(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._getJSONObject34114.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._getJSONObject34114 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "getJSONObject", "(Ljava/lang/String;)Lorg/json/JSONObject;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._getJSONObject34114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _optJSONObject34115;
		public virtual global::org.json.JSONObject optJSONObject(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._optJSONObject34115.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._optJSONObject34115 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "optJSONObject", "(Ljava/lang/String;)Lorg/json/JSONObject;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._optJSONObject34115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _putOpt34116;
		public virtual global::org.json.JSONObject putOpt(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._putOpt34116.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._putOpt34116 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "putOpt", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._putOpt34116, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _accumulate34117;
		public virtual global::org.json.JSONObject accumulate(java.lang.String arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._accumulate34117.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._accumulate34117 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "accumulate", "(Ljava/lang/String;Ljava/lang/Object;)Lorg/json/JSONObject;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._accumulate34117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as org.json.JSONObject;
		}
		internal static global::MonoJavaBridge.MethodId _toJSONArray34118;
		public virtual global::org.json.JSONArray toJSONArray(org.json.JSONArray arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._toJSONArray34118.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._toJSONArray34118 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "toJSONArray", "(Lorg/json/JSONArray;)Lorg/json/JSONArray;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::org.json.JSONObject.staticClass, global::org.json.JSONObject._toJSONArray34118, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as org.json.JSONArray;
		}
		internal static global::MonoJavaBridge.MethodId _numberToString34119;
		public static global::java.lang.String numberToString(java.lang.Number arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._numberToString34119.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._numberToString34119 = @__env.GetStaticMethodIDNoThrow(global::org.json.JSONObject.staticClass, "numberToString", "(Ljava/lang/Number;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(org.json.JSONObject.staticClass, global::org.json.JSONObject._numberToString34119, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _JSONObject34120;
		public JSONObject(org.json.JSONObject arg0, java.lang.String[] arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._JSONObject34120.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._JSONObject34120 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "(Lorg/json/JSONObject;[Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._JSONObject34120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONObject34121;
		public JSONObject(org.json.JSONTokener arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._JSONObject34121.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._JSONObject34121 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "(Lorg/json/JSONTokener;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._JSONObject34121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONObject34122;
		public JSONObject(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._JSONObject34122.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._JSONObject34122 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._JSONObject34122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONObject34123;
		public JSONObject() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._JSONObject34123.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._JSONObject34123 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._JSONObject34123);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _JSONObject34124;
		public JSONObject(java.util.Map arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.json.JSONObject._JSONObject34124.native == global::System.IntPtr.Zero)
				global::org.json.JSONObject._JSONObject34124 = @__env.GetMethodIDNoThrow(global::org.json.JSONObject.staticClass, "<init>", "(Ljava/util/Map;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(org.json.JSONObject.staticClass, global::org.json.JSONObject._JSONObject34124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _NULL34125;
		public static global::java.lang.Object NULL
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::org.json.JSONObject.staticClass, _NULL34125)) as java.lang.Object;
			}
		}
		static JSONObject()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.json.JSONObject.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/json/JSONObject"));
			global::org.json.JSONObject._NULL34125 = @__env.GetStaticFieldIDNoThrow(global::org.json.JSONObject.staticClass, "NULL", "Ljava/lang/Object;");
		}
		internal static void InitJNI()
		{
		}
	}
}
