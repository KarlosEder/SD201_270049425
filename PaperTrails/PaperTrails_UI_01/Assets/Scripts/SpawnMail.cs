using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnMail : MonoBehaviour
{
    public GameObject[] mailPrefabs;
    public int mailCount;
    public TMP_Text mailText;
    public Transform _player;
    public LayerMask _layerMask;
    public GameObject Tutorial;
    private bool seenTutorial = false;

    void Update()
    { 
        if (Physics.Raycast(_player.position, _player.TransformDirection(Vector3.forward), 1.5f, _layerMask)) 
        { 
            if (!seenTutorial)
            {
                Tutorial.SetActive(true);
                seenTutorial = true;
            } 
            if (Input.GetKeyDown(KeyCode.F))
            {
               int mailIndex = Random.Range(0, mailPrefabs.Length); // Randomly select a mail prefab
               Instantiate(mailPrefabs[mailIndex], new Vector3(-4f,1.5f,7.5f), mailPrefabs[mailIndex].transform.rotation); 
            }
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (Tutorial.active)
            {
                Tutorial.SetActive(false);
            }
            else
            {
                Tutorial.SetActive(true);
            }
        }

            mailText.text = "   Mail Sorted: " + mailCount.ToString();
    }
}
