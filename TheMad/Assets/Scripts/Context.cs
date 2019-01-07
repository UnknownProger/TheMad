using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheMad.Core
{
    public class Context : RegisteredMonoBehavour
    {
        [SerializeField]
        private Systems.System[] _systemPrefabs;

        private void Awake()
        {
            base.Register(this);

            Localization.LoadLocalization("Rus");

            var systemsContainer = new GameObject("Systems").transform;
            systemsContainer.transform.SetParent(transform);

            foreach (var system in _systemPrefabs)
            {
                Instantiate(system, systemsContainer);
            }
        }
    }
}
