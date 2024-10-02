namespace CodeTube
{
    [Command(PackageIds.MyCommand)]
    internal sealed class MyToolWindowCommand : BaseCommand<MyToolWindowCommand>
    {
        protected override Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            var windowType = typeof(MyToolWindow);
      
            return MyToolWindow.ShowAsync();
        }
    }

}
