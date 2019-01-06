using System;
using System.Collections.Generic;
using UnityEngine;

namespace TheMad.Ui
{
    [CreateAssetMenu(fileName = "UiPageAsset", menuName = "TheMad/UiPageAsset")]
    public class UiPageAsset : ScriptableObject
    {
        #region Fields

        [SerializeField]
        private List<Item> _items = new List<Item>();

        [Space]

        [SerializeField]
        private string _defaultKey;

        #endregion Fields
        #region Properties

        public List<Item> Items => _items;
        public string DefaultKey => _defaultKey;

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
