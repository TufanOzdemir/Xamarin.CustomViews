package md5fbd5cb67a919f906a494b9232afaa0dd;


public class ItemViewAdapter_CarouselViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.ItemViewAdapter+CarouselViewHolder, Xamarin.Forms.CarouselView", ItemViewAdapter_CarouselViewHolder.class, __md_methods);
	}


	public ItemViewAdapter_CarouselViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == ItemViewAdapter_CarouselViewHolder.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.ItemViewAdapter+CarouselViewHolder, Xamarin.Forms.CarouselView", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
