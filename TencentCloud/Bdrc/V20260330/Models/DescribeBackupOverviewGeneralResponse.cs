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

    public class DescribeBackupOverviewGeneralResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>整机备份（CVM 备份组）概览数据</p>
        /// </summary>
        [JsonProperty("InstanceBackupOverview")]
        public InstanceBackupOverview InstanceBackupOverview{ get; set; }

        /// <summary>
        /// <p>文件备份概览数据</p>
        /// </summary>
        [JsonProperty("FileBackupOverview")]
        public FileBackupOverview FileBackupOverview{ get; set; }

        /// <summary>
        /// <p>备份策略概览</p>
        /// </summary>
        [JsonProperty("BackupPolicyOverview")]
        public BackupPolicyOverview BackupPolicyOverview{ get; set; }

        /// <summary>
        /// <p>备份库概览</p>
        /// </summary>
        [JsonProperty("BackupVaultOverview")]
        public BackupVaultOverview BackupVaultOverview{ get; set; }

        /// <summary>
        /// <p>受保护资源概览</p>
        /// </summary>
        [JsonProperty("ProtectedResourceOverview")]
        public ProtectedResourceOverview ProtectedResourceOverview{ get; set; }

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
            this.SetParamObj(map, prefix + "InstanceBackupOverview.", this.InstanceBackupOverview);
            this.SetParamObj(map, prefix + "FileBackupOverview.", this.FileBackupOverview);
            this.SetParamObj(map, prefix + "BackupPolicyOverview.", this.BackupPolicyOverview);
            this.SetParamObj(map, prefix + "BackupVaultOverview.", this.BackupVaultOverview);
            this.SetParamObj(map, prefix + "ProtectedResourceOverview.", this.ProtectedResourceOverview);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

