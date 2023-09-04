using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    [SerializeField] bool isActive = false;
    [SerializeField] public bool used = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&&isActive)
        {
            used = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        isActive = true;
    }
    private void OnTriggerExit(Collider other)
    {
        isActive = false;
    }
}
