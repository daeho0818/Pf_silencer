using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngineInternal;

public class playerKey : MonoBehaviour
{
    static public int yellowscore = 0;
    static public int bluescore = 0;
    static public int greenscore = 0;

    static public GameObject yUI;
    static public GameObject bUI;
    static public GameObject gUI;

    static public GameObject yellowkey;
    static public GameObject bluekey;
    static public GameObject greenkey;

    void Start()
    {
        yUI = GameObject.FindGameObjectWithTag("YellowKey");
        bUI = GameObject.FindGameObjectWithTag("BlueKey");
        gUI = GameObject.FindGameObjectWithTag("GreenKey");
        yUI.SetActive(false);
        bUI.SetActive(false);
        gUI.SetActive(false);

        yellowkey = GameObject.FindGameObjectWithTag("yellowkey");
        bluekey = GameObject.FindGameObjectWithTag("bluekey");
        greenkey = GameObject.FindGameObjectWithTag("greenkey");

        yellowkey.SetActive(true);
        bluekey.SetActive(false);
        greenkey.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        
        
        if (other.gameObject.tag == "yellowkey")
        {
            other.gameObject.SetActive(false);
            yellowscore++;
            Debug.Log("노란색 열쇠 획득!");
            yUI.SetActive(true);
        }
        else if (other.gameObject.tag == "bluekey")
        {
            other.gameObject.SetActive(false);
            bluescore++;
            Debug.Log("파란색 열쇠 획득!");
            bUI.SetActive(true);
        }
        else if (other.gameObject.tag == "greenkey")
        {
            other.gameObject.SetActive(false);
            greenscore++;
            Debug.Log("초록색 열쇠 획득!");
            gUI.SetActive(true);
        }
    }
}
