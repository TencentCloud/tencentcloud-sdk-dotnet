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

    public class OutputRisk : AbstractModel
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
        /// 风险等级别名。
        /// 
        /// 等级描述如下：
        /// <ul>
        ///     <li>**HIGH** - 高风险</li> 
        ///     <li>**NORMAL** - 风险</li>   
        /// </ul>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// 风险建议
        /// </summary>
        [JsonProperty("RiskAdvice")]
        public string RiskAdvice{ get; set; }

        /// <summary>
        /// 风险评估
        /// </summary>
        [JsonProperty("RiskPresentation")]
        public string[] RiskPresentation{ get; set; }

        /// <summary>
        /// PDF风险原文内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 审查出的PDF段落位置信息
        /// </summary>
        [JsonProperty("Positions")]
        public PositionInfo[] Positions{ get; set; }

        /// <summary>
        /// 审查依据
        /// </summary>
        [JsonProperty("RiskBasis")]
        public string RiskBasis{ get; set; }

        /// <summary>
        /// 风险等级id。1 为最高风险等级，0 为最低风险等级，从[2,n]数字越大风险等级逐渐降低。
        /// </summary>
        [JsonProperty("RiskLevelId")]
        public long? RiskLevelId{ get; set; }

        /// <summary>
        /// 风险标签
        /// </summary>
        [JsonProperty("RiskLabels")]
        public string[] RiskLabels{ get; set; }

        /// <summary>
        /// 风险来源 0:模型标注的风险 1:人工标注的风险
        /// </summary>
        [JsonProperty("RiskOrigin")]
        public long? RiskOrigin{ get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        [JsonProperty("CreatorId")]
        public string CreatorId{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedOn")]
        public long? CreatedOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskId", this.RiskId);
            this.SetParamSimple(map, prefix + "RiskName", this.RiskName);
            this.SetParamSimple(map, prefix + "RiskDescription", this.RiskDescription);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "RiskAdvice", this.RiskAdvice);
            this.SetParamArraySimple(map, prefix + "RiskPresentation.", this.RiskPresentation);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamArrayObj(map, prefix + "Positions.", this.Positions);
            this.SetParamSimple(map, prefix + "RiskBasis", this.RiskBasis);
            this.SetParamSimple(map, prefix + "RiskLevelId", this.RiskLevelId);
            this.SetParamArraySimple(map, prefix + "RiskLabels.", this.RiskLabels);
            this.SetParamSimple(map, prefix + "RiskOrigin", this.RiskOrigin);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreatorId", this.CreatorId);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
        }
    }
}

