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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RollbackData : AbstractModel
    {
        
        /// <summary>
        /// 实例CPU
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 实例内存
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 集群存储上限
        /// </summary>
        [JsonProperty("StorageLimit")]
        public long? StorageLimit{ get; set; }

        /// <summary>
        /// 原集群id
        /// </summary>
        [JsonProperty("OriginalClusterId")]
        public string OriginalClusterId{ get; set; }

        /// <summary>
        /// 原集群名
        /// </summary>
        [JsonProperty("OriginalClusterName")]
        public string OriginalClusterName{ get; set; }

        /// <summary>
        /// 回档方式
        /// </summary>
        [JsonProperty("RollbackStrategy")]
        public string RollbackStrategy{ get; set; }

        /// <summary>
        /// 快照时间
        /// </summary>
        [JsonProperty("SnapshotTime")]
        public string SnapshotTime{ get; set; }

        /// <summary>
        /// 回档到serverlessls集群时最小CPU
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinCpu")]
        public long? MinCpu{ get; set; }

        /// <summary>
        /// 回档到serverlessls集群时最大CPU
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxCpu")]
        public long? MaxCpu{ get; set; }

        /// <summary>
        /// 快照ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapShotId")]
        public ulong? SnapShotId{ get; set; }

        /// <summary>
        /// 回档数据库
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RollbackDatabases")]
        public RollbackDatabase[] RollbackDatabases{ get; set; }

        /// <summary>
        /// 回档数据表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RollbackTables")]
        public RollbackTable[] RollbackTables{ get; set; }

        /// <summary>
        /// 备份文件名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupFileName")]
        public string BackupFileName{ get; set; }

        /// <summary>
        /// 回档进程
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RollbackProcess")]
        public RollbackProcessInfo RollbackProcess{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "StorageLimit", this.StorageLimit);
            this.SetParamSimple(map, prefix + "OriginalClusterId", this.OriginalClusterId);
            this.SetParamSimple(map, prefix + "OriginalClusterName", this.OriginalClusterName);
            this.SetParamSimple(map, prefix + "RollbackStrategy", this.RollbackStrategy);
            this.SetParamSimple(map, prefix + "SnapshotTime", this.SnapshotTime);
            this.SetParamSimple(map, prefix + "MinCpu", this.MinCpu);
            this.SetParamSimple(map, prefix + "MaxCpu", this.MaxCpu);
            this.SetParamSimple(map, prefix + "SnapShotId", this.SnapShotId);
            this.SetParamArrayObj(map, prefix + "RollbackDatabases.", this.RollbackDatabases);
            this.SetParamArrayObj(map, prefix + "RollbackTables.", this.RollbackTables);
            this.SetParamSimple(map, prefix + "BackupFileName", this.BackupFileName);
            this.SetParamObj(map, prefix + "RollbackProcess.", this.RollbackProcess);
        }
    }
}

