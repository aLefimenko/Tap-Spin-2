using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;

class StartScript : MonoBehaviour
{
    public GameObject prefabOfCircleForScore;
    public GameObject prefabOfCircleForDie;

    private Component ComponentForScore;
    private Component ComponentForDie;

    void Start()
    {
        
    }

    public void StartGame()
    {
        gameObject.AddComponent<CircleOneScore>();
        gameObject.GetComponent<CircleOneScore>().StartScriptGame(prefabOfCircleForScore);
        //CircleForDie = gameObject.AddComponent<DeathCircle>();


    }
}

