using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HeneGames.DialogueSystem
{
    public class DialogueChange : MonoBehaviour
    {
        [SerializeField] public List<NPC_Centence> newSentences = new List<NPC_Centence>();
        DialogueManager dialogueManager;
        // Start is called before the first frame update
        void Start()
        {
            dialogueManager = GetComponent<DialogueManager>();
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void ChangeDialogue()
        {
            Debug.Log("lmao");
            dialogueManager.sentences = newSentences;
        }
    }
}