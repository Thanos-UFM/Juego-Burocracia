using UnityEngine;
using System.Collections;


public class MoveObject : MonoBehaviour {

	[SerializeField]
	private float minXSpeed, maxXSpeed, minYSpeed, maxYSpeed;

	[SerializeField]
	private float destroyTime;

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 (Random.Range(minXSpeed, maxXSpeed), Random.Range(maxYSpeed, minYSpeed));
		Destroy (this.gameObject, this.destroyTime);
	}

    void Update()
    {       
        transform.Rotate(0, 0, Random.Range(-100,100) * Time.deltaTime);
    }



}
