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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// 用户在当前地域备份的总个数（包含数据备份和日志备份）。
        /// </summary>
        [JsonProperty("BackupCount")]
        public long? BackupCount{ get; set; }

        /// <summary>
        /// 用户在当前地域备份的总容量
        /// </summary>
        [JsonProperty("BackupVolume")]
        public long? BackupVolume{ get; set; }

        /// <summary>
        /// 用户在当前地域备份的计费容量，即超出赠送容量的部分。
        /// </summary>
        [JsonProperty("BillingVolume")]
        public long? BillingVolume{ get; set; }

        /// <summary>
        /// 用户在当前地域获得的赠送备份容量。
        /// </summary>
        [JsonProperty("FreeVolume")]
        public long? FreeVolume{ get; set; }

        /// <summary>
        /// 用户在当前地域的异地备份总容量。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RemoteBackupVolume")]
        public long? RemoteBackupVolume{ get; set; }

        /// <summary>
        /// 归档备份容量，包含数据备份以及日志备份。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupArchiveVolume")]
        public long? BackupArchiveVolume{ get; set; }

        /// <summary>
        /// 标准存储备份容量，包含数据备份以及日志备份。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupStandbyVolume")]
        public long? BackupStandbyVolume{ get; set; }

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
            this.SetParamSimple(map, prefix + "BackupCount", this.BackupCount);
            this.SetParamSimple(map, prefix + "BackupVolume", this.BackupVolume);
            this.SetParamSimple(map, prefix + "BillingVolume", this.BillingVolume);
            this.SetParamSimple(map, prefix + "FreeVolume", this.FreeVolume);
            this.SetParamSimple(map, prefix + "RemoteBackupVolume", this.RemoteBackupVolume);
            this.SetParamSimple(map, prefix + "BackupArchiveVolume", this.BackupArchiveVolume);
            this.SetParamSimple(map, prefix + "BackupStandbyVolume", this.BackupStandbyVolume);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

