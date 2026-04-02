using System.Collections;
using Unity.Hierarchy;
using UnityEngine;

public class Falling : MonoBehaviour
{
    private float fallDelay = 0.5f; // Delay before the platform starts falling
    private float destroyDelay = 2f; // Delay before the platform is destroyed after falling

    [SerializeField] private Rigidbody2D rb; // Reference to the Rigidbody2D component

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Check if the colliding object is the player
        {
            StartCoroutine(Fall()); // Start the falling process
        }
    }



    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay); // Wait for the specified delay
        rb.bodyType = RigidbodyType2D.Dynamic; // Change the body type to Dynamic to allow it to fall
        Destroy(gameObject, destroyDelay); // Destroy the platform after the specified delay
    }




}