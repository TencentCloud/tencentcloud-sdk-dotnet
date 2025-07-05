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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TransferInDomainBatchRequest : AbstractModel
    {
        
        /// <summary>
        /// 转入的域名名称数组。
        /// 一次提交不大于4000个
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// 域名转移码数组。
        /// </summary>
        [JsonProperty("PassWords")]
        public string[] PassWords{ get; set; }

        /// <summary>
        /// 模板ID。 
        /// 可通过[DescribeTemplateList](https://cloud.tencent.com/document/api/242/48940)接口获取
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 付费模式 0手动在线付费，1使用余额付费。
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 自动续费开关。有两个可选值：
        /// 0 表示关闭，不自动续费（默认值）
        /// 1 表示开启，将自动续费
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// true： 开启60天内禁止转移注册商锁定
        /// false：关闭60天内禁止转移注册商锁定
        /// 默认 true
        /// </summary>
        [JsonProperty("LockTransfer")]
        public bool? LockTransfer{ get; set; }

        /// <summary>
        /// 是否开启更新锁：0=默认不开启，1=开启
        /// </summary>
        [JsonProperty("UpdateProhibition")]
        public long? UpdateProhibition{ get; set; }

        /// <summary>
        /// 是否开启转移锁：0=默认不开启，1=开启
        /// </summary>
        [JsonProperty("TransferProhibition")]
        public long? TransferProhibition{ get; set; }

        /// <summary>
        /// 渠道来源，pc/miniprogram/h5等
        /// </summary>
        [JsonProperty("ChannelFrom")]
        public string ChannelFrom{ get; set; }

        /// <summary>
        /// 订单来源，common正常/dianshi_active点石活动等
        /// </summary>
        [JsonProperty("OrderFrom")]
        public string OrderFrom{ get; set; }

        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("ActivityId")]
        public string ActivityId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamArraySimple(map, prefix + "PassWords.", this.PassWords);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "LockTransfer", this.LockTransfer);
            this.SetParamSimple(map, prefix + "UpdateProhibition", this.UpdateProhibition);
            this.SetParamSimple(map, prefix + "TransferProhibition", this.TransferProhibition);
            this.SetParamSimple(map, prefix + "ChannelFrom", this.ChannelFrom);
            this.SetParamSimple(map, prefix + "OrderFrom", this.OrderFrom);
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
        }
    }
}

