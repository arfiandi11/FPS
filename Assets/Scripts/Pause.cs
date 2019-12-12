using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
	public GameObject panelPause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
	        {
				if (Time.timeScale ==1){
	            panelPause.SetActive(true);
				Time.timeScale = 0;
				}
				else{
					Time.timeScale=1;
					panelPause.SetActive(false);
				}
	        }
    }
	public void resume(){
		if (Time.timeScale ==1){
	            panelPause.SetActive(true);
				Time.timeScale = 0;
				}
				else{
					Time.timeScale=1;
					panelPause.SetActive(false);
				}
	
	}
}
