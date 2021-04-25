using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClue : MonoBehaviour
{
    static public int cluescore = 0;
    static public GameObject clue;

    void Start()
    {
        clue = GameObject.FindGameObjectWithTag("clue");
        clue.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "clue")
        {
            other.gameObject.SetActive(false);
            cluescore++;
            Debug.Log(cluescore+"번째 단서 획득! 타이틀 화면에서 확인해주세요.");           
        }
    }
}
