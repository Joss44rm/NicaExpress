namespace NicaExpress;

public partial class Nicaexpress : FlyoutPage
{
	public Nicaexpress()
	{
		InitializeComponent();
        flyoutpage.collectionview.SelectionChanged +=
         Collectionview_SelectionChanged;
    }
    private void Collectionview_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var item = e.CurrentSelection.FirstOrDefault() as Data.FlyoutPageItem;
        if (item != null)
        {
            Detail = new
            NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            if (!((IFlyoutPageController)this).ShouldShowSplitMode)
            {
                IsPresented = false;
            }
        }
    }


}