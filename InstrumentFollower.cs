using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrumentFollower : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject selectedInstrument;   // 選択された工具オブジェクトを割り当て

    void Update()
    {
        if (selectedInstrument != null)
        {
            // マウスのスクリーン座標を取得
            Vector3 mousePosition = Input.mousePosition;
            // スクリーン座標をワールド座標に変換
            mousePosition.z = 5f;   // 工具がカメラに対して少し前に表示されるように
            Vector3 instrumentPosition = mainCamera.ScreenToWorldPoint(mousePosition);
            // 工具をマウスの位置に移動
            selectedInstrument.transform.position = instrumentPosition;
        }
    }

    public void SetSelectedInstrument(GameObject instrument)
    {
        selectedInstrument = instrument;
    }
}
