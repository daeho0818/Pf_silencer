using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chit : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("titlescene");
            PlayerClue.cluescore++;
            playerKey.yellowscore++;
            playerKey.bluescore++;
            playerKey.greenscore++;
            playerdoor.stagescore++;
        }
    }
}
