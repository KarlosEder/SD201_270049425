using UnityEngine;

public class SoundEffectsPlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioSource AudioSource;
    public AudioClip pressedUI, highlightedUI, mailCollision;
    public AudioClip floor;

    RaycastHit hit;
    public Transform RayStart;
    public float range;
    public LayerMask layerMask;

    public void Footstep()
    {
        if (Physics.Raycast(RayStart.position, RayStart.transform.up * -1, out hit, range, layerMask))
        {
            if (hit.collider.CompareTag("Floor"))
            {
                PLayFootstepSoundL(floor);
            }
        }
    }

    private void Update()
    {
        Debug.DrawRay(RayStart.position, RayStart.transform.up * range * -1, Color.red);
    }

    void PLayFootstepSoundL(AudioClip audio)
    {
        AudioSource.pitch = Random.Range(0.8f, 1f);
        AudioSource.PlayOneShot(audio);
    }

    public void Button1()
    {
        src.clip = pressedUI;
        src.Play();
    }
    public void Button2()
    {
        src.clip = highlightedUI;
        src.Play();
    }
    public void Button3()
    {
        src.clip = mailCollision;
        src.Play();
    }
}
