using Unity.VisualScripting;
using UnityEngine;

public class RespawnScript : MonoBehaviour
{
    public GameObject player;
    public GameObject respwanPoint
        ;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = respwanPoint.transform.position;
        }
    }




}
