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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SnapshotPolicy : AbstractModel
    {
        
        /// <summary>
        /// 快照策略名称。
        /// </summary>
        [JsonProperty("SnapshotPolicyName")]
        public string SnapshotPolicyName{ get; set; }

        /// <summary>
        /// 备份策略类型，operate-操作备份，time-定时备份。
        /// </summary>
        [JsonProperty("BackupType")]
        public string BackupType{ get; set; }

        /// <summary>
        /// 保留时间，支持1～365天。
        /// </summary>
        [JsonProperty("KeepTime")]
        public ulong? KeepTime{ get; set; }

        /// <summary>
        /// 是否创建新的cos桶，默认为False。
        /// </summary>
        [JsonProperty("CreateNewCos")]
        public bool? CreateNewCos{ get; set; }

        /// <summary>
        /// cos桶所在地域。
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// cos桶。
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }

        /// <summary>
        /// 快照策略Id。
        /// </summary>
        [JsonProperty("SnapshotPolicyId")]
        public string SnapshotPolicyId{ get; set; }

        /// <summary>
        /// 时间备份策略。
        /// </summary>
        [JsonProperty("BackupPolicies")]
        public BackupPolicy[] BackupPolicies{ get; set; }

        /// <summary>
        /// 启用状态，True-启用，False-停用，默认为True。
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 标签键值对。	
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SnapshotPolicyName", this.SnapshotPolicyName);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "KeepTime", this.KeepTime);
            this.SetParamSimple(map, prefix + "CreateNewCos", this.CreateNewCos);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
            this.SetParamSimple(map, prefix + "SnapshotPolicyId", this.SnapshotPolicyId);
            this.SetParamArrayObj(map, prefix + "BackupPolicies.", this.BackupPolicies);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
        }
    }
}

