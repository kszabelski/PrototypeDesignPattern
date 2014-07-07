using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrototypeDesignPattern
{
    internal class CloneHelper
    {
        public static T DeepClone<T>(T original) where T : class 
        {
            var stream = new MemoryStream();
            var formatter = new BinaryFormatter();

            formatter.Context = new StreamingContext(StreamingContextStates.Clone);
            formatter.Serialize(stream, original);
            stream.Position = 0;
            return formatter.Deserialize(stream) as T;
        }
    }
}