using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    MeshRenderer m_MeshRenderer;
    private void Awake()
    {
        
    }
    /* Start is called before the first frame update */
    void Start()
    {
        m_MeshRenderer = gameObject.GetComponent<MeshRenderer>();

    }

    /* Update is called once per frame */
    void Update()
    {
        
        m_MeshRenderer.enabled = false;
    }
}
