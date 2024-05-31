using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngineInternal;

public class NewBehaviourScript : MonoBehaviour
{
    MeshRenderer m_MeshRenderer;

    [SerializeField] private GameObject card;
    private void Awake()
    {
        
    }
    /* Start is called before the first frame update */
    void Start()
    {
        m_MeshRenderer = gameObject.GetComponent<MeshRenderer>();
        Instantiate(card);
    }

    /* Update is called once per frame */
    void Update()
    {
        
        m_MeshRenderer.enabled = true;
        
    }
}
