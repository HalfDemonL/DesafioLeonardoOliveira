using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Vida : MonoBehaviour
{
    public GameObject player;
    public float vida2;
    public Sprite vidaCheia;
    public Sprite vidaMetade;
    public Sprite vidaQuase;
    public Sprite vidaVazia;



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        vida2 = player.GetComponent<Player>().vida;
        
        if(vida2 == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = vidaCheia;
}
        else if (vida2 == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = vidaMetade;
        }
        else if (vida2 == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = vidaQuase;
        }
        else if (vida2 == 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = vidaVazia;
            StartCoroutine(changeScene());

        }

    }
    IEnumerator changeScene()
    {
        yield return new WaitForSeconds(1.5F);
        SceneManager.LoadScene("Over");
    }

}
