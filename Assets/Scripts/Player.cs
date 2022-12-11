using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Playables;


public class Player : MonoBehaviour
{
    private SpriteRenderer _sr;
    public Sprite[] srs;
    private int _srIndex;
    private Vector3 _direction;
    public float gravity = -9.8f;
    public float strength = 5f;
    public AudioSource _as;

    private void Awake()
    {
        _sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);

    }
    
    private void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            _direction = Vector3.up * strength;
        }

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                _direction = Vector3.up * strength;
                
            }
        }

        _direction.y += gravity * Time.deltaTime;
        transform.position += _direction * Time.deltaTime;

    }

    private void AnimateSprite()
    {
        _srIndex++;

        if(_srIndex >= srs.Length)
        {
            _srIndex = 0;
        }

        _sr.sprite = srs[_srIndex];
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Wall")
        {
            SceneManager.LoadScene(2);
        }
        if(col.gameObject.tag == "Score")
        {
            FindObjectOfType<UI_Manager>().IncreaseScore();
            _as.Play();
        }
        
    }

    

}
