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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Snapshots : AbstractModel
    {
        
        /// <summary>
        /// 快照名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// 快照Uuid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 仓库名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Repository")]
        public string Repository{ get; set; }

        /// <summary>
        /// 该快照所属集群的版本号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 备份的索引列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Indices")]
        public string[] Indices{ get; set; }

        /// <summary>
        /// 备份的datastream列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataStreams")]
        public string[] DataStreams{ get; set; }

        /// <summary>
        /// 备份的状态
        /// 
        /// FAILED            备份失败
        /// 
        /// IN_PROGRESS 备份执行中
        /// 
        /// PARTIAL          备份部分成功，部分失败，备份失败的索引和原因会在Failures字段中展示
        /// 
        /// SUCCESS     备份成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 快照备份的开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 快照备份的结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 快照备份的耗时时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DurationInMillis")]
        public long? DurationInMillis{ get; set; }

        /// <summary>
        /// 备份的总分片数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalShards")]
        public long? TotalShards{ get; set; }

        /// <summary>
        /// 备份失败的分片数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailedShards")]
        public long? FailedShards{ get; set; }

        /// <summary>
        /// 备份成功的分片数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SuccessfulShards")]
        public long? SuccessfulShards{ get; set; }

        /// <summary>
        /// 备份失败的索引分片和失败原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Failures")]
        public Failures[] Failures{ get; set; }

        /// <summary>
        /// 是否用户备份
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserBackUp")]
        public string UserBackUp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Repository", this.Repository);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamArraySimple(map, prefix + "Indices.", this.Indices);
            this.SetParamArraySimple(map, prefix + "DataStreams.", this.DataStreams);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "DurationInMillis", this.DurationInMillis);
            this.SetParamSimple(map, prefix + "TotalShards", this.TotalShards);
            this.SetParamSimple(map, prefix + "FailedShards", this.FailedShards);
            this.SetParamSimple(map, prefix + "SuccessfulShards", this.SuccessfulShards);
            this.SetParamArrayObj(map, prefix + "Failures.", this.Failures);
            this.SetParamSimple(map, prefix + "UserBackUp", this.UserBackUp);
        }
    }
}

