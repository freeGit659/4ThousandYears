using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectArea : MonoBehaviour
{
    [SerializeField] PlayerManager playerManager;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        playerManager.isSelect = !playerManager.isSelect;
    }
}
