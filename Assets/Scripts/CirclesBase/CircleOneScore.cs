using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;

class CircleOneScore : CircleBase
{
    private Coroutine coroutineForCircleScore;
    private Vector3 randCreat;

    void Start()
    {
        mass = 0.5f;
    }

    protected override void CreateObj()
    {
        coroutineForCircleScore = StartCoroutine(Create());
    }

    IEnumerator Create()
    {
        yield return new WaitForSeconds(1f);
        randCreat = new Vector3(UnityEngine.Random.Range(-2f, 2f), prefabObject.transform.position.y, prefabObject.transform.position.z);
        GameObject objectcircle = Instantiate(prefabObject, randCreat, Quaternion.identity);
        objectcircle.GetComponent<Rigidbody2D>().gravityScale = mass;
        objectcircle.AddComponent<ScoreScript>();
        mass += 0.05f;
        Repeat();
    }

    void Repeat()
    {
        coroutineForCircleScore = StartCoroutine(Create());
    }

    public void StartScriptGame(GameObject pref)
    {
        prefabObject = pref;
        CreateObj();
    }
}
