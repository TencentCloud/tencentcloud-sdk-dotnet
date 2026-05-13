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

    public class SkillScanItem : AbstractModel
    {
        
        /// <summary>
        /// Skill 名称
        /// </summary>
        [JsonProperty("SkillName")]
        public string SkillName{ get; set; }

        /// <summary>
        /// Skill 描述，帮助理解 Skill 的主要用途
        /// </summary>
        [JsonProperty("SkillDescription")]
        public string SkillDescription{ get; set; }

        /// <summary>
        /// ZIP 文件的 SHA256 Hash
        /// 参数格式：sha256:<64位hex>
        /// </summary>
        [JsonProperty("ContentHash")]
        public string ContentHash{ get; set; }

        /// <summary>
        /// 原始上传 ZIP 文件解压后的实际文件数，也是计费的范围，扫描成功后1个文件计为1次额度
        /// </summary>
        [JsonProperty("UploadFileCount")]
        public long? UploadFileCount{ get; set; }

        /// <summary>
        /// 综合风险等级
        /// 枚举值：
        /// malicious：恶意
        /// suspicious：可疑
        /// benign：可信
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// 风险主标签融合规则 ID（9xxxx），由服务端从命中的融合风险标签中生成；benign 且无规则命中时为空。展示名称可通过 RuleCatalog 获取
        /// </summary>
        [JsonProperty("PrimaryRuleID")]
        public string PrimaryRuleID{ get; set; }

        /// <summary>
        /// 综合处置建议，用于指导调用方优先执行下线、隔离、修复、复检等动作。历史结果中可能为空。传 Language=en-US 时返回英文文案
        /// </summary>
        [JsonProperty("Mitigation")]
        public string Mitigation{ get; set; }

        /// <summary>
        /// 风险综合描述，对本次检测发现的风险进行概括性说明。传 Language=en-US 时返回英文文案
        /// </summary>
        [JsonProperty("RiskDescription")]
        public string RiskDescription{ get; set; }

        /// <summary>
        /// 安全评分
        /// 取值范围：[0, 100]
        /// 补充说明：100 为最安全
        /// </summary>
        [JsonProperty("SecurityScore")]
        public long? SecurityScore{ get; set; }

        /// <summary>
        /// 本次扫描使用的引擎版本号
        /// </summary>
        [JsonProperty("EngineVersion")]
        public long? EngineVersion{ get; set; }

        /// <summary>
        /// Skill 能力标签列表，描述 Skill 具备的能力特征或适用场景。不等同于风险标签，也不参与风险等级判定。传 Language=en-US 时 Name 切换为英文，ID 保持不变
        /// </summary>
        [JsonProperty("CapabilityTags")]
        public SkillCapabilityTag[] CapabilityTags{ get; set; }

        /// <summary>
        /// 融合规则目录全集，包含所有融合规则类别（9xxxx），调用方可据此展示分类标签，无需本地维护映射表。传 Language=en-US 时返回英文名称
        /// </summary>
        [JsonProperty("RuleCatalog")]
        public SkillRuleCatalogItem[] RuleCatalog{ get; set; }

        /// <summary>
        /// 扫描结果详情，按子引擎分组。每个元素包含 ScanType（引擎类型）和 RuleList（命中规则列表）。规则中的 RuleID 使用融合编码（9xxxx），可与 RuleCatalog 交叉引用。传 Language=en-US 时 Description 返回英文文本
        /// </summary>
        [JsonProperty("ScanItems")]
        public SkillScanEngineResult[] ScanItems{ get; set; }

        /// <summary>
        /// 综合安全审计报告地址（签名 URL）。有效期由请求参数 ReportURLExpireHours 控制
        /// </summary>
        [JsonProperty("ReportURL")]
        public string ReportURL{ get; set; }

        /// <summary>
        /// 扫描完成时间。仅 Status=SUCCESS 时有值
        /// 参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）
        /// </summary>
        [JsonProperty("ScannedAt")]
        public string ScannedAt{ get; set; }

        /// <summary>
        /// 任务创建时间。仅 Status=SCANNING 时有值
        /// 参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 失败时间。仅 Status=FAILED 时有值
        /// 参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）
        /// </summary>
        [JsonProperty("FailedAt")]
        public string FailedAt{ get; set; }

        /// <summary>
        /// 失败原因描述。仅 Status=FAILED 时有值
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SkillName", this.SkillName);
            this.SetParamSimple(map, prefix + "SkillDescription", this.SkillDescription);
            this.SetParamSimple(map, prefix + "ContentHash", this.ContentHash);
            this.SetParamSimple(map, prefix + "UploadFileCount", this.UploadFileCount);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "PrimaryRuleID", this.PrimaryRuleID);
            this.SetParamSimple(map, prefix + "Mitigation", this.Mitigation);
            this.SetParamSimple(map, prefix + "RiskDescription", this.RiskDescription);
            this.SetParamSimple(map, prefix + "SecurityScore", this.SecurityScore);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamArrayObj(map, prefix + "CapabilityTags.", this.CapabilityTags);
            this.SetParamArrayObj(map, prefix + "RuleCatalog.", this.RuleCatalog);
            this.SetParamArrayObj(map, prefix + "ScanItems.", this.ScanItems);
            this.SetParamSimple(map, prefix + "ReportURL", this.ReportURL);
            this.SetParamSimple(map, prefix + "ScannedAt", this.ScannedAt);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "FailedAt", this.FailedAt);
            this.SetParamSimple(map, prefix + "Message", this.Message);
        }
    }
}

