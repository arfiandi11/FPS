using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScenee : MonoBehaviour {

    // pindah scene ke menu
    public void MenuUtama() {
        SceneManager.LoadScene("Menu");
        // Debug.Log("Menu Scene");
    }

    // pindah scene ke loading
    public void LoadingScene() {
        SceneManager.LoadScene("Loading");
        // Debug.Log("Loading Scene");
    }

    // keluar dari game
    public void KeluarScene() {
        Application.Quit();
        // Debug.Log("Keluar Game");
    }
}
