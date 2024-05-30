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

    public class UpdateImageRegistryTimingScanTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 定时扫描周期
        /// </summary>
        [JsonProperty("ScanPeriod")]
        public ulong? ScanPeriod{ get; set; }

        /// <summary>
        /// 定时扫描开关
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// 定时扫描的时间
        /// </summary>
        [JsonProperty("ScanTime")]
        public string ScanTime{ get; set; }

        /// <summary>
        /// 扫描木马类型数组
        /// </summary>
        [JsonProperty("ScanType")]
        public string[] ScanType{ get; set; }

        /// <summary>
        /// 扫描镜像
        /// </summary>
        [JsonProperty("Images")]
        public ImageInfo[] Images{ get; set; }

        /// <summary>
        /// 是否扫描所有
        /// </summary>
        [JsonProperty("All")]
        [System.Obsolete]
        public bool? All{ get; set; }

        /// <summary>
        /// 扫描镜像Id
        /// </summary>
        [JsonProperty("Id")]
        public ulong?[] Id{ get; set; }

        /// <summary>
        /// 是否扫描最新版本
        /// </summary>
        [JsonProperty("Latest")]
        public bool? Latest{ get; set; }

        /// <summary>
        /// 是否存在运行中的容器
        /// </summary>
        [JsonProperty("ContainerRunning")]
        public bool? ContainerRunning{ get; set; }

        /// <summary>
        /// 扫描结束时间
        /// </summary>
        [JsonProperty("ScanEndTime")]
        public string ScanEndTime{ get; set; }

        /// <summary>
        /// 扫描范围 0全部镜像，1自选镜像，2推荐扫描镜像
        /// </summary>
        [JsonProperty("ScanScope")]
        public ulong? ScanScope{ get; set; }

        /// <summary>
        /// 仓库类型 tcr,ccr,harbor
        /// </summary>
        [JsonProperty("RegistryType")]
        public string[] RegistryType{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string[] Namespace{ get; set; }

        /// <summary>
        /// 排除的镜像资产id
        /// </summary>
        [JsonProperty("ExcludeImageAssetIds")]
        public ulong?[] ExcludeImageAssetIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScanPeriod", this.ScanPeriod);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "ScanTime", this.ScanTime);
            this.SetParamArraySimple(map, prefix + "ScanType.", this.ScanType);
            this.SetParamArrayObj(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "All", this.All);
            this.SetParamArraySimple(map, prefix + "Id.", this.Id);
            this.SetParamSimple(map, prefix + "Latest", this.Latest);
            this.SetParamSimple(map, prefix + "ContainerRunning", this.ContainerRunning);
            this.SetParamSimple(map, prefix + "ScanEndTime", this.ScanEndTime);
            this.SetParamSimple(map, prefix + "ScanScope", this.ScanScope);
            this.SetParamArraySimple(map, prefix + "RegistryType.", this.RegistryType);
            this.SetParamArraySimple(map, prefix + "Namespace.", this.Namespace);
            this.SetParamArraySimple(map, prefix + "ExcludeImageAssetIds.", this.ExcludeImageAssetIds);
        }
    }
}

