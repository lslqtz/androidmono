namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class CursorWrapper : java.lang.Object, Cursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected CursorWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getShort4559;
		public virtual short getShort(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._getShort4559.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._getShort4559 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getShort", "(I)S");
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getShort4559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt4560;
		public virtual int getInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._getInt4560.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._getInt4560 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getInt", "(I)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getInt4560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong4561;
		public virtual long getLong(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._getLong4561.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._getLong4561 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getLong", "(I)J");
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getLong4561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat4562;
		public virtual float getFloat(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._getFloat4562.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._getFloat4562 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getFloat", "(I)F");
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getFloat4562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble4563;
		public virtual double getDouble(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._getDouble4563.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._getDouble4563 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getDouble", "(I)D");
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getDouble4563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _close4564;
		public virtual void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._close4564.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._close4564 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._close4564);
		}
		internal static global::MonoJavaBridge.MethodId _getString4565;
		public virtual global::java.lang.String getString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._getString4565.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._getString4565 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getString4565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isFirst4566;
		public virtual bool isFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._isFirst4566.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._isFirst4566 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isFirst", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isFirst4566);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed4567;
		public virtual bool isClosed()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._isClosed4567.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._isClosed4567 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isClosed", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isClosed4567);
		}
		public new int Position
		{
			get
			{
				return getPosition();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPosition4568;
		public virtual int getPosition()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._getPosition4568.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._getPosition4568 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getPosition", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getPosition4568);
		}
		public new global::android.os.Bundle Extras
		{
			get
			{
				return getExtras();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtras4569;
		public virtual global::android.os.Bundle getExtras()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._getExtras4569.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._getExtras4569 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getExtras", "()Landroid/os/Bundle;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getExtras4569) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _registerContentObserver4570;
		public virtual void registerContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._registerContentObserver4570.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._registerContentObserver4570 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._registerContentObserver4570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterContentObserver4571;
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._unregisterContentObserver4571.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._unregisterContentObserver4571 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._unregisterContentObserver4571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount4572;
		public virtual int getCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._getCount4572.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._getCount4572 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getCount", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getCount4572);
		}
		internal static global::MonoJavaBridge.MethodId _move4573;
		public virtual bool move(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._move4573.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._move4573 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "move", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._move4573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToPosition4574;
		public virtual bool moveToPosition(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._moveToPosition4574.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._moveToPosition4574 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "moveToPosition", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToPosition4574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _moveToFirst4575;
		public virtual bool moveToFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._moveToFirst4575.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._moveToFirst4575 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "moveToFirst", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToFirst4575);
		}
		internal static global::MonoJavaBridge.MethodId _moveToLast4576;
		public virtual bool moveToLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._moveToLast4576.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._moveToLast4576 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "moveToLast", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToLast4576);
		}
		internal static global::MonoJavaBridge.MethodId _moveToNext4577;
		public virtual bool moveToNext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._moveToNext4577.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._moveToNext4577 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "moveToNext", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToNext4577);
		}
		internal static global::MonoJavaBridge.MethodId _moveToPrevious4578;
		public virtual bool moveToPrevious()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._moveToPrevious4578.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._moveToPrevious4578 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "moveToPrevious", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToPrevious4578);
		}
		internal static global::MonoJavaBridge.MethodId _isLast4579;
		public virtual bool isLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._isLast4579.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._isLast4579 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isLast", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isLast4579);
		}
		internal static global::MonoJavaBridge.MethodId _isBeforeFirst4580;
		public virtual bool isBeforeFirst()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._isBeforeFirst4580.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._isBeforeFirst4580 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isBeforeFirst", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isBeforeFirst4580);
		}
		internal static global::MonoJavaBridge.MethodId _isAfterLast4581;
		public virtual bool isAfterLast()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._isAfterLast4581.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._isAfterLast4581 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isAfterLast", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isAfterLast4581);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex4582;
		public virtual int getColumnIndex(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._getColumnIndex4582.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._getColumnIndex4582 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnIndex4582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndexOrThrow4583;
		public virtual int getColumnIndexOrThrow(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._getColumnIndexOrThrow4583.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._getColumnIndexOrThrow4583 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnIndexOrThrow4583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getColumnName4584;
		public virtual global::java.lang.String getColumnName(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._getColumnName4584.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._getColumnName4584 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getColumnName", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnName4584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		public new global::java.lang.String[] ColumnNames
		{
			get
			{
				return getColumnNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4585;
		public virtual global::java.lang.String[] getColumnNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._getColumnNames4585.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._getColumnNames4585 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnNames4585) as java.lang.String[];
		}
		public new int ColumnCount
		{
			get
			{
				return getColumnCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnCount4586;
		public virtual int getColumnCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._getColumnCount4586.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._getColumnCount4586 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getColumnCount", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnCount4586);
		}
		internal static global::MonoJavaBridge.MethodId _getBlob4587;
		public virtual byte[] getBlob(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._getBlob4587.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._getBlob4587 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getBlob", "(I)[B");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getBlob4587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _copyStringToBuffer4588;
		public virtual void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._copyStringToBuffer4588.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._copyStringToBuffer4588 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._copyStringToBuffer4588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _isNull4589;
		public virtual bool isNull(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._isNull4589.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._isNull4589 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "isNull", "(I)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isNull4589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _deactivate4590;
		public virtual void deactivate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._deactivate4590.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._deactivate4590 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "deactivate", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._deactivate4590);
		}
		internal static global::MonoJavaBridge.MethodId _requery4591;
		public virtual bool requery()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._requery4591.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._requery4591 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "requery", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._requery4591);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver4592;
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._registerDataSetObserver4592.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._registerDataSetObserver4592 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._registerDataSetObserver4592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterDataSetObserver4593;
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._unregisterDataSetObserver4593.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._unregisterDataSetObserver4593 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._unregisterDataSetObserver4593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setNotificationUri4594;
		public virtual void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._setNotificationUri4594.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._setNotificationUri4594 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._setNotificationUri4594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool WantsAllOnMoveCalls
		{
			get
			{
				return getWantsAllOnMoveCalls();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getWantsAllOnMoveCalls4595;
		public virtual bool getWantsAllOnMoveCalls()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._getWantsAllOnMoveCalls4595.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._getWantsAllOnMoveCalls4595 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "getWantsAllOnMoveCalls", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getWantsAllOnMoveCalls4595);
		}
		internal static global::MonoJavaBridge.MethodId _respond4596;
		public virtual global::android.os.Bundle respond(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._respond4596.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._respond4596 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._respond4596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _CursorWrapper4597;
		public CursorWrapper(android.database.Cursor arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.CursorWrapper._CursorWrapper4597.native == global::System.IntPtr.Zero)
				global::android.database.CursorWrapper._CursorWrapper4597 = @__env.GetMethodIDNoThrow(global::android.database.CursorWrapper.staticClass, "<init>", "(Landroid/database/Cursor;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._CursorWrapper4597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static CursorWrapper()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.CursorWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/CursorWrapper"));
		}
		internal static void InitJNI()
		{
		}
	}
}
