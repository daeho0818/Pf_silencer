using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerdoor4 : MonoBehaviour
{ 
    public GameObject yellowdoor;
    public GameObject bluedoor;
    public GameObject greendoor;

    void Start()
    {
        yellowdoor.SetActive(true);
        bluedoor.SetActive(false);
        greendoor.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "yellowdoor")
        {
            if (playerKey.yellowscore == 4)
            {
                other.gameObject.SetActive(false);
                Debug.Log("노란색 문 통과, 파란색 문과 열쇠가 생겼습니다.");
                playerKey.bluekey.SetActive(true);
                bluedoor.SetActive(true);
                playerKey.yUI.SetActive(false);
            }
        }
        else if (other.gameObject.tag == "bluedoor")
        {
            if (playerKey.bluescore == 4)
            {
                other.gameObject.SetActive(false);
                Debug.Log("파란색 문 통과, 초록색 문과 열쇠가 생겼습니다.");
                playerKey.greenkey.SetActive(true);
                greendoor.SetActive(true);
                playerKey.bUI.SetActive(false);
                PlayerClue.clue.SetActive(true);
            }
        }
        else if (other.gameObject.tag == "greendoor")
        {
            if (playerKey.greenscore == 4 && PlayerClue.cluescore == 4)
            {
                other.gameObject.SetActive(false);
                Debug.Log("초록색 문 통과");
                Debug.Log("다 깼당");
                playerKey.gUI.SetActive(false);
                SceneManager.LoadScene("titlescene");
                playerdoor.stagescore++;
            }
        }
    }

}
