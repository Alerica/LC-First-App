using UnityEngine;
using UnityEngine.SceneManagement;
public class EndingScene : MonoBehaviour
{
    public void ToMainMenu() 
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }
}
