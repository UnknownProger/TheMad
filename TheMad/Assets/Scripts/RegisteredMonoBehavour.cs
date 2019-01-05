using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TheMad
{
    public class RegisteredMonoBehavour : MonoBehaviour
    {
        void Awake()
        {
            Register(this);
        }

        void OnDestroy()
        {
            Unregister(this);
        }

        public virtual void Register<T>( T obj) where T : RegisteredMonoBehavour
        {
            DataStorage.Register(obj);
        }

        public virtual void Unregister<T>(T obj) where T : RegisteredMonoBehavour
        {
            DataStorage.Unregister(obj);
        }
    }
}
