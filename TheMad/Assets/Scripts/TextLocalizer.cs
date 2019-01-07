using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TheMad
{
    [RequireComponent(typeof(Text))]
    public class TextLocalizer : MonoBehaviour
    {
        [SerializeField]
        private string _localizationKey;

        private Text _text;

        private void Awake()
        {
            Debug.Assert(!string.IsNullOrWhiteSpace(_localizationKey));

            _text = GetComponent<Text>();
            Localization.LocalizationLoadedEvent += OnLocalizationLoaded;
            _text.text = Localization.GetString(_localizationKey);
        }

        private void OnDestroy()
        {
            Localization.LocalizationLoadedEvent -= OnLocalizationLoaded;
        }

        private void OnLocalizationLoaded()
        {
            _text.text = Localization.GetString(_localizationKey);
        }
    }
}
