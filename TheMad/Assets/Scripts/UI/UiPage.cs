using System;
using UnityEngine;

namespace TheMad
{ 
    [RequireComponent(typeof(CanvasGroup))]
    public class UiPage : MonoBehaviour
    {
        private CanvasGroup _canvasGroup;

        private bool IsVisible
        {
            set
            {
                _canvasGroup.alpha = value ? 1f : 0f;
                _canvasGroup.blocksRaycasts = value;
                _canvasGroup.interactable = value;
            }
        }

        public void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
            IsVisible = false;

            Debug.Assert(_canvasGroup != null, "Can not get CanvasGroup");
        }

        public virtual void Open()
        {
            IsVisible = true;
        }

        public virtual void Close()
        {
            IsVisible = false;
        }
    }
}
