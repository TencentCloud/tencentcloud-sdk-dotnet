/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TransactionEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>交易唯一标识</p>
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }

        /// <summary>
        /// <p>您系统中的订单 ID，当一笔交易关联多个订单（合并支付）时请输入所有订单ID</p>
        /// </summary>
        [JsonProperty("OrderId")]
        public string[] OrderId{ get; set; }

        /// <summary>
        /// <p>交易金额</p>
        /// </summary>
        [JsonProperty("PaymentAmount")]
        public Amount PaymentAmount{ get; set; }

        /// <summary>
        /// <p>支付方式，支持多种支付方式</p>
        /// </summary>
        [JsonProperty("PaymentMethod")]
        public PaymentMethod PaymentMethod{ get; set; }

        /// <summary>
        /// <p>交易类型</p><p>枚举值：</p><ul><li>sale： 一次性完成授权与扣款（最常见）</li><li>authorize： 仅授权（冻结金额）</li><li>capture： 执行扣款（在授权后）</li><li>void： 取消待处理的授权或扣款</li><li>refund： 退款（部分或全部）</li><li>deposit： 向账户存款</li><li>withdrawal： 从账户提现</li><li>transfer： 账户间转账</li><li>buy： 购买资产（如加密货币）</li><li>sell： 出售资产</li><li>send： 发送资金/资产（如跨钱包转账）</li><li>receive： 接收资金/资产</li></ul><p>默认值：sale</p>
        /// </summary>
        [JsonProperty("TransactionType")]
        public string TransactionType{ get; set; }

        /// <summary>
        /// <p>账单信息</p>
        /// </summary>
        [JsonProperty("Billing")]
        public Billing Billing{ get; set; }

        /// <summary>
        /// <p>物流信息</p>
        /// </summary>
        [JsonProperty("Delivery")]
        public Delivery Delivery{ get; set; }

        /// <summary>
        /// <p>商家信息</p>
        /// </summary>
        [JsonProperty("Merchant")]
        public Merchant Merchant{ get; set; }

        /// <summary>
        /// <p>支付结果</p>
        /// </summary>
        [JsonProperty("PaymentResult")]
        public PaymentResult PaymentResult{ get; set; }

        /// <summary>
        /// <p>接收方的用户ID，适用于 transfer 交易类型</p>
        /// </summary>
        [JsonProperty("TransferRecipientUserId")]
        public string TransferRecipientUserId{ get; set; }

        /// <summary>
        /// <p>发送方的物理地址，适用于 transfer 交易类型</p>
        /// </summary>
        [JsonProperty("TransferSentAddress")]
        public Address TransferSentAddress{ get; set; }

        /// <summary>
        /// <p>接收方的物理地址，适用于 transfer 交易类型</p>
        /// </summary>
        [JsonProperty("TransferReceivedAddress")]
        public Address TransferReceivedAddress{ get; set; }

        /// <summary>
        /// <p>数字订单列表</p>
        /// </summary>
        [JsonProperty("DigitalOrders")]
        public DigitalOrder[] DigitalOrders{ get; set; }

        /// <summary>
        /// <p>接收加密货币的钱包</p>
        /// </summary>
        [JsonProperty("ReceiverWallet")]
        public Wallet ReceiverWallet{ get; set; }

        /// <summary>
        /// <p>与RCE约定的定制化信息，为K:V 格式的对象数组，示例：[{&quot;Key&quot;: &quot;ApproverName&quot;, &quot;Value&quot;: &quot;bob&quot;},{&quot;Key&quot;:&quot;ApproverPhone&quot;,&quot;Value&quot;: &quot;+86131****5678&quot;}]</p>
        /// </summary>
        [JsonProperty("Cust")]
        public Cust[] Cust{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TransactionId", this.TransactionId);
            this.SetParamArraySimple(map, prefix + "OrderId.", this.OrderId);
            this.SetParamObj(map, prefix + "PaymentAmount.", this.PaymentAmount);
            this.SetParamObj(map, prefix + "PaymentMethod.", this.PaymentMethod);
            this.SetParamSimple(map, prefix + "TransactionType", this.TransactionType);
            this.SetParamObj(map, prefix + "Billing.", this.Billing);
            this.SetParamObj(map, prefix + "Delivery.", this.Delivery);
            this.SetParamObj(map, prefix + "Merchant.", this.Merchant);
            this.SetParamObj(map, prefix + "PaymentResult.", this.PaymentResult);
            this.SetParamSimple(map, prefix + "TransferRecipientUserId", this.TransferRecipientUserId);
            this.SetParamObj(map, prefix + "TransferSentAddress.", this.TransferSentAddress);
            this.SetParamObj(map, prefix + "TransferReceivedAddress.", this.TransferReceivedAddress);
            this.SetParamArrayObj(map, prefix + "DigitalOrders.", this.DigitalOrders);
            this.SetParamObj(map, prefix + "ReceiverWallet.", this.ReceiverWallet);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

