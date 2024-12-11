using Meta.XR.MRUtilityKit;
using UnityEngine;
using UnityEngine.Experimental.XR.Interaction;
using UnityEngine.UIElements;

public class LevelSpawner : MonoBehaviour
{
    public static LevelSpawner Instance {get; private set;} // Singleton
    [SerializeField] private GameObject level; // Level prefab

    [SerializeField] private OVRInput.Button spawnButton; // Button to spawn level

    [SerializeField] private Transform rayStartPoint;

    [SerializeField] private float rayLenght= 8f;

    [SerializeField] private MRUKAnchor.SceneLabels labelFilter;

    private bool levelSpawned = false;

    private void Awake(){
        if(Instance != null && Instance != this)
        {
           Destroy(gameObject); 
        }
            else
            {
                Instance = this;
            }
    }

    // Update is called once per frame
    void Update()
    {
        if(levelSpawned)
        {
            return;
        }
        HandleControllerActoins(OVRInput.Controller.RTouch);
    }

    private void HandleControllerActoins(OVRInput.Controller controller)
    {
        if(OVRInput.GetDown(spawnButton, controller))
        {
            Ray ray = new Ray(rayStartPoint.position, rayStartPoint.forward );

            MRUKRoom room = MRUK.Instance.GetCurrentRoom();

            bool hasHit = room.Raycast(ray, rayLenght, LabelFilter.Included(labelFilter), out RaycastHit hitInfo, out MRUKAnchor anchor);

            if(hasHit)
            {
                Vector3 hitPoint = hitInfo.point;
                Vector3 hitNormal = hitInfo.normal;

                Instantiate(level, hitPoint, Quaternion.Euler(hitNormal));
                levelSpawned = true;

                SpawnerPointGenerator.Instance.GenerateSpawnerPoints(hitPoint);
            }
        }



    }
}
