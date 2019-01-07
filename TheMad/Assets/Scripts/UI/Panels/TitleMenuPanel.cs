using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TheMad.Uitilities;
using TheMad.Ui;

namespace TheMad
{
    public class TitleMenuPanel : UiPage
    {

        [SerializeField]
        private Button _playButton;

        [SerializeField]
        private Button _settingsButton;

        [SerializeField]
        private Button _exitButton;

        private new void Awake()
        {
            base.Awake();

            _settingsButton.onClick.AddListener(ShowSettings);
        }

        private void OnDestroy()
        {
            _settingsButton.onClick.RemoveListener(ShowSettings);
        }

        private void ShowSettings()
        {
            Close();
            UiUtility.Open(UiConstants.TITLE_SETTINGS_PAGE);
        }
    }
}
