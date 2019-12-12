using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuChoose : MonoBehaviour {
	

    // pindah scene ke menu
    public void MenuScene() {
        SceneManager.LoadScene("Menu");
        Debug.Log("Menu Scene");
    }

    // pindah scene ke loading
    public void LoadingScene() {
        SceneManager.LoadScene("Loading");
        Debug.Log("Loading Scene");
    }

    // keluar dari game
    public void KeluarScene() {
        Application.Quit();
        Debug.Log("Keluar Game");
    }
	
	// masuk dari game
    public void MainScene() {
        SceneManager.LoadScene("Main10");
		UIManager.score=0;
        Debug.Log("Main Game");
    }
	// resume dari game
    public void ResumeScene() {
        SceneManager.LoadScene("Main10");
        Debug.Log("Main Game");
    }
}
