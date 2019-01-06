using System;
using System.Collections;
using System.Collections.Generic;

namespace TheMad.Uitilities
{
    public static class UiUtility
    {
        private static UiPageSystem _uiPageSystem;

        public static void Open(string key)
        {
            if(_uiPageSystem == null)
            {
                _uiPageSystem = UiPageSystem.Instance;
            }

            _uiPageSystem.Open(key);
        }

        public static void Close(string key)
        {
            if (_uiPageSystem == null)
            {
                _uiPageSystem = UiPageSystem.Instance;
            }

            _uiPageSystem.Close(key);
        }


    }
}
