using HeneGames.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SceneMan : MonoBehaviour
{
    GameObject diaUI;
    // Start is called before the first frame update
    void Awake()
    {
        diaUI = Resources.FindObjectsOfTypeAll<DialogueUI>().First().gameObject;
        Destroy(diaUI);
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
