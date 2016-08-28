using UnityEngine;
using System.Linq;

namespace TNRD.Automatron.Drawers {

    public class SliderDrawer : AutomationDrawer {

        protected bool hasSlider = false;
        protected int min = 0;
        protected int max = 1;

        public override void Initialize() {
            var attributes = CustomAttributes.Where( x => x.GetType() == typeof( RangeAttribute ) );
            hasSlider = attributes.Count() == 1;

            if ( hasSlider ) {
                var attr = (RangeAttribute)attributes.ElementAt( 0 );
                min = (int)attr.min;
                max = (int)attr.max;
            }
        }
    }
}