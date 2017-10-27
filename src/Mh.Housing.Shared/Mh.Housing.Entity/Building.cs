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
        /// 位置ID
        /// </summary>
        public int Location { get; set; }

    }
}
