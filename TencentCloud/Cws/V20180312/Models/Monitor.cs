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

namespace TencentCloud.Cws.V20180312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Monitor : AbstractModel
    {
        
        /// <summary>
        /// 监控任务ID。
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 监控名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 监测状态：1-监测中；2-暂停监测。
        /// </summary>
        [JsonProperty("MonitorStatus")]
        public ulong? MonitorStatus{ get; set; }

        /// <summary>
        /// 监测模式，normal-正常扫描；deep-深度扫描。
        /// </summary>
        [JsonProperty("ScannerType")]
        public string ScannerType{ get; set; }

        /// <summary>
        /// 扫描周期，单位小时，每X小时执行一次。
        /// </summary>
        [JsonProperty("Crontab")]
        public ulong? Crontab{ get; set; }

        /// <summary>
        /// 指定扫描类型，3位数每位依次表示：扫描Web漏洞、扫描系统漏洞、扫描系统端口。
        /// </summary>
        [JsonProperty("IncludedVulsTypes")]
        public string IncludedVulsTypes{ get; set; }

        /// <summary>
        /// 速率限制，每秒发送X个HTTP请求。
        /// </summary>
        [JsonProperty("RateLimit")]
        public ulong? RateLimit{ get; set; }

        /// <summary>
        /// 首次扫描开始时间。
        /// </summary>
        [JsonProperty("FirstScanStartTime")]
        public string FirstScanStartTime{ get; set; }

        /// <summary>
        /// 扫描状态：0-待扫描（无任何扫描结果）；1-扫描中（正在进行扫描）；2-已扫描（有扫描结果且不正在扫描）；3-扫描完成待同步结果。
        /// </summary>
        [JsonProperty("ScanStatus")]
        public ulong? ScanStatus{ get; set; }

        /// <summary>
        /// 上一次扫描完成时间。
        /// </summary>
        [JsonProperty("LastScanFinishTime")]
        public string LastScanFinishTime{ get; set; }

        /// <summary>
        /// 当前扫描开始时间，如扫描完成则为上一次扫描的开始时间。
        /// </summary>
        [JsonProperty("CurrentScanStartTime")]
        public string CurrentScanStartTime{ get; set; }

        /// <summary>
        /// CreatedAt。
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// UpdatedAt。
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// 云用户appid。
        /// </summary>
        [JsonProperty("Appid")]
        public ulong? Appid{ get; set; }

        /// <summary>
        /// 扫描状态：0-待检测；1-检测完成
        /// </summary>
        [JsonProperty("ContentScanStatus")]
        public ulong? ContentScanStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "MonitorStatus", this.MonitorStatus);
            this.SetParamSimple(map, prefix + "ScannerType", this.ScannerType);
            this.SetParamSimple(map, prefix + "Crontab", this.Crontab);
            this.SetParamSimple(map, prefix + "IncludedVulsTypes", this.IncludedVulsTypes);
            this.SetParamSimple(map, prefix + "RateLimit", this.RateLimit);
            this.SetParamSimple(map, prefix + "FirstScanStartTime", this.FirstScanStartTime);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "LastScanFinishTime", this.LastScanFinishTime);
            this.SetParamSimple(map, prefix + "CurrentScanStartTime", this.CurrentScanStartTime);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "ContentScanStatus", this.ContentScanStatus);
        }
    }
}

