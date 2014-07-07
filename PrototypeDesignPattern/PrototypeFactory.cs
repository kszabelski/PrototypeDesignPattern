using System;
using System.Collections.Generic;

namespace PrototypeDesignPattern
{
    public class PrototypeFactory
    {
        private static Dictionary<Type, IAmPrototypable> _prototypes = new Dictionary<Type, IAmPrototypable>
        {
            {typeof(Movie), new Movie { Title = "Batman forever"}},
            {typeof(Album), new Album {Name = "Robocop songs"}},
        };
        
        public static T GetInstance<T>() where T : class 
        {
            return _prototypes[typeof(T)].Clone() as T;
        }
    }
}
