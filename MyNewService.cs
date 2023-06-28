public MyNewService()
{
    InitializeComponent();
    eventLog1 = new System.Diagnostics.EventLog();
    if (!System.Diagnostics.EventLog.SourceExists("MySource"))
    {
        System.Diagnostics.EventLog.CreateEventSource(
            "MySource","MyNewLog");
    }
    eventLog1.Source = "MySource";
    eventLog1.Log = "MyNewLog";
}
