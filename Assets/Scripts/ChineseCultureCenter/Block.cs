using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    public List<Book> books;
    public string index;

    // Use this for initialization
    void Start () {
        books = new List<Book>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Put(Book book)
    {
        books.Add(book);
    }

    public void Remove(Book book)
    {
        books.Remove(book);
    }

    public bool IsCorrect(Book book)
    {
        return book.label.Equals(index);
    }
}
