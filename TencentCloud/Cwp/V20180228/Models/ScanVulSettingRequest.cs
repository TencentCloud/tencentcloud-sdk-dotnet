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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScanVulSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// 定期检测间隔时间（天）
        /// </summary>
        [JsonProperty("TimerInterval")]
        public ulong? TimerInterval{ get; set; }

        /// <summary>
        /// 漏洞类型：1: web-cms漏洞 2:应用漏洞  4: Linux软件漏洞 5: Windows系统漏洞, 以数组方式传参[1,2]
        /// </summary>
        [JsonProperty("VulCategories")]
        public ulong?[] VulCategories{ get; set; }

        /// <summary>
        /// 危害等级：1-低危；2-中危；3-高危；4-严重,以数组方式传参[1,2,3]
        /// </summary>
        [JsonProperty("VulLevels")]
        public ulong?[] VulLevels{ get; set; }

        /// <summary>
        /// 定期检测时间，如：02:10:50
        /// </summary>
        [JsonProperty("TimerTime")]
        public string TimerTime{ get; set; }

        /// <summary>
        /// 是否是应急漏洞 0 否 1 是
        /// </summary>
        [JsonProperty("VulEmergency")]
        public ulong? VulEmergency{ get; set; }

        /// <summary>
        /// 扫描开始时间，如：00:00
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 扫描结束时间，如：08:00
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 是否开启扫描 1开启 0不开启
        /// </summary>
        [JsonProperty("EnableScan")]
        public ulong? EnableScan{ get; set; }

        /// <summary>
        /// 为空默认扫描全部专业版、旗舰版、轻量版主机，不为空只扫描选中主机
        /// </summary>
        [JsonProperty("Uuids")]
        public string[] Uuids{ get; set; }

        /// <summary>
        /// 0版本比对，2版本比对+poc
        /// </summary>
        [JsonProperty("ScanMethod")]
        public ulong? ScanMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimerInterval", this.TimerInterval);
            this.SetParamArraySimple(map, prefix + "VulCategories.", this.VulCategories);
            this.SetParamArraySimple(map, prefix + "VulLevels.", this.VulLevels);
            this.SetParamSimple(map, prefix + "TimerTime", this.TimerTime);
            this.SetParamSimple(map, prefix + "VulEmergency", this.VulEmergency);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "EnableScan", this.EnableScan);
            this.SetParamArraySimple(map, prefix + "Uuids.", this.Uuids);
            this.SetParamSimple(map, prefix + "ScanMethod", this.ScanMethod);
        }
    }
}

