package md5fbd5cb67a919f906a494b9232afaa0dd;


public class PhysicalLayoutManager_SeekAndSnapScroller
	extends android.support.v7.widget.LinearSmoothScroller
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getHorizontalSnapPreference:()I:GetGetHorizontalSnapPreferenceHandler\n" +
			"n_computeScrollVectorForPosition:(I)Landroid/graphics/PointF;:GetComputeScrollVectorForPosition_IHandler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.PhysicalLayoutManager+SeekAndSnapScroller, Xamarin.Forms.CarouselView", PhysicalLayoutManager_SeekAndSnapScroller.class, __md_methods);
	}


	public PhysicalLayoutManager_SeekAndSnapScroller (android.content.Context p0)
	{
		super (p0);
		if (getClass () == PhysicalLayoutManager_SeekAndSnapScroller.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.PhysicalLayoutManager+SeekAndSnapScroller, Xamarin.Forms.CarouselView", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public int getHorizontalSnapPreference ()
	{
		return n_getHorizontalSnapPreference ();
	}

	private native int n_getHorizontalSnapPreference ();


	public android.graphics.PointF computeScrollVectorForPosition (int p0)
	{
		return n_computeScrollVectorForPosition (p0);
	}

	private native android.graphics.PointF n_computeScrollVectorForPosition (int p0);

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
