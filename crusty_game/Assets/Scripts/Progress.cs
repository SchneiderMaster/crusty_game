using TMPro;
using UnityEngine;

public class Progress : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;

    public GameObject cd;

    public GameObject bean;

    public TextMeshProUGUI talkPrompt;

    public Camera cam;

    GameObject[] shards = new GameObject[5];

    bool allCollected = false;

    bool spawned = false;

    // Start is called before the first frame update
    void Start()
    {
        shards[0] = one;
        shards[1] = two;
        shards[2] = three;
        shards[3] = four;
        shards[4] = five;
    }

    // Update is called once per frame
    void Update()
    {
        allCollected = true;
        for (int i = 0; i < shards.Length; i++)
        {
            if (shards[i] != null)
            {
                allCollected = false;
                print(i + " is null");

            }
        }

        if (allCollected && !spawned)
        {
            print("all have been collected");


            cd.GetComponent<test>().talkPrompt = talkPrompt;
            cd.GetComponent<test>().cam = cam;
            cd.GetComponent<LookAtCool>().cam = cam;


            Instantiate(cd, bean.transform.position, Quaternion.identity);

            spawned = true;
        }
    }
}
