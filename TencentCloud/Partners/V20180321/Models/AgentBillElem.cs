/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Partners.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentBillElem : AbstractModel
    {
        
        /// <summary>
        /// 代理商账号ID
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 订单号，仅对预付费账单有意义
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 代客账号ID
        /// </summary>
        [JsonProperty("ClientUin")]
        public string ClientUin{ get; set; }

        /// <summary>
        /// 代客备注名称
        /// </summary>
        [JsonProperty("ClientRemark")]
        public string ClientRemark{ get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [JsonProperty("PayTime")]
        public string PayTime{ get; set; }

        /// <summary>
        /// 云产品名称
        /// </summary>
        [JsonProperty("GoodsType")]
        public string GoodsType{ get; set; }

        /// <summary>
        /// 预付费/后付费
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 支付月份
        /// </summary>
        [JsonProperty("SettleMonth")]
        public string SettleMonth{ get; set; }

        /// <summary>
        /// 支付金额，单位分
        /// </summary>
        [JsonProperty("Amt")]
        public long? Amt{ get; set; }

        /// <summary>
        /// agentpay：代付；selfpay：自付
        /// </summary>
        [JsonProperty("PayerMode")]
        public string PayerMode{ get; set; }

        /// <summary>
        /// 客户类型：可以为new(新拓)/assign(指定)/old(存量)/空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientType")]
        public string ClientType{ get; set; }

        /// <summary>
        /// 项目类型：可以为self(自拓项目)/platform(合作项目)/repeat(复算项目  )/空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectType")]
        public string ProjectType{ get; set; }

        /// <summary>
        /// 活动ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActivityId")]
        public string ActivityId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "ClientUin", this.ClientUin);
            this.SetParamSimple(map, prefix + "ClientRemark", this.ClientRemark);
            this.SetParamSimple(map, prefix + "PayTime", this.PayTime);
            this.SetParamSimple(map, prefix + "GoodsType", this.GoodsType);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "SettleMonth", this.SettleMonth);
            this.SetParamSimple(map, prefix + "Amt", this.Amt);
            this.SetParamSimple(map, prefix + "PayerMode", this.PayerMode);
            this.SetParamSimple(map, prefix + "ClientType", this.ClientType);
            this.SetParamSimple(map, prefix + "ProjectType", this.ProjectType);
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
        }
    }
}

