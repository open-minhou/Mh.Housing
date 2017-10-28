using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mh.Housing.Entity
{
    /// <summary>
    /// 楼盘实体
    /// </summary>
    public class Building
    {
        /// <summary>
        /// 自增主键
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// 楼盘名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 位置
        /// </summary>
        public string Location { get; set; }
        public string Tags { get; set; }
        public string Area { get; set; }
        public decimal BeginPrice { get; set; }
        public decimal AvgPrice { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime InTime { get; set; }
        public string Status { get; set; }
        public int BuildType { get; set; }
        public string HouseType { get; set; }
        public string Descrition { get; set; }
        public string Phone { get; set; }

        #region 物业信息
        public string Company { get; set; }
        public decimal ManagementFee { get; set; }
        public int PlanArea { get; set; }
        public int BuildArea { get; set; }
        #endregion

        #region 配套设施
        public string School { get; set; }
        public string Shopping { get; set; }
        public string Hospital { get; set; }
        public string Live { get; set; }
        public string Amusement { get; set; }
        public string Beverage { get; set; }
        public string Transportation { get; set; }
        #endregion
    }
}
