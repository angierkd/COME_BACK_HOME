﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotocquit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void aa()
    {

        if (DataController.gameData.num == 2)
            SceneManager.LoadScene("chapter2");
        else if (DataController.gameData.num == 3)
            SceneManager.LoadScene("chapter3");
        else
            SceneManager.LoadScene("chapter1");
    }
}
