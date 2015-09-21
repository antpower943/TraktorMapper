using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using TraktorMapper.Code.Objects;

namespace TraktorMapper.Code
{
    public class Serializer
    {
        static public void SerializeObject(string filename, SaveFile objectToSerialize)
        {
            Stream stream = File.Open(filename, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, objectToSerialize);
            stream.Close();
        }

        static public SaveFile DeSerializeObject(string filename)
        {
            SaveFile objectToSerialize;
            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            objectToSerialize = (SaveFile)bFormatter.Deserialize(stream);
            stream.Close();
            return objectToSerialize;
        }
    }
}