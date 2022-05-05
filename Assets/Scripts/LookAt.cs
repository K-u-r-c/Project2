using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {
    public new Transform gameObject;

    // Update is called once per frame
    void Update() {
        transform.LookAt(gameObject, Vector3.zero);
    }
}
