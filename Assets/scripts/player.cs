using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {
    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;
	void Start()
	{	
        rb=GetComponent<Rigidbody>();
		count = 0;
        SetCountText ();
        winText.text = "";
	}

	void FixedUpdate() 
	{
		float horizontal=Input.GetAxis("Horizontal");
		float vertical=Input.GetAxis("Vertical");
		
		Vector3 movement= new Vector3(horizontal,0.0f,vertical);
		rb.AddForce(movement * speed);
	}

        void OnTriggerEnter(Collider other)
        {
        	if(other.gameObject.CompareTag("Pick up"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
            SetCountText ();
		}
	}	/*
	void FixedUpdate ()
	{
		float moveHorizontal = Input.acceleration.x;
		float moveVertical = Input.acceleration.y;
		transform.position += new Vector3 (moveHorizontal, 0.0f, moveVertical)* speed * Time.deltaTime;
	}
*/

        void SetCountText ()
        {
        countText.text = "Count: " + count.ToString ();
        if (count >= 24)
           {
            winText.text = "You Win!";
			Destroy (GameObject.FindGameObjectWithTag ("Enemy"));
           }

        }
}
