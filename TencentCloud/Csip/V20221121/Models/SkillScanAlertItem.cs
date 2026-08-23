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

    public class SkillScanAlertItem : AbstractModel
    {
        
        /// <summary>
        /// <p>告警记录 ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// <p>租户 AppID</p>
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// <p>主机 UUID</p>
        /// </summary>
        [JsonProperty("UUID")]
        public string UUID{ get; set; }

        /// <summary>
        /// <p>主机 IP 地址</p>
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// <p>实例 ID<br>参数格式：形如 ins-xxxxxxxx</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>归属资产类型<br>枚举值：<br>HOST：主机<br>CONTAINER：容器</p>
        /// </summary>
        [JsonProperty("BelongAssetType")]
        public string BelongAssetType{ get; set; }

        /// <summary>
        /// <p>Skill 名称</p>
        /// </summary>
        [JsonProperty("SkillName")]
        public string SkillName{ get; set; }

        /// <summary>
        /// <p>Skill 文件路径</p>
        /// </summary>
        [JsonProperty("SkillPath")]
        public string SkillPath{ get; set; }

        /// <summary>
        /// <p>Skill 作用域</p>
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// <p>Skill 版本号</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>文件内容 SHA256 哈希值<br>参数格式：sha256:&lt;64位hex&gt;</p>
        /// </summary>
        [JsonProperty("ContentHash")]
        public string ContentHash{ get; set; }

        /// <summary>
        /// <p>风险等级<br>枚举值：<br>malicious：恶意<br>suspicious：可疑</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// <p>安全评分<br>取值范围：[0, 100]</p>
        /// </summary>
        [JsonProperty("SecurityScore")]
        public long? SecurityScore{ get; set; }

        /// <summary>
        /// <p>主命中规则 ID</p>
        /// </summary>
        [JsonProperty("PrimaryRuleID")]
        public string PrimaryRuleID{ get; set; }

        /// <summary>
        /// <p>命中规则 ID 列表（9xxxx），按 RuleID 去重<br>展示名称通过响应外层 RuleCatalog 字典翻译<br>历史告警未持久化该字段时返回空数组</p>
        /// </summary>
        [JsonProperty("HitRules")]
        public string[] HitRules{ get; set; }

        /// <summary>
        /// <p>检测引擎版本号</p>
        /// </summary>
        [JsonProperty("EngineVersion")]
        public long? EngineVersion{ get; set; }

        /// <summary>
        /// <p>处理状态<br>枚举值：<br>0：未处理<br>1：已处理<br>2：已忽略<br>3：已信任<br>4：已删除（软删除）</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>告警级别<br>枚举值：<br>high：高危<br>medium：中危</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>首次检出时间<br>参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>最后更新时间<br>参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "UUID", this.UUID);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "BelongAssetType", this.BelongAssetType);
            this.SetParamSimple(map, prefix + "SkillName", this.SkillName);
            this.SetParamSimple(map, prefix + "SkillPath", this.SkillPath);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "ContentHash", this.ContentHash);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "SecurityScore", this.SecurityScore);
            this.SetParamSimple(map, prefix + "PrimaryRuleID", this.PrimaryRuleID);
            this.SetParamArraySimple(map, prefix + "HitRules.", this.HitRules);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

