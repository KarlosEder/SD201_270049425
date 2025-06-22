using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public SpawnMail mm;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("canPickUp"))
        {
            Destroy(collision.gameObject);

            mm.mailCount++;
        }
    }
}
