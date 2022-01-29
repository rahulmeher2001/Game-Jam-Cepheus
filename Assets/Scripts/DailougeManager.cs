using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailougeManager : MonoBehaviour
{
    private Queue<string> Sentences;
    public Text nameText;
    public Text dialogueText;
    public GameObject dailougebox;
    public bool uiisactive;
    public trigger1[] tri;
    private GameObject[] trig;


    // Start is called before the first frame update
    private void Start()
    {
        trig = GameObject.FindGameObjectsWithTag("dialogue");
        for(int i = 0; i < trig.Length; i++)
        {
            tri[i] = trig[i].GetComponent<trigger1>();
        }
    }

    public void StartDialogue(Dailouge dailouge)
    {
        Sentences = new Queue<string>();
        uiisactive = true;
        dailougebox.SetActive(true);
        nameText.enabled = true;
        dialogueText.enabled = true;
        // Debug.Log("lol");
        nameText.text = dailouge.name;
        Sentences.Clear();
        foreach (string sentence in dailouge.sentences)
        {
            Sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (Sentences.Count == 0)
        {
            EndDialogue();
        }

        string Sentence = Sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(Sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        uiisactive = false;
        dailougebox.SetActive(false);
        nameText.enabled = false;
        dialogueText.enabled = false;
        for(int i=0; i < tri.Length; i++)
        {
            tri[i].ifdialogue = false;
        }
       
    }
}
