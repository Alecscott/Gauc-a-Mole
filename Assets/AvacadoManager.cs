using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvacadoManager : MonoBehaviour {
	// public accessors
	public void CreateAvacado()
	{
		Instance ().prvtCreateAvacado ();
	}
	public void RecycleAvacado() {
		Instance ().prvtRecycleAvacado ();
	}

	public void Terminate ()
	{
		avacadoStack.Clear ();
	}



	// Private
	// Singleton setup
	private static AvacadoManager instance = null;
	private static AvacadoManager Instance()
	{
		if (instance == null) {
			instance = new AvacadoManager ();
		}
		return instance;
	}

	// Stack
	Stack<Avacado> avacadoStack = new Stack<Avacado>();

	// Priv methods
	private void prvtCreateAvacado(){
		Debug.Log ("new avacado");
		avacadoStack.Push (new Avacado ());
	}
	private void prvtRecycleAvacado(){
		Debug.Log ("remove avacado");
		avacadoStack.Pop ();
	}

}