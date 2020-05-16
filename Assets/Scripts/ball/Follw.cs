using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follw : MonoBehaviour {

    public Transform b;
    Vector3 offset;
	void Start () {
        offset = this.transform.position - b.transform.position;
	}
	

	void Update () {
        this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y, b.transform.position.z + offset.z);

    }
}
