using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class GiveScore : MonoBehaviour
{
    // Start is called before the first frame update
    public Text curData;

    public List<Toggle> Avgs;
    public List<Dropdown> Dds;
    public List<InputField> Iis;
    
    enum Avg{
        Sleep,Egg,Tooth,Guitar,Watch,HomeWorkDone,HomeWorkNotDown
    }

    enum Dd
    {
        FinishTime
    }

    enum Ii
    {
        Math,En,Ch
    }
    void Start()
    {
        curData.text= GetCurDate(DateTime.Now.ToLongDateString(),DateTime.Now.DayOfWeek.ToString());
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string GetCurDate(string Day,string Week)
    {
        StringBuilder t = new StringBuilder();
        t.Append("当前日期:");
        t.Append(Day);
        t.Append("\n");
        switch (Week)
        {
            case "Monday":
                t.Append("星期一");
                break;
            case "Tuesday":
                t.Append("星期二");
                break;
            case "Wednesday":
                t.Append("星期三");
                break;
            case "Thursday":
                t.Append("星期四");
                break;
            case "Friday":
                t.Append("星期五");
                break;
            case "Saturday":
                t.Append("星期六");
                break;
            case "Sunday":
                t.Append("星期天");
                break;
        }
        return t.ToString();
    }
}
