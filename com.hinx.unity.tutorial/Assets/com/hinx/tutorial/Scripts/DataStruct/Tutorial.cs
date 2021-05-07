using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine;

public class Tutorial : UIBehaviour, ITutorial
{
    public UnityEvent OnFinished { get; } = new UnityEvent();

    public UnityEvent OnCanceled { get; } = new UnityEvent();


    public virtual void Cancel()
    {
        gameObject.SetActive(false);
        OnCanceled?.Invoke();
    }

    public virtual void Done()
    {
        gameObject.SetActive(false);
        OnFinished?.Invoke();
    }

    public virtual void Show()
    {
        gameObject.SetActive(true);
    }

    public virtual void Skip()
    {
        Done();
    }
}



public class TutorialBase : Tutorial
{
    [SerializeField] protected Button cancel = null;
    [SerializeField] protected Button done = null;


    protected override void Start()
    {
        cancel?.onClick.AddListener(Cancel);
        done.onClick.AddListener(Done);
    }
}