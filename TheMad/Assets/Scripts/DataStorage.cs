using System;
using System.Collections;
using System.Collections.Generic;

namespace TheMad
{
    public static partial class DataStorage
    {

        private static List<RegisteredMonoBehavour> _registeredMonoBehavours = new List<RegisteredMonoBehavour>();

        public static void Register<T>(T obj) where T : RegisteredMonoBehavour
        {
            if(!_registeredMonoBehavours.Contains(obj))
            {
                _registeredMonoBehavours.Add(obj);
            }
        }

        public static void Unregister<T>(T obj) where T : RegisteredMonoBehavour
        {
            if (_registeredMonoBehavours.Contains(obj))
            {
                _registeredMonoBehavours.Remove(obj);
            }
        }

        public static RegisteredMonoBehavour Find<T>(T type)
        {
            return _registeredMonoBehavours.Find(x => x.GetType() == type.GetType());
        }

        public static RegisteredMonoBehavour Find(Predicate<RegisteredMonoBehavour> predicate)
        {
            return _registeredMonoBehavours.Find(predicate);
        }

        public static List<RegisteredMonoBehavour> FindAll<T>(T type)
        {
            return _registeredMonoBehavours.FindAll(x => x.GetType() == type.GetType());
        }

        public static List<RegisteredMonoBehavour> FindAll(Predicate<RegisteredMonoBehavour> predicate)
        {
            return _registeredMonoBehavours.FindAll(predicate);
        }

    }
}
