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

namespace TencentCloud.Aca.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RiskInfo : AbstractModel
    {
        
        /// <summary>
        /// 药品ID
        /// </summary>
        [JsonProperty("DrugId")]
        public string DrugId{ get; set; }

        /// <summary>
        /// 药品名称
        /// </summary>
        [JsonProperty("DrugName")]
        public string DrugName{ get; set; }

        /// <summary>
        /// 风险等级：低级风险、中级风险、高级风险
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// 风险提示
        /// </summary>
        [JsonProperty("RiskTips")]
        public string RiskTips{ get; set; }

        /// <summary>
        /// FDA分级
        /// </summary>
        [JsonProperty("FdaLevel")]
        public string FdaLevel{ get; set; }

        /// <summary>
        /// 关联药品名称
        /// </summary>
        [JsonProperty("RelatedDrugName")]
        public string RelatedDrugName{ get; set; }

        /// <summary>
        /// 关联处方ID
        /// </summary>
        [JsonProperty("RelatedPrescriptionId")]
        public string RelatedPrescriptionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DrugId", this.DrugId);
            this.SetParamSimple(map, prefix + "DrugName", this.DrugName);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "RiskTips", this.RiskTips);
            this.SetParamSimple(map, prefix + "FdaLevel", this.FdaLevel);
            this.SetParamSimple(map, prefix + "RelatedDrugName", this.RelatedDrugName);
            this.SetParamSimple(map, prefix + "RelatedPrescriptionId", this.RelatedPrescriptionId);
        }
    }
}

