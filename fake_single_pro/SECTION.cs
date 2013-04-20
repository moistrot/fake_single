using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireBirdHelper
{
    public class SECTION
    {
        private long id;
        private float min;
        private float max;

        public long getId()
        {
            return id;
        }
        public void setId(long id)
        {
            this.id = id;
        }
        public float getMin()
        {
            return min;
        }
        public void setMin(float min)
        {
            this.min = min;
        }

        public float getMax()
        {
            return max;
        }
        public void setMax(float max)
        {
            this.max = max;
        }
        
        public String toString()
        {
            return "" + min + "-" + max;
        }

    }
}
