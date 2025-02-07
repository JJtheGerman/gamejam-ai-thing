using LLMUnitySamples;
using UnityEngine;
using StarterAssets;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class InteractablePrompt : MonoBehaviour, IInteractable
{
    private Outline outline;
    [FormerlySerializedAs("Canvas")] [SerializeField]
    private Canvas canvas;
    [FormerlySerializedAs("ChatBot")] [SerializeField]
    private ChatBot chatBot;
    [SerializeField]
    private FirstPersonController firstPersonController;
    [SerializeField] 
    private Text MonitorText;

    void Start()
    {
        // Ensure the object has an Outline component
        outline = GetComponent<Outline>();
        if (outline != null)
        {
            outline.enabled = false; // Disable the outline initially
        }
        
        canvas.gameObject.SetActive(false);
        MonitorText.text = "";
    }

    public void Interact()
    {
        canvas.gameObject.SetActive(true);
        //chatBot.ActivateInput();
        firstPersonController.enabled = false;
    }

    public void SetHighlight(bool bState)
    {
        if (outline)
        {
            outline.enabled = bState;
        }
    }

    public void StopInteract()
    {
        canvas.gameObject.SetActive(false);
        firstPersonController.enabled = true;
    }
}
