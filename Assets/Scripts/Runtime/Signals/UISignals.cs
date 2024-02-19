using System;
using UnityEngine;
using UnityEngine.Events;

namespace Runtime.Controllers.UI
{
    public class UISignals: MonoBehaviour
    {
        #region Singleton

        public static UISignals Instance;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }

            Instance = this;
        }

        #endregion

        public UnityAction<byte> onSetStageColor = delegate { };
        public UnityAction<byte> onSetNewLevelValue = delegate { };
        public UnityAction onPlay = delegate { };
    
    }
}