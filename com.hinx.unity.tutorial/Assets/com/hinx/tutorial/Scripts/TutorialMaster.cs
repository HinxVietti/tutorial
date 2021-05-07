using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace HinxCor.tutorial
{

    public interface ITutorial
    {
        UnityEvent OnBeganTutorial { get; }
        UnityEvent OnStepNextTutorial { get; }
        UnityEvent OnFinishTutorial { get; }
        UnityEvent OnStopTutorial { get; }

        
    }


    public class TutorialMaster
    {


        public TutorialMaster()
        {

        }



    }
}