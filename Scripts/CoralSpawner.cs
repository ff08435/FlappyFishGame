using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoralSpawner : MonoBehaviour
{
    [SerializeField] GameObject _coral;
    [SerializeField] float _spawnRate = 2f;
    [SerializeField] float _highOffset = 10;
    private float timer = 0;

    void Start()
    {
        SpawnCoral();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(timer);
        if (timer < _spawnRate)
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
        Instantiate(_coral, new Vector3(_coral.transform.position.x, Random.Range(lowestPoint, higgestPoint), 0), transform.rotation);
    }
}
