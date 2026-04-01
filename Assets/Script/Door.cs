using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator _animator;

    [SerializeField] private int requiredItemCount; // จำนวนไอเท็มที่ต้องการเพื่อเปิดประตู

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // ตรวจสอบว่าผู้เล่นมีไอเท็มครบตามที่ต้องการหรือไม่
            PlayerInventory playerInventory = collision.GetComponent<PlayerInventory>();
            if (playerInventory != null && playerInventory.currentItems >= requiredItemCount)
            {
                Open(); // เปิดประตู
            }
        }


        else
        { 
            Debug.Log("Player does not have enough items to open the door.");


        }

    }





    [ContextMenu("Open")]
    public void Open()
    { 
    
        _animator.SetTrigger("Open");

    }








}
