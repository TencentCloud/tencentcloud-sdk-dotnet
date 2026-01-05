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

namespace TencentCloud.Svp.V20240125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SavingPlanUsageDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>节省计划资源id</p>
        /// </summary>
        [JsonProperty("SpId")]
        public string SpId{ get; set; }

        /// <summary>
        /// <p>节省计划类型</p>
        /// </summary>
        [JsonProperty("SpType")]
        public string SpType{ get; set; }

        /// <summary>
        /// <p>节省计划状态</p>枚举值：<ul><li> 1：  生效</li><li> 2： 失效 </li><li> 3： 作废</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>累计抵扣的金额（单位：元）</p>
        /// </summary>
        [JsonProperty("DeductAmount")]
        public string DeductAmount{ get; set; }

        /// <summary>
        /// <p>累计承诺消费金额（单位：元）</p>
        /// </summary>
        [JsonProperty("PromiseAmount")]
        public string PromiseAmount{ get; set; }

        /// <summary>
        /// <p>累计净节省金额（单位：元）</p>
        /// </summary>
        [JsonProperty("NetSavings")]
        public string NetSavings{ get; set; }

        /// <summary>
        /// <p>使用率</p>
        /// </summary>
        [JsonProperty("UtilizationRate")]
        public float? UtilizationRate{ get; set; }

        /// <summary>
        /// <p>累计流失金额（单位：元）</p>
        /// </summary>
        [JsonProperty("LossAmount")]
        public string LossAmount{ get; set; }

        /// <summary>
        /// <p>累计按量计费预期金额（单位：元）</p>
        /// </summary>
        [JsonProperty("DosageAmount")]
        public string DosageAmount{ get; set; }

        /// <summary>
        /// <p>累计成本金额（单位：元）</p>
        /// </summary>
        [JsonProperty("CostAmount")]
        public string CostAmount{ get; set; }

        /// <summary>
        /// <p>地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string[] Region{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpId", this.SpId);
            this.SetParamSimple(map, prefix + "SpType", this.SpType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DeductAmount", this.DeductAmount);
            this.SetParamSimple(map, prefix + "PromiseAmount", this.PromiseAmount);
            this.SetParamSimple(map, prefix + "NetSavings", this.NetSavings);
            this.SetParamSimple(map, prefix + "UtilizationRate", this.UtilizationRate);
            this.SetParamSimple(map, prefix + "LossAmount", this.LossAmount);
            this.SetParamSimple(map, prefix + "DosageAmount", this.DosageAmount);
            this.SetParamSimple(map, prefix + "CostAmount", this.CostAmount);
            this.SetParamArraySimple(map, prefix + "Region.", this.Region);
        }
    }
}

