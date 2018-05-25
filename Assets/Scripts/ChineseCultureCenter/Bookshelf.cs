using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Book
{
    public string name;
    public string label;

    public Book(string n, string l)
    {
        name = n;
        label = l;
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
