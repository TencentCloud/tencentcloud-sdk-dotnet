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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyQualityRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目Id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 规则类型 1.系统模版, 2.自定义模版, 3.自定义SQL
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 报警触发条件
        /// </summary>
        [JsonProperty("CompareRule")]
        public QualityCompareRule CompareRule{ get; set; }

        /// <summary>
        /// 报警触发级别 1.低, 2.中, 3.高
        /// </summary>
        [JsonProperty("AlarmLevel")]
        public ulong? AlarmLevel{ get; set; }

        /// <summary>
        /// 数据表ID
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// 规则模板ID，当Type≠3（自定义SQL）时必填
        /// </summary>
        [JsonProperty("RuleTemplateId")]
        public ulong? RuleTemplateId{ get; set; }

        /// <summary>
        /// 规则所属质量维度，Type=3（自定义SQL）时必填（1：准确性，2：唯一性，3：完整性，4：一致性，5：及时性，6：有效性）
        /// </summary>
        [JsonProperty("QualityDim")]
        public ulong? QualityDim{ get; set; }

        /// <summary>
        /// 规则组ID
        /// </summary>
        [JsonProperty("RuleGroupId")]
        public ulong? RuleGroupId{ get; set; }

        /// <summary>
        /// 源字段详细类型，int、string
        /// </summary>
        [JsonProperty("SourceObjectDataTypeName")]
        public string SourceObjectDataTypeName{ get; set; }

        /// <summary>
        /// 源字段名称
        /// </summary>
        [JsonProperty("SourceObjectValue")]
        public string SourceObjectValue{ get; set; }

        /// <summary>
        /// 检测范围，当Type=1(系统模板)时必填。 1.全表 2.条件扫描
        /// </summary>
        [JsonProperty("ConditionType")]
        public ulong? ConditionType{ get; set; }

        /// <summary>
        /// 条件扫描WHERE条件表达式，ConditionType=2(条件扫描)时必填
        /// </summary>
        [JsonProperty("ConditionExpression")]
        public string ConditionExpression{ get; set; }

        /// <summary>
        /// 自定义SQL，Type=3（自定义SQL）时必填
        /// </summary>
        [JsonProperty("CustomSql")]
        public string CustomSql{ get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 目标库Id
        /// </summary>
        [JsonProperty("TargetDatabaseId")]
        public string TargetDatabaseId{ get; set; }

        /// <summary>
        /// 目标表Id
        /// </summary>
        [JsonProperty("TargetTableId")]
        public string TargetTableId{ get; set; }

        /// <summary>
        /// 目标过滤条件表达式
        /// </summary>
        [JsonProperty("TargetConditionExpr")]
        public string TargetConditionExpr{ get; set; }

        /// <summary>
        /// 源字段与目标字段关联条件on表达式
        /// </summary>
        [JsonProperty("RelConditionExpr")]
        public string RelConditionExpr{ get; set; }

        /// <summary>
        /// 自定义模版sql表达式字段替换参数，Type=2时必填
        /// </summary>
        [JsonProperty("FieldConfig")]
        public QualityRuleFieldConfig FieldConfig{ get; set; }

        /// <summary>
        /// 目标字段名称  CITY
        /// </summary>
        [JsonProperty("TargetObjectValue")]
        public string TargetObjectValue{ get; set; }

        /// <summary>
        /// 该规则支持的执行引擎列表，Type=3（自定义SQL）时必填，可选值如下：1 - MYSQL2 - HIVE4 - SPARK8 - LIVY16 - DLC32 - GBASE64 - TCHouse-P128 - DORIS256 - TCHouse-D512 - EMR_STARROCKS1024 - TCHouse-X
        /// </summary>
        [JsonProperty("SourceEngineTypes")]
        public ulong?[] SourceEngineTypes{ get; set; }

        /// <summary>
        /// 目标库名
        /// </summary>
        [JsonProperty("TargetDatabaseName")]
        public string TargetDatabaseName{ get; set; }

        /// <summary>
        /// 目标模式名
        /// </summary>
        [JsonProperty("TargetSchemaName")]
        public string TargetSchemaName{ get; set; }

        /// <summary>
        /// 目标表名
        /// </summary>
        [JsonProperty("TargetTableName")]
        public string TargetTableName{ get; set; }

        /// <summary>
        /// 数据目录名称，主要用于dlc数据源
        /// </summary>
        [JsonProperty("CatalogName")]
        public string CatalogName{ get; set; }

        /// <summary>
        /// 目标数据目录名称，主要用于dlc数据源
        /// </summary>
        [JsonProperty("TargetCatalogName")]
        public string TargetCatalogName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "CompareRule.", this.CompareRule);
            this.SetParamSimple(map, prefix + "AlarmLevel", this.AlarmLevel);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "RuleTemplateId", this.RuleTemplateId);
            this.SetParamSimple(map, prefix + "QualityDim", this.QualityDim);
            this.SetParamSimple(map, prefix + "RuleGroupId", this.RuleGroupId);
            this.SetParamSimple(map, prefix + "SourceObjectDataTypeName", this.SourceObjectDataTypeName);
            this.SetParamSimple(map, prefix + "SourceObjectValue", this.SourceObjectValue);
            this.SetParamSimple(map, prefix + "ConditionType", this.ConditionType);
            this.SetParamSimple(map, prefix + "ConditionExpression", this.ConditionExpression);
            this.SetParamSimple(map, prefix + "CustomSql", this.CustomSql);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "TargetDatabaseId", this.TargetDatabaseId);
            this.SetParamSimple(map, prefix + "TargetTableId", this.TargetTableId);
            this.SetParamSimple(map, prefix + "TargetConditionExpr", this.TargetConditionExpr);
            this.SetParamSimple(map, prefix + "RelConditionExpr", this.RelConditionExpr);
            this.SetParamObj(map, prefix + "FieldConfig.", this.FieldConfig);
            this.SetParamSimple(map, prefix + "TargetObjectValue", this.TargetObjectValue);
            this.SetParamArraySimple(map, prefix + "SourceEngineTypes.", this.SourceEngineTypes);
            this.SetParamSimple(map, prefix + "TargetDatabaseName", this.TargetDatabaseName);
            this.SetParamSimple(map, prefix + "TargetSchemaName", this.TargetSchemaName);
            this.SetParamSimple(map, prefix + "TargetTableName", this.TargetTableName);
            this.SetParamSimple(map, prefix + "CatalogName", this.CatalogName);
            this.SetParamSimple(map, prefix + "TargetCatalogName", this.TargetCatalogName);
        }
    }
}

