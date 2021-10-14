using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObstacleMover : MonoBehaviour
{
    [SerializeField] private Transform _endPosition;
    

    private void Start()
    {        
        transform.DOMove(_endPosition.position, 2f).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }

    
}
