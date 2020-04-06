using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Event4ContPage
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnlogin.Clicked += Btnlogin_Clicked;
            btnreset.Clicked += Btnreset_Clicked;

            TapGestureRecognizer objUsr = new TapGestureRecognizer();
            objUsr.Tapped += ObjUsr_Tapped;
            lblNew.GestureRecognizers.Add(objUsr);
            
            
        }

        private void ObjUsr_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserPage());
        }

        private void Btnreset_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ResetPage());
        }

        private void Btnlogin_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Loginpage());
        }
    }
}
