using System;
using System.Collections.Generic;
using UnityEngine.Events;

public interface ITutorial
{
    UnityEvent OnFinished { get; }
    UnityEvent OnCanceled { get; }

    void Show();
    void Skip();
    void Done();
    void Cancel();

}
