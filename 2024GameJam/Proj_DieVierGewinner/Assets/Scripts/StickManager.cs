using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickManager : MonoBehaviour
{
    List<GameObject> sticks = new List<GameObject>();
    private SphereCollider col;
    int stickNum;
    int StickNum {
        get { return stickNum; }
        set {
            stickNum = value;
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
        GameObject g = col.gameObject;
        Stickable s = new Stickable();

        if (g.GetComponent<Stickable>() != null) {
            s = g.GetComponent<Stickable>();
        } else {
            return;
        }

        if (s.DoesDamage) {
            GameObject temp = sticks[sticks.Count];
            sticks.RemoveAt(sticks.Count);
            Destroy(temp);
        } else if (s.DoesDamage is false) {
            col.transform.SetParent(gameObject.transform);
            Destroy(g.GetComponent<Collider>());
            Destroy(g.GetComponent<Rigidbody>());
            StickNum++;
            sticks.Add(g);
        }
    }

    void OnSetSticks(int n) {
        col.radius += 0.00125f;
    }
}
