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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnvBillingInfoItem : AbstractModel
    {
        
        /// <summary>
        /// 环境ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// tcb产品套餐ID，参考DescribePackages接口的返回值。
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// 自动续费标记
        /// </summary>
        [JsonProperty("IsAutoRenew")]
        public bool? IsAutoRenew{ get; set; }

        /// <summary>
        /// 状态。包含以下取值：
        /// <li> NORMAL：正常</li>
        /// <li> ISOLATE：隔离</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 支付方式。包含以下取值：
        /// <li> PREPAYMENT：预付费</li>
        /// <li> POSTPAID：后付费</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 隔离时间，最近一次隔离的时间
        /// </summary>
        [JsonProperty("IsolatedTime")]
        public string IsolatedTime{ get; set; }

        /// <summary>
        /// 过期时间，套餐即将到期的时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 创建时间，第一次接入计费方案的时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间，计费信息最近一次更新的时间。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// true表示从未升级过付费版。
        /// </summary>
        [JsonProperty("IsAlwaysFree")]
        public bool? IsAlwaysFree{ get; set; }

        /// <summary>
        /// 付费渠道。
        /// <li> miniapp：小程序</li>
        /// <li> qcloud：腾讯云</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PaymentChannel")]
        public string PaymentChannel{ get; set; }

        /// <summary>
        /// 最新的订单信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderInfo")]
        public OrderInfo OrderInfo{ get; set; }

        /// <summary>
        /// 免费配额信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FreeQuota")]
        public string FreeQuota{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "IsAutoRenew", this.IsAutoRenew);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "IsolatedTime", this.IsolatedTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "IsAlwaysFree", this.IsAlwaysFree);
            this.SetParamSimple(map, prefix + "PaymentChannel", this.PaymentChannel);
            this.SetParamObj(map, prefix + "OrderInfo.", this.OrderInfo);
            this.SetParamSimple(map, prefix + "FreeQuota", this.FreeQuota);
        }
    }
}

