using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaWalls : MonoBehaviour
{
    [SerializeField]FoxMove fox;
    // Start is called before the first frame update
    void Start()
    {
        fox = GameObject.Find("Fox").GetComponent<FoxMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fox.canSwim)
        {
            gameObject.SetActive(false);
        }
    }
}
