using System.Collections.Generic;
using UnityEngine;

namespace MatchGem.Core
{
    /// <summary>
    /// 單次的配對結果
    /// </summary>
    public class MatchResult
    {
        #region 唯獨紀錄
        private readonly List<MatchLine> _lines = new List<MatchLine>();
        #endregion 唯獨紀錄

        #region 公開資訊
        public int LineCount => _lines.Count;
        /// <summary>
        /// 是否有產生任何配對
        /// </summary>
        public bool HasMatch => LineCount > 0;
        #endregion 公開資訊

        #region 公開方法
        public void AddLine(MatchLine line)
        {
            _lines.Add(line);
        }
        #endregion 公開方法
    }

}
