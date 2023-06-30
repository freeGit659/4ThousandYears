using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] protected GameObject selector;
    public bool isSelect;
    // Start is called before the first frame update
    void Start()
    {
        isSelect = false;
    }

    void Update()
    {
        SetActiveSelector();
    }
    private void OnMouseDown()
    {
        isSelect = !isSelect;
    }
    private void SetActiveSelector()
    {
        selector.SetActive(isSelect);
    }
}
