using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {
    public float xMovSpeed;
    public float zMovSpeed;

    Rigidbody rb;
    Collider col;

    private void Awake() {
        rb = GetComponent<Rigidbody>();
    }

    void Start() {
        
    }

    void Update() {
        Vector3 inp = new Vector3 (AscertainInputQuantities().Item1, 0, AscertainInputQuantities().Item2);
        ModifyNewtonianForces (inp);
    }

    (float, float) AscertainInputQuantities() {
        float sideAx = Input.GetAxis("Horizontal") * xMovSpeed * Time.deltaTime;
        float forwAx = Input.GetAxis("Vertical") * zMovSpeed * Time.deltaTime;
        return (sideAx, forwAx);
    }

    void ModifyNewtonianForces(Vector3 i) {
        rb.AddForce(i);
    }
}
