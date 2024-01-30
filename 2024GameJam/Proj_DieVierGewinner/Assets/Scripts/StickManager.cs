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

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.GetComponent<Stickable>() != null) {
            collision.transform.SetParent(gameObject.transform);
            Destroy(collision.gameObject.GetComponent<Collider>());
            Destroy(collision.gameObject.GetComponent<Rigidbody>());
            Sticks++;
        }
    }

    void OnSetSticks(int n) {
        col.radius += n * 0.1f;
    }
}
