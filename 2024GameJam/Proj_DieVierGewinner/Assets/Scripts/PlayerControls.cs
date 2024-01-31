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
        float sideAx = -1 * Input.GetAxis("Horizontal") * xMovSpeed * Time.deltaTime;
        Vector3 inp = new Vector3 (0, 0, sideAx);
        rb.AddForce(inp, ForceMode.Acceleration);
    }
}
