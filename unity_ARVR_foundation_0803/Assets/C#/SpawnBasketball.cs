using Valve.VR.InteractionSystem;
using UnityEngine;

namespace jerry
{
    public class SpawnBasketball : MonoBehaviour
    {
        [SerializeField, Header("籃球預製物")]
        private GameObject goBasketball;
        private UIElement btnSpawnBadketball;
        private Transform traPlayer;

        private void Awake()
        {
            traPlayer = GameObject.Find("Player").transform;

            btnSpawnBadketball = GameObject.Find("生成籃球").GetComponent<UIElement>();
            btnSpawnBadketball.onHandClick.AddListener((x) =>
            {
            Vector3 posBall = traPlayer.position + traPlayer.forward * 0.8f + traPlayer.up;
            Instantiate(goBasketball,posBall,Quaternion.identity);
            });
        }
    }

}
