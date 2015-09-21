using System;
using System.Linq;
using TraktorMapper.Code.Enum;

namespace TraktorMapper.Code.Objects
{
    public class IO
    {
        private string sChannel = "";
        private IOState mInput = IOState.Input;
        private int iInput = 0;

        /// <summary>
        /// Contains information about an IO-Port
        /// </summary>
        /// <param name="channel">Channelname</param>
        /// <param name="input">Is input? true for Input, false for Output</param>
        public IO(string channel, IOState input)
        {
            sChannel = channel;
            mInput = input;
        }


        public IO(string channel, IOState input, int iinput)
        {
            sChannel = channel;
            mInput = input;
            iInput = iinput;
        }

        /// <summary>
        /// ChannelName
        /// </summary>
        public string Channel
        {
            get { return sChannel; }
            set { sChannel = value; }
        }

        /// <summary>
        /// Input State. True for Input, False for Output
        /// </summary>
        public IOState Input
        {
            get { return mInput; }
            set { mInput = value; }
        }

        public int InputInt
        {
            get { return iInput; }
            set { iInput = value; }
        }
    }

    public class ReturnIO
    {
        private int ii = 0;
        private IO Io = null;

        public ReturnIO(int i, IO io)
        {
            ii = i;
            Io = io;
        }

        public int i() { return ii; }
        public IO IO() { return Io; }
    }
}
