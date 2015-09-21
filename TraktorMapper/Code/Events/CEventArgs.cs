using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TraktorMapper.Code.Enum;

namespace TraktorMapper.Code.Events
{
    public class ucfEventArgs : EventArgs
    {
        public int Page { get; set; }
        public DeckFocus Deck { get; set; }
        public string Comment { get; set; }
    }
}
