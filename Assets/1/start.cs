﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
            SceneManager.LoadScene("intro");
    }
}
