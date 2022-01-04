using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;
using System.Runtime.InteropServices;

namespace OCR_from_ScreenCopy
{
    
    class AutoIt
    {

        AutoItX3 auto = new AutoItX3();

        public bool Click { get; internal set; }
        

        public void mClick(string ClickSide, int x, int y,int manyClick,int Speed)
        {
            auto.MouseClick(ClickSide,x,y,manyClick,Speed);
 
        }


    }
}
