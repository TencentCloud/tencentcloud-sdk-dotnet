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

    public class DatabaseMeta : AbstractModel
    {
        
        /// <summary>
        /// 项目Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 技术类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetastoreType")]
        public string MetastoreType{ get; set; }

        /// <summary>
        /// 数据源名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceName")]
        public string DatasourceName{ get; set; }

        /// <summary>
        /// 数据源Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceId")]
        public long? DatasourceId{ get; set; }

        /// <summary>
        /// 项目英文名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 数据源类别：绑定引擎、绑定数据库,可用值:DB,ENGINE
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Category")]
        public string Category{ get; set; }

        /// <summary>
        /// 数据源描述信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 数据源引擎的实例ID，如CDB实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Instance")]
        public string Instance{ get; set; }

        /// <summary>
        /// 数据源引擎所属区域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 数据源数据源的可见性，1为可见、0为不可见。默认为1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// db名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 项目中文名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectDisplayName")]
        public string ProjectDisplayName{ get; set; }

        /// <summary>
        /// 责任人名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerAccountName")]
        public string OwnerAccountName{ get; set; }

        /// <summary>
        /// 数据来源展示名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 数据库ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatabaseId")]
        public string DatabaseId{ get; set; }

        /// <summary>
        /// 数据来源类型：hive/mysql/hbase等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// 存储量大小,单位为 byte
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageSize")]
        public long? StorageSize{ get; set; }

        /// <summary>
        /// 格式化后的存储量大小，带单位，如 12B
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageSizeWithUnit")]
        public string StorageSizeWithUnit{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 总表数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableCount")]
        public long? TableCount{ get; set; }

        /// <summary>
        /// 数据源信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceList")]
        public GovDatasourceInfo[] DatasourceList{ get; set; }

        /// <summary>
        /// 采集任务id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CollectJobId")]
        public string CollectJobId{ get; set; }

        /// <summary>
        /// 采集任务名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CollectJobName")]
        public string CollectJobName{ get; set; }

        /// <summary>
        /// 引擎id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 引擎名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 库下表的最新更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifiedTimeByTables")]
        public ulong? ModifiedTimeByTables{ get; set; }

        /// <summary>
        /// 库下表的最新访问时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastAccessTimeByTables")]
        public ulong? LastAccessTimeByTables{ get; set; }

        /// <summary>
        /// 库guid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatabaseGuid")]
        public string DatabaseGuid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "MetastoreType", this.MetastoreType);
            this.SetParamSimple(map, prefix + "DatasourceName", this.DatasourceName);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "Category", this.Category);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Instance", this.Instance);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "ProjectDisplayName", this.ProjectDisplayName);
            this.SetParamSimple(map, prefix + "OwnerAccountName", this.OwnerAccountName);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "DatabaseId", this.DatabaseId);
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "StorageSize", this.StorageSize);
            this.SetParamSimple(map, prefix + "StorageSizeWithUnit", this.StorageSizeWithUnit);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "TableCount", this.TableCount);
            this.SetParamArrayObj(map, prefix + "DatasourceList.", this.DatasourceList);
            this.SetParamSimple(map, prefix + "CollectJobId", this.CollectJobId);
            this.SetParamSimple(map, prefix + "CollectJobName", this.CollectJobName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ModifiedTimeByTables", this.ModifiedTimeByTables);
            this.SetParamSimple(map, prefix + "LastAccessTimeByTables", this.LastAccessTimeByTables);
            this.SetParamSimple(map, prefix + "DatabaseGuid", this.DatabaseGuid);
        }
    }
}

