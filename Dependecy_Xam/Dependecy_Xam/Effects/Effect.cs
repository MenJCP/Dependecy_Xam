using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Dependecy_Xam.Effects
{
    public class Effect: RoutingEffect
    {
        public Effect() : base($"MyCompany.{nameof(Effect)}")
        {

        }

    }
}
