using System;
using UnityEngine;

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


    }
}