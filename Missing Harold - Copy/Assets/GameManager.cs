using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    
    public void EndGame ()
    {
        if(gameHasEnded == false);
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);  //gives delay when game ends
        }
    }
    
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
