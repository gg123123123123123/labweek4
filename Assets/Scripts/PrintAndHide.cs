using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public Renderer rend;       
    private int blueHideAt;         

    void Start()
    {
        // choose Blue’s hide frame once at start
        blueHideAt = Random.Range(150, 251);
    }

    void Update()
    {
        i++; // first printed value should be 4
        Debug.Log(gameObject.name + ":" + i); 

        // Red rule: deactivate GameObject at i == 100
        if (CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }

        // Blue rule: disable the Renderer at random frame 150..250
        if (CompareTag("Blue") && i == blueHideAt && rend != null)
        {
            rend.enabled = false;
        }
    }
}
