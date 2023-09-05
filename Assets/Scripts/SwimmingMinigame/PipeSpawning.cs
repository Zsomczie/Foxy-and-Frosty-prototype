using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawning : MonoBehaviour
{
    public List<GameObject> prefabs;
    [SerializeField] float spawnRate = 1f;
    [SerializeField] float minHeight = -2f;
    [SerializeField] float maxHeight = 2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }
    void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    void Spawn()
    {
        int whichObject = Random.Range(0, prefabs.Count);
        //GameObject pipes = Instantiate(prefabs[whichObject]);
        GameObject pipes = Instantiate(prefabs[whichObject], transform.position, Quaternion.identity);
        pipes.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
