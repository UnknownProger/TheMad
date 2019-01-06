using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TheMad.Uitilities;

namespace TheMad
{
    public class TitleSettingsPanel : UiPage
    {
        [SerializeField]
        private Button _closeButton;

        [SerializeField]
        private Button _applyButton;

        private void Awake()
        {
            base.Awake();

            _closeButton.onClick.AddListener(OnCloseClick);
        }

        private void OnDestroy()
        {
            _closeButton.onClick.RemoveListener(OnCloseClick);
        }

        private void OnCloseClick()
        {
            Close();
            UiUtility.Open(UiConstants.TITLE_MENU_PAGE);
        }
    }
}
