using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SelfIdentifier : MonoBehaviour
{
    public bool continuousIdentify = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Identify();
    }

    private GameObject GetParent()
    {
        return gameObject.transform.parent.gameObject;
    }
    
    private void Identify()
    {
        Debug.Log($"The component '{this.name}' is attached to '{GetParent().name}.'", this);
    }

    // Update is called once per frame
    void Update()
    {
        if (continuousIdentify) Identify();
    }
}
