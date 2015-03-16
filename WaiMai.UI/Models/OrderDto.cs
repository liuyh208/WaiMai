using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace WaiMai.UI.Models
{
    /// <summary>
    /// 订单传输类
    /// </summary>
    public class OrderDto
    {
        /// <summary>
        /// 订单id
        /// </summary>
        public Guid OrderId { get; set; }
        /// <summary>
        /// 送餐时间id
        /// </summary>
        public Guid DeliverId { get; set; }
        /// <summary>
        /// 微信id
        /// </summary>
        public Guid Unionid { get; set; }
        /// <summary>
        /// 地址id
        /// </summary>
        public Guid AddressId { get; set; }
        /// <summary>
        /// 饿单备注id(多个用逗号分隔)
        /// </summary>
        public string RemarkId { get; set; }
        /// <summary>
        /// 支付类型(0：未支付 1：已支付)
        /// </summary>
        public int PayType { get; set; }
        /// <summary>
        /// 是否使用折扣
        /// </summary>
        public bool IsDiscount { get; set; }

        private List<OrderDetailDto> _OrderDetailDto = new List<OrderDetailDto>();

        public List<OrderDetailDto> OrderDetailDto
        {
            get { return _OrderDetailDto; }
            set { _OrderDetailDto = value; }
        }
    }
}
