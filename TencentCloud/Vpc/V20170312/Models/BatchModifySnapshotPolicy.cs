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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchModifySnapshotPolicy : AbstractModel
    {
        
        /// <summary>
        /// 快照策略Id。
        /// </summary>
        [JsonProperty("SnapshotPolicyId")]
        public string SnapshotPolicyId{ get; set; }

        /// <summary>
        /// 快照策略名称。
        /// </summary>
        [JsonProperty("SnapshotPolicyName")]
        public string SnapshotPolicyName{ get; set; }

        /// <summary>
        /// 备份策略。
        /// </summary>
        [JsonProperty("BackupPolicies")]
        public BackupPolicy[] BackupPolicies{ get; set; }

        /// <summary>
        /// 快照保留时间，支持1～365天。
        /// </summary>
        [JsonProperty("KeepTime")]
        public ulong? KeepTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SnapshotPolicyId", this.SnapshotPolicyId);
            this.SetParamSimple(map, prefix + "SnapshotPolicyName", this.SnapshotPolicyName);
            this.SetParamArrayObj(map, prefix + "BackupPolicies.", this.BackupPolicies);
            this.SetParamSimple(map, prefix + "KeepTime", this.KeepTime);
        }
    }
}

