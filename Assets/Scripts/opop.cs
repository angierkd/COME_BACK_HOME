﻿using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class opop : MonoBehaviour
{
    public Text ex;
    private string s_text = " 안녕하세요.\n\n 2190년 2월 25일 15시 55분, 부팅을 시작합니다... ";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_typing());

    }

    IEnumerator _typing()
    {
        yield return new WaitForSeconds(1f);
        for (int i = 0; i <= s_text.Length; i++)
        {
            ex.text = s_text.Substring(0, i);
            yield return new WaitForSeconds(0.15f);
        }

        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("error");

    }
    // Update is called once per frame
    void Update()
    {

    }
}
