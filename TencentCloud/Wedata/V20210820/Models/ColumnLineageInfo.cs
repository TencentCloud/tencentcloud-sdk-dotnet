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

    public class ColumnLineageInfo : AbstractModel
    {
        
        /// <summary>
        /// 血缘id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 数据源ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceId")]
        public string DatasourceId{ get; set; }

        /// <summary>
        /// 字段名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColumnName")]
        public string ColumnName{ get; set; }

        /// <summary>
        /// 字段中文名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColumnNameCn")]
        public string ColumnNameCn{ get; set; }

        /// <summary>
        /// 字段类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColumnType")]
        public string ColumnType{ get; set; }

        /// <summary>
        /// 关系参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RelationParams")]
        public string RelationParams{ get; set; }

        /// <summary>
        /// 参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Params")]
        public string Params{ get; set; }

        /// <summary>
        /// 父id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentId")]
        public string ParentId{ get; set; }

        /// <summary>
        /// 元数据类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetastoreType")]
        public string MetastoreType{ get; set; }

        /// <summary>
        /// 元数据类型名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetastoreTypeName")]
        public string MetastoreTypeName{ get; set; }

        /// <summary>
        /// 表名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 字段全名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QualifiedName")]
        public string QualifiedName{ get; set; }

        /// <summary>
        /// 下游节点数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DownStreamCount")]
        public long? DownStreamCount{ get; set; }

        /// <summary>
        /// 上游节点数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpStreamCount")]
        public long? UpStreamCount{ get; set; }

        /// <summary>
        /// 描述信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 由中心节点出发的路径信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrefixPath")]
        public string PrefixPath{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 任务id列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tasks")]
        public string[] Tasks{ get; set; }

        /// <summary>
        /// 父节点列表字符串
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParentSet")]
        public string ParentSet{ get; set; }

        /// <summary>
        /// 子节点列表字符串
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChildSet")]
        public string ChildSet{ get; set; }

        /// <summary>
        /// 额外参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtParams")]
        public LineageParamRecord[] ExtParams{ get; set; }

        /// <summary>
        /// 表ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "ColumnName", this.ColumnName);
            this.SetParamSimple(map, prefix + "ColumnNameCn", this.ColumnNameCn);
            this.SetParamSimple(map, prefix + "ColumnType", this.ColumnType);
            this.SetParamSimple(map, prefix + "RelationParams", this.RelationParams);
            this.SetParamSimple(map, prefix + "Params", this.Params);
            this.SetParamSimple(map, prefix + "ParentId", this.ParentId);
            this.SetParamSimple(map, prefix + "MetastoreType", this.MetastoreType);
            this.SetParamSimple(map, prefix + "MetastoreTypeName", this.MetastoreTypeName);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "QualifiedName", this.QualifiedName);
            this.SetParamSimple(map, prefix + "DownStreamCount", this.DownStreamCount);
            this.SetParamSimple(map, prefix + "UpStreamCount", this.UpStreamCount);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "PrefixPath", this.PrefixPath);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamArraySimple(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "ParentSet", this.ParentSet);
            this.SetParamSimple(map, prefix + "ChildSet", this.ChildSet);
            this.SetParamArrayObj(map, prefix + "ExtParams.", this.ExtParams);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
        }
    }
}

