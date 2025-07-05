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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAssetImageScanSettingRequest : AbstractModel
    {
        
        /// <summary>
        /// 开关
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// 扫描开始时间
        /// 01:00 时分
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }

        /// <summary>
        /// 扫描周期
        /// </summary>
        [JsonProperty("ScanPeriod")]
        public ulong? ScanPeriod{ get; set; }

        /// <summary>
        /// 扫描木马
        /// </summary>
        [JsonProperty("ScanVirus")]
        public bool? ScanVirus{ get; set; }

        /// <summary>
        /// 扫描敏感信息
        /// </summary>
        [JsonProperty("ScanRisk")]
        public bool? ScanRisk{ get; set; }

        /// <summary>
        /// 扫描漏洞
        /// </summary>
        [JsonProperty("ScanVul")]
        public bool? ScanVul{ get; set; }

        /// <summary>
        /// 全部镜像
        /// </summary>
        [JsonProperty("All")]
        [System.Obsolete]
        public bool? All{ get; set; }

        /// <summary>
        /// 自定义镜像
        /// </summary>
        [JsonProperty("Images")]
        public string[] Images{ get; set; }

        /// <summary>
        /// 镜像是否存在运行中的容器
        /// </summary>
        [JsonProperty("ContainerRunning")]
        public bool? ContainerRunning{ get; set; }

        /// <summary>
        /// 扫描范围 0 全部授权镜像，1自选镜像，2 推荐扫描
        /// </summary>
        [JsonProperty("ScanScope")]
        public ulong? ScanScope{ get; set; }

        /// <summary>
        /// 扫描结束时间
        /// 02:00 时分
        /// </summary>
        [JsonProperty("ScanEndTime")]
        public string ScanEndTime{ get; set; }

        /// <summary>
        /// 排除扫描的镜像
        /// </summary>
        [JsonProperty("ExcludeImages")]
        public string[] ExcludeImages{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamSimple(map, prefix + "ScanPeriod", this.ScanPeriod);
            this.SetParamSimple(map, prefix + "ScanVirus", this.ScanVirus);
            this.SetParamSimple(map, prefix + "ScanRisk", this.ScanRisk);
            this.SetParamSimple(map, prefix + "ScanVul", this.ScanVul);
            this.SetParamSimple(map, prefix + "All", this.All);
            this.SetParamArraySimple(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "ContainerRunning", this.ContainerRunning);
            this.SetParamSimple(map, prefix + "ScanScope", this.ScanScope);
            this.SetParamSimple(map, prefix + "ScanEndTime", this.ScanEndTime);
            this.SetParamArraySimple(map, prefix + "ExcludeImages.", this.ExcludeImages);
        }
    }
}

