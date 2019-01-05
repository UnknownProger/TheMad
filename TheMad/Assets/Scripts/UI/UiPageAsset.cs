using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheMad
{
    [CreateAssetMenu(fileName = "UiPageAsset", menuName = "TheMad/UiPageAsset")]
    public class UiPageAsset : ScriptableObject
    {
        #region Fields

        [SerializeField]
        List<Item> _items = new List<Item>();

        #endregion Fields
        #region Properties

        public List<Item> Items => _items;

        #endregion Properties

        #region Classes

        [Serializable]
        public class Item
        {
            [SerializeField]
            private string _key;

            [SerializeField]
            private UiPage _value;

            public string Key => _key;
            public UiPage Value => _value;
        }

        #endregion Classes
    }
}
