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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterContainerDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>主账号AppID</p>
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// <p>容器ID</p>
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// <p>容器启动CMD</p>
        /// </summary>
        [JsonProperty("Cmd")]
        public string Cmd{ get; set; }

        /// <summary>
        /// <p>容器创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>运行状态</p>
        /// </summary>
        [JsonProperty("RunStatus")]
        public string RunStatus{ get; set; }

        /// <summary>
        /// <p>隔离状态</p>
        /// </summary>
        [JsonProperty("IsolateStatus")]
        public string IsolateStatus{ get; set; }

        /// <summary>
        /// <p>严重风险事件数</p>
        /// </summary>
        [JsonProperty("RiskEventCriticalCount")]
        [System.Obsolete]
        public long? RiskEventCriticalCount{ get; set; }

        /// <summary>
        /// <p>高风险事件数</p>
        /// </summary>
        [JsonProperty("RiskEventHighCount")]
        [System.Obsolete]
        public long? RiskEventHighCount{ get; set; }

        /// <summary>
        /// <p>中风险事件数</p>
        /// </summary>
        [JsonProperty("RiskEventMiddleCount")]
        [System.Obsolete]
        public long? RiskEventMiddleCount{ get; set; }

        /// <summary>
        /// <p>低风险事件数</p>
        /// </summary>
        [JsonProperty("RiskEventLowCount")]
        [System.Obsolete]
        public long? RiskEventLowCount{ get; set; }

        /// <summary>
        /// <p>镜像名称</p>
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// <p>镜像ID</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>镜像大小</p>
        /// </summary>
        [JsonProperty("ImageSize")]
        public string ImageSize{ get; set; }

        /// <summary>
        /// <p>镜像创建时间</p>
        /// </summary>
        [JsonProperty("ImageCreateTime")]
        public string ImageCreateTime{ get; set; }

        /// <summary>
        /// <p>节点名称</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>节点内网IP</p>
        /// </summary>
        [JsonProperty("NodeInternalIP")]
        public string NodeInternalIP{ get; set; }

        /// <summary>
        /// <p>节点运行状态</p>
        /// </summary>
        [JsonProperty("NodeRunStatus")]
        public string NodeRunStatus{ get; set; }

        /// <summary>
        /// <p>挂载信息列表</p>
        /// </summary>
        [JsonProperty("Mounts")]
        public ContainerMountItem[] Mounts{ get; set; }

        /// <summary>
        /// <p>网络名称</p>
        /// </summary>
        [JsonProperty("NetworkName")]
        public string NetworkName{ get; set; }

        /// <summary>
        /// <p>网络模式</p>
        /// </summary>
        [JsonProperty("NetworkMode")]
        public string NetworkMode{ get; set; }

        /// <summary>
        /// <p>网络ID</p>
        /// </summary>
        [JsonProperty("NetworkId")]
        public string NetworkId{ get; set; }

        /// <summary>
        /// <p>端点ID</p>
        /// </summary>
        [JsonProperty("EndpointId")]
        public string EndpointId{ get; set; }

        /// <summary>
        /// <p>网关地址</p>
        /// </summary>
        [JsonProperty("Gateway")]
        public string Gateway{ get; set; }

        /// <summary>
        /// <p>IPv4地址</p>
        /// </summary>
        [JsonProperty("IPv4")]
        public string IPv4{ get; set; }

        /// <summary>
        /// <p>IPv6地址</p>
        /// </summary>
        [JsonProperty("IPv6")]
        public string IPv6{ get; set; }

        /// <summary>
        /// <p>MAC地址</p>
        /// </summary>
        [JsonProperty("MAC")]
        public string MAC{ get; set; }

        /// <summary>
        /// <p>容器名称</p>
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// <p>节点实例ID</p>
        /// </summary>
        [JsonProperty("NodeInstanceId")]
        public string NodeInstanceId{ get; set; }

        /// <summary>
        /// <p>容器关联节点的节点类型</p>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>容器关联节点的节点唯一ID</p>
        /// </summary>
        [JsonProperty("NodeUniqueID")]
        public string NodeUniqueID{ get; set; }

        /// <summary>
        /// <p>容器关联集群的集群ca证书md5值，集群的唯一标识</p>
        /// </summary>
        [JsonProperty("ClusterCaMD5")]
        public string ClusterCaMD5{ get; set; }

        /// <summary>
        /// <p>容器镜像能否关联到镜像仓库中的记录</p>
        /// </summary>
        [JsonProperty("EnableLinkImage")]
        public bool? EnableLinkImage{ get; set; }

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
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "Cmd", this.Cmd);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "RunStatus", this.RunStatus);
            this.SetParamSimple(map, prefix + "IsolateStatus", this.IsolateStatus);
            this.SetParamSimple(map, prefix + "RiskEventCriticalCount", this.RiskEventCriticalCount);
            this.SetParamSimple(map, prefix + "RiskEventHighCount", this.RiskEventHighCount);
            this.SetParamSimple(map, prefix + "RiskEventMiddleCount", this.RiskEventMiddleCount);
            this.SetParamSimple(map, prefix + "RiskEventLowCount", this.RiskEventLowCount);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ImageSize", this.ImageSize);
            this.SetParamSimple(map, prefix + "ImageCreateTime", this.ImageCreateTime);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "NodeInternalIP", this.NodeInternalIP);
            this.SetParamSimple(map, prefix + "NodeRunStatus", this.NodeRunStatus);
            this.SetParamArrayObj(map, prefix + "Mounts.", this.Mounts);
            this.SetParamSimple(map, prefix + "NetworkName", this.NetworkName);
            this.SetParamSimple(map, prefix + "NetworkMode", this.NetworkMode);
            this.SetParamSimple(map, prefix + "NetworkId", this.NetworkId);
            this.SetParamSimple(map, prefix + "EndpointId", this.EndpointId);
            this.SetParamSimple(map, prefix + "Gateway", this.Gateway);
            this.SetParamSimple(map, prefix + "IPv4", this.IPv4);
            this.SetParamSimple(map, prefix + "IPv6", this.IPv6);
            this.SetParamSimple(map, prefix + "MAC", this.MAC);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "NodeInstanceId", this.NodeInstanceId);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeUniqueID", this.NodeUniqueID);
            this.SetParamSimple(map, prefix + "ClusterCaMD5", this.ClusterCaMD5);
            this.SetParamSimple(map, prefix + "EnableLinkImage", this.EnableLinkImage);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

