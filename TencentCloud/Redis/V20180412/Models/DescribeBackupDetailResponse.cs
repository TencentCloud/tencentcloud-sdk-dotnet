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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 备份 ID。
        /// </summary>
        [JsonProperty("BackupId")]
        public string BackupId{ get; set; }

        /// <summary>
        /// 备份开始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 备份结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 备份方式。 
        /// 
        /// - 1：手动备份。
        /// -  0：自动备份。
        /// </summary>
        [JsonProperty("BackupType")]
        public string BackupType{ get; set; }

        /// <summary>
        /// 备份状态。 
        /// 
        /// - 1：备份被其它流程锁定。
        /// - 2：备份正常，没有被任何流程锁定。
        /// - -1：备份已过期。
        /// - 3：备份正在被导出。
        /// - 4：备份导出成功。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 备份的备注信息。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 备份是否被锁定。
        /// 
        /// - 0：未被锁定。
        /// - 1：已被锁定。
        /// </summary>
        [JsonProperty("Locked")]
        public long? Locked{ get; set; }

        /// <summary>
        /// 备份文件大小。单位：Byte。
        /// </summary>
        [JsonProperty("BackupSize")]
        public long? BackupSize{ get; set; }

        /// <summary>
        /// 实例类型。
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// 单分片内存规格大小，单位：MB。
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// 分片数量。
        /// </summary>
        [JsonProperty("ShardNum")]
        public long? ShardNum{ get; set; }

        /// <summary>
        /// 副本数量。
        /// </summary>
        [JsonProperty("ReplicasNum")]
        public long? ReplicasNum{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupId", this.BackupId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Locked", this.Locked);
            this.SetParamSimple(map, prefix + "BackupSize", this.BackupSize);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "ShardNum", this.ShardNum);
            this.SetParamSimple(map, prefix + "ReplicasNum", this.ReplicasNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

