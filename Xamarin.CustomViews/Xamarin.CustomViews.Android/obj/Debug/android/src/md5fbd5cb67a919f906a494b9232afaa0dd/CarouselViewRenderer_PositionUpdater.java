package md5fbd5cb67a919f906a494b9232afaa0dd;


public class CarouselViewRenderer_PositionUpdater
	extends android.support.v7.widget.RecyclerView.AdapterDataObserver
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onItemRangeInserted:(II)V:GetOnItemRangeInserted_IIHandler\n" +
			"n_onItemRangeRemoved:(II)V:GetOnItemRangeRemoved_IIHandler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.CarouselViewRenderer+PositionUpdater, Xamarin.Forms.CarouselView", CarouselViewRenderer_PositionUpdater.class, __md_methods);
	}


	public CarouselViewRenderer_PositionUpdater ()
	{
		super ();
		if (getClass () == CarouselViewRenderer_PositionUpdater.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.CarouselViewRenderer+PositionUpdater, Xamarin.Forms.CarouselView", "", this, new java.lang.Object[] {  });
	}

	public CarouselViewRenderer_PositionUpdater (md5fbd5cb67a919f906a494b9232afaa0dd.CarouselViewRenderer p0)
	{
		super ();
		if (getClass () == CarouselViewRenderer_PositionUpdater.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.CarouselViewRenderer+PositionUpdater, Xamarin.Forms.CarouselView", "Xamarin.Forms.Platform.CarouselViewRenderer, Xamarin.Forms.CarouselView", this, new java.lang.Object[] { p0 });
	}


	public void onItemRangeInserted (int p0, int p1)
	{
		n_onItemRangeInserted (p0, p1);
	}

	private native void n_onItemRangeInserted (int p0, int p1);


	public void onItemRangeRemoved (int p0, int p1)
	{
		n_onItemRangeRemoved (p0, p1);
	}

	private native void n_onItemRangeRemoved (int p0, int p1);

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
