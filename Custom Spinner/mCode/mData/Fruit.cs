using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Custom_Spinner.mCode.mData
{
    class Fruit
    {
        private string name;
        private int image ;

        public Fruit()
        {
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}