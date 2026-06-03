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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TableColumn : AbstractModel
    {
        
        /// <summary>
        /// 列名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 列的别名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AliasName")]
        public string AliasName{ get; set; }

        /// <summary>
        /// 列的类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// 段类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FieldType")]
        public string FieldType{ get; set; }

        /// <summary>
        /// 备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Mark")]
        public string Mark{ get; set; }

        /// <summary>
        /// excel名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExcelName")]
        public string ExcelName{ get; set; }

        /// <summary>
        /// 关联的字典表Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DictId")]
        public long? DictId{ get; set; }

        /// <summary>
        /// 关联的字典表表名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DictName")]
        public string DictName{ get; set; }

        /// <summary>
        /// 多表关联新增字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableNodeId")]
        public string TableNodeId{ get; set; }

        /// <summary>
        /// 字段所属的表名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 用户设置的带格式的目标复杂格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FieldComplexType")]
        public string FieldComplexType{ get; set; }

        /// <summary>
        /// 格式规则
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FormatRule")]
        public string FormatRule{ get; set; }

        /// <summary>
        /// 数据字段是否过滤空值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsFilter")]
        public bool? IsFilter{ get; set; }

        /// <summary>
        /// 计算字段类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CalcType")]
        public string CalcType{ get; set; }

        /// <summary>
        /// 计算字段的公式内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CalcFormula")]
        public string CalcFormula{ get; set; }

        /// <summary>
        /// 计算字段的中文公式内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CalcDesc")]
        public string CalcDesc{ get; set; }

        /// <summary>
        /// Api数据源json路径名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JsonPathName")]
        public string JsonPathName{ get; set; }

        /// <summary>
        /// 地理类型标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Granularity")]
        public string Granularity{ get; set; }

        /// <summary>
        /// 自定义地图Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GeoJsonId")]
        public ulong? GeoJsonId{ get; set; }

        /// <summary>
        /// 空值展示样式配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EmptyValueConfig")]
        public EmptyValueConfig EmptyValueConfig{ get; set; }

        /// <summary>
        /// 原列名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbFieldName")]
        public string DbFieldName{ get; set; }

        /// <summary>
        /// 是否是复制字段操作
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsCopyOperation")]
        public bool? IsCopyOperation{ get; set; }

        /// <summary>
        /// 是否从普通字段复制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsCopyFromNormal")]
        public bool? IsCopyFromNormal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "AliasName", this.AliasName);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "FieldType", this.FieldType);
            this.SetParamSimple(map, prefix + "Mark", this.Mark);
            this.SetParamSimple(map, prefix + "ExcelName", this.ExcelName);
            this.SetParamSimple(map, prefix + "DictId", this.DictId);
            this.SetParamSimple(map, prefix + "DictName", this.DictName);
            this.SetParamSimple(map, prefix + "TableNodeId", this.TableNodeId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "FieldComplexType", this.FieldComplexType);
            this.SetParamSimple(map, prefix + "FormatRule", this.FormatRule);
            this.SetParamSimple(map, prefix + "IsFilter", this.IsFilter);
            this.SetParamSimple(map, prefix + "CalcType", this.CalcType);
            this.SetParamSimple(map, prefix + "CalcFormula", this.CalcFormula);
            this.SetParamSimple(map, prefix + "CalcDesc", this.CalcDesc);
            this.SetParamSimple(map, prefix + "JsonPathName", this.JsonPathName);
            this.SetParamSimple(map, prefix + "Granularity", this.Granularity);
            this.SetParamSimple(map, prefix + "GeoJsonId", this.GeoJsonId);
            this.SetParamObj(map, prefix + "EmptyValueConfig.", this.EmptyValueConfig);
            this.SetParamSimple(map, prefix + "DbFieldName", this.DbFieldName);
            this.SetParamSimple(map, prefix + "IsCopyOperation", this.IsCopyOperation);
            this.SetParamSimple(map, prefix + "IsCopyFromNormal", this.IsCopyFromNormal);
        }
    }
}

