using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chit2 : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("endscene");
            PlayerClue.cluescore++;
            playerKey.yellowscore++;
            playerKey.bluescore++;
            playerKey.greenscore++;
            playerdoor.stagescore++;
        }
    }
}
