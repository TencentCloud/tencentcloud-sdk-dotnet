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

    public class DescribeContainerAssetSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 容器总数
        /// </summary>
        [JsonProperty("ContainerTotalCnt")]
        public ulong? ContainerTotalCnt{ get; set; }

        /// <summary>
        /// 正在运行容器数量
        /// </summary>
        [JsonProperty("ContainerRunningCnt")]
        public ulong? ContainerRunningCnt{ get; set; }

        /// <summary>
        /// 暂停运行容器数量
        /// </summary>
        [JsonProperty("ContainerPauseCnt")]
        public ulong? ContainerPauseCnt{ get; set; }

        /// <summary>
        /// 停止运行容器数量
        /// </summary>
        [JsonProperty("ContainerStopped")]
        public ulong? ContainerStopped{ get; set; }

        /// <summary>
        /// 本地镜像数量
        /// </summary>
        [JsonProperty("ImageCnt")]
        public ulong? ImageCnt{ get; set; }

        /// <summary>
        /// 主机节点数量
        /// </summary>
        [JsonProperty("HostCnt")]
        public ulong? HostCnt{ get; set; }

        /// <summary>
        /// 主机正在运行节点数量
        /// </summary>
        [JsonProperty("HostRunningCnt")]
        public ulong? HostRunningCnt{ get; set; }

        /// <summary>
        /// 主机离线节点数量
        /// </summary>
        [JsonProperty("HostOfflineCnt")]
        public ulong? HostOfflineCnt{ get; set; }

        /// <summary>
        /// 镜像仓库数量
        /// </summary>
        [JsonProperty("ImageRegistryCnt")]
        public ulong? ImageRegistryCnt{ get; set; }

        /// <summary>
        /// 镜像总数
        /// </summary>
        [JsonProperty("ImageTotalCnt")]
        public ulong? ImageTotalCnt{ get; set; }

        /// <summary>
        /// 主机未安装agent数量
        /// </summary>
        [JsonProperty("HostUnInstallCnt")]
        public ulong? HostUnInstallCnt{ get; set; }

        /// <summary>
        /// 超级节点个数
        /// </summary>
        [JsonProperty("HostSuperNodeCnt")]
        public ulong? HostSuperNodeCnt{ get; set; }

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
            this.SetParamSimple(map, prefix + "ContainerTotalCnt", this.ContainerTotalCnt);
            this.SetParamSimple(map, prefix + "ContainerRunningCnt", this.ContainerRunningCnt);
            this.SetParamSimple(map, prefix + "ContainerPauseCnt", this.ContainerPauseCnt);
            this.SetParamSimple(map, prefix + "ContainerStopped", this.ContainerStopped);
            this.SetParamSimple(map, prefix + "ImageCnt", this.ImageCnt);
            this.SetParamSimple(map, prefix + "HostCnt", this.HostCnt);
            this.SetParamSimple(map, prefix + "HostRunningCnt", this.HostRunningCnt);
            this.SetParamSimple(map, prefix + "HostOfflineCnt", this.HostOfflineCnt);
            this.SetParamSimple(map, prefix + "ImageRegistryCnt", this.ImageRegistryCnt);
            this.SetParamSimple(map, prefix + "ImageTotalCnt", this.ImageTotalCnt);
            this.SetParamSimple(map, prefix + "HostUnInstallCnt", this.HostUnInstallCnt);
            this.SetParamSimple(map, prefix + "HostSuperNodeCnt", this.HostSuperNodeCnt);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

