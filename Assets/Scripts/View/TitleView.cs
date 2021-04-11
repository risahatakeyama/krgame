using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
namespace krgame.View
{
    public class TitleView : MonoBehaviour
    {
        [SerializeField]
        private Button _buttonStart;
        private Action<GameState, Dictionary<string, object>> _onChangeState;
        public void InitView(Action<GameState, Dictionary<string, object>> onChangeState)
        {
            _onChangeState = onChangeState;
            SetStartButton();

        }
        private void SetStartButton()
        {
            _buttonStart.onClick.RemoveAllListeners();
            _buttonStart.onClick.AddListener(()=> {
                _onChangeState(GameState.InitMain, null);
            });
        }
    }
}

