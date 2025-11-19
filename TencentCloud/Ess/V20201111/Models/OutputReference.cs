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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutputReference : AbstractModel
    {
        
        /// <summary>
        /// 合同审查风险结果ID
        /// </summary>
        [JsonProperty("RiskId")]
        public string RiskId{ get; set; }

        /// <summary>
        /// 风险名称
        /// </summary>
        [JsonProperty("RiskName")]
        public string RiskName{ get; set; }

        /// <summary>
        /// 风险描述
        /// </summary>
        [JsonProperty("RiskDescription")]
        public string RiskDescription{ get; set; }

        /// <summary>
        /// 风险要点分类名称
        /// </summary>
        [JsonProperty("CategoryName")]
        public string CategoryName{ get; set; }

        /// <summary>
        /// 审查依据
        /// </summary>
        [JsonProperty("RiskBasis")]
        public string RiskBasis{ get; set; }

        /// <summary>
        /// 引文内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Excerpts")]
        public ReferenceExcerpt[] Excerpts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskId", this.RiskId);
            this.SetParamSimple(map, prefix + "RiskName", this.RiskName);
            this.SetParamSimple(map, prefix + "RiskDescription", this.RiskDescription);
            this.SetParamSimple(map, prefix + "CategoryName", this.CategoryName);
            this.SetParamSimple(map, prefix + "RiskBasis", this.RiskBasis);
            this.SetParamArrayObj(map, prefix + "Excerpts.", this.Excerpts);
        }
    }
}

