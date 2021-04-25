using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ending : MonoBehaviour
{
    public GameObject ending1;
    public GameObject ending3;
    void Start()
    {
        ending1.SetActive(false);
        ending3.SetActive(false);
        StartCoroutine("outtro");
    }

    IEnumerator outtro()
    {
        ending1.SetActive(true);
        yield return new WaitForSeconds(20);
        ending1.SetActive(false);
        ending3.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("titlescene");
        yield return null;
    }
}
