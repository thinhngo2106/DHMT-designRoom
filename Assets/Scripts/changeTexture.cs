using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeTexture : MonoBehaviour
{
    // Start is called before the first frame update
    
    MeshRenderer m_Renderer;
    public int i;

    void Start()
    {
        m_Renderer = GetComponent<MeshRenderer> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changedTexture(Texture texture){   
        
        if (texture != null) {
            Debug.Log(m_Renderer.materials[i]);
            m_Renderer.materials[i].SetTexture("_MainTex", texture);
        }
    }
}
