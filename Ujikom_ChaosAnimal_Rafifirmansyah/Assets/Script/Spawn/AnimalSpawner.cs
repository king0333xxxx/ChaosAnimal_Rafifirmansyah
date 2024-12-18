using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    [SerializeField] private SO_Animal _animalList;
    public Vector3 SpawnOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnRandomAnimal()
    {
        if(_animalList == null || _animalList.AnimalList.Count == 0) 
        {
            return;
        }

        //randomisasi animal dari list
        int randomIndex = Random.Range(0, _animalList.AnimalList.Count);
        GameObject selectedanimal = _animalList.AnimalList[randomIndex];

        //spawn selected animal
        Instantiate(selectedanimal, transform.position + SpawnOffset, Quaternion.identity, transform);
    }
}
