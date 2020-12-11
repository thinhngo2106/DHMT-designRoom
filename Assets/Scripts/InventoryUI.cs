using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject inventoryUI;
    public Interactable focus;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (focus){
            inventoryUI.SetActive(!inventoryUI.activeSelf);
        }
    }
    void UpdateUI(){
        
    }
}
