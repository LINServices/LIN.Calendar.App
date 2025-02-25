﻿#if ANDROID
using Android.Views;
#endif
using LIN.Access.Auth;
using LIN.Access.Calendar;
using Microsoft.Extensions.Logging;

namespace LIN.Calendar.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddAuthenticationService();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddCalendarService();

            return builder.Build();
        }



        public static void Aa()
        {
#if ANDROID
            var currentActivity = Platform.CurrentActivity;

            if (currentActivity == null || currentActivity.Window == null)
                return;

            var currentTheme = AppInfo.RequestedTheme;

            if (currentTheme == AppTheme.Light)
            {
                currentActivity.Window.SetStatusBarColor(new(255, 255, 255));
                currentActivity.Window.SetNavigationBarColor(new(255, 255, 255));
                currentActivity.Window.DecorView.SystemUiVisibility = (StatusBarVisibility)SystemUiFlags.LightStatusBar;
            }
            else
            {
                currentActivity.Window.SetStatusBarColor(new(0, 0, 0));
                currentActivity.Window.SetNavigationBarColor(new(0, 0, 0));
                currentActivity.Window.DecorView.SystemUiVisibility = (StatusBarVisibility)SystemUiFlags.Visible;
            }


            //currentActivity.Window.SetTitleColor(new(0, 0, 0));
#endif
        }
    }
}
