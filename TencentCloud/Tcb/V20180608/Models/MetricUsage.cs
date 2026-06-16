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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MetricUsage : AbstractModel
    {
        
        /// <summary>
        /// <p>指标名称</p>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// <p>资源类型</p>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// <p>原始资源用量</p>
        /// </summary>
        [JsonProperty("Value")]
        public long? Value{ get; set; }

        /// <summary>
        /// <p>资源点用量</p>
        /// </summary>
        [JsonProperty("CreditsValue")]
        public float? CreditsValue{ get; set; }

        /// <summary>
        /// <p>计费周期类型，取值为hourly/daily</p>
        /// </summary>
        [JsonProperty("BillingCycleType")]
        public string BillingCycleType{ get; set; }

        /// <summary>
        /// <p>原始资源用量单位</p>
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// <p>原始资源用量明细</p>
        /// </summary>
        [JsonProperty("ValueDetailList")]
        public ValueDetail[] ValueDetailList{ get; set; }

        /// <summary>
        /// <p>资源点套餐内用量</p>
        /// </summary>
        [JsonProperty("DeductValue")]
        public float? DeductValue{ get; set; }

        /// <summary>
        /// <p>资源点资源包用量</p>
        /// </summary>
        [JsonProperty("PackageDeductValue")]
        public float? PackageDeductValue{ get; set; }

        /// <summary>
        /// <p>资源点按量用量</p>
        /// </summary>
        [JsonProperty("ReportValue")]
        public float? ReportValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "CreditsValue", this.CreditsValue);
            this.SetParamSimple(map, prefix + "BillingCycleType", this.BillingCycleType);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamArrayObj(map, prefix + "ValueDetailList.", this.ValueDetailList);
            this.SetParamSimple(map, prefix + "DeductValue", this.DeductValue);
            this.SetParamSimple(map, prefix + "PackageDeductValue", this.PackageDeductValue);
            this.SetParamSimple(map, prefix + "ReportValue", this.ReportValue);
        }
    }
}

