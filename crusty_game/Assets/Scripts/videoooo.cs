using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class videoooo : MonoBehaviour
{

    public AudioClip clip;
    VideoPlayer gamer;

    // Start is called before the first frame update
    void Start()
    {
        gamer = this.GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        print(gamer.frameCount + "; " + (gamer.frame+1));

        if ((long) gamer.frameCount <= (gamer.frame+1))
        {
            Destroy(gamer);
            this.transform.parent.AddComponent<BeanMove>();
            this.transform.parent.GetComponent<BeanMove>().speed = 6000;
            this.transform.parent.GetComponent<BeanMove>().cam = this.gameObject.GetComponent<Camera>();

            this.AddComponent<AudioSource>();
            this.GetComponent<AudioSource>().loop = true;
            this.GetComponent<AudioSource>().clip = clip;
            this.GetComponent<AudioSource>().Play();
        }
    }
}
