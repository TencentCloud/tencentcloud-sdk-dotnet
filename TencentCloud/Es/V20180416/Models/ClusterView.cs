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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterView : AbstractModel
    {
        
        /// <summary>
        /// 集群健康状态
        /// </summary>
        [JsonProperty("Health")]
        public float? Health{ get; set; }

        /// <summary>
        /// 集群是否可见
        /// </summary>
        [JsonProperty("Visible")]
        public float? Visible{ get; set; }

        /// <summary>
        /// 集群是否熔断
        /// </summary>
        [JsonProperty("Break")]
        public float? Break{ get; set; }

        /// <summary>
        /// 平均磁盘使用率
        /// </summary>
        [JsonProperty("AvgDiskUsage")]
        public float? AvgDiskUsage{ get; set; }

        /// <summary>
        /// 平均内存使用率
        /// </summary>
        [JsonProperty("AvgMemUsage")]
        public float? AvgMemUsage{ get; set; }

        /// <summary>
        /// 平均cpu使用率
        /// </summary>
        [JsonProperty("AvgCpuUsage")]
        public float? AvgCpuUsage{ get; set; }

        /// <summary>
        /// 集群总存储大小
        /// </summary>
        [JsonProperty("TotalDiskSize")]
        public ulong? TotalDiskSize{ get; set; }

        /// <summary>
        /// 客户端请求节点
        /// </summary>
        [JsonProperty("TargetNodeTypes")]
        public string[] TargetNodeTypes{ get; set; }

        /// <summary>
        /// 在线节点数
        /// </summary>
        [JsonProperty("NodeNum")]
        public long? NodeNum{ get; set; }

        /// <summary>
        /// 总节点数
        /// </summary>
        [JsonProperty("TotalNodeNum")]
        public long? TotalNodeNum{ get; set; }

        /// <summary>
        /// 数据节点数
        /// </summary>
        [JsonProperty("DataNodeNum")]
        public long? DataNodeNum{ get; set; }

        /// <summary>
        /// 索引数
        /// </summary>
        [JsonProperty("IndexNum")]
        public long? IndexNum{ get; set; }

        /// <summary>
        /// 文档数
        /// </summary>
        [JsonProperty("DocNum")]
        public long? DocNum{ get; set; }

        /// <summary>
        /// 磁盘已使用字节数
        /// </summary>
        [JsonProperty("DiskUsedInBytes")]
        public long? DiskUsedInBytes{ get; set; }

        /// <summary>
        /// 分片个数
        /// </summary>
        [JsonProperty("ShardNum")]
        public long? ShardNum{ get; set; }

        /// <summary>
        /// 主分片个数
        /// </summary>
        [JsonProperty("PrimaryShardNum")]
        public long? PrimaryShardNum{ get; set; }

        /// <summary>
        /// 迁移中的分片个数
        /// </summary>
        [JsonProperty("RelocatingShardNum")]
        public long? RelocatingShardNum{ get; set; }

        /// <summary>
        /// 初始化中的分片个数
        /// </summary>
        [JsonProperty("InitializingShardNum")]
        public long? InitializingShardNum{ get; set; }

        /// <summary>
        /// 未分配的分片个数
        /// </summary>
        [JsonProperty("UnassignedShardNum")]
        public long? UnassignedShardNum{ get; set; }

        /// <summary>
        /// 企业版COS存储容量大小，单位GB
        /// </summary>
        [JsonProperty("TotalCosStorage")]
        public long? TotalCosStorage{ get; set; }

        /// <summary>
        /// 企业版集群可搜索快照cos存放的bucket名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SearchableSnapshotCosBucket")]
        public string SearchableSnapshotCosBucket{ get; set; }

        /// <summary>
        /// 企业版集群可搜索快照cos所属appid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SearchableSnapshotCosAppId")]
        public string SearchableSnapshotCosAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Health", this.Health);
            this.SetParamSimple(map, prefix + "Visible", this.Visible);
            this.SetParamSimple(map, prefix + "Break", this.Break);
            this.SetParamSimple(map, prefix + "AvgDiskUsage", this.AvgDiskUsage);
            this.SetParamSimple(map, prefix + "AvgMemUsage", this.AvgMemUsage);
            this.SetParamSimple(map, prefix + "AvgCpuUsage", this.AvgCpuUsage);
            this.SetParamSimple(map, prefix + "TotalDiskSize", this.TotalDiskSize);
            this.SetParamArraySimple(map, prefix + "TargetNodeTypes.", this.TargetNodeTypes);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "TotalNodeNum", this.TotalNodeNum);
            this.SetParamSimple(map, prefix + "DataNodeNum", this.DataNodeNum);
            this.SetParamSimple(map, prefix + "IndexNum", this.IndexNum);
            this.SetParamSimple(map, prefix + "DocNum", this.DocNum);
            this.SetParamSimple(map, prefix + "DiskUsedInBytes", this.DiskUsedInBytes);
            this.SetParamSimple(map, prefix + "ShardNum", this.ShardNum);
            this.SetParamSimple(map, prefix + "PrimaryShardNum", this.PrimaryShardNum);
            this.SetParamSimple(map, prefix + "RelocatingShardNum", this.RelocatingShardNum);
            this.SetParamSimple(map, prefix + "InitializingShardNum", this.InitializingShardNum);
            this.SetParamSimple(map, prefix + "UnassignedShardNum", this.UnassignedShardNum);
            this.SetParamSimple(map, prefix + "TotalCosStorage", this.TotalCosStorage);
            this.SetParamSimple(map, prefix + "SearchableSnapshotCosBucket", this.SearchableSnapshotCosBucket);
            this.SetParamSimple(map, prefix + "SearchableSnapshotCosAppId", this.SearchableSnapshotCosAppId);
        }
    }
}

