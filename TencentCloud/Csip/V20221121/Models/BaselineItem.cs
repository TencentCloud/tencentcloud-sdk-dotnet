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

    public class BaselineItem : AbstractModel
    {
        
        /// <summary>
        /// <p>基线检测项 ID。</p>
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>内置规则 ID。</p>
        /// </summary>
        [JsonProperty("RuleID")]
        public ulong? RuleID{ get; set; }

        /// <summary>
        /// <p>检测对象描述，例如配置文件路径、内核参数、Kubernetes 资源等。</p>
        /// </summary>
        [JsonProperty("CheckObject")]
        public string[] CheckObject{ get; set; }

        /// <summary>
        /// <p>风险等级。取值：</p><ul><li>LOW：低危</li><li>MEDIUM：中危</li><li>HIGH：高危</li><li>CRITICAL：严重</li></ul>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// <p>检测项名称（中文）。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>检测项描述（中文，说明检测背景与判定逻辑）。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>检测项修复建议（中文，含建议的配置参考值或加固命令）。</p>
        /// </summary>
        [JsonProperty("FixSuggestion")]
        public string FixSuggestion{ get; set; }

        /// <summary>
        /// <p>检测项的参考链接列表。</p>
        /// </summary>
        [JsonProperty("ReferenceLink")]
        public string ReferenceLink{ get; set; }

        /// <summary>
        /// <p>所属系统父分类信息。</p>
        /// </summary>
        [JsonProperty("SystemCategory")]
        public BaselineCategory SystemCategory{ get; set; }

        /// <summary>
        /// <p>所属子分类信息。</p>
        /// </summary>
        [JsonProperty("Category")]
        public BaselineCategory Category{ get; set; }

        /// <summary>
        /// <p>是否支持一键修复。true 支持，false 不支持。</p>
        /// </summary>
        [JsonProperty("SupportFix")]
        public bool? SupportFix{ get; set; }

        /// <summary>
        /// <p>是否支持用户自定义判定值。true 支持，false 不支持。</p>
        /// </summary>
        [JsonProperty("SupportCustomValue")]
        public bool? SupportCustomValue{ get; set; }

        /// <summary>
        /// <p>该检测项适用的操作系统/组件版本列表。</p>
        /// </summary>
        [JsonProperty("AffectedVersionList")]
        public string[] AffectedVersionList{ get; set; }

        /// <summary>
        /// <p>编辑自定义判定值时的参数定义（如取值范围、控件类型等）。</p>
        /// </summary>
        [JsonProperty("WebEditParam")]
        public string WebEditParam{ get; set; }

        /// <summary>
        /// <p>检测项默认判定值列表。</p>
        /// </summary>
        [JsonProperty("DefaultValueList")]
        public string[] DefaultValueList{ get; set; }

        /// <summary>
        /// <p>是否已被用户自定义。true 已自定义，false 仍使用默认值。</p>
        /// </summary>
        [JsonProperty("IsCustomConf")]
        public bool? IsCustomConf{ get; set; }

        /// <summary>
        /// <p>用户自定义配置记录 ID，未自定义时为 0。</p>
        /// </summary>
        [JsonProperty("CustomItemID")]
        public ulong? CustomItemID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamArraySimple(map, prefix + "CheckObject.", this.CheckObject);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "FixSuggestion", this.FixSuggestion);
            this.SetParamSimple(map, prefix + "ReferenceLink", this.ReferenceLink);
            this.SetParamObj(map, prefix + "SystemCategory.", this.SystemCategory);
            this.SetParamObj(map, prefix + "Category.", this.Category);
            this.SetParamSimple(map, prefix + "SupportFix", this.SupportFix);
            this.SetParamSimple(map, prefix + "SupportCustomValue", this.SupportCustomValue);
            this.SetParamArraySimple(map, prefix + "AffectedVersionList.", this.AffectedVersionList);
            this.SetParamSimple(map, prefix + "WebEditParam", this.WebEditParam);
            this.SetParamArraySimple(map, prefix + "DefaultValueList.", this.DefaultValueList);
            this.SetParamSimple(map, prefix + "IsCustomConf", this.IsCustomConf);
            this.SetParamSimple(map, prefix + "CustomItemID", this.CustomItemID);
        }
    }
}

