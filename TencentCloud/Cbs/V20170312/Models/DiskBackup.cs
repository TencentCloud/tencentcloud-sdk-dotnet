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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiskBackup : AbstractModel
    {
        
        /// <summary>
        /// 云硬盘备份点的ID。
        /// </summary>
        [JsonProperty("DiskBackupId")]
        public string DiskBackupId{ get; set; }

        /// <summary>
        /// 云硬盘备份点关联的云硬盘ID。
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// 云硬盘大小，单位GiB。
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// 云硬盘类型。取值范围：<br>
        /// <li>SYSTEM_DISK：系统盘</li>
        /// <li>DATA_DISK：数据盘。</li>
        /// </summary>
        [JsonProperty("DiskUsage")]
        public string DiskUsage{ get; set; }

        /// <summary>
        /// 备份点名称。
        /// </summary>
        [JsonProperty("DiskBackupName")]
        public string DiskBackupName{ get; set; }

        /// <summary>
        /// <p>云硬盘备份点状态。取值范围：</p>
        /// <ul>
        ///   <li>NORMAL：正常</li>
        ///   <li>CREATING：创建中</li>
        ///   <li>ROLLBACKING：回滚中</li>
        /// </ul>
        /// </summary>
        [JsonProperty("DiskBackupState")]
        public string DiskBackupState{ get; set; }

        /// <summary>
        /// 云硬盘备份点创建百分比。
        /// </summary>
        [JsonProperty("Percent")]
        public ulong? Percent{ get; set; }

        /// <summary>
        /// 云硬盘备份点的创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 云盘是否为加密盘。取值范围：<br><li>false:表示非加密盘<br></li>true:表示加密盘。
        /// </summary>
        [JsonProperty("Encrypt")]
        public bool? Encrypt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskBackupId", this.DiskBackupId);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DiskUsage", this.DiskUsage);
            this.SetParamSimple(map, prefix + "DiskBackupName", this.DiskBackupName);
            this.SetParamSimple(map, prefix + "DiskBackupState", this.DiskBackupState);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
        }
    }
}

