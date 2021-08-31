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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BaselineRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// 检测项名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 检测项描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 修复建议
        /// </summary>
        [JsonProperty("FixMessage")]
        public string FixMessage{ get; set; }

        /// <summary>
        /// 危害等级
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 检测项id
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// 最后检测时间
        /// </summary>
        [JsonProperty("LastScanAt")]
        public string LastScanAt{ get; set; }

        /// <summary>
        /// 具体原因说明
        /// </summary>
        [JsonProperty("RuleRemark")]
        public string RuleRemark{ get; set; }

        /// <summary>
        /// 唯一Uuid
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 唯一事件ID
        /// </summary>
        [JsonProperty("EventId")]
        public ulong? EventId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "FixMessage", this.FixMessage);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "LastScanAt", this.LastScanAt);
            this.SetParamSimple(map, prefix + "RuleRemark", this.RuleRemark);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
        }
    }
}

