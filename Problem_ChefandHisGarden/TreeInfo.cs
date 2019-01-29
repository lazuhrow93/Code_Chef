
using System.Collections.Generic;

namespace Chef_And_HisGarden
{
    class TreeInfo
    {
        public int curr_height { get; set; }
        public int growing_rate { get; set; }

        public TreeInfo()
        {

        }

        public TreeInfo(int height, int growRate)
        {
            curr_height = height;
            growing_rate = growRate;
        }

        public void increase_tree()
        {
            curr_height = curr_height + growing_rate;
        }

        


    }
}
