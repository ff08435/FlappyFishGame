using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoralMover : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 3f;
    public float _deadZone = -10.25f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      transform.position = transform.position + (Vector3.left * _moveSpeed) * Time.deltaTime;
        if (transform.position.x < _deadZone)
        { 
            Destroy(gameObject);
        }
    

    }
}
