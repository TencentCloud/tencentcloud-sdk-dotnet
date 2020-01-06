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

    public class ModifyMonitorAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 监测任务ID
        /// </summary>
        [JsonProperty("MonitorId")]
        public ulong? MonitorId{ get; set; }

        /// <summary>
        /// 站点的url列表
        /// </summary>
        [JsonProperty("Urls")]
        public string[] Urls{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 扫描模式，normal-正常扫描；deep-深度扫描
        /// </summary>
        [JsonProperty("ScannerType")]
        public string ScannerType{ get; set; }

        /// <summary>
        /// 扫描周期，单位小时，每X小时执行一次
        /// </summary>
        [JsonProperty("Crontab")]
        public ulong? Crontab{ get; set; }

        /// <summary>
        /// 扫描速率限制，每秒发送X个HTTP请求
        /// </summary>
        [JsonProperty("RateLimit")]
        public ulong? RateLimit{ get; set; }

        /// <summary>
        /// 首次扫描开始时间
        /// </summary>
        [JsonProperty("FirstScanStartTime")]
        public string FirstScanStartTime{ get; set; }

        /// <summary>
        /// 监测状态：1-监测中；2-暂停监测
        /// </summary>
        [JsonProperty("MonitorStatus")]
        public ulong? MonitorStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MonitorId", this.MonitorId);
            this.SetParamArraySimple(map, prefix + "Urls.", this.Urls);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ScannerType", this.ScannerType);
            this.SetParamSimple(map, prefix + "Crontab", this.Crontab);
            this.SetParamSimple(map, prefix + "RateLimit", this.RateLimit);
            this.SetParamSimple(map, prefix + "FirstScanStartTime", this.FirstScanStartTime);
            this.SetParamSimple(map, prefix + "MonitorStatus", this.MonitorStatus);
        }
    }
}

