using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickManager : MonoBehaviour
{
    private SphereCollider col;
    int sticks;
    int Sticks {
        get { return sticks; }
        set {
            sticks = value;
            OnSetSticks(value);
        }
    }

    private void Start() {
        col = GetComponent<SphereCollider>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col) {
        if (col.gameObject.GetComponent<Stickable>() != null) {
            col.transform.SetParent(gameObject.transform);
            Destroy(col.gameObject.GetComponent<Collider>());
            Destroy(col.gameObject.GetComponent<Rigidbody>());
            Sticks++;
        }
    }

    void OnSetSticks(int n) {
        col.radius += 0.0005f;
    }
}
