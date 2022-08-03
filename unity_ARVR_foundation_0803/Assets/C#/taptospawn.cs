using UnityEngine;
using UnityEngine.XR.ARFoundation;
using System.Collections.Generic;
using UnityEngine.XR.ARSubsystems;

namespace jerry
{
    /// <summary>
    /// 點擊後生成物件
    /// </summary>
    [RequireComponent(typeof(ARRaycastManager))]
    public class taptospawnObject : MonoBehaviour
    {
        #region
        [SerializeField, Header("要生成的物件")]
        private GameObject goSpawnObject;

        private ARRaycastManager arManager;
        private Vector2 touchPoint;
        private List<ARRaycastManager> hits = new List<ARRaycastManager>();
        private object trackableTypes;
        #endregion

        private void Awake()
        {
            arManager = GetComponent<ARRaycastManager>();
        }

        private void Update()
        {
            taptospawn();
        }

        private void taptospawn()
        {
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                touchPoint = Input.mousePosition;
                if(arManager.Raycast(touchPoint, hits,TrackableType.PlaneWithinPolygon))
                {
                    Pose pose = hits[0].pose;
                    GameObject temp = Instantiate(goSpawnObject, pose.position, Quaternion.identity);
                    Vector3 camerapos = temp.transform.position;
                    camerapos.y = temp.transform.position.y;
                    temp.transform.LookAt(camerapos);
                }
            }
        }
    }
}


