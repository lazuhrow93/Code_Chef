
using System.Collections.Generic;

namespace Chef_And_HisGarden
{
    class TreeCollection
    {
        public List<TreeInfo> test_trees = new List<TreeInfo>();

        public int size { get; set; }

        public TreeCollection()
        {
            size = 0;
        }

        public void add_tree(TreeInfo new_tree)
        {
            test_trees.Add(new_tree);
            ++size;
        }

        public bool is_zigZag()
        {

            //figure out pattern

            bool zero_is_greater_one_is_less = false;

            if (test_trees[0].curr_height > test_trees[1].curr_height)
            {
                zero_is_greater_one_is_less = false;
            }
            else if (test_trees[0].curr_height < test_trees[1].curr_height)
            {
                zero_is_greater_one_is_less = true;
            }
            else //if equal, already failed
            {
                return false;
            }

            for (int element = 0; element < test_trees.Count-1; ++element)
            {
                if (zero_is_greater_one_is_less) //if the next should be less
                {
                    if (test_trees[element].curr_height >= test_trees[element + 1].curr_height) return false;
                }
                else //if the next should be greater
                {
                    if (test_trees[element].curr_height <= test_trees[element + 1].curr_height) return false;
                }

                zero_is_greater_one_is_less = !zero_is_greater_one_is_less; //flip the next condition
            }



            return true; //if it gets here, then zigzag

        }

        public void grow_trees()
        {
            for(int element = 0; element < test_trees.Count; ++element)
            {
                test_trees[element].increase_tree();
            }
        }

    }
}
