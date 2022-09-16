using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public Bird birdScript;
    public float time;
    public float height;
    public GameObject Pipes;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
    public IEnumerator SpawnObject(float time)
    {
        while (!birdScript.isDead)
        {
            Instantiate(Pipes, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
    }   
}
