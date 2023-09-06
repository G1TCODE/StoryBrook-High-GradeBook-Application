using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StoryBrook_High_GradeBook
{
    public class GradeNode
    {
        public double Grade;
        public GradeNode Left;
        public GradeNode Right;

        public GradeNode(double gradenode, GradeNode left, GradeNode rigt)
        {
            this.Grade = gradenode;
            this.Left = left;
            this.Right = rigt;
        }
    }
    public class DirectoryBST
    {
        public GradeNode RootGrade;
        public DirectoryBST()
        {
            RootGrade = null;
        }

        public void InsertGrade(GradeNode rootgrade, double newgrade)
        {
            GradeNode temp = null;

            while (rootgrade is not null)
            {
                temp = rootgrade;

                if (newgrade == rootgrade.Grade)
                {
                    return;
                }
                else if (newgrade < rootgrade.Grade)
                {
                    rootgrade = rootgrade.Left;
                }
                else if (newgrade > rootgrade.Grade)
                {
                    rootgrade = rootgrade.Right;
                }
            }    

            GradeNode NextGrade = new GradeNode(newgrade, null, null);

            if (RootGrade is not null)
            {
                if (newgrade < temp.Grade)
                {
                    temp.Left = NextGrade;
                }
                else if (newgrade > temp.Grade)
                {
                    temp.Right = NextGrade;
                }
            }
            else if (rootgrade is null)
            {
                RootGrade = NextGrade;
            }
        }

        public void TraverseInOrder(GradeNode root)
        {
            if (root != null)
            {
                TraverseInOrder(root.Left);
                Console.Write(root.Grade + " ");
                TraverseInOrder(root.Right);
            }
        }
    }
}
