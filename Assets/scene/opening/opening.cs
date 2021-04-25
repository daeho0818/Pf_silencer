using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opening : MonoBehaviour
{
    public GameObject intro1;
    public GameObject intro2;
    public GameObject intro3;
    public GameObject intro4;
    void Start()
    {
        intro1.SetActive(false);
        intro2.SetActive(false);
        intro3.SetActive(false);
        intro4.SetActive(false);
        StartCoroutine ("intro");
    }

    IEnumerator intro()
    {
        intro1.SetActive(true);
        yield return new WaitForSeconds(3);
        intro2.SetActive(true);
        yield return new WaitForSeconds(3);
        intro3.SetActive(true);
        yield return new WaitForSeconds(3);
        intro4.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("titlescene");
        yield return null;
    }
}
