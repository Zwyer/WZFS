using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject loginPanel, changePwdPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoginButton()
    {
        loginPanel.SetActive(true);
    }

    public void ChangePwdButton()
    {
        changePwdPanel.SetActive(true);
    }

    public void QueryScoreButton()
    {
        Debug.Log("Query!");
    }
}
