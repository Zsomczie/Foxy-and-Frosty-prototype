using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    float leftEdge;
    [SerializeField] Transform Locator;
    [SerializeField] Vector3 newPos;
    [SerializeField] Transform EndLocator;
    [SerializeField] Vector3 oldPos;
    // Start is called before the first frame update
    void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 5f;
        newPos = Locator.position;
        oldPos = EndLocator.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < oldPos.x)
        {
            transform.position=newPos;
        }
    }
}
