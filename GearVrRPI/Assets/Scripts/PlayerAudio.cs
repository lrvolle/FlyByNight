using UnityEngine;
using System.Collections;

public class PlayerAudio : MonoBehaviour {
    public bool playRain = false;
    public AudioClip WingFlap1;
    public AudioClip WingFlap2;
    public AudioClip LightRain;
    public AudioClip RainDrops;
    private AudioSource wingSource1;
    private AudioSource wingSource2;
    private AudioSource rainSource1;
    private AudioSource rainSource2;

    // Use this for initialization
    void Start () {
        //initialize audio sources
        wingSource1 = gameObject.AddComponent<AudioSource>();
        wingSource2 = gameObject.AddComponent<AudioSource>();
        rainSource1 = gameObject.AddComponent<AudioSource>();
        rainSource2 = gameObject.AddComponent<AudioSource>();

        //attach audio clips to audio sources
        wingSource1.clip = WingFlap1;
        wingSource2.clip = WingFlap2;
        rainSource1.clip = LightRain;
        rainSource2.clip = RainDrops;
        rainSource1.volume = 0.1f;
        rainSource2.volume = 0.1f;

        StartCoroutine(PlayWingAudio());
    }
	
	// Update is called once per frame
	void Update () {
        if (playRain)
        {
            if (!rainSource1.isPlaying || rainSource1.clip.length - rainSource1.time < 2 )
            {
                rainSource1.Play();
            }
        }
    }

    IEnumerator PlayWingAudio()
    {
        //initialize audio sources
        float waitTime = 1f;
        while (true)
        {
            waitTime = Random.Range(waitTime - .4f, waitTime + .4f);
            if (waitTime < .5f)
            {
                waitTime = .5f;
            }
            else if (waitTime > 1.6f)
            {
                waitTime = 1.6f;
            }
            yield return new WaitForSeconds(waitTime);
            wingSource1.pitch = Random.Range(0.5f, 1.5f);
            wingSource1.volume = Random.Range(0.2f, 0.4f);
            wingSource1.panStereo = -1;
            wingSource2.pitch = Random.Range(0.5f, 1.5f);
            wingSource2.volume = Random.Range(0.2f, 0.4f);
            wingSource2.panStereo = 1;

            wingSource1.PlayDelayed(0.05f);
            wingSource2.PlayDelayed(Random.Range(0f, 0.1f));
        }
    }
}
