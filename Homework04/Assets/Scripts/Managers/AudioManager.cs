using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{
    //[SerializeField] AudioClip shotSound;
    //[SerializeField] AudioClip bulletSound;
    //[SerializeField] AudioClip ballSound;
    //[SerializeField] AudioClip grenadeSound;

    [SerializeField] AudioSource shoot;
    [SerializeField] AudioSource grenade;
    [SerializeField] AudioSource ball;
    [SerializeField] AudioSource bullet;

    public void PlayAudioClip(AmmoType type) 
    {
        switch (type)
        {
            case AmmoType.bullet:                
                bullet.Play();
                break;
            case AmmoType.grenade:               
                grenade.Play();
                break;
            case AmmoType.ball:                
                ball.Play();
                break;
            default:
                break;
        }
    }
    public void PlayShotClip()
    {        
        shoot.Play();
    }
}

