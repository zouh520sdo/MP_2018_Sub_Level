using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public List<Book> booksToPut;
    public Book selected;

	// Use this for initialization
	void Start () {
        booksToPut = new List<Book>
        {
            new Book("到底", "一"),
            new Book("到底", "二"),
            new Book("到底", "三"),
            new Book("到底", "四"),
            new Book("到底", "五"),
            new Book("到底", "六"),
            new Book("到底", "七"),
            new Book("到底", "八"),
            new Book("到底", "九"),
            new Book("到底", "十")
        };
        selected = booksToPut[0];
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit;
            int layerMask = ~LayerMask.NameToLayer("Block");
            hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector3.forward, Mathf.Infinity, layerMask);
            if (hit.collider != null)
            {
                print(hit.collider.name);
                Block block = hit.collider.GetComponent<Block>();
                if (block.IsCorrect(selected))
                {
                    print("Put " + selected.name + " with label " + selected.label + " into block " + block.name);
                    block.Put(selected);
                    booksToPut.Remove(selected);
                    if (booksToPut.Count != 0)
                    {
                        selected = booksToPut[0];
                    }
                }
                else
                {
                    print("Can't put " + selected.name + " with label " + selected.label + " into block " + block.name + " with label " + block.index);
                }
            }
        }
    }
}
