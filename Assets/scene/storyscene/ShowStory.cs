using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowStory : MonoBehaviour
{
    public GameObject Story1;
    public GameObject Story2;
    public GameObject Story3;
    public GameObject Story4;
    public GameObject Story5;
    public GameObject Story6;
    public GameObject DontSee;

    public GameObject isLock1;
    public GameObject isLock2;
    public GameObject isLock3;
    public GameObject isLock4;
    public GameObject isLock5;
    public GameObject isLock6;

    public GameObject GotoStory;
    void Start()
    {
        GotoStory.SetActive(false);
    }
    void Update()
    {
        
        if (PlayerClue.cluescore <= 0)
            isLock1.SetActive(true);
        if (PlayerClue.cluescore <= 1)
            isLock2.SetActive(true);
        if (PlayerClue.cluescore <= 2)
            isLock3.SetActive(true);
        if (PlayerClue.cluescore <= 3)
            isLock4.SetActive(true);
        if (PlayerClue.cluescore <= 4)
            isLock5.SetActive(true);
        if (PlayerClue.cluescore <= 5)
            isLock6.SetActive(true);

        if (PlayerClue.cluescore >= 1)
            isLock1.SetActive(false);
        if (PlayerClue.cluescore >= 2)
            isLock2.SetActive(false);
        if (PlayerClue.cluescore >= 3)
            isLock3.SetActive(false);
        if (PlayerClue.cluescore >= 4)
            isLock4.SetActive(false);
        if (PlayerClue.cluescore >= 5)
            isLock5.SetActive(false);
        if (PlayerClue.cluescore >= 6)
            isLock6.SetActive(false);
    }
    public void gotostory()
    {
        Story1.SetActive(false);
        Story2.SetActive(false);
        Story3.SetActive(false);
        Story4.SetActive(false);
        Story5.SetActive(false);
        Story6.SetActive(false);
        DontSee.SetActive(false);
        GotoStory.SetActive(false);
    }
    public void story1()
    {      
        GotoStory.SetActive(true);
        isLock1.SetActive(false);
        isLock2.SetActive(false);
        isLock3.SetActive(false);
        isLock4.SetActive(false);
        isLock5.SetActive(false);
        isLock6.SetActive(false);
        if (PlayerClue.cluescore >= 1)
            Story1.SetActive(true);
        else
            DontSee.SetActive(true);
    }
    public void story2()
    {     
        GotoStory.SetActive(true);
        isLock1.SetActive(false);
        isLock2.SetActive(false);
        isLock3.SetActive(false);
        isLock4.SetActive(false);
        isLock5.SetActive(false);
        isLock6.SetActive(false);
        if (PlayerClue.cluescore >= 2)
            Story2.SetActive(true);
        else
            DontSee.SetActive(true);
    }

    public void story3()
    {
        GotoStory.SetActive(true);
        isLock1.SetActive(false);
        isLock2.SetActive(false);
        isLock3.SetActive(false);
        isLock4.SetActive(false);
        isLock5.SetActive(false);
        isLock6.SetActive(false);
        if (PlayerClue.cluescore >= 3)
            Story3.SetActive(true);
        else
            DontSee.SetActive(true);
    }
    public void story4()
    {
        GotoStory.SetActive(true);
        isLock1.SetActive(false);
        isLock2.SetActive(false);
        isLock3.SetActive(false);
        isLock4.SetActive(false);
        isLock5.SetActive(false);
        isLock6.SetActive(false);
        if (PlayerClue.cluescore >= 4)
            Story4.SetActive(true);
        else
            DontSee.SetActive(true);
    }
    public void story5()
    {
        GotoStory.SetActive(true);
        isLock1.SetActive(false);
        isLock2.SetActive(false);
        isLock3.SetActive(false);
        isLock4.SetActive(false);
        isLock5.SetActive(false);
        isLock6.SetActive(false);
        if (PlayerClue.cluescore >= 5)
            Story5.SetActive(true);
        else
            DontSee.SetActive(true);
    }
    public void story6()
    {
        GotoStory.SetActive(true);
        isLock1.SetActive(false);
        isLock2.SetActive(false);
        isLock3.SetActive(false);
        isLock4.SetActive(false);
        isLock5.SetActive(false);
        isLock6.SetActive(false);
        if (PlayerClue.cluescore >=6 )
            Story6.SetActive(true);
        else
            DontSee.SetActive(true);
    }
}
