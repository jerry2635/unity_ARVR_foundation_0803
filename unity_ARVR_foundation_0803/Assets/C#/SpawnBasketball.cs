using Valve.VR.InteractionSystem;
using UnityEngine;

namespace jerry
{
    public class SpawnBasketball : MonoBehaviour
    {
        [SerializeField, Header("�x�y�w�s��")]
        private GameObject goBasketball;
        private UIElement btnSpawnBadketball;
        private Transform traPlayer;

        private void Awake()
        {
            traPlayer = GameObject.Find("Player").transform;

            btnSpawnBadketball = GameObject.Find("�ͦ��x�y").GetComponent<UIElement>();
            btnSpawnBadketball.onHandClick.AddListener((x) =>
            {
            Vector3 posBall = traPlayer.position + traPlayer.forward * 0.8f + traPlayer.up;
            Instantiate(goBasketball,posBall,Quaternion.identity);
            });
        }
    }

}
