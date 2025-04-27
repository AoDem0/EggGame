using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChange : MonoBehaviour
{
    public void GameStart()
    {   
        
        SceneManager.LoadScene("game");
       
    }
        public void Again()
    {   
        SceneManager.LoadScene("game");
    }
    public void QuitGame()
    {
        
        Debug.Log("Quit");
        Application.Quit();
    }
}
