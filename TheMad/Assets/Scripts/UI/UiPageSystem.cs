using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheMad.Ui;

namespace TheMad
{
    public class UiPageSystem : Systems.System
    {
        #region Fields

        private static UiPageSystem _instance;

        [SerializeField]
        UiPageAsset _uiPageAsset;

        Dictionary<string, UiPage> _uiDictionary = new Dictionary<string, UiPage>();

        #endregion Fields
        #region Properties

        public static UiPageSystem Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }

                return null;
            }
        }

        #endregion Properties
        #region Methods

        private void Awake()
        {
            base.Register(this);

            Initialize();
        }

        public void Open(string key)
        {
            _uiDictionary[key].Open();
        }

        public void Close(string key)
        {
            _uiDictionary[key].Close();
        }

        public override void Initialize()
        {
            if (_instance != null)
            {
                return;
            }

            _instance = this;

            foreach (var item in _uiPageAsset.Items)
            {
                var page = Instantiate(item.Value, transform);
                _uiDictionary.Add(item.Key, page);
            }

            Open(_uiPageAsset.DefaultKey);
        }

        #endregion Methods
    }
}
