﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppFlix.Droid
{
    [Activity(Label = "Xamarin Flix", // Nome do Aplicativo.
              Theme = "@style/MainTheme.SplashScreen", // Tema feito especificamente à Splash Screen.
              MainLauncher = true, /* Define que essa activity é a principal. Como essa é a principal, devemos ir ao arquivo
                                    * "MainActivity" e habilitar esta mesma propriedade como false, senão serão compilados, no
                                    * celular, dois aplicativos (um com uma Splash Screen, e o outro, sem nenhuma.). */
              NoHistory = true /* Garante que se o usuário apertar o botão voltar, ele retornará à tela inicial do dispositivo,
                                * e não à tela da Splash Screen. */)]
    public class Splash_Screen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);

            // Iniciando a outra activity do projeto.

            StartActivity(new Intent(Application.Context, typeof(MainActivity)));

            // Create your application here

        }
    }
}