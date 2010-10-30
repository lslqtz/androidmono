namespace org.apache.http
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.apache.http.HttpResponse_))]
	public partial interface HttpResponse : HttpMessage
	{
		void setLocale(java.util.Locale arg0);
		global::java.util.Locale getLocale();
		global::org.apache.http.StatusLine getStatusLine();
		void setStatusLine(org.apache.http.ProtocolVersion arg0, int arg1);
		void setStatusLine(org.apache.http.ProtocolVersion arg0, int arg1, java.lang.String arg2);
		void setStatusLine(org.apache.http.StatusLine arg0);
		void setStatusCode(int arg0);
		void setReasonPhrase(java.lang.String arg0);
		global::org.apache.http.HttpEntity getEntity();
		void setEntity(org.apache.http.HttpEntity arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.apache.http.HttpResponse))]
	internal sealed partial class HttpResponse_ : java.lang.Object, HttpResponse
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal HttpResponse_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setLocale31638;
		void org.apache.http.HttpResponse.setLocale(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._setLocale31638.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._setLocale31638 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setLocale", "(Ljava/util/Locale;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setLocale31638, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLocale31639;
		global::java.util.Locale org.apache.http.HttpResponse.getLocale()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._getLocale31639.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._getLocale31639 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getLocale", "()Ljava/util/Locale;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.util.Locale>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getLocale31639)) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _getStatusLine31640;
		global::org.apache.http.StatusLine org.apache.http.HttpResponse.getStatusLine()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._getStatusLine31640.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._getStatusLine31640 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getStatusLine", "()Lorg/apache/http/StatusLine;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.StatusLine>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getStatusLine31640)) as org.apache.http.StatusLine;
		}
		internal static global::MonoJavaBridge.MethodId _setStatusLine31641;
		void org.apache.http.HttpResponse.setStatusLine(org.apache.http.ProtocolVersion arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._setStatusLine31641.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._setStatusLine31641 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setStatusLine", "(Lorg/apache/http/ProtocolVersion;I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setStatusLine31641, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setStatusLine31642;
		void org.apache.http.HttpResponse.setStatusLine(org.apache.http.ProtocolVersion arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._setStatusLine31642.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._setStatusLine31642 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setStatusLine", "(Lorg/apache/http/ProtocolVersion;ILjava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setStatusLine31642, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setStatusLine31643;
		void org.apache.http.HttpResponse.setStatusLine(org.apache.http.StatusLine arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._setStatusLine31643.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._setStatusLine31643 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setStatusLine", "(Lorg/apache/http/StatusLine;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setStatusLine31643, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStatusCode31644;
		void org.apache.http.HttpResponse.setStatusCode(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._setStatusCode31644.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._setStatusCode31644 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setStatusCode", "(I)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setStatusCode31644, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setReasonPhrase31645;
		void org.apache.http.HttpResponse.setReasonPhrase(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._setReasonPhrase31645.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._setReasonPhrase31645 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setReasonPhrase", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setReasonPhrase31645, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getEntity31646;
		global::org.apache.http.HttpEntity org.apache.http.HttpResponse.getEntity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._getEntity31646.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._getEntity31646 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getEntity", "()Lorg/apache/http/HttpEntity;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HttpEntity>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getEntity31646)) as org.apache.http.HttpEntity;
		}
		internal static global::MonoJavaBridge.MethodId _setEntity31647;
		void org.apache.http.HttpResponse.setEntity(org.apache.http.HttpEntity arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._setEntity31647.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._setEntity31647 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setEntity", "(Lorg/apache/http/HttpEntity;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setEntity31647, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getProtocolVersion31648;
		global::org.apache.http.ProtocolVersion org.apache.http.HttpMessage.getProtocolVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._getProtocolVersion31648.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._getProtocolVersion31648 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getProtocolVersion", "()Lorg/apache/http/ProtocolVersion;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getProtocolVersion31648)) as org.apache.http.ProtocolVersion;
		}
		internal static global::MonoJavaBridge.MethodId _getParams31649;
		global::org.apache.http.@params.HttpParams org.apache.http.HttpMessage.getParams()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._getParams31649.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._getParams31649 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getParams", "()Lorg/apache/http/params/HttpParams;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.@params.HttpParams>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getParams31649)) as org.apache.http.@params.HttpParams;
		}
		internal static global::MonoJavaBridge.MethodId _setParams31650;
		void org.apache.http.HttpMessage.setParams(org.apache.http.@params.HttpParams arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._setParams31650.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._setParams31650 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setParams", "(Lorg/apache/http/params/HttpParams;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setParams31650, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getHeaders31651;
		global::org.apache.http.Header[] org.apache.http.HttpMessage.getHeaders(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._getHeaders31651.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._getHeaders31651 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getHeaders", "(Ljava/lang/String;)[Lorg/apache/http/Header;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getHeaders31651, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _containsHeader31652;
		bool org.apache.http.HttpMessage.containsHeader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._containsHeader31652.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._containsHeader31652 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "containsHeader", "(Ljava/lang/String;)Z");
			return @__env.CallBooleanMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._containsHeader31652, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFirstHeader31653;
		global::org.apache.http.Header org.apache.http.HttpMessage.getFirstHeader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._getFirstHeader31653.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._getFirstHeader31653 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getFirstHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getFirstHeader31653, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getLastHeader31654;
		global::org.apache.http.Header org.apache.http.HttpMessage.getLastHeader(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._getLastHeader31654.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._getLastHeader31654 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getLastHeader", "(Ljava/lang/String;)Lorg/apache/http/Header;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getLastHeader31654, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.Header;
		}
		internal static global::MonoJavaBridge.MethodId _getAllHeaders31655;
		global::org.apache.http.Header[] org.apache.http.HttpMessage.getAllHeaders()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._getAllHeaders31655.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._getAllHeaders31655 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "getAllHeaders", "()[Lorg/apache/http/Header;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<org.apache.http.Header>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._getAllHeaders31655)) as org.apache.http.Header[];
		}
		internal static global::MonoJavaBridge.MethodId _addHeader31656;
		void org.apache.http.HttpMessage.addHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._addHeader31656.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._addHeader31656 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "addHeader", "(Lorg/apache/http/Header;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._addHeader31656, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addHeader31657;
		void org.apache.http.HttpMessage.addHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._addHeader31657.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._addHeader31657 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "addHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._addHeader31657, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader31658;
		void org.apache.http.HttpMessage.setHeader(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._setHeader31658.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._setHeader31658 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setHeader", "(Ljava/lang/String;Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setHeader31658, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setHeader31659;
		void org.apache.http.HttpMessage.setHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._setHeader31659.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._setHeader31659 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setHeader", "(Lorg/apache/http/Header;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setHeader31659, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setHeaders31660;
		void org.apache.http.HttpMessage.setHeaders(org.apache.http.Header[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._setHeaders31660.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._setHeaders31660 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "setHeaders", "([Lorg/apache/http/Header;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._setHeaders31660, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeader31661;
		void org.apache.http.HttpMessage.removeHeader(org.apache.http.Header arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._removeHeader31661.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._removeHeader31661 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "removeHeader", "(Lorg/apache/http/Header;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._removeHeader31661, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeHeaders31662;
		void org.apache.http.HttpMessage.removeHeaders(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._removeHeaders31662.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._removeHeaders31662 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "removeHeaders", "(Ljava/lang/String;)V");
			@__env.CallVoidMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._removeHeaders31662, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator31663;
		global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._headerIterator31663.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._headerIterator31663 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "headerIterator", "()Lorg/apache/http/HeaderIterator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._headerIterator31663)) as org.apache.http.HeaderIterator;
		}
		internal static global::MonoJavaBridge.MethodId _headerIterator31664;
		global::org.apache.http.HeaderIterator org.apache.http.HttpMessage.headerIterator(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::org.apache.http.HttpResponse_._headerIterator31664.native == global::System.IntPtr.Zero)
				global::org.apache.http.HttpResponse_._headerIterator31664 = @__env.GetMethodIDNoThrow(global::org.apache.http.HttpResponse_.staticClass, "headerIterator", "(Ljava/lang/String;)Lorg/apache/http/HeaderIterator;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::org.apache.http.HeaderIterator>(@__env.CallObjectMethod(this.JvmHandle, global::org.apache.http.HttpResponse_._headerIterator31664, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as org.apache.http.HeaderIterator;
		}
		static HttpResponse_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.apache.http.HttpResponse_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/apache/http/HttpResponse"));
		}
		internal static void InitJNI()
		{
		}
	}
}
