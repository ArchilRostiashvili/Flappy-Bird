using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] private float maxTime;
    [SerializeField] private float heightRange;
    [SerializeField] private GameObject collumns;

    private float timer;

    private void Update()
    {
        if(timer > maxTime)
        {
            SpawnCollumn();
            timer = 0;
        }

        timer += Time.deltaTime;
    }

    private void SpawnCollumn()
    {
        Vector3 spawnPos = transform.position + new Vector3 (0, Random.Range(-heightRange, heightRange));
        GameObject _collums = Instantiate(collumns, spawnPos, Quaternion.identity);

        Destroy(_collums, 10f);
    }

}
