using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    Rigidbody RB;
    public CharacterController cc;
    Vector3 move;
	public float speed;
    public float gravity;
    public bool temCartao = false;
    private bool saida;
    [SerializeField] private GameObject Menu;
    
    // Start is called before the first frame update
    void Start()
    {
        //cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

		if (Input.GetKeyDown(KeyCode.Escape))
		{
            Menu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
		}
        if (Input.GetKeyDown(KeyCode.E)&&saida){
            SceneManager.LoadScene("Menu");
        }
    }

	private void MovePlayer()
	{
        if(cc.isGrounded)
        {
            move = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            move = transform.TransformDirection(move);
            move *= speed;

           
        }
        move.y -= gravity * Time.deltaTime;
        

        cc.Move(move * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Cartão")){
            //other.GetComponent<Cartões>().Pegar();
            temCartao = true;
        }

        else if (other.CompareTag("Fim")){
            
            if(temCartao || other.GetComponent<Cartões>().FoiPega()){
                //SceneManager.LoadScene("Menu");
                saida = true;
            }

            else{
                Debug.Log("Você não tem o Cartão");
            }
        }
    }
}
