using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;

class CircleOneScore : CircleBase
{
    private Coroutine coroutineForCircleScore;

    protected override void CreateObj()
    {
        coroutineForCircleScore = StartCoroutine(Create());
    }

    IEnumerator Create()
    {
        yield return new WaitForSeconds(4f);
        Instantiate(prefabObject, prefabObject.transform.position, Quaternion.identity);
        Repeat();
    }

    void Repeat()
    {
        coroutineForCircleScore = StartCoroutine(Create());
    }

    public  void StartScriptGame(GameObject pref)
    {
        prefabObject = pref;
        CreateObj();
    }
}
