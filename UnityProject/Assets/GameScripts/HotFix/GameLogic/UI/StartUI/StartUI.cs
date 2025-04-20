using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using TEngine;
using TMPro;

namespace GameLogic
{
    [Window(UILayer.UI)]
    class StartUI : UIWindow
    {
        #region 脚本工具生成的代码
        private TextMeshProUGUI _textStartGame;
        private Button _btnChangeText;
        protected override void ScriptGenerator()
        {
            _textStartGame = FindChildComponent<TextMeshProUGUI>("m_textStartGame");
            _btnChangeText = FindChildComponent<Button>("m_btnChangeText");
            _btnChangeText.onClick.AddListener(UniTask.UnityAction(OnClickChangeTextBtn));
        }
        #endregion

        #region 事件
        private async UniTaskVoid OnClickChangeTextBtn() {
            Debug.Log(UserData);
            Debug.Log(_textStartGame);
            _textStartGame.text = UserData as string;
            await UniTask.Yield();
        }
        #endregion

        protected override void OnCreate() {
            // base.OnCreate();
            _textStartGame.text = UserData as string;
        }
    }
}
