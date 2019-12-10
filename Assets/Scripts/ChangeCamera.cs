using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public int CameraMode;
    public GameObject FPS;
    public GameObject TPS;

<<<<<<< HEAD
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown ("Camera")) 
        {
            if (CameraMode == 1) {
                CameraMode = 0;
            }
            else {
                CameraMode += 1;
            }
        StartCoroutine (SwitchCamera());
        }
    }

    IEnumerator SwitchCamera () 
    {
        yield return new WaitForSeconds (0.01f);
        if (CameraMode == 0) {
            FPS.SetActive(true);
            TPS.SetActive(false);
        }
        if (CameraMode == 1) {
            FPS.SetActive (false);
            TPS.SetActive (true);
=======
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown ("Camera")) {
        if (CameraMode == 1) {
            CameraMode = 0;
        }
        else {
            CameraMode += 1;
        }
        StartCoroutine (SwitchCamera());
    }

    }
    IEnumerator SwitchCamera () {
    yield return new WaitForSeconds (0.01f);
    if (CameraMode == 0) {
        FPS.SetActive(true);
        TPS.SetActive(false);
    }
    if (CameraMode == 1) {
        FPS.SetActive (false);
        TPS.SetActive (true);
>>>>>>> d5f921440475e25c3c926765154506c735796b8f
    }
}

}
