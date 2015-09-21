using System;
using System.Collections.Generic;
using System.Linq;

namespace TraktorMapper.Code.Objects
{
    public class TSIFile
    {
        // Contains information about a TSI file

        private string Type; // MUST
        private int DeviceTarget;
        private string ConfigVersion; // MUST
        private int BuildVersion;
        private string FileComment; // OPTIONAL
        private string Input; // OPTIONAL
        private string Output; // OPTIONAL
        public List<IO> IOList;
        public List<TSIControl> Controls;

        /// <summary>
        /// Contains information about a file
        /// </summary>
        /// <param name="type">Type of mapping. (MIDI/Keyboard/...)</param>
        /// <param name="devicetarget">Wich Deck to target</param>
        /// <param name="configversion">Version of Traktor the file was made for</param>
        /// <param name="configversionextra">Build Number</param>
        public TSIFile(string type, int devicetarget, string configversion, int buildversion)
        {
            NewFile(type, devicetarget, configversion, buildversion, "", "", "");
        }

        /// <summary>
        /// Contains information about a file
        /// </summary>
        /// <param name="type">Type of mapping. (MIDI/Keyboard/...)</param>
        /// <param name="devicetarget">Wich Deck to target</param>
        /// <param name="configversion">Version of Traktor the file was made for</param>
        /// <param name="configversionextra">Build Number</param>
        /// <param name="filecomment">Comment that the file gets</param>
        public TSIFile(string type, int devicetarget, string configversion, int buildversion, string filecomment)
        {
            NewFile(type, devicetarget, configversion, buildversion, filecomment, "", "");
        }

        /// <summary>
        /// Contains information about a file
        /// </summary>
        /// <param name="type">Type of mapping. (MIDI/Keyboard/...)</param>
        /// <param name="devicetarget">Wich Deck to target</param>
        /// <param name="configversion">Version of Traktor the file was made for</param>
        /// <param name="configversionextra">Build Number</param>
        /// <param name="input">The Inputport</param>
        /// <param name="output">The Outputport</param>
        public TSIFile(string type, int devicetarget, string configversion, int buildversion, string input, string output)
        {
            NewFile(type, devicetarget, configversion, buildversion, "", input, output);
        }

        /// <summary>
        /// Contains information about a file
        /// </summary>
        /// <param name="type">Type of mapping. (MIDI/Keyboard/...)</param>
        /// <param name="devicetarget">Wich Deck to target</param>
        /// <param name="configversion">Version of Traktor the file was made for</param>
        /// <param name="configversionextra">Build Number</param>
        /// <param name="filecomment">Comment that the file gets</param>
        /// <param name="input">The Inputport</param>
        /// <param name="output">The Outputport</param>
        public TSIFile(string type, int devicetarget, string configversion, int buildversion, string filecomment, string input, string output)
        {
            NewFile(type, devicetarget, configversion, buildversion, filecomment, input, output);
        }

        /// <summary>
        /// Contains information about a file
        /// </summary>
        /// <param name="type">Type of mapping. (MIDI/Keyboard/...)</param>
        /// <param name="devicetarget">Wich Deck to target</param>
        /// <param name="configversion">Version of Traktor the file was made for</param>
        /// <param name="configversionextra">Build Number</param>
        /// <param name="filecomment">Comment that the file gets</param>
        /// <param name="input">The Inputport</param>
        /// <param name="output">The Outputport</param>
        private void NewFile(string type, int devicetarget, string configversion, int buildversion, string filecomment, string input, string output)
        {
            Type = type;
            DeviceTarget = devicetarget;
            ConfigVersion = configversion;
            BuildVersion = buildversion;
            FileComment = filecomment;
            Input = input;
            Output = output;
        }

        // #### Properties ####

        public string PType
        {
            get
            {
                return this.Type;
            }
            set
            {
                this.Type = value;
            }
        }

        public string POutput
        {
            get { return this.Output; }
            set { this.Output = value; }
        }

        public string PInput
        {
            get { return this.Input; }
            set { this.Input = value; }
        }

        public string PFileComment
        {
            get { return this.FileComment; }
            set { this.FileComment = value; }
        }

        public int PBuildVersion
        {
            get { return this.BuildVersion; }
            set { this.BuildVersion = value; }
        }

        public string PConfigVersion
        {
            get { return this.ConfigVersion; }
            set { this.ConfigVersion = value; }
        }

        public int PDeviceTarget
        {
            get { return this.DeviceTarget; }
            set { this.DeviceTarget = value; }
        }
    }
}
