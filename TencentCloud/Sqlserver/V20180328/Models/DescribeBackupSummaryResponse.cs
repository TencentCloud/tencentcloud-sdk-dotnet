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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 实际免费总空间，单位(KB)。
        /// </summary>
        [JsonProperty("FreeSpace")]
        public ulong? FreeSpace{ get; set; }

        /// <summary>
        /// 备份实际使用空间，单位(KB)。
        /// </summary>
        [JsonProperty("ActualUsedSpace")]
        public ulong? ActualUsedSpace{ get; set; }

        /// <summary>
        /// 备份文件总个数。
        /// </summary>
        [JsonProperty("BackupFilesTotal")]
        public ulong? BackupFilesTotal{ get; set; }

        /// <summary>
        /// 备份占用收费空间，单位(KB)。
        /// </summary>
        [JsonProperty("BillingSpace")]
        public ulong? BillingSpace{ get; set; }

        /// <summary>
        /// 数据备份使用空间，单位(KB)。
        /// </summary>
        [JsonProperty("DataBackupSpace")]
        public ulong? DataBackupSpace{ get; set; }

        /// <summary>
        /// 数据备份文件总个数。
        /// </summary>
        [JsonProperty("DataBackupCount")]
        public ulong? DataBackupCount{ get; set; }

        /// <summary>
        /// 数据备份中手动备份使用空间，单位(KB)。
        /// </summary>
        [JsonProperty("ManualBackupSpace")]
        public ulong? ManualBackupSpace{ get; set; }

        /// <summary>
        /// 数据备份中手动备份文件总个数。
        /// </summary>
        [JsonProperty("ManualBackupCount")]
        public ulong? ManualBackupCount{ get; set; }

        /// <summary>
        /// 数据备份中自动备份使用空间，单位(KB)。
        /// </summary>
        [JsonProperty("AutoBackupSpace")]
        public ulong? AutoBackupSpace{ get; set; }

        /// <summary>
        /// 数据备份中自动备份文件总个数。
        /// </summary>
        [JsonProperty("AutoBackupCount")]
        public ulong? AutoBackupCount{ get; set; }

        /// <summary>
        /// 日志备份使用空间，单位(KB)。
        /// </summary>
        [JsonProperty("LogBackupSpace")]
        public ulong? LogBackupSpace{ get; set; }

        /// <summary>
        /// 日志备份文件总个数。
        /// </summary>
        [JsonProperty("LogBackupCount")]
        public ulong? LogBackupCount{ get; set; }

        /// <summary>
        /// 预估收费金额，单位（元/小时）。
        /// </summary>
        [JsonProperty("EstimatedAmount")]
        public float? EstimatedAmount{ get; set; }

        /// <summary>
        /// 本地备份文件总个数
        /// </summary>
        [JsonProperty("LocalBackupFilesTotal")]
        public ulong? LocalBackupFilesTotal{ get; set; }

        /// <summary>
        /// 跨地域备份文件总个数
        /// </summary>
        [JsonProperty("CrossBackupFilesTotal")]
        public ulong? CrossBackupFilesTotal{ get; set; }

        /// <summary>
        /// 跨地域备份占用收费空间，单位（KB）
        /// </summary>
        [JsonProperty("CrossBillingSpace")]
        public ulong? CrossBillingSpace{ get; set; }

        /// <summary>
        /// 跨地域自动数据备份使用空间，单位（KB）
        /// </summary>
        [JsonProperty("CrossAutoBackupSpace")]
        public ulong? CrossAutoBackupSpace{ get; set; }

        /// <summary>
        /// 跨地域自动数据备份文件总个数
        /// </summary>
        [JsonProperty("CrossAutoBackupCount")]
        public ulong? CrossAutoBackupCount{ get; set; }

        /// <summary>
        /// 本地日志备份使用空间，单位（KB）
        /// </summary>
        [JsonProperty("LocalLogBackupSpace")]
        public ulong? LocalLogBackupSpace{ get; set; }

        /// <summary>
        /// 本地日志备份文件总个数
        /// </summary>
        [JsonProperty("LocalLogBackupCount")]
        public ulong? LocalLogBackupCount{ get; set; }

        /// <summary>
        /// 跨地域日志备份使用空间，单位（KB）
        /// </summary>
        [JsonProperty("CrossLogBackupSpace")]
        public ulong? CrossLogBackupSpace{ get; set; }

        /// <summary>
        /// 跨地域日志备份文件总个数
        /// </summary>
        [JsonProperty("CrossLogBackupCount")]
        public ulong? CrossLogBackupCount{ get; set; }

        /// <summary>
        /// 跨地域备份预估收费金额，单位（元/小时）
        /// </summary>
        [JsonProperty("CrossEstimatedAmount")]
        public float? CrossEstimatedAmount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FreeSpace", this.FreeSpace);
            this.SetParamSimple(map, prefix + "ActualUsedSpace", this.ActualUsedSpace);
            this.SetParamSimple(map, prefix + "BackupFilesTotal", this.BackupFilesTotal);
            this.SetParamSimple(map, prefix + "BillingSpace", this.BillingSpace);
            this.SetParamSimple(map, prefix + "DataBackupSpace", this.DataBackupSpace);
            this.SetParamSimple(map, prefix + "DataBackupCount", this.DataBackupCount);
            this.SetParamSimple(map, prefix + "ManualBackupSpace", this.ManualBackupSpace);
            this.SetParamSimple(map, prefix + "ManualBackupCount", this.ManualBackupCount);
            this.SetParamSimple(map, prefix + "AutoBackupSpace", this.AutoBackupSpace);
            this.SetParamSimple(map, prefix + "AutoBackupCount", this.AutoBackupCount);
            this.SetParamSimple(map, prefix + "LogBackupSpace", this.LogBackupSpace);
            this.SetParamSimple(map, prefix + "LogBackupCount", this.LogBackupCount);
            this.SetParamSimple(map, prefix + "EstimatedAmount", this.EstimatedAmount);
            this.SetParamSimple(map, prefix + "LocalBackupFilesTotal", this.LocalBackupFilesTotal);
            this.SetParamSimple(map, prefix + "CrossBackupFilesTotal", this.CrossBackupFilesTotal);
            this.SetParamSimple(map, prefix + "CrossBillingSpace", this.CrossBillingSpace);
            this.SetParamSimple(map, prefix + "CrossAutoBackupSpace", this.CrossAutoBackupSpace);
            this.SetParamSimple(map, prefix + "CrossAutoBackupCount", this.CrossAutoBackupCount);
            this.SetParamSimple(map, prefix + "LocalLogBackupSpace", this.LocalLogBackupSpace);
            this.SetParamSimple(map, prefix + "LocalLogBackupCount", this.LocalLogBackupCount);
            this.SetParamSimple(map, prefix + "CrossLogBackupSpace", this.CrossLogBackupSpace);
            this.SetParamSimple(map, prefix + "CrossLogBackupCount", this.CrossLogBackupCount);
            this.SetParamSimple(map, prefix + "CrossEstimatedAmount", this.CrossEstimatedAmount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

