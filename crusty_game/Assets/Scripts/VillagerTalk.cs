using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VillagerTalk : MonoBehaviour
{

    public CapsuleCollider talkZone;
    public TextMeshProUGUI talkPrompt;
    public TextMeshProUGUI dialog;
    public String dialogText;

    // Start is called before the first frame update
    void Start()
    {
        talkPrompt.color = new Color(0, 0, 0, 0);
        dialog.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        talkPrompt.color = new Color(255, 0, 255, 1);
    }

    private void OnTriggerExit(Collider other)
    {
        talkPrompt.color = new Color(0, 0, 0, 0);
        dialog.text = "";
    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
        {
            dialog.text = dialogText;
            talkPrompt.color = new Color(0, 0, 0, 0);
        }
    }
}
