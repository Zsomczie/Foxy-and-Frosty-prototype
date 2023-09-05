using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlap : MonoBehaviour
{
    Vector3 direction;
    [SerializeField] float gravity = -9.8f;
    [SerializeField] float strength = 5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0))
        {
            direction = Vector3.up * strength;
        }
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength;
            }
        }
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pipe")
        {
            FindObjectOfType<ScoreCounter>().GameOver();
        }
        else if (collision.gameObject.tag == "Scoring")
        {
            FindObjectOfType<ScoreCounter>().IncreaseScore();
        }
    }
}
