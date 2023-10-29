using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;

namespace BigIslandBarcode;

public partial class AppShell : Shell
{
    public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();

    public AppShell()
	{
		InitializeComponent();
        RegisterRoutes();
        BindingContext = this;
    }

    void RegisterRoutes()
    {
        Routes.Add("mainpage", typeof(MainPage));
        Routes.Add("newpage1", typeof(NewPage1));
        Routes.Add("newpage2", typeof(NewPage2));

        foreach (var item in Routes)
        {
            Routing.RegisterRoute(item.Key, item.Value);
        }
    }
}