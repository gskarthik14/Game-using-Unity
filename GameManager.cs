using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnd = false;
    public GameObject LevelCompleteUI;
    public void LevelComplete ()
        {
        LevelCompleteUI.SetActive(true);
        }
    public void Endgame()
    {

        if (gameEnd == false)
        {
            gameEnd = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", 1f);
        }
    
    }
          void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    

}

