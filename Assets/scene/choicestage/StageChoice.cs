using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageChoice : MonoBehaviour
{
    public GameObject isLock1;
    public GameObject isLock2;
    public GameObject isLock3;
    public GameObject isLock4;
    public GameObject isLock5;
    public GameObject isLock6;

    void Update()
    {
        if (playerdoor.stagescore <= 1)
            isLock2.SetActive(true);
        if (playerdoor.stagescore <= 2)
            isLock3.SetActive(true);
        if (playerdoor.stagescore <= 3)
            isLock4.SetActive(true);
        if (playerdoor.stagescore <= 4)
            isLock5.SetActive(true);
        if (playerdoor.stagescore <= 5)
            isLock6.SetActive(true);

        if (playerdoor.stagescore >= 0)
            isLock1.SetActive(false);
        if (playerdoor.stagescore >= 1)
            isLock2.SetActive(false);
        if (playerdoor.stagescore >= 2)
            isLock3.SetActive(false);
        if (playerdoor.stagescore >= 3)
            isLock4.SetActive(false);
        if (playerdoor.stagescore >= 4)
            isLock5.SetActive(false);
        if (playerdoor.stagescore >= 5)
            isLock6.SetActive(false);
    }
    public void tutorial()
    {
        SceneManager.LoadScene("tutorial");
    } 
    public void stage1()
    {
        if (playerdoor.stagescore >= 0) {
            SceneManager.LoadScene("stage1scene");
            PlayerClue.cluescore = 0;
            playerKey.yellowscore = 0;
            playerKey.bluescore = 0;
            playerKey.greenscore = 0;
                }
    }
    public void stage2()
    {
        if (playerdoor.stagescore >= 1)
        {
            SceneManager.LoadScene("stage2scene");
            PlayerClue.cluescore = 1;
            playerKey.yellowscore = 1;
            playerKey.bluescore = 1;
            playerKey.greenscore = 1;
        }
    }
    public void stage3()
    {
        if (playerdoor.stagescore >= 2)
        {
            SceneManager.LoadScene("stage3scene");
            PlayerClue.cluescore = 2;
            playerKey.yellowscore = 2;
            playerKey.bluescore = 2;
            playerKey.greenscore = 2;
        }
        }
    public void stage4()
    {
        if (playerdoor.stagescore >= 3)
        {
            SceneManager.LoadScene("stage4scene");
            PlayerClue.cluescore = 3;
            playerKey.yellowscore = 3;
            playerKey.bluescore = 3;
            playerKey.greenscore = 3;
        }
        }
    public void stage5()
    {
        if (playerdoor.stagescore >= 4)
        {
            SceneManager.LoadScene("stage5scene");
            PlayerClue.cluescore = 4;
            playerKey.yellowscore = 4;
            playerKey.bluescore = 4;
            playerKey.greenscore = 4;
        }
        }
    public void stage6()
    {
        if (playerdoor.stagescore >= 5)
        {
            SceneManager.LoadScene("stage6scene");
            PlayerClue.cluescore = 5;
            playerKey.yellowscore = 5;
            playerKey.bluescore = 5;
            playerKey.greenscore = 5;
        }
        }
}
