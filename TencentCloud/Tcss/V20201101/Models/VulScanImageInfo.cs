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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulScanImageInfo : AbstractModel
    {
        
        /// <summary>
        /// 镜像ID
        /// </summary>
        [JsonProperty("ImageID")]
        public string ImageID{ get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 镜像大小
        /// </summary>
        [JsonProperty("Size")]
        public float? Size{ get; set; }

        /// <summary>
        /// 任务状态:SCANNING:扫描中 FAILED:失败 FINISHED:完成 CANCELED:取消
        /// </summary>
        [JsonProperty("ScanStatus")]
        public string ScanStatus{ get; set; }

        /// <summary>
        /// 扫描时长
        /// </summary>
        [JsonProperty("ScanDuration")]
        public float? ScanDuration{ get; set; }

        /// <summary>
        /// 高危漏洞数
        /// </summary>
        [JsonProperty("HighLevelVulCount")]
        public long? HighLevelVulCount{ get; set; }

        /// <summary>
        /// 中危漏洞数
        /// </summary>
        [JsonProperty("MediumLevelVulCount")]
        public long? MediumLevelVulCount{ get; set; }

        /// <summary>
        /// 低危漏洞数
        /// </summary>
        [JsonProperty("LowLevelVulCount")]
        public long? LowLevelVulCount{ get; set; }

        /// <summary>
        /// 严重漏洞数
        /// </summary>
        [JsonProperty("CriticalLevelVulCount")]
        public long? CriticalLevelVulCount{ get; set; }

        /// <summary>
        /// 本地镜像漏洞扫描任务ID
        /// </summary>
        [JsonProperty("TaskID")]
        public long? TaskID{ get; set; }

        /// <summary>
        /// 漏洞扫描的开始时间
        /// </summary>
        [JsonProperty("ScanStartTime")]
        public string ScanStartTime{ get; set; }

        /// <summary>
        /// 漏洞扫描的结束时间
        /// </summary>
        [JsonProperty("ScanEndTime")]
        public string ScanEndTime{ get; set; }

        /// <summary>
        /// 失败原因:TIMEOUT:超时 TOO_MANY:任务过多 OFFLINE:离线
        /// </summary>
        [JsonProperty("ErrorStatus")]
        public string ErrorStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageID", this.ImageID);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "ScanStatus", this.ScanStatus);
            this.SetParamSimple(map, prefix + "ScanDuration", this.ScanDuration);
            this.SetParamSimple(map, prefix + "HighLevelVulCount", this.HighLevelVulCount);
            this.SetParamSimple(map, prefix + "MediumLevelVulCount", this.MediumLevelVulCount);
            this.SetParamSimple(map, prefix + "LowLevelVulCount", this.LowLevelVulCount);
            this.SetParamSimple(map, prefix + "CriticalLevelVulCount", this.CriticalLevelVulCount);
            this.SetParamSimple(map, prefix + "TaskID", this.TaskID);
            this.SetParamSimple(map, prefix + "ScanStartTime", this.ScanStartTime);
            this.SetParamSimple(map, prefix + "ScanEndTime", this.ScanEndTime);
            this.SetParamSimple(map, prefix + "ErrorStatus", this.ErrorStatus);
        }
    }
}

