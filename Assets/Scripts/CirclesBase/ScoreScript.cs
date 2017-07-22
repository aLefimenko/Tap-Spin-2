using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class ScoreScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        Debug.Log("SciptOn");
        Destroy(gameObject);
    }

    void Update()
    {
        if(this.transform.position.y<=-6f)
        {
            Destroy(gameObject);
        }
    }
}
