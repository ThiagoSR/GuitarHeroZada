﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    int multiplier=0;
    int streak=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){

        Destroy(col.gameObject);

    }

    public void AddStreak(){

        streak++;
        if(streak>=24)
            multiplier=4;
        else if(streak>=16)
            multiplier=3;
        else if(streak>=8)
            multiplier=2;
        else
            multiplier=1;
            UpdateGUI();

    }

    public void ResetStreak(){

        streak=0;
        multiplier=1;
        UpdateGUI();

    }

    void UpdateGUI(){

        PlayerPrefs.SetInt("Streak", streak);
        PlayerPrefs.SetInt("Mult", multiplier);

    }

    public int GetScore(){
        return 100*multiplier;
    }

}
