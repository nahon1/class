using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour {

    [SerializeField]
    private Transform[] ballList;
    private float[] speed;

    private void Awake()
    {
        speed = new float[ballList.Length];
    }

    private void Start()
    {

    }

    private void Update()
    {

    }

    private void FixedUpdate()
    {

    }

    private void LateUpdate()
    {

    }

    private void OnCollisionEnter(Collider other)
    {

    }

    private void OnCollisionExit(Collider other)
    {

    }

    private void OnCollisionStay(Collider other)
    {

    }

    private void OnTriggerEnter(Collision collision)
    {

    }


}
