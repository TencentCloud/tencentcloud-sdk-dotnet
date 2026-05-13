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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SkillScanEngineResult : AbstractModel
    {
        
        /// <summary>
        /// 子引擎类型
        /// 枚举值：
        /// AI：AI 引擎
        /// STATIC：静态分析引擎
        /// </summary>
        [JsonProperty("ScanType")]
        public string ScanType{ get; set; }

        /// <summary>
        /// 该引擎命中的规则列表
        /// </summary>
        [JsonProperty("RuleList")]
        public SkillScanRuleHit[] RuleList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScanType", this.ScanType);
            this.SetParamArrayObj(map, prefix + "RuleList.", this.RuleList);
        }
    }
}

