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
            uiReplay = GameObject.Find("���s�C��").GetComponent<UIElement>();
            uiQuit = GameObject.Find("���}�C��").GetComponent<UIElement>();
        }
    }

}

