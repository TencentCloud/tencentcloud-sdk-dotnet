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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 备份方式。
        /// - 0：自动备份。
        /// - 1：手动备份。
        /// </summary>
        [JsonProperty("BackupType")]
        public ulong? BackupType{ get; set; }

        /// <summary>
        /// 备份文件名称。
        /// </summary>
        [JsonProperty("BackupName")]
        public string BackupName{ get; set; }

        /// <summary>
        /// 备份任务备注信息。
        /// </summary>
        [JsonProperty("BackupDesc")]
        public string BackupDesc{ get; set; }

        /// <summary>
        /// 备份文件大小，单位：KB。
        /// </summary>
        [JsonProperty("BackupSize")]
        public ulong? BackupSize{ get; set; }

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
        /// 备份状态。
        /// - 1：备份中。
        /// - 2：备份成功。
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 备份方式。
        /// - 0：逻辑备份。
        /// - 1：物理备份。
        /// - 3：快照备份。
        /// **说明:**
        /// - 通用版实例支持逻辑备份与物理备份。云盘版实例支持物理备份与快照备份，暂不支持逻辑备份。
        /// - 实例开通存储加密，则备份方式不能为物理备份。
        /// </summary>
        [JsonProperty("BackupMethod")]
        public ulong? BackupMethod{ get; set; }

        /// <summary>
        /// 备份记录 ID。
        /// </summary>
        [JsonProperty("BackId")]
        public long? BackId{ get; set; }

        /// <summary>
        /// 备份删除时间。
        /// </summary>
        [JsonProperty("DeleteTime")]
        public string DeleteTime{ get; set; }

        /// <summary>
        /// 异地备份地域。
        /// </summary>
        [JsonProperty("BackupRegion")]
        public string BackupRegion{ get; set; }

        /// <summary>
        /// 备份支持的回档时间。
        /// </summary>
        [JsonProperty("RestoreTime")]
        public string RestoreTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "BackupName", this.BackupName);
            this.SetParamSimple(map, prefix + "BackupDesc", this.BackupDesc);
            this.SetParamSimple(map, prefix + "BackupSize", this.BackupSize);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BackId", this.BackId);
            this.SetParamSimple(map, prefix + "DeleteTime", this.DeleteTime);
            this.SetParamSimple(map, prefix + "BackupRegion", this.BackupRegion);
            this.SetParamSimple(map, prefix + "RestoreTime", this.RestoreTime);
        }
    }
}

