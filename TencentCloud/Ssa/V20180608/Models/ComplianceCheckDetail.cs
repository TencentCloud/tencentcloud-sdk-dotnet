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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComplianceCheckDetail : AbstractModel
    {
        
        /// <summary>
        /// 检查项ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 检查项类别
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 检查项类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 不通过总数
        /// </summary>
        [JsonProperty("ErrorCount")]
        public long? ErrorCount{ get; set; }

        /// <summary>
        /// 检查项英文名
        /// </summary>
        [JsonProperty("NameEn")]
        public string NameEn{ get; set; }

        /// <summary>
        /// 检查项名称
        /// </summary>
        [JsonProperty("CheckName")]
        public string CheckName{ get; set; }

        /// <summary>
        /// 检查项处置方式
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 帮助文档
        /// </summary>
        [JsonProperty("Doc")]
        public string Doc{ get; set; }

        /// <summary>
        /// 通过总数
        /// </summary>
        [JsonProperty("SafeCount")]
        public long? SafeCount{ get; set; }

        /// <summary>
        /// 检查项检查内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 是否通过检测
        /// </summary>
        [JsonProperty("IsPass")]
        public long? IsPass{ get; set; }

        /// <summary>
        /// 忽略总数
        /// </summary>
        [JsonProperty("IgnoreCount")]
        public long? IgnoreCount{ get; set; }

        /// <summary>
        /// 风险总数
        /// </summary>
        [JsonProperty("RiskCount")]
        public long? RiskCount{ get; set; }

        /// <summary>
        /// 最近一次检测时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastCheckTime")]
        public string LastCheckTime{ get; set; }

        /// <summary>
        /// 资产组类型
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// res_count
        /// </summary>
        [JsonProperty("ResCount")]
        public long? ResCount{ get; set; }

        /// <summary>
        /// 检查项UUID
        /// </summary>
        [JsonProperty("UUID")]
        public string UUID{ get; set; }

        /// <summary>
        /// 标准项
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StandardItem")]
        public string StandardItem{ get; set; }

        /// <summary>
        /// 章节
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Chapter")]
        public string Chapter{ get; set; }

        /// <summary>
        /// 资产类型描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetTypeDesc")]
        public string AssetTypeDesc{ get; set; }

        /// <summary>
        /// 是否忽略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsIgnore")]
        public ulong? IsIgnore{ get; set; }

        /// <summary>
        /// 风险项
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskItem")]
        public string RiskItem{ get; set; }

        /// <summary>
        /// 合规检查项完整名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Title")]
        public string Title{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ErrorCount", this.ErrorCount);
            this.SetParamSimple(map, prefix + "NameEn", this.NameEn);
            this.SetParamSimple(map, prefix + "CheckName", this.CheckName);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "Doc", this.Doc);
            this.SetParamSimple(map, prefix + "SafeCount", this.SafeCount);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "IsPass", this.IsPass);
            this.SetParamSimple(map, prefix + "IgnoreCount", this.IgnoreCount);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamSimple(map, prefix + "LastCheckTime", this.LastCheckTime);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "ResCount", this.ResCount);
            this.SetParamSimple(map, prefix + "UUID", this.UUID);
            this.SetParamSimple(map, prefix + "StandardItem", this.StandardItem);
            this.SetParamSimple(map, prefix + "Chapter", this.Chapter);
            this.SetParamSimple(map, prefix + "AssetTypeDesc", this.AssetTypeDesc);
            this.SetParamSimple(map, prefix + "IsIgnore", this.IsIgnore);
            this.SetParamSimple(map, prefix + "RiskItem", this.RiskItem);
            this.SetParamSimple(map, prefix + "Title", this.Title);
        }
    }
}

