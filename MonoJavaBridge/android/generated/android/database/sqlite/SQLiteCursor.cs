namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteCursor : android.database.AbstractWindowedCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _finalize4715;
		protected override void finalize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteCursor._finalize4715.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteCursor._finalize4715 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "finalize", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._finalize4715);
		}
		internal static global::MonoJavaBridge.MethodId _close4716;
		public override void close()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteCursor._close4716.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteCursor._close4716 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "close", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._close4716);
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCount4717;
		public override int getCount()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteCursor._getCount4717.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteCursor._getCount4717 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "getCount", "()I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._getCount4717);
		}
		internal static global::MonoJavaBridge.MethodId _getColumnIndex4718;
		public override int getColumnIndex(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteCursor._getColumnIndex4718.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteCursor._getColumnIndex4718 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "getColumnIndex", "(Ljava/lang/String;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._getColumnIndex4718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String[] ColumnNames
		{
			get
			{
				return getColumnNames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getColumnNames4719;
		public override global::java.lang.String[] getColumnNames()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteCursor._getColumnNames4719.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteCursor._getColumnNames4719 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._getColumnNames4719) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _deactivate4720;
		public override void deactivate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteCursor._deactivate4720.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteCursor._deactivate4720 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "deactivate", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._deactivate4720);
		}
		internal static global::MonoJavaBridge.MethodId _requery4721;
		public override bool requery()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteCursor._requery4721.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteCursor._requery4721 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "requery", "()Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._requery4721);
		}
		internal static global::MonoJavaBridge.MethodId _registerDataSetObserver4722;
		public override void registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteCursor._registerDataSetObserver4722.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteCursor._registerDataSetObserver4722 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._registerDataSetObserver4722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onMove4723;
		public override bool onMove(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteCursor._onMove4723.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteCursor._onMove4723 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "onMove", "(II)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._onMove4723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::android.database.CursorWindow Window
		{
			set
			{
				setWindow(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setWindow4724;
		public override void setWindow(android.database.CursorWindow arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteCursor._setWindow4724.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteCursor._setWindow4724 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "setWindow", "(Landroid/database/CursorWindow;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._setWindow4724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.database.sqlite.SQLiteDatabase Database
		{
			get
			{
				return getDatabase();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDatabase4725;
		public virtual global::android.database.sqlite.SQLiteDatabase getDatabase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteCursor._getDatabase4725.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteCursor._getDatabase4725 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "getDatabase", "()Landroid/database/sqlite/SQLiteDatabase;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._getDatabase4725) as android.database.sqlite.SQLiteDatabase;
		}
		public new global::java.lang.String[] SelectionArguments
		{
			set
			{
				setSelectionArguments(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSelectionArguments4726;
		public virtual void setSelectionArguments(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteCursor._setSelectionArguments4726.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteCursor._setSelectionArguments4726 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "setSelectionArguments", "([Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._setSelectionArguments4726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SQLiteCursor4727;
		public SQLiteCursor(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteCursor._SQLiteCursor4727.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteCursor._SQLiteCursor4727 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteCursor.staticClass, "<init>", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/database/sqlite/SQLiteCursorDriver;Ljava/lang/String;Landroid/database/sqlite/SQLiteQuery;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteCursor.staticClass, global::android.database.sqlite.SQLiteCursor._SQLiteCursor4727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		static SQLiteCursor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteCursor"));
		}
		internal static void InitJNI()
		{
		}
	}
}
