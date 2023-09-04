using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Flower : MonoBehaviour
{
    Interaction interaction;
    [SerializeField]FoxItems foxItems;
    public UnityEvent switchDialogue;
    // Start is called before the first frame update
    void Start()
    {
        interaction = GetComponent<Interaction>();
        foxItems = GameObject.Find("Fox").GetComponent<FoxItems>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interaction.used)
        {
            switchDialogue.Invoke();
            foxItems.flower = true;
            Destroy(gameObject);
        }
    }
    public void enableFlower() 
    {
        interaction.enabled = true;
    }
}
