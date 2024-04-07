using System;
using TMPro;
using UnityEngine;

public class CollectShard : MonoBehaviour
{

    bool pressed = false;

    public TextMeshProUGUI talkPrompt;

    // Start is called before the first frame update
    void Start()
    {
        talkPrompt.color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Bean")
        {
            talkPrompt.color = new Color(255, 0, 255, 1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Bean")
        {
            talkPrompt.color = new Color(0, 0, 0, 0);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Bean")
        {

            if (Input.GetKey(KeyCode.E) && !pressed)
            {
                pressed = true;
                talkPrompt.color = new Color(0, 0, 0, 0);
                Destroy(this.gameObject);

            }
        }
    }
}
