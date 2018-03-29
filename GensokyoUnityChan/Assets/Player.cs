using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [Range(0.0f, 10.0f)] // create a slider in the editor and set limits on moveSpeed
    public float moveSpeed = 3f;

    private Rigidbody _rigidbody;

    float _vx;
    float _vy;

    // Use this for initialization
    void Awake() {
        _rigidbody = GetComponent<Rigidbody>();
        if (_rigidbody == null) // if Rigidbody is missing
            Debug.LogError("Rigidbody component missing from this gameobject");

    }

    // Update is called once per frame
    void Update () {
        _vx = Input.GetAxisRaw("Horizontal");
        _vy = Input.GetAxisRaw("Vertical");
        

        _rigidbody.velocity = new Vector3(_vx * moveSpeed, _vy * moveSpeed, 0);
    }
}
