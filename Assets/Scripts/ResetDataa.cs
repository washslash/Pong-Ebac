using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetDataa : MonoBehaviour
{
	public void ClearData()
	{
		SaveController.Instance.ClearSave();
	}
}
