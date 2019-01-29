using System;
using System.Collections.Generic;

namespace Chef_And_HisGarden
{
    class Chef_and_His_Gard
    {
        static void Main(string[] args)
        {

            TreeCollection user_trees = new TreeCollection();

            //user_trees.add_tree(new TreeInfo(0, 1));
            //user_trees.add_tree(new TreeInfo(2, 2));
            //user_trees.add_tree(new TreeInfo(0, 3));

            //user_trees.add_tree(new TreeInfo(2,1));
            //user_trees.add_tree(new TreeInfo(1,2));

            user_trees.add_tree(new TreeInfo(1, 1));
            user_trees.add_tree(new TreeInfo(2, 2));
            user_trees.add_tree(new TreeInfo(3, 3));


            int max_time = 100000;
            int total_consec = 0;

            bool consec_active = false;

            for (int curr_time = 0; curr_time < max_time; ++curr_time)
            {

                if (consec_active)
                {
                    if (!user_trees.is_zigZag()) consec_active = false;
                }
                else
                {
                    if (user_trees.is_zigZag())
                    {
                        consec_active = true;
                        ++total_consec;
                    }
                }


                user_trees.grow_trees();
            }

            Console.Out.WriteLine("There are this many zigzags over the time of 100000: " + total_consec.ToString());

            Console.ReadKey();

        }

        


    }
}
