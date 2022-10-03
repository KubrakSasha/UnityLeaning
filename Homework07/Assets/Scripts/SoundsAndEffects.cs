using UnityEngine;

public class SoundsAndEffects : MonoBehaviour
{
    CharacterController controller;

    [SerializeField] AudioClip[] sounds;
    [SerializeField] AudioSource audioSource;

    [SerializeField] AudioClip[] backgroundSounds;    
    [SerializeField] AudioSource audioSourceBackground;

    [SerializeField] GameObject[] prefabs;
    public CharacterController Controller { get { return controller = controller ?? GetComponent<CharacterController>(); } }
       
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RandomSound(backgroundSounds, audioSourceBackground);
        }        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lights and Sounds"))
        {
            RandomSound(sounds, audioSource);
            RandomLightEffects();
        }       
    }
    public void RandomSound(AudioClip[] clips, AudioSource source) 
    {
        if (source.isPlaying)
        {
            source.Stop();
        }
        else
        {
            source.clip = clips[Random.Range(0, clips.Length)];
            source.Play();
        }
    }
    public void RandomLightEffects() 
    {
        Vector3 pos = Random.insideUnitSphere * 2;
        Instantiate(prefabs[Random.Range(0, prefabs.Length)], transform.position + pos, Quaternion.identity);
    }
}