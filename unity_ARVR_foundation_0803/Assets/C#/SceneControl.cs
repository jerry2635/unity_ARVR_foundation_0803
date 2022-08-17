using UnityEngine;
using Valve.VR.InteractionSystem;

namespace jerry
{
    public class SceneControl : MonoBehaviour
    {
        private UIElement uiReplay;
        private UIElement uiQuit;

        private void Awake()
        {
            uiReplay = GameObject.Find("重新遊戲").GetComponent<UIElement>();
            uiQuit = GameObject.Find("離開遊戲").GetComponent<UIElement>();
        }
    }

}

