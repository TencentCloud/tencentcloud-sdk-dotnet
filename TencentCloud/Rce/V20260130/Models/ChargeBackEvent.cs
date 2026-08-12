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

    public class ChargeBackEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>交易ID</p>
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId{ get; set; }

        /// <summary>
        /// <p>订单 ID，当一笔交易关联多个订单（合并支付）时请输入所有订单ID</p>
        /// </summary>
        [JsonProperty("OrderId")]
        public string[] OrderId{ get; set; }

        /// <summary>
        /// <p>拒付理由码，参考各卡组织定义的拒付码，例如：10.1、13.1、 4870、4871等</p>
        /// </summary>
        [JsonProperty("ChargeBackCode")]
        public string ChargeBackCode{ get; set; }

        /// <summary>
        /// <p>拒付原因，参考各卡组织定义的拒付原因，例如：未收到商品、欺诈等</p>
        /// </summary>
        [JsonProperty("ChargeBackReason")]
        public string ChargeBackReason{ get; set; }

        /// <summary>
        /// <p>拒付申诉阶段</p><p>枚举值：</p><ul><li>need_response： 需要商家回应</li><li>information_supplied： 商家已提供信息</li><li>chargeback_reversed： 拒付已撤销</li><li>chargeback_sustained： 拒付已成立</li></ul>
        /// </summary>
        [JsonProperty("ChargeBackProcess")]
        public string ChargeBackProcess{ get; set; }

        /// <summary>
        /// <p>拒付金额</p>
        /// </summary>
        [JsonProperty("ChargeBackAmount")]
        public Amount ChargeBackAmount{ get; set; }

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
            this.SetParamSimple(map, prefix + "ChargeBackCode", this.ChargeBackCode);
            this.SetParamSimple(map, prefix + "ChargeBackReason", this.ChargeBackReason);
            this.SetParamSimple(map, prefix + "ChargeBackProcess", this.ChargeBackProcess);
            this.SetParamObj(map, prefix + "ChargeBackAmount.", this.ChargeBackAmount);
            this.SetParamArrayObj(map, prefix + "Cust.", this.Cust);
        }
    }
}

