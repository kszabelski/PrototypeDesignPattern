using System;

namespace PrototypeDesignPattern
{
    [Serializable]
    internal class Movie : IAmPrototypable
    {
        public string Title { get; set; }

        public IAmPrototypable Clone()
        {
            return CloneHelper.DeepClone(this);
        }
    }
}