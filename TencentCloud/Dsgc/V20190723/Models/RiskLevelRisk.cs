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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RiskLevelRisk : AbstractModel
    {
        
        /// <summary>
        /// 风险id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 风险等级列表
        /// </summary>
        [JsonProperty("RiskLevelName")]
        public string RiskLevelName{ get; set; }

        /// <summary>
        /// 风险级别描述
        /// </summary>
        [JsonProperty("RiskLevelDescription")]
        public string RiskLevelDescription{ get; set; }

        /// <summary>
        /// 引用的分类分级模板
        /// </summary>
        [JsonProperty("IdentifyComplianceName")]
        public string IdentifyComplianceName{ get; set; }

        /// <summary>
        /// 类型，区分自定义还是系统内置
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "RiskLevelName", this.RiskLevelName);
            this.SetParamSimple(map, prefix + "RiskLevelDescription", this.RiskLevelDescription);
            this.SetParamSimple(map, prefix + "IdentifyComplianceName", this.IdentifyComplianceName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

