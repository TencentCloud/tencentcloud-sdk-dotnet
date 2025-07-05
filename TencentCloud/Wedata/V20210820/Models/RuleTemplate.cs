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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleTemplate : AbstractModel
    {
        
        /// <summary>
        /// 规则模版ID
        /// </summary>
        [JsonProperty("RuleTemplateId")]
        public ulong? RuleTemplateId{ get; set; }

        /// <summary>
        /// 规则模版名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 规则模版描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 模版类型（1：系统模版，2：自定义）
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 规则适用的源数据对象类型（1：常量，2：离线表级，3：离线字段级别）
        /// </summary>
        [JsonProperty("SourceObjectType")]
        public ulong? SourceObjectType{ get; set; }

        /// <summary>
        /// 规则适用的源数据对象类型（1：数值，2：字符串）
        /// </summary>
        [JsonProperty("SourceObjectDataType")]
        public ulong? SourceObjectDataType{ get; set; }

        /// <summary>
        /// 规则模版源侧内容，区分引擎，JSON 结构
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceContent")]
        public string SourceContent{ get; set; }

        /// <summary>
        /// 源数据适用类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceEngineTypes")]
        public ulong?[] SourceEngineTypes{ get; set; }

        /// <summary>
        /// 规则所属质量维度（1：准确性，2：唯一性，3：完整性，4：一致性，5：及时性，6：有效性）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QualityDim")]
        public ulong? QualityDim{ get; set; }

        /// <summary>
        /// 规则支持的比较方式类型（1：固定值比较，大于、小于，大于等于等 2：波动值比较，绝对值、上升、下降）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompareType")]
        public ulong? CompareType{ get; set; }

        /// <summary>
        /// 引用次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CitationCount")]
        public ulong? CitationCount{ get; set; }

        /// <summary>
        /// 创建人id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserId")]
        public ulong? UserId{ get; set; }

        /// <summary>
        /// 创建人昵称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 更新时间yyyy-MM-dd HH:mm:ss
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 是否添加where参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WhereFlag")]
        public bool? WhereFlag{ get; set; }

        /// <summary>
        /// 是否关联多个库表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MultiSourceFlag")]
        public bool? MultiSourceFlag{ get; set; }

        /// <summary>
        /// 自定义模板SQL表达式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlExpression")]
        public string SqlExpression{ get; set; }

        /// <summary>
        /// 模版子维度，0.父维度类型,1.一致性: 枚举范围一致性,2.一致性：数值范围一致性,3.一致性：字段数据相关性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubQualityDim")]
        public ulong? SubQualityDim{ get; set; }

        /// <summary>
        /// sql表达式解析对象
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResolvedSqlExpression")]
        public SqlExpression ResolvedSqlExpression{ get; set; }

        /// <summary>
        /// 支持的数据源类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceTypes")]
        public long?[] DatasourceTypes{ get; set; }

        /// <summary>
        /// 创建人IdStr
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserIdStr")]
        public string UserIdStr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleTemplateId", this.RuleTemplateId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SourceObjectType", this.SourceObjectType);
            this.SetParamSimple(map, prefix + "SourceObjectDataType", this.SourceObjectDataType);
            this.SetParamSimple(map, prefix + "SourceContent", this.SourceContent);
            this.SetParamArraySimple(map, prefix + "SourceEngineTypes.", this.SourceEngineTypes);
            this.SetParamSimple(map, prefix + "QualityDim", this.QualityDim);
            this.SetParamSimple(map, prefix + "CompareType", this.CompareType);
            this.SetParamSimple(map, prefix + "CitationCount", this.CitationCount);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "WhereFlag", this.WhereFlag);
            this.SetParamSimple(map, prefix + "MultiSourceFlag", this.MultiSourceFlag);
            this.SetParamSimple(map, prefix + "SqlExpression", this.SqlExpression);
            this.SetParamSimple(map, prefix + "SubQualityDim", this.SubQualityDim);
            this.SetParamObj(map, prefix + "ResolvedSqlExpression.", this.ResolvedSqlExpression);
            this.SetParamArraySimple(map, prefix + "DatasourceTypes.", this.DatasourceTypes);
            this.SetParamSimple(map, prefix + "UserIdStr", this.UserIdStr);
        }
    }
}

