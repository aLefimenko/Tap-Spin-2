using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using UnityEngine;

class DeathCircle : CircleBase
{
    private Coroutine coroutineForInst;

    protected override void CreateObj()
    {
        coroutineForInst = StartCoroutine(Create());
    }

    IEnumerator Create()
    {
        yield return new WaitForSeconds(2f);
        Instantiate(prefabObject, prefabObject.transform.position, Quaternion.identity);
        Repeat();
    }

    void Repeat()
    {
        coroutineForInst= StartCoroutine(Create());
    }
}

