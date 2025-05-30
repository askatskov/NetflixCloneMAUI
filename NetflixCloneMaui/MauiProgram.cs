﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using NetflixCloneMaui.Pages;
using NetflixCloneMaui.Services;
using NetflixCloneMaui.ViewModels;

namespace NetflixCloneMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
				fonts.AddFont("Poppins-Semibold.ttf", "PoppinsSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddHttpClient(TmdbService.TmdbHttpClientName,
            httpClient => httpClient.BaseAddress = new Uri("https://api.themoviedb.org"));


        builder.Services.AddSingleton<TmdbService>();
        builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<HomeViewModel>();

        return builder.Build();
	}
}
