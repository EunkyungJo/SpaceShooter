using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
<<<<<<< HEAD
	public GameObject explosion;
	public GameObject playerExplosion;

=======
>>>>>>> a38e3b7ce805dd4232b99ac7c5c3455ce0118381
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			return;
		}
<<<<<<< HEAD
		Instantiate(explosion, transform.position, transform.rotation);
		if (other.tag == "Player")
		{
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			//gameController.GameOver ();
		}
=======

>>>>>>> a38e3b7ce805dd4232b99ac7c5c3455ce0118381
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}