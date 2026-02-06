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

    public class CreateAssetImageRegistryScanTaskOneKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// 是否扫描全部镜像(废弃)
        /// </summary>
        [JsonProperty("All")]
        [System.Obsolete]
        public bool? All{ get; set; }

        /// <summary>
        /// 扫描的镜像列表
        /// </summary>
        [JsonProperty("Images")]
        public ImageInfo[] Images{ get; set; }

        /// <summary>
        /// 扫描类型数组
        /// </summary>
        [JsonProperty("ScanType")]
        public string[] ScanType{ get; set; }

        /// <summary>
        /// 扫描的镜像列表Id
        /// </summary>
        [JsonProperty("Id")]
        public ulong?[] Id{ get; set; }

        /// <summary>
        /// 剔除扫描的镜像id列表
        /// </summary>
        [JsonProperty("ExcludeIDs")]
        public ulong?[] ExcludeIDs{ get; set; }

        /// <summary>
        /// 是否最新镜像
        /// </summary>
        [JsonProperty("IsLatest")]
        public bool? IsLatest{ get; set; }

        /// <summary>
        /// 扫描范围 0全部镜像，1自选镜像，2推荐扫描镜像
        /// </summary>
        [JsonProperty("ScanScope")]
        public ulong? ScanScope{ get; set; }

        /// <summary>
        /// 仓库类型
        /// </summary>
        [JsonProperty("RegistryType")]
        public string[] RegistryType{ get; set; }

        /// <summary>
        /// 命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string[] Namespace{ get; set; }

        /// <summary>
        /// 是否存在运行中的容器
        /// </summary>
        [JsonProperty("ContainerRunning")]
        public bool? ContainerRunning{ get; set; }

        /// <summary>
        /// 任务超时时长单位s
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "All", this.All);
            this.SetParamArrayObj(map, prefix + "Images.", this.Images);
            this.SetParamArraySimple(map, prefix + "ScanType.", this.ScanType);
            this.SetParamArraySimple(map, prefix + "Id.", this.Id);
            this.SetParamArraySimple(map, prefix + "ExcludeIDs.", this.ExcludeIDs);
            this.SetParamSimple(map, prefix + "IsLatest", this.IsLatest);
            this.SetParamSimple(map, prefix + "ScanScope", this.ScanScope);
            this.SetParamArraySimple(map, prefix + "RegistryType.", this.RegistryType);
            this.SetParamArraySimple(map, prefix + "Namespace.", this.Namespace);
            this.SetParamSimple(map, prefix + "ContainerRunning", this.ContainerRunning);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
        }
    }
}

