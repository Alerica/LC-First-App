using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ToMainScene() 
    {
        SceneManager.LoadSceneAsync("Main Scene");
    }
}
