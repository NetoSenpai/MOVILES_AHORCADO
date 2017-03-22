package md578b798426d27212ec3977d1f815bcd30;


public class menuActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("AHORCADOGAME.menuActivity, AHORCADOGAME, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", menuActivity.class, __md_methods);
	}


	public menuActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == menuActivity.class)
			mono.android.TypeManager.Activate ("AHORCADOGAME.menuActivity, AHORCADOGAME, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
