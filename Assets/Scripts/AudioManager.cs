using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("------ Audio Source ------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource backgroundSource;
    [SerializeField] AudioSource SFXSource;

    [Header("------ Audio Clip ------")]
    public AudioClip background;
    public AudioClip death;
    public AudioClip eagle;
    public AudioClip music;
    public AudioClip takeOnion;

    private void Start(){
        backgroundSource.clip = background;
        backgroundSource.Play();
        musicSource.clip = music;
        musicSource.Play();
    }

    public void PLaySFX(AudioClip clip){
        SFXSource.PlayOneShot(clip);
    }
}

