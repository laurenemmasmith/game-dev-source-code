using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// Displays fps and total memory used at top left corner of screen
// Note: Total memory is mono memory after garbage collection
public class FPS_Memory : MonoBehaviour
{
    float fps;
    long monoMemory;

    public Text fpsMem;

    void Start()
    {
        StartCoroutine(Recalculate());
    }

    private IEnumerator Recalculate()
    {
        while (true)
        {
            fps = 1.0f / Time.deltaTime;
            monoMemory = System.GC.GetTotalMemory(true);
            yield return new WaitForSeconds(1);
        }
    }

    void Update()
    {
        fpsMem.text = "FPS: " + string.Format("{0:0}", fps) + "\nMemory: " + string.Format("{0:0}", monoMemory);
    }
}
