using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppLab5
{
    public partial class ListViewCode : ContentPage
    {
        public ListViewCode()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {


            listView.ItemsSource = new string[]
            {
                "mono",
                "monodroid",
                "monotouch",
                "monorail",
                "monodevelop",
                "monotone",
                "monopoly",
                "monomodal",
                "mononucleosis"
            };

        }

    }
}
