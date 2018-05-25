using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Book
{
    public string name;
    public string label;
}

public class Block
{
    public List<Book> books;
    public string index;

    public void Put (Book book)
    {
        books.Add(book);
    }

    public void Remove (Book book)
    {
        books.Remove(book);
    }

    public bool isCorrect (Book book)
    {
        return book.label.Equals(index);
    }
}

public class Bookshelf : MonoBehaviour {

    public List<Block> blocks;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
