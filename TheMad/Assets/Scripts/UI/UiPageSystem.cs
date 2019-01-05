using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheMad
{
    public class UiPageSystem : RegisteredMonoBehavour
    {
        [SerializeField]
        UiPageAsset _uiPageAsset;

        Dictionary<string, UiPage> _uiDictionary = new Dictionary<string, UiPage>();

        private void Awake()
        {
            base.Register(this);

            Initialize();
        }

        public void Open(string key, Action onAfterClose = null)
        {
            _uiDictionary[key].Open(onAfterClose);
        }

        public void Close(string key)
        {
            _uiDictionary[key].Close();
        }

        private void Initialize()
        {
            foreach (var item in _uiPageAsset.Items)
            {
                var page = Instantiate(item.Value, transform);
                _uiDictionary.Add(item.Key, page);
            }
        }
    }
}
