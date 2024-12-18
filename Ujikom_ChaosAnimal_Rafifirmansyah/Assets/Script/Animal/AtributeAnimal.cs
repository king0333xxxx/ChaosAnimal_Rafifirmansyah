using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtributeAnimal : MonoBehaviour
{
    //atribute
    [SerializeField] private string _nameAnimal;
    [SerializeField] private float _speedAnimal;
    [SerializeField] private int _scoreAnimal;

    private Rigidbody rb;
    private Vector3 _moveDirection;
    
    // Start is called before the first frame update
    void Start()
    {
        MoveAnimal();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += _moveDirection * _speedAnimal * Time.deltaTime;
    }

    private void MoveAnimal()
    {
        _moveDirection = transform.forward;

    }
}
