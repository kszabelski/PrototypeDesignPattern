using System;

namespace PrototypeDesignPattern
{
    [Serializable]
    internal class Album : IAmPrototypable
    {
        public string Name { get; set; }

        public IAmPrototypable Clone()
        {
            return CloneHelper.DeepClone(this);
        }
    }
}