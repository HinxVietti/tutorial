using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class TutorialString : TutorialBase
{
    public Text txtComponent;
    
    public void SetString(string displaytxt, string btncancel = "", string btndone = "")
    {
        if (this.txtComponent)
            this.txtComponent.text = displaytxt;
        if (!string.IsNullOrEmpty(btncancel))
            SetButtonText(cancel, btncancel);
        if (!string.IsNullOrEmpty(btndone))
            SetButtonText(done, btndone);
    }

    private void SetButtonText(Button btton, string btnText)
    {
        var txtCom = btton.GetComponentInChildren<Text>(true);
        if (txtCom)
            txtCom.text = btnText;
    }
}
