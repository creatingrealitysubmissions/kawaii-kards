using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    public AudioSource SoundSource;
    public AudioClip CatSound, DolphinSound, BearSound, PenguinSound, WhaleSound, SharkSound;
    public AudioClip FishSound;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Debug.Log("Touching");
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {

                Debug.Log(" you touched " + hit.collider.gameObject.name);
                if (hit.collider.gameObject.name == "Cat")
                {
                    SoundSource.clip = CatSound;
                    SoundSource.Play();
                }
                else if (hit.collider.gameObject.name == "Dolphin")
                {
                    SoundSource.clip = DolphinSound;
                    SoundSource.Play();
                }
                else if (hit.collider.gameObject.name == "Bear")
                {
                    SoundSource.clip = BearSound;
                    SoundSource.Play();
                }
                else if (hit.collider.gameObject.name == "Penguin")
                {
                    SoundSource.clip = PenguinSound;
                    SoundSource.Play();
                }
                else if (hit.collider.gameObject.name == "Whale")
                {
                    SoundSource.clip = WhaleSound;
                    SoundSource.Play();
                }
                else if (hit.collider.gameObject.name == "Shark")
                {
                    SoundSource.clip = SharkSound;
                    SoundSource.Play();
                }
                else if (hit.collider.gameObject.name == "Fish")
                {
                    SoundSource.clip = FishSound;
                    SoundSource.Play();
                }
            }

        }


    }
}
