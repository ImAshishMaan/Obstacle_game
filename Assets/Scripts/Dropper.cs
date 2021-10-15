using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    new MeshRenderer renderer;
    Rigidbody rigidBody;
    [SerializeField] float dropTime = 12f; 

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.useGravity = false;
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //print(Time.time);
        if (Time.time > dropTime) 
        {
            EnableGravity();
            EnableMeshRenderer();
        }
    }
    void EnableGravity()
    {
        rigidBody.useGravity = true;
    }
    void EnableMeshRenderer()
    {
        renderer.enabled = true;
    }
}
