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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SkillScanQueryData : AbstractModel
    {
        
        /// <summary>
        /// <p>检测状态：success（检测完成，有结果）、scanning（检测进行中）、not_found（无记录）、failed（检测失败）</p><p>枚举值：</p><ul><li>success： 检测完成，有结果</li><li>scanning： 检测进行中</li><li>not_found： 无记录</li><li>failed： 检测失败</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Skill 名称，用于页面展示、结果列表呈现和人工研判</p>
        /// </summary>
        [JsonProperty("SkillName")]
        public string SkillName{ get; set; }

        /// <summary>
        /// <p>Skill 描述，通常来自 Skill 元数据或说明信息，用于帮助调用方理解 Skill 的用途</p>
        /// </summary>
        [JsonProperty("SkillDescription")]
        public string SkillDescription{ get; set; }

        /// <summary>
        /// <p>ZIP 文件的 SHA256 哈希值，格式为 sha256:hex_digest</p>
        /// </summary>
        [JsonProperty("ContentHash")]
        public string ContentHash{ get; set; }

        /// <summary>
        /// <p>风险等级：malicious（恶意）、suspicious（可疑）、benign（可信）</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// <p>综合处置建议字段，位于 data 顶层，用于给出本次检测结果的总体修复、缓解或人工处置建议</p>
        /// </summary>
        [JsonProperty("Mitigation")]
        public string Mitigation{ get; set; }

        /// <summary>
        /// <p>安全评分（0-100，分数越高越安全）</p><p>取值范围：[0, 100]</p>
        /// </summary>
        [JsonProperty("SecurityScore")]
        public ulong? SecurityScore{ get; set; }

        /// <summary>
        /// <p>本次扫描使用的引擎版本号</p>
        /// </summary>
        [JsonProperty("EngineVersion")]
        public ulong? EngineVersion{ get; set; }

        /// <summary>
        /// <p>Skill 的能力标签列表，对外固定返回格式为 [{id,name}]。该字段用于描述 Skill 具备的能力特征或适用场景，便于调用方做检索、展示或分类；不等同于风险标签，也不表示风险高低或命中规则结果。当 lang=en 时，仅 name 会切换为英文，id 保持不变</p>
        /// </summary>
        [JsonProperty("CapabilityTags")]
        public SkillScanCapabilityTag[] CapabilityTags{ get; set; }

        /// <summary>
        /// <p>融合规则目录全集，key 为融合 rule_id（9xxxx），value 为风险类别名称；包含所有融合规则类别，调用方可据此展示分类标签，无需本地维护映射表。传 lang=en 时返回英文名称。该对象是名称映射表，不表达主标签优先级</p>
        /// </summary>
        [JsonProperty("RuleCatalog")]
        public SkillRuleCatalogItem[] RuleCatalog{ get; set; }

        /// <summary>
        /// <p>扫描结果详情，按子引擎分组，每个元素包含 scan_type（引擎类型）和 rule_list（命中的规则列表）；规则中的 rule_id 使用融合编码（9xxxx），可与 rule_catalog 交叉引用。传 lang=en 时，description 返回英文文本</p>
        /// </summary>
        [JsonProperty("ScanItems")]
        public SkillScanItem[] ScanItems{ get; set; }

        /// <summary>
        /// <p>综合安全审计报告地址。调用方可通过 report_url_expire_hours 指定有效期，不传时默认返回 1 年有效期地址</p>
        /// </summary>
        [JsonProperty("ReportUrl")]
        public string ReportUrl{ get; set; }

        /// <summary>
        /// <p>扫描完成时间</p>
        /// </summary>
        [JsonProperty("ScannedAt")]
        public string ScannedAt{ get; set; }

        /// <summary>
        /// <p>任务创建时间</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>失败时间</p>
        /// </summary>
        [JsonProperty("FailedAt")]
        public string FailedAt{ get; set; }

        /// <summary>
        /// <p>失败原因描述</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SkillName", this.SkillName);
            this.SetParamSimple(map, prefix + "SkillDescription", this.SkillDescription);
            this.SetParamSimple(map, prefix + "ContentHash", this.ContentHash);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "Mitigation", this.Mitigation);
            this.SetParamSimple(map, prefix + "SecurityScore", this.SecurityScore);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamArrayObj(map, prefix + "CapabilityTags.", this.CapabilityTags);
            this.SetParamArrayObj(map, prefix + "RuleCatalog.", this.RuleCatalog);
            this.SetParamArrayObj(map, prefix + "ScanItems.", this.ScanItems);
            this.SetParamSimple(map, prefix + "ReportUrl", this.ReportUrl);
            this.SetParamSimple(map, prefix + "ScannedAt", this.ScannedAt);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "FailedAt", this.FailedAt);
            this.SetParamSimple(map, prefix + "Message", this.Message);
        }
    }
}

