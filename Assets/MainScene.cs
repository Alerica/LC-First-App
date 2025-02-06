using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    public void ToMainMenu() {
        SceneManager.LoadSceneAsync("Main Menu");
    }
}
