namespace org.xml.sax
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::org.xml.sax.ContentHandler_))]
	public interface ContentHandler  : global::MonoJavaBridge.IJavaObject 
	{
		void startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3);
		void characters(char[] arg0, int arg1, int arg2);
		void endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2);
		void startDocument();
		void endDocument();
		void startPrefixMapping(java.lang.String arg0, java.lang.String arg1);
		void ignorableWhitespace(char[] arg0, int arg1, int arg2);
		void processingInstruction(java.lang.String arg0, java.lang.String arg1);
		void setDocumentLocator(org.xml.sax.Locator arg0);
		void skippedEntity(java.lang.String arg0);
		void endPrefixMapping(java.lang.String arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::org.xml.sax.ContentHandler))]
	public sealed partial class ContentHandler_ : java.lang.Object, ContentHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ContentHandler_()
		{
			InitJNI();
		}
		internal ContentHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _startElement16488;
		 void org.xml.sax.ContentHandler.startElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2, org.xml.sax.Attributes arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_._startElement16488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_.staticClass, global::org.xml.sax.ContentHandler_._startElement16488, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _characters16489;
		 void org.xml.sax.ContentHandler.characters(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_._characters16489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_.staticClass, global::org.xml.sax.ContentHandler_._characters16489, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _endElement16490;
		 void org.xml.sax.ContentHandler.endElement(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_._endElement16490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_.staticClass, global::org.xml.sax.ContentHandler_._endElement16490, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _startDocument16491;
		 void org.xml.sax.ContentHandler.startDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_._startDocument16491);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_.staticClass, global::org.xml.sax.ContentHandler_._startDocument16491);
		}
		internal static global::MonoJavaBridge.MethodId _endDocument16492;
		 void org.xml.sax.ContentHandler.endDocument() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_._endDocument16492);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_.staticClass, global::org.xml.sax.ContentHandler_._endDocument16492);
		}
		internal static global::MonoJavaBridge.MethodId _startPrefixMapping16493;
		 void org.xml.sax.ContentHandler.startPrefixMapping(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_._startPrefixMapping16493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_.staticClass, global::org.xml.sax.ContentHandler_._startPrefixMapping16493, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _ignorableWhitespace16494;
		 void org.xml.sax.ContentHandler.ignorableWhitespace(char[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_._ignorableWhitespace16494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_.staticClass, global::org.xml.sax.ContentHandler_._ignorableWhitespace16494, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _processingInstruction16495;
		 void org.xml.sax.ContentHandler.processingInstruction(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_._processingInstruction16495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_.staticClass, global::org.xml.sax.ContentHandler_._processingInstruction16495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDocumentLocator16496;
		 void org.xml.sax.ContentHandler.setDocumentLocator(org.xml.sax.Locator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_._setDocumentLocator16496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_.staticClass, global::org.xml.sax.ContentHandler_._setDocumentLocator16496, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _skippedEntity16497;
		 void org.xml.sax.ContentHandler.skippedEntity(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_._skippedEntity16497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_.staticClass, global::org.xml.sax.ContentHandler_._skippedEntity16497, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endPrefixMapping16498;
		 void org.xml.sax.ContentHandler.endPrefixMapping(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_._endPrefixMapping16498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::org.xml.sax.ContentHandler_.staticClass, global::org.xml.sax.ContentHandler_._endPrefixMapping16498, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::org.xml.sax.ContentHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("org/xml/sax/ContentHandler"));
			global::org.xml.sax.ContentHandler_._startElement16488 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ContentHandler_.staticClass, "startElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lorg/xml/sax/Attributes;)V");
			global::org.xml.sax.ContentHandler_._characters16489 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ContentHandler_.staticClass, "characters", "([CII)V");
			global::org.xml.sax.ContentHandler_._endElement16490 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ContentHandler_.staticClass, "endElement", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ContentHandler_._startDocument16491 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ContentHandler_.staticClass, "startDocument", "()V");
			global::org.xml.sax.ContentHandler_._endDocument16492 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ContentHandler_.staticClass, "endDocument", "()V");
			global::org.xml.sax.ContentHandler_._startPrefixMapping16493 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ContentHandler_.staticClass, "startPrefixMapping", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ContentHandler_._ignorableWhitespace16494 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ContentHandler_.staticClass, "ignorableWhitespace", "([CII)V");
			global::org.xml.sax.ContentHandler_._processingInstruction16495 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ContentHandler_.staticClass, "processingInstruction", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::org.xml.sax.ContentHandler_._setDocumentLocator16496 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ContentHandler_.staticClass, "setDocumentLocator", "(Lorg/xml/sax/Locator;)V");
			global::org.xml.sax.ContentHandler_._skippedEntity16497 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ContentHandler_.staticClass, "skippedEntity", "(Ljava/lang/String;)V");
			global::org.xml.sax.ContentHandler_._endPrefixMapping16498 = @__env.GetMethodIDNoThrow(global::org.xml.sax.ContentHandler_.staticClass, "endPrefixMapping", "(Ljava/lang/String;)V");
		}
	}
}
