using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CURSO_MVC.Models.ViewModel
{
    public class UsuarioViewModels : ContentPage
    {
        public UsuarioViewModels()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }
    }
}