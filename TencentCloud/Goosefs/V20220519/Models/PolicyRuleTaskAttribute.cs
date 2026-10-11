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

namespace TencentCloud.Goosefs.V20220519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PolicyRuleTaskAttribute : AbstractModel
    {
        
        /// <summary>
        /// <p>规则id</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>规则名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>扫描目录</p>
        /// </summary>
        [JsonProperty("ScanDir")]
        public string ScanDir{ get; set; }

        /// <summary>
        /// <p>执行计划</p>
        /// </summary>
        [JsonProperty("Execution")]
        public ExecutionPlan Execution{ get; set; }

        /// <summary>
        /// <p>扫描规则</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PolicyRuleSet")]
        public PolicyRuleOperator[] PolicyRuleSet{ get; set; }

        /// <summary>
        /// <p>是否输出清单</p>
        /// </summary>
        [JsonProperty("EnableManifest")]
        public bool? EnableManifest{ get; set; }

        /// <summary>
        /// <p>输出清单配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Manifest")]
        public ManifestAttr Manifest{ get; set; }

        /// <summary>
        /// <p>任务状态</p><p>枚举值：</p><ul><li>0： 启用（enable）</li><li>1： 禁用（disable）</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>修改时间</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ScanDir", this.ScanDir);
            this.SetParamObj(map, prefix + "Execution.", this.Execution);
            this.SetParamArrayObj(map, prefix + "PolicyRuleSet.", this.PolicyRuleSet);
            this.SetParamSimple(map, prefix + "EnableManifest", this.EnableManifest);
            this.SetParamObj(map, prefix + "Manifest.", this.Manifest);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
        }
    }
}

