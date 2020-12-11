using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlot : MonoBehaviour
{
    // Start is called before the first frame update
    public Image Image; 
    public Texture texture;
    public changeTexture change;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onChange(){
        change.changedTexture(texture);
    }

}
