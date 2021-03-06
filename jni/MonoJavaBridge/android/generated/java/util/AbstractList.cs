namespace java.util
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.util.AbstractList_))]
	public abstract partial class AbstractList : java.util.AbstractCollection, List
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractList()
		{
			InitJNI();
		}
		protected AbstractList(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _add15187;
		public override bool add(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractList._add15187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._add15187, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _add15188;
		public virtual void add(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.AbstractList._add15188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._add15188, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _get15189;
		public abstract global::java.lang.Object get(int arg0);
		internal static global::MonoJavaBridge.MethodId _equals15190;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractList._equals15190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._equals15190, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15191;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractList._hashCode15191);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._hashCode15191);
		}
		internal static global::MonoJavaBridge.MethodId _indexOf15192;
		public virtual int indexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractList._indexOf15192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._indexOf15192, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clear15193;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.AbstractList._clear15193);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._clear15193);
		}
		internal static global::MonoJavaBridge.MethodId _lastIndexOf15194;
		public virtual int lastIndexOf(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractList._lastIndexOf15194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._lastIndexOf15194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addAll15195;
		public virtual bool addAll(int arg0, java.util.Collection arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.util.AbstractList._addAll15195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._addAll15195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _iterator15196;
		public override global::java.util.Iterator iterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractList._iterator15196)) as java.util.Iterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Iterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._iterator15196)) as java.util.Iterator;
		}
		internal static global::MonoJavaBridge.MethodId _remove15197;
		public virtual global::java.lang.Object remove(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractList._remove15197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._remove15197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _set15198;
		public virtual global::java.lang.Object set(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractList._set15198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._set15198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _subList15199;
		public virtual global::java.util.List subList(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractList._subList15199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.List>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._subList15199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.util.List;
		}
		internal static global::MonoJavaBridge.MethodId _removeRange15200;
		protected virtual void removeRange(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.util.AbstractList._removeRange15200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._removeRange15200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _listIterator15201;
		public virtual global::java.util.ListIterator listIterator(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractList._listIterator15201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._listIterator15201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _listIterator15202;
		public virtual global::java.util.ListIterator listIterator() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractList._listIterator15202)) as java.util.ListIterator;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.ListIterator>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractList.staticClass, global::java.util.AbstractList._listIterator15202)) as java.util.ListIterator;
		}
		internal static global::MonoJavaBridge.MethodId _AbstractList15203;
		protected AbstractList()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.util.AbstractList.staticClass, global::java.util.AbstractList._AbstractList15203);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractList.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractList"));
			global::java.util.AbstractList._add15187 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "add", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractList._add15188 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "add", "(ILjava/lang/Object;)V");
			global::java.util.AbstractList._get15189 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.AbstractList._equals15190 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.util.AbstractList._hashCode15191 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "hashCode", "()I");
			global::java.util.AbstractList._indexOf15192 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "indexOf", "(Ljava/lang/Object;)I");
			global::java.util.AbstractList._clear15193 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "clear", "()V");
			global::java.util.AbstractList._lastIndexOf15194 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "lastIndexOf", "(Ljava/lang/Object;)I");
			global::java.util.AbstractList._addAll15195 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "addAll", "(ILjava/util/Collection;)Z");
			global::java.util.AbstractList._iterator15196 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "iterator", "()Ljava/util/Iterator;");
			global::java.util.AbstractList._remove15197 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "remove", "(I)Ljava/lang/Object;");
			global::java.util.AbstractList._set15198 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "set", "(ILjava/lang/Object;)Ljava/lang/Object;");
			global::java.util.AbstractList._subList15199 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "subList", "(II)Ljava/util/List;");
			global::java.util.AbstractList._removeRange15200 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "removeRange", "(II)V");
			global::java.util.AbstractList._listIterator15201 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "listIterator", "(I)Ljava/util/ListIterator;");
			global::java.util.AbstractList._listIterator15202 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "listIterator", "()Ljava/util/ListIterator;");
			global::java.util.AbstractList._AbstractList15203 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.util.AbstractList))]
	public sealed partial class AbstractList_ : java.util.AbstractList
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AbstractList_()
		{
			InitJNI();
		}
		internal AbstractList_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get15204;
		public override global::java.lang.Object get(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.util.AbstractList_._get15204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.util.AbstractList_.staticClass, global::java.util.AbstractList_._get15204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _size15205;
		public override int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.util.AbstractList_._size15205);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.util.AbstractList_.staticClass, global::java.util.AbstractList_._size15205);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.util.AbstractList_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/util/AbstractList"));
			global::java.util.AbstractList_._get15204 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList_.staticClass, "get", "(I)Ljava/lang/Object;");
			global::java.util.AbstractList_._size15205 = @__env.GetMethodIDNoThrow(global::java.util.AbstractList_.staticClass, "size", "()I");
		}
	}
}
