// using UnityEngine;
// using UnityEngine.InputSystem;

// public class MoveLeft : MonoBehaviour
// {
//     public float speed = 10f;

//     private float leftBound = -15;

//     private PlayerController playerController;

//     private InputAction shiftaction;

//     void Start()
//     {
//         playerController = GameObject.Find("Player").GetComponent<PlayerController>();
//         shiftaction = new InputAction("Shift", InputActionType.Button, "<Keyboard>/leftShift");
//         shiftaction.Enable();
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (!playerController.gameOver)
//         {
//             transform.Translate(Vector3.left * Time.deltaTime * speed);
//         }

//         if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
//         {
//             Destroy(gameObject);
//         }

//         if (shiftaction.IsPressed() && !playerController.gameOver)
//         {
//             speed = 30f;
//         }
//         else
//         {
//             speed = 10f;
//         }
//     }
// }
