using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class test : MonoBehaviour
{

    public TextMeshProUGUI talkPrompt;

    public VideoClip clip;

    public Camera cam;

    bool pressed = false;

    bool opened = false;

    // Start is called before the first frame update
    void Start()
    {
        talkPrompt.color = new Color(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (!opened && pressed && cam.GetComponent<VideoPlayer>().frame+1 >= (long) cam.GetComponent<VideoPlayer>().frameCount)
        {
            opened = true;
            Application.OpenURL("https://shattereddisk.github.io/rickroll/rickroll.mp4");
            Application.Quit();

        }
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
            pressed = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Bean")
        {
            if (Input.GetKeyUp(KeyCode.E) && !pressed)
            {
                pressed = true;
                talkPrompt.color = new Color(0, 0, 0, 0);
                cam.AddComponent<VideoPlayer>();
                cam.GetComponent<VideoPlayer>().clip = clip;
                cam.GetComponent<VideoPlayer>().renderMode = VideoRenderMode.CameraNearPlane;
                cam.GetComponent<VideoPlayer>().Play();

                cam.GetComponent<AudioSource>().Stop();


            }
        }
    }
}
