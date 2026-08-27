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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IpsRuleDetailNew : AbstractModel
    {
        
        /// <summary>
        /// <p>规则ID</p>
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }

        /// <summary>
        /// <p>规则名称</p>
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// <p>规则描述</p>
        /// </summary>
        [JsonProperty("EventNameDesc")]
        public string EventNameDesc{ get; set; }

        /// <summary>
        /// <p>规则类型</p>
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// <p>置信度</p>
        /// </summary>
        [JsonProperty("Confidence")]
        public string Confidence{ get; set; }

        /// <summary>
        /// <p>自增id</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>漏洞对象</p>
        /// </summary>
        [JsonProperty("VulTarget")]
        public string VulTarget{ get; set; }

        /// <summary>
        /// <p>漏洞编号</p>
        /// </summary>
        [JsonProperty("Cve")]
        public string Cve{ get; set; }

        /// <summary>
        /// <p>状态 0 关闭 1打开</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>0观察, 1阻断</p>
        /// </summary>
        [JsonProperty("Action")]
        public long? Action{ get; set; }

        /// <summary>
        /// <p>默认策略</p>
        /// </summary>
        [JsonProperty("DefaultAction")]
        public long? DefaultAction{ get; set; }

        /// <summary>
        /// <p>基础防御/虚拟补丁</p>
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }

        /// <summary>
        /// <p>危险等级</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>FwType字段 1 border 2 nat 4 vpc</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FwType")]
        public long? FwType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "EventNameDesc", this.EventNameDesc);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "VulTarget", this.VulTarget);
            this.SetParamSimple(map, prefix + "Cve", this.Cve);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "DefaultAction", this.DefaultAction);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "FwType", this.FwType);
        }
    }
}

