using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using krgame.View;
namespace krgame
{
    public class MainScene : MonoBehaviour
    {
        [SerializeField]
        private Transform _mainCanvas;

        private GameState _gameState;
        private Dictionary<string, object> _param;

        private TitleView _titleView;
        private MainView _mainView;
        private void Start()
        {
            ChangeState(GameState.InitTitle);
        }
        private void Update()
        {
            switch (_gameState)
            {
                case GameState.InitTitle:
                    InitTitle();
                    break;

                case GameState.UpdateTitle:
                    break;

                case GameState.InitMain:
                    InitMain();
                    break;

                case GameState.UpdateMain:

                    UpdateMain();

                    break;

            }
        }

        private void InitTitle()
        {
            if (_titleView == null)
            {
                _titleView = ResourceManager.Instance.InstantiateView<TitleView>(_mainCanvas);
            }
            HideAllView();
            _titleView.gameObject.SetActive(true);
            _titleView.InitView(ChangeState);

            ChangeState(GameState.UpdateTitle);
        }
        private void InitMain()
        {
            if (_mainView == null)
            {
                _mainView = ResourceManager.Instance.InstantiateView<MainView>(_mainCanvas);
            }
            HideAllView();
            _mainView.gameObject.SetActive(true);
            _mainView.InitView(ChangeState);
        }
        private void UpdateMain()
        {

        }
        private void HideAllView()
        {
            if (_titleView != null)
            {
                _titleView.gameObject.SetActive(false);
            }
            if (_mainView != null)
            {
                _mainView.gameObject.SetActive(false);
            }
        }

        private void ChangeState(GameState state, Dictionary<string, object> param = null)
        {
            _gameState = state;
            _param = param;
        }
    }
}

