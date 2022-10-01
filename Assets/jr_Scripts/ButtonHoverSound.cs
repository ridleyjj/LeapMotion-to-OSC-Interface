using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoverSound : MonoBehaviour, IPointerEnterHandler
{
    private AudioSource soundManager;

    private void Awake()
    {
        soundManager = FindObjectOfType<AudioSource>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        soundManager.PlayOneShot(soundManager.clip);
    }
}
