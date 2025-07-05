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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiskBackup : AbstractModel
    {
        
        /// <summary>
        /// 云硬盘备份点ID。
        /// </summary>
        [JsonProperty("DiskBackupId")]
        public string DiskBackupId{ get; set; }

        /// <summary>
        /// 创建此云硬盘备份点的云硬盘类型。取值：<li>DATA_DISK：数据盘</li>
        /// </summary>
        [JsonProperty("DiskUsage")]
        public string DiskUsage{ get; set; }

        /// <summary>
        /// 创建此云硬盘备份点的云硬盘 ID。
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// 创建此云硬盘备份点的云硬盘大小，单位 GB。
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// 云硬盘备份点名称，用户自定义的云硬盘备份点别名。
        /// </summary>
        [JsonProperty("DiskBackupName")]
        public string DiskBackupName{ get; set; }

        /// <summary>
        /// 云硬盘备份点的状态。取值范围：
        /// <li>NORMAL：正常。 </li>
        /// <li>CREATING：创建中。</li>
        /// <li>ROLLBACKING：回滚中。</li>
        /// <li>DELETING：删除中。</li>
        /// </summary>
        [JsonProperty("DiskBackupState")]
        public string DiskBackupState{ get; set; }

        /// <summary>
        /// 创建或回滚云硬盘备份点进度百分比，成功后此字段取值为 100。
        /// </summary>
        [JsonProperty("Percent")]
        public long? Percent{ get; set; }

        /// <summary>
        /// 上一次操作
        /// </summary>
        [JsonProperty("LatestOperation")]
        public string LatestOperation{ get; set; }

        /// <summary>
        /// 上一次操作状态
        /// </summary>
        [JsonProperty("LatestOperationState")]
        public string LatestOperationState{ get; set; }

        /// <summary>
        /// 上一次请求ID
        /// </summary>
        [JsonProperty("LatestOperationRequestId")]
        public string LatestOperationRequestId{ get; set; }

        /// <summary>
        /// 创建时间。按照 ISO8601 标准表示，并且使用 UTC 时间。 
        /// 格式为： YYYY-MM-DDThh:mm:ssZ。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskBackupId", this.DiskBackupId);
            this.SetParamSimple(map, prefix + "DiskUsage", this.DiskUsage);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DiskBackupName", this.DiskBackupName);
            this.SetParamSimple(map, prefix + "DiskBackupState", this.DiskBackupState);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "LatestOperation", this.LatestOperation);
            this.SetParamSimple(map, prefix + "LatestOperationState", this.LatestOperationState);
            this.SetParamSimple(map, prefix + "LatestOperationRequestId", this.LatestOperationRequestId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
        }
    }
}

