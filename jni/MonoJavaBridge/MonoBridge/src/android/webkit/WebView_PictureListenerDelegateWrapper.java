package android.webkit;

import com.koushikdutta.monojavabridge.MonoBridge;
import com.koushikdutta.monojavabridge.MonoProxy;

public class WebView_PictureListenerDelegateWrapper extends java.lang.Object implements MonoProxy, android.webkit.WebView.PictureListener
{
	static
	{
		MonoBridge.link(WebView_PictureListenerDelegateWrapper.class, "onNewPicture", "(Landroid/webkit/WebView;Landroid/graphics/Picture;)V", "android.webkit.WebView,android.graphics.Picture");

	}

	@Override
	public native void onNewPicture(android.webkit.WebView arg0,android.graphics.Picture arg1);


	long myGcHandle;
	public long getGCHandle() {
		return myGcHandle;
	}

	public void setGCHandle(long gcHandle) {
		myGcHandle = gcHandle;
	}
}