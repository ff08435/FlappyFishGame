using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleMover : MonoBehaviour
{
    [SerializeField] float _bubbleMoveSpeed = 3f;
    public float _bubbleDeadZone = -10.25f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * _bubbleMoveSpeed) * Time.deltaTime;
        if (transform.position.x < _bubbleDeadZone)
        {
            Destroy(gameObject);
        }


    }
}