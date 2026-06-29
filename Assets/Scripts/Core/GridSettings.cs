using UnityEngine;//導入Unity引擎標準資料庫前端

//避免衝突 要自己用一個核心命名空間(消除寶石)
namespace MatchGem.Core
{
    /// <summary>
    /// 棋盤格尺寸設定
    /// </summary>
    public class GridSettings : MonoBehaviour
    {
        #region 基本參數 
        [SerializeField] private int _cellSize = 64; //底線 私變數
        [SerializeField] private float _pixelPerUnit = 64f;
        private BoardModel _boardModel;
        #endregion 基本參數

        #region 公開屬性
        /// <summary>
        /// 單一格像素尺寸
        /// </summary>
        public int CellSize => _cellSize; //唯讀 讀的到改不到
        /// <summary>
        /// 一個Unit單位的對應像素值
        /// </summary>
        private float PixePerUnit => _pixelPerUnit;
        /// <summary>
        /// 單一格在世界座標的比例
        /// </summary>
        private float CellWorldSize => _cellSize / _pixelPerUnit;
        #endregion 公開屬性

        private void Start()
        {
            _boardModel = new BoardModel(8, 8);
            //CellCoord coord = new CellCoord(1,1);
            //for loop ()裡面要填的參數 1.起始值;2.終點條件;3.迭代值 {}裡面要填的是執行內容
            for (int x = 0;x < 8 ;x++ )
            {
                for(int y = 0; y < 8; y++)
                {
                    _boardModel.SetGem(x, y, (GemType)Random.Range(0,6));//可以在Random前面加上()進行想要的類別轉型
                    Debug.Log($"座標:{x},{y},顏色:{_boardModel.GetGem(x,y).Color}");
                    //Debug.Log($"{x}{y}{GemType.Pink}");
                }
            }
        }

    }
}