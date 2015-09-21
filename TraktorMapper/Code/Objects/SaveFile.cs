using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TraktorMapper.Code.Objects
{
    public class SaveFile
    {
        private bool oneWindow = true;
        private int sizelistX = 80;
        private int sizelistY = 50;
        private int sizeucfX = 20;
        private int sizeucfY = 100;
        private int sizeucsX = 80;
        private int sizeucsY = 50;

        public SaveFile()
        {

        }

        public bool OneWindow
        {
            get { return oneWindow; }
            set { oneWindow = value; }
        }

        public void SizeList(int X, int Y)
        {
            sizelistX = X;
            sizelistY = Y;
        }

        public void SizeUcf(int X, int Y)
        {
            sizeucfX = X;
            sizeucfY = Y;
        }

        public void SizeUcs(int X, int Y)
        {
            sizeucsX = X;
            sizeucsY = Y;
        }

        public int SizeListX
        {
            get { return sizelistX; }
        }
        public int SizeListY
        {
            get { return sizelistY; }
        }
        public int SizeUcfX
        {
            get { return sizeucfX; }
        }
        public int SizeUcfY
        {
            get { return sizeucfY; }
        }
        public int SizeUcsX
        {
            get { return sizeucsX; }
        }
        public int SizeUcsY
        {
            get { return sizeucsY; }
        }


    }
}
