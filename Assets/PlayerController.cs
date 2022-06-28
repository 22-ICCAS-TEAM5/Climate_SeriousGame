using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float Health = 100f;

    public float playerSpeed = 0.25f;
    private float lastXPosition;
    public GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {
        lastXPosition = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {

        float changeInX = transform.position.x + (Input.GetAxis("Horizontal") * playerSpeed);
        float changeInY = transform.position.y + (Input.GetAxis("Vertical") * playerSpeed);

        transform.position = new Vector3(changeInX, changeInY);

        lastXPosition = transform.position.x;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Äç");
        Health-=5;

        if (other.gameObject.name == "flag")
        {
            SceneManager.LoadScene("ClearScene");
        }

    }

}