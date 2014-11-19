using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FBD2014.Model;
using FBD2014.Model.ElementCreators;

namespace FBD2014.ViewModel
{
    public class ViewModel
    {
        public static MainForm mf;
        public static BlockModel MainBlock;
        public static BlockModel CurrentBlock; 
        public static BlockModel upperBlock;
        public static DiagramForm currentDiagram;
        public static DiagramForm mainDiagram;
       public static void CreateNewElement(Type T)
        {
            var eb = Activator.CreateInstance(T) as ElementBasic ;
            eb.createElement(currentDiagram,ViewModel.CurrentBlock);
          
           
        }
       public static void SetCurrentDiagram(BlockView bv)
       {
           currentDiagram.Visible = false;
           currentDiagram = bv.innerDiagram;
           currentDiagram.Visible = true;
           upperBlock = bv.bm.parentBlock;
           CurrentBlock = bv.bm;
       }

       public static void setMainDiagram()
       {
           currentDiagram.Visible = false;
           currentDiagram = mainDiagram;
           currentDiagram.Visible = true;
           upperBlock = null;
           CurrentBlock = null;
       }
        public static int setNumber(BlockModel bm)
        {
            if (bm.type == "Controller")
            {
                return 1;
            }
            else
            {
                int startnum = 1;
                List<int> bookedlist = new List<int>();
                for (int i = 0; i < bm.parentBlock.innerBlocks.Count; i++)
                {
                    if (bm.parentBlock.innerBlocks[i].type == bm.type)
                    {
                        bookedlist.Add(bm.parentBlock.innerBlocks[i].number);
                    }
                }
                bookedlist.Sort();
                if (bookedlist.Count != 0)
                {bool seted=false;
                    while (!seted)
                    {seted=true;
                        foreach (int item in bookedlist)
                        {

                            if (item == startnum)
                                seted = false;
                        }
                        if (!seted)
                            startnum++;
                    }
                }
                return startnum;
            }
        }

        public static int setPriority(BlockModel bm)
        {
            if (bm.type == "Controller")
            {
                return 10;
            }
            int startnum = 10;
            List<int> bookedlist = new List<int>();
            for (int i = 0; i < bm.parentBlock.innerBlocks.Count; i++)
            {
                
                    bookedlist.Add(bm.parentBlock.innerBlocks[i].priority);
                
            }
           if(bookedlist.Count!=0)
            startnum=bookedlist.Max()+10;
          
            return startnum;
        }
     
    }
}
