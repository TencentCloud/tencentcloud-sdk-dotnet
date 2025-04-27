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

    public class CreateVulScanTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 本地镜像扫描范围类型。ALL:全部本地镜像，NOT_SCAN：全部已授权未扫描本地镜像，IMAGEIDS:自选本地镜像ID
        /// </summary>
        [JsonProperty("LocalImageScanType")]
        public string LocalImageScanType{ get; set; }

        /// <summary>
        /// 根据已授权的本地镜像IDs扫描，优先权高于根据满足条件的已授权的本地镜像。
        /// </summary>
        [JsonProperty("LocalImageIDs")]
        public string[] LocalImageIDs{ get; set; }

        /// <summary>
        /// 仓库镜像扫描范围类型。ALL:全部仓库镜像，NOT_SCAN：全部已授权未扫描仓库镜像，IMAGEIDS:自选仓库镜像ID
        /// </summary>
        [JsonProperty("RegistryImageScanType")]
        public string RegistryImageScanType{ get; set; }

        /// <summary>
        /// 根据已授权的仓库镜像IDs扫描，优先权高于根据满足条件的已授权的仓库镜像。
        /// </summary>
        [JsonProperty("RegistryImageIDs")]
        public ulong?[] RegistryImageIDs{ get; set; }

        /// <summary>
        /// 本地镜像重新漏洞扫描时的任务ID
        /// </summary>
        [JsonProperty("LocalTaskID")]
        public long? LocalTaskID{ get; set; }

        /// <summary>
        /// 仓库镜像重新漏洞扫描时的任务ID
        /// </summary>
        [JsonProperty("RegistryTaskID")]
        public long? RegistryTaskID{ get; set; }

        /// <summary>
        /// 本地镜像容器运行中
        /// </summary>
        [JsonProperty("LocalImageContainerRunning")]
        public bool? LocalImageContainerRunning{ get; set; }

        /// <summary>
        /// 仓库镜像容器运行中
        /// </summary>
        [JsonProperty("RegistryImageContainerRunning")]
        public bool? RegistryImageContainerRunning{ get; set; }

        /// <summary>
        /// 仓库镜像是否是最新
        /// </summary>
        [JsonProperty("IsLatest")]
        public bool? IsLatest{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LocalImageScanType", this.LocalImageScanType);
            this.SetParamArraySimple(map, prefix + "LocalImageIDs.", this.LocalImageIDs);
            this.SetParamSimple(map, prefix + "RegistryImageScanType", this.RegistryImageScanType);
            this.SetParamArraySimple(map, prefix + "RegistryImageIDs.", this.RegistryImageIDs);
            this.SetParamSimple(map, prefix + "LocalTaskID", this.LocalTaskID);
            this.SetParamSimple(map, prefix + "RegistryTaskID", this.RegistryTaskID);
            this.SetParamSimple(map, prefix + "LocalImageContainerRunning", this.LocalImageContainerRunning);
            this.SetParamSimple(map, prefix + "RegistryImageContainerRunning", this.RegistryImageContainerRunning);
            this.SetParamSimple(map, prefix + "IsLatest", this.IsLatest);
        }
    }
}

