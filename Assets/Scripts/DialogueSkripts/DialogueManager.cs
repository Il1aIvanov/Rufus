using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    public Text personText;
    [SerializeField] GameObject StartButton;

    private  Queue<string> sentenses;


    void Start()
    {
        sentenses = new Queue<string>();

    }

    public void StartDialogue(Dialogue dialogue)
    { 
        personText.text = dialogue.person;

        sentenses.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentenses.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentenses.Count == 0)
        {
            StartButton.SetActive(true);
            EndDialogue();
            return;
        }

        string sentence = sentenses.Dequeue();
        StopAllCoroutines ();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentance)
    {
        dialogueText.text = "";
        foreach (char letter in sentance.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;

        }
    }

    void EndDialogue()
    { 
     
    }
}
