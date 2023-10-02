using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.BaseBehavior.EventHelper
{
    public class NumericEventArgs : EventArgs
    {
        private float _value { get; set; }
        public NumericEventArgs(int value)
        {
            _value = float.Parse(value.ToString());
        }
        public NumericEventArgs(float value)
        {
            _value = value;
        }
        public float getValue()
        {
            return _value;
        }
    }
}
