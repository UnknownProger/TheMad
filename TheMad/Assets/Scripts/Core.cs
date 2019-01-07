using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheMad.Core
{
    public class Core : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);

            Initialize();
        }

        //For init all base objects
        private void Initialize()
        {
            Localization.LoadLocalization("Rus");
        }
    }
}
