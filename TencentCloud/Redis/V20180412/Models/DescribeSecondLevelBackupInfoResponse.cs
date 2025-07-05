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

    public class DescribeSecondLevelBackupInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 备份记录ID 
        /// </summary>
        [JsonProperty("BackupId")]
        public string BackupId{ get; set; }

        /// <summary>
        /// 备份时间戳
        /// </summary>
        [JsonProperty("BackupTimestamp")]
        public long? BackupTimestamp{ get; set; }

        /// <summary>
        /// 备份不存在的时间戳范围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MissingTimestamps")]
        public SecondLevelBackupMissingTimestamps[] MissingTimestamps{ get; set; }

        /// <summary>
        /// 实例开启秒级备份的时间戳
        /// </summary>
        [JsonProperty("StartTimestamp")]
        public long? StartTimestamp{ get; set; }

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
            this.SetParamSimple(map, prefix + "BackupTimestamp", this.BackupTimestamp);
            this.SetParamArrayObj(map, prefix + "MissingTimestamps.", this.MissingTimestamps);
            this.SetParamSimple(map, prefix + "StartTimestamp", this.StartTimestamp);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

