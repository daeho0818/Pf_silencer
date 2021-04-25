using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BangHyang : MonoBehaviour
{
    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow3;
    public GameObject arrow4;
    public GameObject arrow5;
    public GameObject arrow6;

    public GameObject arrow_1;
    public GameObject arrow_2;
    public GameObject arrow_3;
    public GameObject arrow_4;
    public GameObject arrow_5;
    public GameObject arrow_6;
    void Start()
    {
        arrow1.SetActive(false);
        arrow2.SetActive(false);
        arrow3.SetActive(false);
        arrow4.SetActive(false);
        arrow5.SetActive(false);
        arrow6.SetActive(false);

        arrow_1.SetActive(false);
        arrow_2.SetActive(false);
        arrow_3.SetActive(false);
        arrow_4.SetActive(false);
        arrow_5.SetActive(false);
        arrow_6.SetActive(false);
    }
    public void arrow1up()
    {
        arrow1.SetActive(true);
        arrow_1.SetActive(true);
    }
    public void arrow1down()
    {
        arrow1.SetActive(false);
        arrow_1.SetActive(false);
    }
    public void arrow2up()
    {
        arrow2.SetActive(true);
        arrow_2.SetActive(true);
    }
    public void arrow2down()
    {
        arrow2.SetActive(false);
        arrow_2.SetActive(false);
    }
    public void arrow3up()
    {
        arrow3.SetActive(true);
        arrow_3.SetActive(true);
    }
    public void arrow3down()
    {
        arrow3.SetActive(false);
        arrow_3.SetActive(false);
    }
    public void arrow4up()
    {
        arrow4.SetActive(true);
        arrow_4.SetActive(true);
    }
    public void arrow4down()
    {
        arrow4.SetActive(false);
        arrow_4.SetActive(false);
    }
    public void arrow5up()
    {
        arrow5.SetActive(true);
        arrow_5.SetActive(true);
    }
    public void arrow5down()
    {
        arrow5.SetActive(false);
        arrow_5.SetActive(false);
    }
    public void arrow6up()
    {
        arrow6.SetActive(true);
        arrow_6.SetActive(true);
    }
    public void arrow6down()
    {
        arrow6.SetActive(false);
        arrow_6.SetActive(false);
    }
}
