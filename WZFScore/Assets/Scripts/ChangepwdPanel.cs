using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangepwdPanel : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField RawPwd, NowPwd;
    public GameObject WrongAdvice;
    private string _pwd;
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        _pwd = "000000";
        WrongAdvice.SetActive(false);
        if (PlayerPrefs.HasKey("pwd"))
        {
            _pwd = PlayerPrefs.GetString("pwd");
        }
    }

    private void OnDisable()
    {
        RawPwd.text = "";
        NowPwd.text = "";
        
    }

    public void OKButton()
    {
        if (_pwd == RawPwd.text)
        {
            PlayerPrefs.SetString("pwd",NowPwd.text);
            gameObject.SetActive(false);
        }
        else
        {
            WrongAdvice.SetActive(true);
        }

        
    }

    public void CloseButton()
    {
        gameObject.SetActive(false);
    }
}

