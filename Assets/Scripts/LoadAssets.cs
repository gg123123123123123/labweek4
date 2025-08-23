using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;                   // drag RedPrefab here in Inspector
    [SerializeField] private GameObject blueObj; // drag BluePrefab here (private but visible)
    
    void Start()
    {
        // keep frame-rate consistent for testing
        Application.targetFrameRate = 60;

        // spawn the red & blue prefabs at fixed positions
        Instantiate(redObj,  new Vector3( 2.2f, 0f, 0f), Quaternion.identity);
        Instantiate(blueObj, new Vector3(-2.2f, 0f, 0f), Quaternion.identity);
    }
}
