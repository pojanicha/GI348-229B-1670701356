using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int currentItems; // จำนวนไอเท็มที่ผู้เล่นมีในปัจจุบัน

    public void AddItem()
    {
        currentItems++; // เพิ่มจำนวนไอเท็มเมื่อผู้เล่นเก็บไอเท็ม
        Debug.Log("Current Items: " + currentItems);
    }



}
