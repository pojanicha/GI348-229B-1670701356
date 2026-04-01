using UnityEngine;

public class Item : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision)
   {
       if (collision.CompareTag("Player"))
       {
           PlayerInventory playerInventory = collision.GetComponent<PlayerInventory>();
           if (playerInventory != null)
           {
               playerInventory.AddItem(); // เพิ่มไอเท็มให้กับผู้เล่น
           }

            Destroy(gameObject); // ทำลายไอเท็มหลังจากเก็บ

        }
    }
}