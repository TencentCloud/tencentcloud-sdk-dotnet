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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TableInfo : AbstractModel
    {
        
        /// <summary>
        /// 表名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 字段信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Columns")]
        public ColumnInfo[] Columns{ get; set; }

        /// <summary>
        /// 属性值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Properties")]
        public KVPair[] Properties{ get; set; }

        /// <summary>
        /// 分区
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Partitioning")]
        public Partitioning[] Partitioning{ get; set; }

        /// <summary>
        /// 索引
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Indexes")]
        public Index[] Indexes{ get; set; }

        /// <summary>
        /// 编辑者
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Audit")]
        public Audit Audit{ get; set; }

        /// <summary>
        /// 表版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableFormat")]
        public string TableFormat{ get; set; }

        /// <summary>
        /// owner信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetaOwner")]
        public MetaOwner MetaOwner{ get; set; }

        /// <summary>
        /// 资产全局唯一ID
        /// </summary>
        [JsonProperty("AssetGuid")]
        public string AssetGuid{ get; set; }

        /// <summary>
        /// 总文件数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilesCount")]
        public string FilesCount{ get; set; }

        /// <summary>
        /// 总数据量大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilesSize")]
        public string FilesSize{ get; set; }

        /// <summary>
        /// 表类型
        /// 
        /// - Managed 内部
        /// - External 外部
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableType")]
        public string TableType{ get; set; }

        /// <summary>
        /// 特征表类型：Online-在线表 Offline-离线表 空字符串-非特征表
        /// </summary>
        [JsonProperty("FeatureTableType")]
        public string FeatureTableType{ get; set; }

        /// <summary>
        /// 特征表详细信息，仅当FeatureTableType不为空时有值
        /// </summary>
        [JsonProperty("FeatureTableDetail")]
        public FeatureTableDetail FeatureTableDetail{ get; set; }

        /// <summary>
        /// 当前用户对该实体的权限信息
        /// </summary>
        [JsonProperty("PermissionDetail")]
        public PermissionDetail PermissionDetail{ get; set; }

        /// <summary>
        /// 表级标签列表，仅当请求中FetchOption.FetchTags=true时返回，默认不返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public CommonTagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
            this.SetParamArrayObj(map, prefix + "Properties.", this.Properties);
            this.SetParamArrayObj(map, prefix + "Partitioning.", this.Partitioning);
            this.SetParamArrayObj(map, prefix + "Indexes.", this.Indexes);
            this.SetParamObj(map, prefix + "Audit.", this.Audit);
            this.SetParamSimple(map, prefix + "TableFormat", this.TableFormat);
            this.SetParamObj(map, prefix + "MetaOwner.", this.MetaOwner);
            this.SetParamSimple(map, prefix + "AssetGuid", this.AssetGuid);
            this.SetParamSimple(map, prefix + "FilesCount", this.FilesCount);
            this.SetParamSimple(map, prefix + "FilesSize", this.FilesSize);
            this.SetParamSimple(map, prefix + "TableType", this.TableType);
            this.SetParamSimple(map, prefix + "FeatureTableType", this.FeatureTableType);
            this.SetParamObj(map, prefix + "FeatureTableDetail.", this.FeatureTableDetail);
            this.SetParamObj(map, prefix + "PermissionDetail.", this.PermissionDetail);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

