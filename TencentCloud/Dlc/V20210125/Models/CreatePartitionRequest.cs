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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePartitionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>交易类型：purchase-新购，renew-续费，modify-变配</p>
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// <p>付费模式：0-后付费，1-预付费</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// <p>资源配额列表（计费项+数量）</p>
        /// </summary>
        [JsonProperty("ResourceQuotaList")]
        public ResourceQuota[] ResourceQuotaList{ get; set; }

        /// <summary>
        /// <p>时间大小，预付费时为购买月数，后付费时为3600</p>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// <p>时间单位，预付费为m（月），后付费为s（秒）</p>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// <p>自动续费标志：0-默认，1-自动续费，2-不自动续费（仅预付费有效）</p>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>弹性资源池名称，用于订单页展示</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>队列描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamArrayObj(map, prefix + "ResourceQuotaList.", this.ResourceQuotaList);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

