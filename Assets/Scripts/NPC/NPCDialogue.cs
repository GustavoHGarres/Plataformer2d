using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCDialogue : MonoBehaviour
{
    public string[] dialogueNPC; // Armazena os dialogos do NPC
    public int dialogueIndex;

    public GameObject dialoguePanel;
    public Text dialogueText;

    public Text nameNPC;
    public Image imageNPC;
    public Sprite SpriteNPC;

    public bool readyToSpeak;
    public bool startDialogue;

    
    void Start()
    {
        dialoguePanel.SetActive(false);
    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A) && readyToSpeak)
        {
            if(!startDialogue) // SE startDialogue for false
            {
               FindObjectOfType<MovementPlayer>().speed = 0; // Player nao movimenta mais
               StartDialogue();
            }

            else if (dialogueText.text == dialogueNPC[dialogueIndex])
            {
               NextDialogue();
            }

            void NextDialogue()
            {
                dialogueIndex++;
                
                if(dialogueIndex < dialogueNPC.Length)
                {
                    StartCoroutine(ShowDialogue());
                }
                else
                {
                    dialoguePanel.SetActive(false);
                    startDialogue = false;
                    dialogueIndex = 0;
                    FindObjectOfType<MovementPlayer>().speed = 5;
                }
            }
        }

        void StartDialogue()
        {
           nameNPC.text = "Sandra"; // Pega o compenete de texto.Sua propriedade de texto e atribui o nome Sandra
           imageNPC.sprite = SpriteNPC; // Pega o compenete de imagem.Sua propiedade sprite e atribui uma imagem
           startDialogue = true; // Iniciando um dialogo
           dialogueIndex = 0; // O primeiro dialogo
           dialoguePanel.SetActive(true); // Ativa o painel de dialogo   
           StartCoroutine(ShowDialogue());
        }
        
        IEnumerator ShowDialogue()
        {
           dialogueText.text = "";
           foreach (char letter in dialogueNPC[dialogueIndex])
           {
            dialogueText.text += letter;
            yield return null; // new WaitforSeconds(0.1f);
           }
        }
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.CompareTag("Player"))
         {
            readyToSpeak = true;
         }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            readyToSpeak = false;
         }
    }
}
