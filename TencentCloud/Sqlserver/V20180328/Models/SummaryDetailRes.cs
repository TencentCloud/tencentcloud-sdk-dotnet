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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SummaryDetailRes : AbstractModel
    {
        
        /// <summary>
        /// 地域标识
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// 实例状态。1：申请中2：运行中3：受限运行中 (主备切换中)4：已隔离5：回收中6：已回收7：任务执行中 (实例做备份、回档等操作)8：已下线9：实例扩容中10：实例迁移中
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 备份空间
        /// </summary>
        [JsonProperty("ActualUsedSpace")]
        public ulong? ActualUsedSpace{ get; set; }

        /// <summary>
        /// 数据备份空间
        /// </summary>
        [JsonProperty("DataBackupSpace")]
        public ulong? DataBackupSpace{ get; set; }

        /// <summary>
        /// 数据备份文件总个数
        /// </summary>
        [JsonProperty("DataBackupCount")]
        public ulong? DataBackupCount{ get; set; }

        /// <summary>
        /// 日志备份空间
        /// </summary>
        [JsonProperty("LogBackupSpace")]
        public ulong? LogBackupSpace{ get; set; }

        /// <summary>
        /// 日志备份文件总个数
        /// </summary>
        [JsonProperty("LogBackupCount")]
        public ulong? LogBackupCount{ get; set; }

        /// <summary>
        /// 自动备份空间
        /// </summary>
        [JsonProperty("AutoBackupSpace")]
        public ulong? AutoBackupSpace{ get; set; }

        /// <summary>
        /// 自动备份文件总个数
        /// </summary>
        [JsonProperty("AutoBackupCount")]
        public ulong? AutoBackupCount{ get; set; }

        /// <summary>
        /// 手动备份空间
        /// </summary>
        [JsonProperty("ManualBackupSpace")]
        public ulong? ManualBackupSpace{ get; set; }

        /// <summary>
        /// 手动备份文件总个数
        /// </summary>
        [JsonProperty("ManualBackupCount")]
        public ulong? ManualBackupCount{ get; set; }

        /// <summary>
        /// 实例所属地域码
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ActualUsedSpace", this.ActualUsedSpace);
            this.SetParamSimple(map, prefix + "DataBackupSpace", this.DataBackupSpace);
            this.SetParamSimple(map, prefix + "DataBackupCount", this.DataBackupCount);
            this.SetParamSimple(map, prefix + "LogBackupSpace", this.LogBackupSpace);
            this.SetParamSimple(map, prefix + "LogBackupCount", this.LogBackupCount);
            this.SetParamSimple(map, prefix + "AutoBackupSpace", this.AutoBackupSpace);
            this.SetParamSimple(map, prefix + "AutoBackupCount", this.AutoBackupCount);
            this.SetParamSimple(map, prefix + "ManualBackupSpace", this.ManualBackupSpace);
            this.SetParamSimple(map, prefix + "ManualBackupCount", this.ManualBackupCount);
            this.SetParamSimple(map, prefix + "Region", this.Region);
        }
    }
}

