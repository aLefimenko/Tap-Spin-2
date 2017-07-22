using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CircleBase : MonoBehaviour {

    protected int mass;
    protected string type;
    protected GameObject prefabObject;

    protected abstract void CreateObj();
}
