using System;
using UnityEngine;

namespace TheMad
{
    public class UiPage : MonoBehaviour
    {
        private Canvas _canvas;

        private void Awake()
        {
            _canvas = GetComponent<Canvas>();

            Debug.Assert(_canvas != null, "Can not get CanvasGroup");
        }

        public virtual void Open(Action action)
        {
            _canvas.enabled = true;
        }

        public virtual void Close()
        {
            _canvas.enabled = false;
        }
    }
}
