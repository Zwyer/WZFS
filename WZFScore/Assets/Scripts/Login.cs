using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField passwordInput;
    private string _pwd;
    public GameObject changePwdPanel;
    
    void Start()
    {
        gameObject.SetActive(false);
        _pwd = "000000";//DefaultPwd
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.HasKey("pwd"))
        {
            _pwd = PlayerPrefs.GetString("pwd");
        }
    }

    private void OnDisable()
    {
        passwordInput.text = "";
    }

    public void LoginButton()
    {
        if (_pwd == passwordInput.text)
        {
            Debug.Log("OK");
        }
        else
        {
            Debug.Log("No");
        }
    }

    public void CloseButton()
    {
        gameObject.SetActive(false);
    }

    public void ChangePwdButton()
    {
        changePwdPanel.SetActive(true);
    }
}
