using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public Text scoreText;
    public Text winText;

    private Rigidbody rb;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        score = 0;
        SetCountText();
        winText.text = "";

=======

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
>>>>>>> player
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");

        var movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);

            score = score + 1;//内部的にスコアを増やす

            SetCountText();//ついでに、UI更新委託
        }
    }
    void SetCountText()//UIの更新を委託
    {
        scoreText.text = "Count: " + score.ToString();

        if (score >= 2)
        {
            winText.text = "You Win!";
        }
=======
        
>>>>>>> player
    }
}
