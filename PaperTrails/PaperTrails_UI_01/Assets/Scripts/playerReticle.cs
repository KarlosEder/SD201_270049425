using UnityEngine;

public class playerReticle : MonoBehaviour
{
    public GameObject reticle; // Reference to the reticle GameObject

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        reticle.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Toggle the visibility of the reticle when Escape is pressed
            gameObject.SetActive(!gameObject.activeSelf);
        }
    }
}
