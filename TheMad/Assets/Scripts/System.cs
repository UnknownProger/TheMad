using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheMad.Systems
{
    public abstract class System : RegisteredMonoBehavour
    {
        public abstract void Initialize();
    }
}
