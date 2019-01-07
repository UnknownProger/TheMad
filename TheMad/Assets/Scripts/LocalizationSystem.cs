using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TheMad
{
    public static class Localization
    {
        private static Dictionary<string, string> _localizationDictionary = new Dictionary<string, string>();

        public delegate void OnLocalizationLoaded();
        public static event OnLocalizationLoaded LocalizationLoadedEvent;
        
        public static void LoadLocalization(string lang)
        {
            var path = string.Format("{0}/{1}", Directory.GetCurrentDirectory(), "/Assets/Localizations/Rus.loc");
            var allText = File.ReadAllLines(path);

            foreach (var line in allText)
            {
                var keyValue = line.Split('|');

                if (keyValue.Length == 2)
                {
                    _localizationDictionary.Add(keyValue[0], keyValue[1]);
                }
            }

            LocalizationLoadedEvent?.Invoke();
        }

        public static string GetString(string key)
        {
            string result = string.Empty;

            if (_localizationDictionary.TryGetValue(key, out result))
            {
                return result;
            }
            else
            {
                Debug.LogWarning(string.Format("Localization string [{0}] not found!", key));
                return result;
            }
        }
    }
}
