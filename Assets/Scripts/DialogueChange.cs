using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace HeneGames.DialogueSystem
{
    public class DialogueChange : MonoBehaviour
    {
        [SerializeField] public List<NPC_Centence> newSentences = new List<NPC_Centence>();
        DialogueManager dialogueManager;
        FoxMove fox;
        // Start is called before the first frame update
        void Start()
        {
            fox = GameObject.Find("Fox").GetComponent<FoxMove>();
            dialogueManager = GetComponent<DialogueManager>();
            if (fox.canSwim == true)
            {
                gameObject.GetComponents<DialogueChange>().Last().ChangeDialogue();
            }
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