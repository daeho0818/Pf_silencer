using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartscene : MonoBehaviour
{
    public void restartfirstscene()
    {
        SceneManager.LoadScene("stage1scene");
        playerKey.bluescore = 0;
        playerKey.yellowscore = 0;
        playerKey.greenscore = 0;
        PlayerClue.cluescore = 0;
    }
    public void restartsecondscene()
    {
        SceneManager.LoadScene("stage2scene");
        playerKey.bluescore = 1;
        playerKey.yellowscore = 1;
        playerKey.greenscore = 1;
        PlayerClue.cluescore = 1;
    }
    public void restartthirdscene()
    {
        SceneManager.LoadScene("stage3scene");
        playerKey.bluescore = 2;
        playerKey.yellowscore = 2;
        playerKey.greenscore = 2;
        PlayerClue.cluescore = 2;
    }
    public void restartfourthscene()
    {
        SceneManager.LoadScene("stage4scene");
        playerKey.bluescore = 3;
        playerKey.yellowscore = 3;
        playerKey.greenscore = 3;
        PlayerClue.cluescore = 3;
    }
    public void restartFifthscene()
    {
        SceneManager.LoadScene("stage5scene");
        playerKey.bluescore = 4;
        playerKey.yellowscore = 4;
        playerKey.greenscore = 4;
        PlayerClue.cluescore = 4;
    }
    public void restartsixthscene()
    {
        SceneManager.LoadScene("stage6scene");
        playerKey.bluescore = 5;
        playerKey.yellowscore = 5;
        playerKey.greenscore = 5;
        PlayerClue.cluescore = 5;
    }
}
