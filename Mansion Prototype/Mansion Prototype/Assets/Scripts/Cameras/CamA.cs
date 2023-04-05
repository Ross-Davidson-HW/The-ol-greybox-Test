using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamA : MonoBehaviour
{
    public GameObject cam1, cam2;
    public bool on = false;
    public int camNum;

    // Start is called before the first frame update
    void Start()
    {
        camNum = 1;
        StartCoroutine(switchCam());
    }

    IEnumerator switchCam()
    {
        yield return new WaitForSeconds(5);
        cam2.SetActive(true);
        cam1.SetActive(false);
        on = true;
        camNum = 2;
    }
}
