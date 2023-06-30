using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedCell : MonoBehaviour
{
    [SerializeField] bool isfull;
    [SerializeField] SpriteRenderer spriteRenderer;
    public GameManager gameManager;
    // Start is called before the first frame update
    public void Start()
    {
        isfull = false;
        gameManager = GameManager.instance;
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }

    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if(isfull == false && gameManager.isSelect)
        {
            gameManager.currentSelectedCell = this.gameObject;
            gameManager.MovePlayerToSelectedCell();
        }
    }
    private void OnMouseOver()
    {
        if (isfull == false && gameManager.isSelect) spriteRenderer.enabled = true;
    }
    private void OnMouseExit()
    {
        spriteRenderer.enabled = false;
    }
}
