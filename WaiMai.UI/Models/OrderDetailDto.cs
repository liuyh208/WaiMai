using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace WaiMai.UI.Models
{

    public class OrderDetail
    {
        /// <summary>
        /// 食物id
        /// </summary>
        public Guid FoodId { get; set; }
        /// <summary>
        /// 食物名称
        /// </summary>
        public string FoodName { get; set; }
        /// <summary>
        /// 食物单价
        /// </summary>
        public int UnitPrice { get; set; }
        /// <summary>
        /// 食物订购数量
        /// </summary>
        public int Total { get; set; }

    }

    public class OrderDetailDto
    {
        private List<OrderDetail> _OrderDetail = new List<OrderDetail>();

        public List<OrderDetail> OrderDetail
        {
            get { return _OrderDetail; }
            set { _OrderDetail = value; }
        }

    }

}
