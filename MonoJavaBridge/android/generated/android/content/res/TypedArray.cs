namespace android.content.res
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TypedArray : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected TypedArray(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString4256;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._toString4256)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._toString4256)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean4257;
		public virtual bool getBoolean(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray._getBoolean4257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getBoolean4257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4258;
		public virtual int getInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getInt4258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getInt4258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4259;
		public virtual float getFloat(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.content.res.TypedArray._getFloat4259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getFloat4259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _length4260;
		public virtual int length()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._length4260);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._length4260);
		}
		internal static global::MonoJavaBridge.MethodId _getValue4261;
		public virtual bool getValue(int arg0, android.util.TypedValue arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray._getValue4261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getValue4261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.content.res.Resources Resources
		{
			get
			{
				return getResources();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getResources4262;
		public virtual global::android.content.res.Resources getResources()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getResources4262)) as android.content.res.Resources;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getResources4262)) as android.content.res.Resources;
		}
		internal static global::MonoJavaBridge.MethodId _getInteger4263;
		public virtual int getInteger(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getInteger4263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getInteger4263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getString4264;
		public virtual global::java.lang.String getString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getString4264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getString4264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getIndex4265;
		public virtual int getIndex(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getIndex4265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getIndex4265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getText4266;
		public virtual global::java.lang.CharSequence getText(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getText4266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getText4266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _recycle4267;
		public virtual void recycle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.res.TypedArray._recycle4267);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._recycle4267);
		}
		internal static global::MonoJavaBridge.MethodId _getTextArray4268;
		public virtual global::java.lang.CharSequence[] getTextArray(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getTextArray4268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getTextArray4268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
		}
		internal static global::MonoJavaBridge.MethodId _getDimension4269;
		public virtual float getDimension(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.content.res.TypedArray._getDimension4269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getDimension4269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDimensionPixelOffset4270;
		public virtual int getDimensionPixelOffset(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getDimensionPixelOffset4270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getDimensionPixelOffset4270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDimensionPixelSize4271;
		public virtual int getDimensionPixelSize(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getDimensionPixelSize4271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getDimensionPixelSize4271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFraction4272;
		public virtual float getFraction(int arg0, int arg1, int arg2, float arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.content.res.TypedArray._getFraction4272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getFraction4272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _getDrawable4273;
		public virtual global::android.graphics.drawable.Drawable getDrawable(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getDrawable4273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getDrawable4273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getColor4274;
		public virtual int getColor(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getColor4274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getColor4274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getColorStateList4275;
		public virtual global::android.content.res.ColorStateList getColorStateList(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getColorStateList4275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getColorStateList4275, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.res.ColorStateList;
		}
		public new global::java.lang.String PositionDescription
		{
			get
			{
				return getPositionDescription();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPositionDescription4276;
		public virtual global::java.lang.String getPositionDescription()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getPositionDescription4276)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getPositionDescription4276)) as java.lang.String;
		}
		public new int IndexCount
		{
			get
			{
				return getIndexCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getIndexCount4277;
		public virtual int getIndexCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getIndexCount4277);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getIndexCount4277);
		}
		internal static global::MonoJavaBridge.MethodId _getNonResourceString4278;
		public virtual global::java.lang.String getNonResourceString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._getNonResourceString4278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getNonResourceString4278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutDimension4279;
		public virtual int getLayoutDimension(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getLayoutDimension4279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getLayoutDimension4279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLayoutDimension4280;
		public virtual int getLayoutDimension(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getLayoutDimension4280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getLayoutDimension4280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getResourceId4281;
		public virtual int getResourceId(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.res.TypedArray._getResourceId4281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._getResourceId4281, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _hasValue4282;
		public virtual bool hasValue(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray._hasValue4282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._hasValue4282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _peekValue4283;
		public virtual global::android.util.TypedValue peekValue(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.res.TypedArray._peekValue4283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.TypedValue;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.res.TypedArray.staticClass, global::android.content.res.TypedArray._peekValue4283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.TypedValue;
		}
		static TypedArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.res.TypedArray.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/res/TypedArray"));
			global::android.content.res.TypedArray._toString4256 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.res.TypedArray._getBoolean4257 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getBoolean", "(IZ)Z");
			global::android.content.res.TypedArray._getInt4258 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getInt", "(II)I");
			global::android.content.res.TypedArray._getFloat4259 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getFloat", "(IF)F");
			global::android.content.res.TypedArray._length4260 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "length", "()I");
			global::android.content.res.TypedArray._getValue4261 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getValue", "(ILandroid/util/TypedValue;)Z");
			global::android.content.res.TypedArray._getResources4262 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getResources", "()Landroid/content/res/Resources;");
			global::android.content.res.TypedArray._getInteger4263 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getInteger", "(II)I");
			global::android.content.res.TypedArray._getString4264 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getString", "(I)Ljava/lang/String;");
			global::android.content.res.TypedArray._getIndex4265 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getIndex", "(I)I");
			global::android.content.res.TypedArray._getText4266 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getText", "(I)Ljava/lang/CharSequence;");
			global::android.content.res.TypedArray._recycle4267 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "recycle", "()V");
			global::android.content.res.TypedArray._getTextArray4268 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getTextArray", "(I)[Ljava/lang/CharSequence;");
			global::android.content.res.TypedArray._getDimension4269 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getDimension", "(IF)F");
			global::android.content.res.TypedArray._getDimensionPixelOffset4270 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getDimensionPixelOffset", "(II)I");
			global::android.content.res.TypedArray._getDimensionPixelSize4271 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getDimensionPixelSize", "(II)I");
			global::android.content.res.TypedArray._getFraction4272 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getFraction", "(IIIF)F");
			global::android.content.res.TypedArray._getDrawable4273 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getDrawable", "(I)Landroid/graphics/drawable/Drawable;");
			global::android.content.res.TypedArray._getColor4274 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getColor", "(II)I");
			global::android.content.res.TypedArray._getColorStateList4275 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getColorStateList", "(I)Landroid/content/res/ColorStateList;");
			global::android.content.res.TypedArray._getPositionDescription4276 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getPositionDescription", "()Ljava/lang/String;");
			global::android.content.res.TypedArray._getIndexCount4277 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getIndexCount", "()I");
			global::android.content.res.TypedArray._getNonResourceString4278 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getNonResourceString", "(I)Ljava/lang/String;");
			global::android.content.res.TypedArray._getLayoutDimension4279 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getLayoutDimension", "(II)I");
			global::android.content.res.TypedArray._getLayoutDimension4280 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getLayoutDimension", "(ILjava/lang/String;)I");
			global::android.content.res.TypedArray._getResourceId4281 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "getResourceId", "(II)I");
			global::android.content.res.TypedArray._hasValue4282 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "hasValue", "(I)Z");
			global::android.content.res.TypedArray._peekValue4283 = @__env.GetMethodIDNoThrow(global::android.content.res.TypedArray.staticClass, "peekValue", "(I)Landroid/util/TypedValue;");
		}
		internal static void InitJNI()
		{
		}
	}
}