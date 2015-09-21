using System;
using System.Linq;
using TraktorMapper.Code.Enum;

namespace TraktorMapper.Code.Objects
{
    public class TSIControl
    {
        private int iID = 0;
        private IOState mIO = IOState.Input;
        private int iActionID;
        private int iControllerType = 0;
        private int iInteraction;
        private DeckFocus mDeck = 0;
        private bool bInverted = false;
        private bool bSoftTakeover = false;
        private int iRotarySensitivity = 0;
        private int iRotaryAcceleration = 0;
        private int iButtonOrElse;
        private int iInteractionValue;
        private string sComment = "";
        private Modifier mModifier1;
        private Modifier mModifier2;
        private int iControllerRangeMin = 0;
        private int iControllerRangeMax = 0;
        private int iMIDIRangeMin = 0;
        private int iMIDIRangeMax = 0;
        private bool bBlend = false;
        private string sNote = "";

        public TSIControl(int id,
            IOState io,
            int actionid,
            int controllertype,
            int interaction,
            DeckFocus deck,
            bool inverted,
            bool softtakeover,
            int rotarysensitivity,
            int rotaryacceleration,
            int buttonorelse,
            int interactionvalue,
            string comment,
            Modifier modifier1,
            Modifier modifier2,
            int controllerrangemin,
            int controllerrangemax,
            int midirangemin,
            int midirangemax,
            bool blend)
        {
            iID = id;
            mIO = io;
            iActionID = actionid;
            iControllerType = controllertype;
            iInteraction = interaction;
            mDeck = deck;
            bInverted = inverted;
            bSoftTakeover = softtakeover;
            iRotarySensitivity = rotarysensitivity;
            iRotaryAcceleration = rotaryacceleration;
            iButtonOrElse = buttonorelse;
            iInteractionValue = interactionvalue;
            sComment = comment;
            mModifier1 = modifier1;
            mModifier2 = modifier2;
            iControllerRangeMin = controllerrangemin;
            iControllerRangeMax = controllerrangemax;
            iMIDIRangeMin = midirangemin;
            iMIDIRangeMax = midirangemax;
            bBlend = blend;
        }

        public string Note
        {
            get { return sNote; }
            set { sNote = value; }
        }

        public int ID() { return iID; }
        public IOState IO() { return mIO; }
        public int ActionID() { return iActionID; }
        public int ControllerType() { return iControllerType; }
        public int Interaction() { return iInteraction; }
        public DeckFocus Deck() { return mDeck; }
        public bool Inverted() { return bInverted; }
        public bool SoftTakeover() { return bSoftTakeover; }
        public int RotarySensitivity() { return iRotarySensitivity; }
        public int RotaryAcceleration() { return iRotaryAcceleration; }
        public int ButtonOrElse() { return iButtonOrElse; }
        public int InteractionValue() { return iInteractionValue; }
        public string Comment() { return sComment; }
        public Modifier Modifier1() { return mModifier1; }
        public Modifier Modifier2() { return mModifier2; }
        public int ControllerRangeMin() { return iControllerRangeMin; }
        public int ControllerRangeMax() { return iControllerRangeMax; }
        public int MIDIRangeMin() { return iMIDIRangeMin; }
        public int MIDIRangeMax() { return iMIDIRangeMax; }
        public bool Blend() { return bBlend; }
    }

    public class ReturnControl
    {
        private int ii = 0;
        private TSIControl c = null;

        public ReturnControl(int i, TSIControl control)
        {
            ii = i;
            c = control;
        }

        public int i() { return ii; }
        public TSIControl Ctrl() { return c; }
    }
}
