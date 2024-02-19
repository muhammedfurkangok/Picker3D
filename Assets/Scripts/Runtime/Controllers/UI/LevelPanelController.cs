using System;
using System.Collections.Generic;
using DG.Tweening;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Runtime.Controllers.UI
{
    public class LevelPanelController : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Veriables

        [SerializeField] private List<Image> stageImages = new List<Image>();
        [SerializeField] private List<TextMeshProUGUI> levelTexts = new List<TextMeshProUGUI>();

        #endregion

        #endregion

        private void OnEnable()
        {
            SubscribeEvents();
            
        }

      

        private void SubscribeEvents()
        {
            UISignals.Instance.onSetNewLevelValue += OnSetNewLevelValue;
            UISignals.Instance.onSetStageColor += OnSetStageColor;

        }
        [ Button("SetStageColour")]
        private void OnSetStageColor(byte stageValue)
        {
            stageImages[stageValue].DOColor(Color.yellow, 0.5f);
        }

        private void OnSetNewLevelValue(byte levelValue)
        {
            var additionalValue = ++levelValue;
            levelTexts[0].text = additionalValue.ToString();
            additionalValue++;
            levelTexts[1].text = additionalValue.ToString();


        }

        private void UnSubscribeEvents()
        {
            UISignals.Instance.onSetNewLevelValue -= OnSetNewLevelValue;
            UISignals.Instance.onSetStageColor -= OnSetStageColor;
        }

        private void OnDisable()
        {
            UnSubscribeEvents();
        }
    }
}