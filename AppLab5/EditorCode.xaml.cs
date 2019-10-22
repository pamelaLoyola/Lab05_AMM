using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppLab5
{
    public partial class EditorCode : ContentPage
    {
        public EditorCode()
        {
            InitializeComponent();

            StackLayout stack = new StackLayout();
            var MyEditor = new Editor { Text = "I am an Editor" };
            stack.Children.Add(MyEditor);
            Content = stack;

        }
    }
}
