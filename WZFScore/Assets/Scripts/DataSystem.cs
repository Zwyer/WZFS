using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[Serializable]
public class DataContent
{
    struct Data
    {
        private int time;
        private int usedScore;
        private int ScoreAfterToday;//不包括使用的
        private bool avg1, avg2, avg3;//三及格项
        private List<int> otherScore;
    }

    private int totalScore;
    
}
