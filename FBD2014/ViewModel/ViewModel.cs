﻿using System;
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
        public BlockModel MainBlock;
        public BlockModel CurrentBlock;
        public static DiagramForm currentDiagram;
       public  void CreateNewElement(Type T)
        {
            var eb = Activator.CreateInstance(T) as ElementBasic ;
            eb.createElement(currentDiagram);
          
           
        }
       public static void SetMainDiagram(BlockView bv)
       {
           currentDiagram.Visible = false;
           currentDiagram = bv.innerDiagram;
           currentDiagram.Visible = true;
       }
     
    }
}
