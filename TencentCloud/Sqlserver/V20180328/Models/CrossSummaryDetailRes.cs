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

    public class CrossSummaryDetailRes : AbstractModel
    {
        
        /// <summary>
        /// 实例状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 实例所属地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

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
        /// 跨地域备份状态 enable-开启，disable-关闭
        /// </summary>
        [JsonProperty("CrossBackupEnabled")]
        public string CrossBackupEnabled{ get; set; }

        /// <summary>
        /// 跨地域备份目标地域
        /// </summary>
        [JsonProperty("CrossRegions")]
        public string[] CrossRegions{ get; set; }

        /// <summary>
        /// 最新备份开始时间
        /// </summary>
        [JsonProperty("LastBackupStartTime")]
        public string LastBackupStartTime{ get; set; }

        /// <summary>
        /// 跨地域备份保留天数
        /// </summary>
        [JsonProperty("CrossBackupSaveDays")]
        public long? CrossBackupSaveDays{ get; set; }

        /// <summary>
        /// 跨地域数据备份总空间
        /// </summary>
        [JsonProperty("DataBackupSpace")]
        public ulong? DataBackupSpace{ get; set; }

        /// <summary>
        /// 跨地域数据备份文件总个数
        /// </summary>
        [JsonProperty("DataBackupCount")]
        public ulong? DataBackupCount{ get; set; }

        /// <summary>
        /// 跨地域日志备份总空间
        /// </summary>
        [JsonProperty("LogBackupSpace")]
        public ulong? LogBackupSpace{ get; set; }

        /// <summary>
        /// 跨地域日志备份文件总个数
        /// </summary>
        [JsonProperty("LogBackupCount")]
        public ulong? LogBackupCount{ get; set; }

        /// <summary>
        /// 跨地域备份总空间
        /// </summary>
        [JsonProperty("ActualUsedSpace")]
        public ulong? ActualUsedSpace{ get; set; }

        /// <summary>
        /// 跨地域备份总个数
        /// </summary>
        [JsonProperty("ActualUsedCount")]
        public ulong? ActualUsedCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CrossBackupEnabled", this.CrossBackupEnabled);
            this.SetParamArraySimple(map, prefix + "CrossRegions.", this.CrossRegions);
            this.SetParamSimple(map, prefix + "LastBackupStartTime", this.LastBackupStartTime);
            this.SetParamSimple(map, prefix + "CrossBackupSaveDays", this.CrossBackupSaveDays);
            this.SetParamSimple(map, prefix + "DataBackupSpace", this.DataBackupSpace);
            this.SetParamSimple(map, prefix + "DataBackupCount", this.DataBackupCount);
            this.SetParamSimple(map, prefix + "LogBackupSpace", this.LogBackupSpace);
            this.SetParamSimple(map, prefix + "LogBackupCount", this.LogBackupCount);
            this.SetParamSimple(map, prefix + "ActualUsedSpace", this.ActualUsedSpace);
            this.SetParamSimple(map, prefix + "ActualUsedCount", this.ActualUsedCount);
        }
    }
}

