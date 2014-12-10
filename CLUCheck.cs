using UnityEngine;
using System.Collections;

public class CLUCheck : MonoBehaviour 
{
	void Start () 
    {
        this.gameObject.AddComponent<GLUInteractiveTerminal>();
        new LoadingScreen().ShowModal(true);
	}
}
