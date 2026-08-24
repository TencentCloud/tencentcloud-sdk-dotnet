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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProtectInstance : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 客户端ID
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }

        /// <summary>
        /// 客户端版本
        /// </summary>
        [JsonProperty("AgentVersion")]
        public string AgentVersion{ get; set; }

        /// <summary>
        /// 客户端状态
        /// </summary>
        [JsonProperty("AgentStatus")]
        public string AgentStatus{ get; set; }

        /// <summary>
        /// 最后心跳时间
        /// </summary>
        [JsonProperty("LastHeartbeatTime")]
        public string LastHeartbeatTime{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 最新备份点中记录的 CVM 基础信息
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public string ExtraInfo{ get; set; }

        /// <summary>
        /// 该实例可用备份点数量
        /// </summary>
        [JsonProperty("BackupCount")]
        public ulong? BackupCount{ get; set; }

        /// <summary>
        /// 实例名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 最近一次备份时间
        /// </summary>
        [JsonProperty("LatestBackupTime")]
        public string LatestBackupTime{ get; set; }

        /// <summary>
        /// 离线原因
        /// </summary>
        [JsonProperty("OfflineReason")]
        public string OfflineReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamSimple(map, prefix + "AgentVersion", this.AgentVersion);
            this.SetParamSimple(map, prefix + "AgentStatus", this.AgentStatus);
            this.SetParamSimple(map, prefix + "LastHeartbeatTime", this.LastHeartbeatTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ExtraInfo", this.ExtraInfo);
            this.SetParamSimple(map, prefix + "BackupCount", this.BackupCount);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "LatestBackupTime", this.LatestBackupTime);
            this.SetParamSimple(map, prefix + "OfflineReason", this.OfflineReason);
        }
    }
}

