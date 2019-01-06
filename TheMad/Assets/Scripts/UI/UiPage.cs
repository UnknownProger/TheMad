using System;
using UnityEngine;

namespace TheMad
{ 
    public class UiPage : MonoBehaviour
    {
        private Canvas _canvas;

        public void Awake()
        {
            _canvas = GetComponent<Canvas>();
            _canvas.enabled = false;

            Debug.Assert(_canvas != null, "Can not get Canvas");
        }

        public virtual void Open()
        {
            _canvas.enabled = true;
        }

        public virtual void Close()
        {
            _canvas.enabled = false;
        }
    }
}
