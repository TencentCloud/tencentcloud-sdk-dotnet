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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTrialReportResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>是否展示</p>
        /// </summary>
        [JsonProperty("IsShow")]
        public bool? IsShow{ get; set; }

        /// <summary>
        /// <p>新增机器数</p>
        /// </summary>
        [JsonProperty("AddMachineCnt")]
        public long? AddMachineCnt{ get; set; }

        /// <summary>
        /// <p>基线风险数(检测项)</p>
        /// </summary>
        [JsonProperty("BaselineRiskCnt")]
        public long? BaselineRiskCnt{ get; set; }

        /// <summary>
        /// <p>漏洞数</p>
        /// </summary>
        [JsonProperty("VulCnt")]
        public long? VulCnt{ get; set; }

        /// <summary>
        /// <p>木马告警成功数</p>
        /// </summary>
        [JsonProperty("MalwareAlarmCnt")]
        public long? MalwareAlarmCnt{ get; set; }

        /// <summary>
        /// <p>爆破告警成功数</p>
        /// </summary>
        [JsonProperty("BruteAlarmCnt")]
        public long? BruteAlarmCnt{ get; set; }

        /// <summary>
        /// <p>自动隔离木马数(成功)</p>
        /// </summary>
        [JsonProperty("AutoIsolateMalwareCnt")]
        public long? AutoIsolateMalwareCnt{ get; set; }

        /// <summary>
        /// <p>自动阻断数(成功)</p>
        /// </summary>
        [JsonProperty("AutoBlockBruteCnt")]
        public long? AutoBlockBruteCnt{ get; set; }

        /// <summary>
        /// <p>自动防御漏洞数(成功)</p>
        /// </summary>
        [JsonProperty("AutoDefenceCnt")]
        public long? AutoDefenceCnt{ get; set; }

        /// <summary>
        /// <p>漏洞自动修复数</p>
        /// </summary>
        [JsonProperty("AutoVulFixCnt")]
        public long? AutoVulFixCnt{ get; set; }

        /// <summary>
        /// <p>java内存码告警数</p>
        /// </summary>
        [JsonProperty("JavaShellCnt")]
        public long? JavaShellCnt{ get; set; }

        /// <summary>
        /// <p>核心文件监控告警数</p>
        /// </summary>
        [JsonProperty("FileTamperCnt")]
        public long? FileTamperCnt{ get; set; }

        /// <summary>
        /// <p>事件调查数</p>
        /// </summary>
        [JsonProperty("EventCnt")]
        public long? EventCnt{ get; set; }

        /// <summary>
        /// <p>恶意请求事件数</p>
        /// </summary>
        [JsonProperty("DnsCnt")]
        public long? DnsCnt{ get; set; }

        /// <summary>
        /// <p>高危命令事件数</p>
        /// </summary>
        [JsonProperty("BashCnt")]
        public long? BashCnt{ get; set; }

        /// <summary>
        /// <p>云服务器厂商类型</p>
        /// </summary>
        [JsonProperty("CloudFrom")]
        public CloudFromCnt[] CloudFrom{ get; set; }

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
            this.SetParamSimple(map, prefix + "IsShow", this.IsShow);
            this.SetParamSimple(map, prefix + "AddMachineCnt", this.AddMachineCnt);
            this.SetParamSimple(map, prefix + "BaselineRiskCnt", this.BaselineRiskCnt);
            this.SetParamSimple(map, prefix + "VulCnt", this.VulCnt);
            this.SetParamSimple(map, prefix + "MalwareAlarmCnt", this.MalwareAlarmCnt);
            this.SetParamSimple(map, prefix + "BruteAlarmCnt", this.BruteAlarmCnt);
            this.SetParamSimple(map, prefix + "AutoIsolateMalwareCnt", this.AutoIsolateMalwareCnt);
            this.SetParamSimple(map, prefix + "AutoBlockBruteCnt", this.AutoBlockBruteCnt);
            this.SetParamSimple(map, prefix + "AutoDefenceCnt", this.AutoDefenceCnt);
            this.SetParamSimple(map, prefix + "AutoVulFixCnt", this.AutoVulFixCnt);
            this.SetParamSimple(map, prefix + "JavaShellCnt", this.JavaShellCnt);
            this.SetParamSimple(map, prefix + "FileTamperCnt", this.FileTamperCnt);
            this.SetParamSimple(map, prefix + "EventCnt", this.EventCnt);
            this.SetParamSimple(map, prefix + "DnsCnt", this.DnsCnt);
            this.SetParamSimple(map, prefix + "BashCnt", this.BashCnt);
            this.SetParamArrayObj(map, prefix + "CloudFrom.", this.CloudFrom);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

