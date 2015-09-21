using System;

namespace TraktorMapper.Code.Objects
{
    public class Modifier
    {
        private int iID = 0;
        private int iParameter = 0;
        private int iValue = 0;

        public Modifier(int id, int parameter, int value)
        {
            iID = id;
            iParameter = parameter;
            iValue = value;
        }

        public int ID { get { return iID; } set { iID = value; } }
        public int Parameter { get { return iParameter; } set { iParameter = value; } }
        public int Value { get { return iValue; } set { iValue = value; } }
    }
}
