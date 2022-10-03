using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class FootstepsSoundController : MonoBehaviour
{
    [SerializeField] AudioClip footSteps;
    [SerializeField] AudioSource audioSource;
    CharacterController characterController;
    Vector2 lastCharacterPosition;
    Vector2 CurrentCharacterPosition => new Vector2(transform.position.x, transform.position.z);

    public CharacterController CharacterController { get { return characterController = CharacterController ?? GetComponent<CharacterController>(); } }

    void Start()
    {        
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = footSteps;
    }
    void Update()
    {
        float velocity = Vector3.Distance(CurrentCharacterPosition, lastCharacterPosition);
        if (velocity >= 0.01f)
        {
            if (!audioSource.isPlaying)
            {                          
                audioSource.Play();
            }            
        }
        else 
        {
            audioSource.Stop();
        }
        lastCharacterPosition = CurrentCharacterPosition;
    }    
}