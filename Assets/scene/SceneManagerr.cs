using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerr : MonoBehaviour
{
    // Start is called before the first frame update
    public void GameStart()
    {
        SceneManager.LoadScene("stagechoicescene");
    }

    public void GotoTitle()
    {
        SceneManager.LoadScene("titlescene");
    }
    public void GameExit()
    {
        Debug.Log("종료되었습니다.");
        Application.Quit();
    }
    public void SeeStory()
    {
        SceneManager.LoadScene("storyscene");
    }
}
