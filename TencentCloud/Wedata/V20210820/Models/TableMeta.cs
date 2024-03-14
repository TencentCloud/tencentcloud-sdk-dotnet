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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TableMeta : AbstractModel
    {
        
        /// <summary>
        /// 表的全局唯一ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// 表名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 责任人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableOwnerName")]
        public string TableOwnerName{ get; set; }

        /// <summary>
        /// 数据源全局唯一ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceId")]
        public long? DatasourceId{ get; set; }

        /// <summary>
        /// 所属集群名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 数据源名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceName")]
        public string DatasourceName{ get; set; }

        /// <summary>
        /// 数据库名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 表路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TablePath")]
        public string TablePath{ get; set; }

        /// <summary>
        /// 表中文名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableNameCn")]
        public string TableNameCn{ get; set; }

        /// <summary>
        /// 元数据租户ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetastoreId")]
        public long? MetastoreId{ get; set; }

        /// <summary>
        /// 技术类型，可用值:HIVE,MYSQL,KAFKA, HBASE
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetastoreType")]
        public string MetastoreType{ get; set; }

        /// <summary>
        /// 表描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 列分隔符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ColumnSeparator")]
        public string ColumnSeparator{ get; set; }

        /// <summary>
        /// 存储格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageFormat")]
        public string StorageFormat{ get; set; }

        /// <summary>
        /// 存储量，字节数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageSize")]
        public long? StorageSize{ get; set; }

        /// <summary>
        /// 表类型，如hive MANAGED_TABLE;EXTERNAL_TABLE
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableType")]
        public string TableType{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最近数据变更时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 最近DDL变更时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DdlModifyTime")]
        public string DdlModifyTime{ get; set; }

        /// <summary>
        /// 数据最后访问时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastAccessTime")]
        public string LastAccessTime{ get; set; }

        /// <summary>
        /// 所属项目英文名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 所属数据目录id（可能多个）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BizCatalogIds")]
        public string[] BizCatalogIds{ get; set; }

        /// <summary>
        /// 所属数据目录（可能多个）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BizCatalogNames")]
        public string[] BizCatalogNames{ get; set; }

        /// <summary>
        /// true已收藏/false表示未收藏状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasFavorite")]
        public bool? HasFavorite{ get; set; }

        /// <summary>
        /// 生命周期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LifeCycleTime")]
        public long? LifeCycleTime{ get; set; }

        /// <summary>
        /// 存储量，已转为适合的单位展示
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageSizeWithUnit")]
        public string StorageSizeWithUnit{ get; set; }

        /// <summary>
        /// 数据源引擎的实例ID：如EMR集群实例ID/数据源实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 数据来源技术类型：HIVE/MYSQL/HBASE/KAFKA等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TechnologyType")]
        public string TechnologyType{ get; set; }

        /// <summary>
        /// 表英文名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableNameEn")]
        public string TableNameEn{ get; set; }

        /// <summary>
        /// 项目Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Kafka Topic 分区数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Partitions")]
        public string Partitions{ get; set; }

        /// <summary>
        /// Kafka Topic 副本数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReplicationFactor")]
        public string ReplicationFactor{ get; set; }

        /// <summary>
        /// 所属项目英中文名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProjectDisplayName")]
        public string ProjectDisplayName{ get; set; }

        /// <summary>
        /// 数据最后修改时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataModifyTime")]
        public string DataModifyTime{ get; set; }

        /// <summary>
        /// 集群ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 当前用户是否有管理员权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasAdminAuthority")]
        public bool? HasAdminAuthority{ get; set; }

        /// <summary>
        /// 数据源展示名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceDisplayName")]
        public string DatasourceDisplayName{ get; set; }

        /// <summary>
        /// 数据库ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatabaseId")]
        public string DatabaseId{ get; set; }

        /// <summary>
        /// 租户下对表的收藏总次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FavoriteCount")]
        public long? FavoriteCount{ get; set; }

        /// <summary>
        /// 租户下对表的点赞总次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LikeCount")]
        public long? LikeCount{ get; set; }

        /// <summary>
        /// true已点赞/false表示未点赞状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasLike")]
        public bool? HasLike{ get; set; }

        /// <summary>
        /// 表的资产评分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TablePropertyScore")]
        public TablePropertyScore TablePropertyScore{ get; set; }

        /// <summary>
        /// 表的热度值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableHeat")]
        public TableHeat TableHeat{ get; set; }

        /// <summary>
        /// 数据源ownerProjectId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OwnerProjectId")]
        public string OwnerProjectId{ get; set; }

        /// <summary>
        /// 表负责人ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableOwnerId")]
        public string TableOwnerId{ get; set; }

        /// <summary>
        /// 系统源-CLUSTER, DB-自定义源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataSourceCategory")]
        public string DataSourceCategory{ get; set; }

        /// <summary>
        /// 表字段信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Columns")]
        public SearchColumnDocVO[] Columns{ get; set; }

        /// <summary>
        /// 表采集类型
        /// TABLE, VIEW, MANAGED_TABLE(Hive管理表), EXTERNAL_TABLE(Hive外部表), VIRTUAL_VIEW(虚拟视图), MATERIALIZED_VIEW(物化视图), LATERAL_VIEW, INDEX_TABLE(索引表), END_SELECT(查询结构), INSTANCE(中间临时表类型(数据血缘)), CDW(CDW表类型)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MetaCrawlType")]
        public string MetaCrawlType{ get; set; }

        /// <summary>
        /// 是否视图
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsView")]
        public bool? IsView{ get; set; }

        /// <summary>
        /// 存储位置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// 判断是否是分区表1 是 0否
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsPartitionTable")]
        public long? IsPartitionTable{ get; set; }

        /// <summary>
        /// 分区字段 key
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PartitionColumns")]
        public string[] PartitionColumns{ get; set; }

        /// <summary>
        /// 生命周期-分区保留天数【分区保留策略时有效】
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PartitionExpireDays")]
        public long? PartitionExpireDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TableOwnerName", this.TableOwnerName);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "DatasourceName", this.DatasourceName);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "TablePath", this.TablePath);
            this.SetParamSimple(map, prefix + "TableNameCn", this.TableNameCn);
            this.SetParamSimple(map, prefix + "MetastoreId", this.MetastoreId);
            this.SetParamSimple(map, prefix + "MetastoreType", this.MetastoreType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ColumnSeparator", this.ColumnSeparator);
            this.SetParamSimple(map, prefix + "StorageFormat", this.StorageFormat);
            this.SetParamSimple(map, prefix + "StorageSize", this.StorageSize);
            this.SetParamSimple(map, prefix + "TableType", this.TableType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "DdlModifyTime", this.DdlModifyTime);
            this.SetParamSimple(map, prefix + "LastAccessTime", this.LastAccessTime);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamArraySimple(map, prefix + "BizCatalogIds.", this.BizCatalogIds);
            this.SetParamArraySimple(map, prefix + "BizCatalogNames.", this.BizCatalogNames);
            this.SetParamSimple(map, prefix + "HasFavorite", this.HasFavorite);
            this.SetParamSimple(map, prefix + "LifeCycleTime", this.LifeCycleTime);
            this.SetParamSimple(map, prefix + "StorageSizeWithUnit", this.StorageSizeWithUnit);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "TechnologyType", this.TechnologyType);
            this.SetParamSimple(map, prefix + "TableNameEn", this.TableNameEn);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Partitions", this.Partitions);
            this.SetParamSimple(map, prefix + "ReplicationFactor", this.ReplicationFactor);
            this.SetParamSimple(map, prefix + "ProjectDisplayName", this.ProjectDisplayName);
            this.SetParamSimple(map, prefix + "DataModifyTime", this.DataModifyTime);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "HasAdminAuthority", this.HasAdminAuthority);
            this.SetParamSimple(map, prefix + "DatasourceDisplayName", this.DatasourceDisplayName);
            this.SetParamSimple(map, prefix + "DatabaseId", this.DatabaseId);
            this.SetParamSimple(map, prefix + "FavoriteCount", this.FavoriteCount);
            this.SetParamSimple(map, prefix + "LikeCount", this.LikeCount);
            this.SetParamSimple(map, prefix + "HasLike", this.HasLike);
            this.SetParamObj(map, prefix + "TablePropertyScore.", this.TablePropertyScore);
            this.SetParamObj(map, prefix + "TableHeat.", this.TableHeat);
            this.SetParamSimple(map, prefix + "OwnerProjectId", this.OwnerProjectId);
            this.SetParamSimple(map, prefix + "TableOwnerId", this.TableOwnerId);
            this.SetParamSimple(map, prefix + "DataSourceCategory", this.DataSourceCategory);
            this.SetParamArrayObj(map, prefix + "Columns.", this.Columns);
            this.SetParamSimple(map, prefix + "MetaCrawlType", this.MetaCrawlType);
            this.SetParamSimple(map, prefix + "IsView", this.IsView);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "IsPartitionTable", this.IsPartitionTable);
            this.SetParamArraySimple(map, prefix + "PartitionColumns.", this.PartitionColumns);
            this.SetParamSimple(map, prefix + "PartitionExpireDays", this.PartitionExpireDays);
        }
    }
}

