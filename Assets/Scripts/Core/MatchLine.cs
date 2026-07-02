using System.Collections.Generic;
using UnityEngine;

namespace MatchGem.Core
{
    /// <summary>
    /// 消除的配對方向
    /// </summary>
    public enum MatchDirection
    {
        /// <summary>
        /// 橫向
        /// </summary>
        Horizontal,
        /// <summary>
        /// 直向
        /// </summary>
        Vertical
    }
    /// <summary>
    /// 連線的寶石配對
    /// </summary>
    public class MatchLine
    {
        #region 唯獨紀錄
        /// <summary>
        /// 連線的棋盤座標清單
        /// </summary>
        private List<CellCoord> _coords;
        #endregion 唯獨紀錄

        #region 公開資訊
        /// <summary>
        /// 連線方向
        /// </summary>
        public MatchDirection Direction { get; }
        /// <summary>
        /// 連線的顏色
        /// </summary>
        public GemType Color { get; }
        /// <summary>
        /// 連線長度(資料記錄數量)
        /// </summary>
        public int Length => _coord.Count;
        #endregion 公開資訊

        #region 建構式
        public MatchLine(GemType color, MatchDirection direction, List<CellCoord> coords)
        {
            Color = color;
            Direction = direction;
            _coords = coords;
        }
        #endregion 建構式
    }

}
