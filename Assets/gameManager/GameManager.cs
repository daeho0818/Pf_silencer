using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isstop = false;
    public GameObject stop;
    void Start()
    {
        stop.SetActive(false);
        isstop = false;
    }
    void Update()
    {
        if (isstop == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                stop.SetActive(true);
                isstop = true;
            }
        }
        else if (isstop == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                stop.SetActive(false);
                isstop = false;
            }
        }       
    }
    public void stopOnOff()
    {
        stop.SetActive(false);
    }
}
