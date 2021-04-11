using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace krgame.View
{
    public class MainView : MonoBehaviour
    {
        private Action<GameState, Dictionary<string, object>> _onChangeState;
        public void InitView(Action<GameState, Dictionary<string, object>> onChangeState)
        {
            _onChangeState = onChangeState;

            _onChangeState(GameState.UpdateMain,null);
        }

    }
}

