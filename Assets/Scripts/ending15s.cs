﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ending15s : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator _typing()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("ending16");

    }
}
