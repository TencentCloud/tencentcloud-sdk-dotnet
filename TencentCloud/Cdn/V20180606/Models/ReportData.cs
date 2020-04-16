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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReportData : AbstractModel
    {
        
        /// <summary>
        /// 项目ID/域名ID。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 项目名称/域名。
        /// </summary>
        [JsonProperty("Resource")]
        public string Resource{ get; set; }

        /// <summary>
        /// 流量总和/带宽最大值，单位分别为bytes，bps。
        /// </summary>
        [JsonProperty("Value")]
        public long? Value{ get; set; }

        /// <summary>
        /// 单个资源占总体百分比。
        /// </summary>
        [JsonProperty("Percentage")]
        public float? Percentage{ get; set; }

        /// <summary>
        /// 计费流量总和/计费带宽最大值，单位分别为bytes，bps。
        /// </summary>
        [JsonProperty("BillingValue")]
        public long? BillingValue{ get; set; }

        /// <summary>
        /// 计费数值占总体百分比。
        /// </summary>
        [JsonProperty("BillingPercentage")]
        public float? BillingPercentage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "Resource", this.Resource);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Percentage", this.Percentage);
            this.SetParamSimple(map, prefix + "BillingValue", this.BillingValue);
            this.SetParamSimple(map, prefix + "BillingPercentage", this.BillingPercentage);
        }
    }
}

