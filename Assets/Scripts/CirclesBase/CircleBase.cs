using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CircleBase : MonoBehaviour {

    protected float mass;
    protected string type;
    protected GameObject prefabObject;

    protected abstract void CreateObj();
}
