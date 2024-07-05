using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubblespawer : MonoBehaviour
{
    [SerializeField] GameObject _bubble;
    [SerializeField] float _spawnRateBubble = 2f;
    [SerializeField] float _highOffset = 0.5f;
    private float timer = 0;

    void Start()
    {
        SpawnCoral();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timer);
        if (timer < _spawnRateBubble)
        {
            timer = timer + Time.deltaTime;

        }
        else
        {
            SpawnCoral();
            timer = 0;
        }
    }

    private void SpawnCoral()

    {
        float lowestPoint = transform.position.y - _highOffset;
        float higgestPoint = transform.position.y + _highOffset;
        float xlowpoint = transform.position.x - _highOffset;
        float xhighpoint = transform.position.x + _highOffset;
        Instantiate(_bubble, new Vector3(Random.Range(xlowpoint, xhighpoint), Random.Range(lowestPoint, higgestPoint), 0), transform.rotation);
    }
}
