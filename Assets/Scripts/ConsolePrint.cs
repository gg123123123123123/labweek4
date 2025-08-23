using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    private int i = 3;

    void Update()
    {
        i++; // first frame prints 4
        Debug.Log(gameObject.name + ":" + i); // no spaces!
    }
}
