using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDeath : MonoBehaviour
{
    public GameObject anim;
    public int maxHealth = 1;
    static public bool isDie = false;
    int health = 1;
    public GameObject gameover;
    void Start()
    {
        health = maxHealth;
        gameover.SetActive(false);
        isDie = false;
        anim.SetActive(false);
    }
    void Update()
    {
        health = 0;
        if (health == 0)
        {
            if (!isDie)
                Die();
            return;
        }
    }
    void FixedUpdate()
    {
        if (health == 0)
            return;
    }
    void Die()
    {
        Debug.Log("사일런서가 돌아다니는 중...");
        if (Vector3.Distance(GameObject.FindGameObjectWithTag("silencer").transform.position,
            GameObject.FindGameObjectWithTag("Player").transform.position) <= 0.1f)
        {
            Debug.Log("넌 죽었엉");
            isDie = true;
            StartCoroutine("time");            
        }
    }
    IEnumerator time()
    {
        anim.SetActive(true);
        yield return new WaitForSeconds(1f);
        anim.SetActive(false);
        gameover.SetActive(true);
        yield return null;
    }
}