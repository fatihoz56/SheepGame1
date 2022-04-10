using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioClip shootClip;
    public AudioClip SheepDroppedClip;
    public AudioClip Sheepdhit;
    private Vector3 cameraPosition;
    void Awake()
    {
        instance = this;
        cameraPosition = Camera.main.transform.position;
    }

   private void PlaySound(AudioClip clip)
    {
        AudioSource.PlayClipAtPoint(clip, cameraPosition);

    }
    public void PlayShootClip()
    {
        PlaySound(shootClip);
    }
    public void PlaySheepHit()
    {
        PlaySound(Sheepdhit);
    }
    public void PlaySheepDroped()
    {
        PlaySound(SheepDroppedClip);
    }
}
