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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SkillAnalysisInfo : AbstractModel
    {
        
        /// <summary>
        /// 安全检测状态
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 待检测 |
        /// | 1 | 检测中 |
        /// | 2 | 可用 |
        /// | 3 | 不可用 |
        /// | 4 | 检测失败 |
        /// </summary>
        [JsonProperty("AnalysisStatus")]
        public long? AnalysisStatus{ get; set; }

        /// <summary>
        /// 风险描述
        /// </summary>
        [JsonProperty("RiskDescription")]
        public string RiskDescription{ get; set; }

        /// <summary>
        /// 风险等级
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 无风险 |
        /// | 1 | 低风险 |
        /// | 2 | 中风险 |
        /// | 3 | 高风险 |
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long? RiskLevel{ get; set; }

        /// <summary>
        /// 安全报告跳转url;
        /// </summary>
        [JsonProperty("SecurityReportUrl")]
        public string SecurityReportUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AnalysisStatus", this.AnalysisStatus);
            this.SetParamSimple(map, prefix + "RiskDescription", this.RiskDescription);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "SecurityReportUrl", this.SecurityReportUrl);
        }
    }
}

