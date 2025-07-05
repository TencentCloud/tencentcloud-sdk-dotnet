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

    public class CreateAssetImageScanTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 是否扫描全部镜像；全部镜像，镜像列表和根据过滤条件筛选三选一。
        /// </summary>
        [JsonProperty("All")]
        [System.Obsolete]
        public bool? All{ get; set; }

        /// <summary>
        /// 需要扫描的镜像列表；全部镜像，镜像列表和根据过滤条件筛选三选一。
        /// </summary>
        [JsonProperty("Images")]
        public string[] Images{ get; set; }

        /// <summary>
        /// 扫描漏洞；漏洞，木马和风险需选其一
        /// </summary>
        [JsonProperty("ScanVul")]
        public bool? ScanVul{ get; set; }

        /// <summary>
        /// 扫描木马；漏洞，木马和风险需选其一
        /// </summary>
        [JsonProperty("ScanVirus")]
        public bool? ScanVirus{ get; set; }

        /// <summary>
        /// 扫描风险；漏洞，木马和风险需选其一
        /// </summary>
        [JsonProperty("ScanRisk")]
        public bool? ScanRisk{ get; set; }

        /// <summary>
        /// 根据过滤条件筛选出镜像；全部镜像，镜像列表和根据过滤条件筛选三选一。
        /// </summary>
        [JsonProperty("Filters")]
        public AssetFilters[] Filters{ get; set; }

        /// <summary>
        /// 根据过滤条件筛选出镜像，再排除个别镜像
        /// </summary>
        [JsonProperty("ExcludeImageIds")]
        public string[] ExcludeImageIds{ get; set; }

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
        /// 任务超时时长单位秒，默认1小时
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// 一键扫描任务。默认false表示非一键扫描，true一键扫描
        /// </summary>
        [JsonProperty("IsOneClickScanningTask")]
        public bool? IsOneClickScanningTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "All", this.All);
            this.SetParamArraySimple(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "ScanVul", this.ScanVul);
            this.SetParamSimple(map, prefix + "ScanVirus", this.ScanVirus);
            this.SetParamSimple(map, prefix + "ScanRisk", this.ScanRisk);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "ExcludeImageIds.", this.ExcludeImageIds);
            this.SetParamSimple(map, prefix + "ContainerRunning", this.ContainerRunning);
            this.SetParamSimple(map, prefix + "ScanScope", this.ScanScope);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "IsOneClickScanningTask", this.IsOneClickScanningTask);
        }
    }
}

