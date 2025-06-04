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

    public class RunTimeEventBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// 事件唯一ID
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// 事件发现时间
        /// </summary>
        [JsonProperty("FoundTime")]
        public string FoundTime{ get; set; }

        /// <summary>
        /// 容器id
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// 容器名称
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// 镜像id
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 状态， “EVENT_UNDEAL”:事件未处理
        ///     "EVENT_DEALED":事件已经处理
        ///     "EVENT_INGNORE"：事件已经忽略
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 事件名称：
        /// 宿主机文件访问逃逸、
        /// Syscall逃逸、
        /// MountNamespace逃逸、
        /// 程序提权逃逸、
        /// 特权容器启动逃逸、
        /// 敏感路径挂载
        /// 恶意进程启动
        /// 文件篡改
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// 事件类型
        ///    ESCAPE_HOST_ACESS_FILE:宿主机文件访问逃逸
        ///    ESCAPE_MOUNT_NAMESPACE:MountNamespace逃逸
        ///    ESCAPE_PRIVILEDGE:程序提权逃逸
        ///    ESCAPE_PRIVILEDGE_CONTAINER_START:特权容器启动逃逸
        ///    ESCAPE_MOUNT_SENSITIVE_PTAH:敏感路径挂载
        ///    ESCAPE_SYSCALL:Syscall逃逸
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// 事件数量
        /// </summary>
        [JsonProperty("EventCount")]
        public long? EventCount{ get; set; }

        /// <summary>
        /// 最近生成时间
        /// </summary>
        [JsonProperty("LatestFoundTime")]
        public string LatestFoundTime{ get; set; }

        /// <summary>
        /// 内网ip
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// 外网ip
        /// </summary>
        [JsonProperty("ClientIP")]
        public string ClientIP{ get; set; }

        /// <summary>
        /// 网络状态
        /// 未隔离  	NORMAL
        /// 已隔离		ISOLATED
        /// 隔离中		ISOLATING
        /// 隔离失败	ISOLATE_FAILED
        /// 解除隔离中  RESTORING
        /// 解除隔离失败 RESTORE_FAILED
        /// </summary>
        [JsonProperty("ContainerNetStatus")]
        public string ContainerNetStatus{ get; set; }

        /// <summary>
        /// 容器子状态
        /// "AGENT_OFFLINE"       //Agent离线
        /// "NODE_DESTROYED"      //节点已销毁
        /// "CONTAINER_EXITED"    //容器已退出
        /// "CONTAINER_DESTROYED" //容器已销毁
        /// "SHARED_HOST"         // 容器与主机共享网络
        /// "RESOURCE_LIMIT"      //隔离操作资源超限
        /// "UNKNOW"              // 原因未知
        /// </summary>
        [JsonProperty("ContainerNetSubStatus")]
        public string ContainerNetSubStatus{ get; set; }

        /// <summary>
        /// 容器隔离操作来源
        /// </summary>
        [JsonProperty("ContainerIsolateOperationSrc")]
        public string ContainerIsolateOperationSrc{ get; set; }

        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("NodeID")]
        public string NodeID{ get; set; }

        /// <summary>
        /// 节点类型:NORMAL:普通节点;SUPER:超级节点
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 节点子网ID
        /// </summary>
        [JsonProperty("NodeSubNetID")]
        public string NodeSubNetID{ get; set; }

        /// <summary>
        /// 节点子网名称
        /// </summary>
        [JsonProperty("NodeSubNetName")]
        public string NodeSubNetName{ get; set; }

        /// <summary>
        /// 节点子网网段
        /// </summary>
        [JsonProperty("NodeSubNetCIDR")]
        public string NodeSubNetCIDR{ get; set; }

        /// <summary>
        /// pod名称
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// podIP
        /// </summary>
        [JsonProperty("PodIP")]
        public string PodIP{ get; set; }

        /// <summary>
        /// pod状态
        /// </summary>
        [JsonProperty("PodStatus")]
        public string PodStatus{ get; set; }

        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 节点唯一id
        /// </summary>
        [JsonProperty("NodeUniqueID")]
        public string NodeUniqueID{ get; set; }

        /// <summary>
        /// uuid
        /// </summary>
        [JsonProperty("HostID")]
        public string HostID{ get; set; }

        /// <summary>
        /// Namespace
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// WorkloadType
        /// </summary>
        [JsonProperty("WorkloadType")]
        public string WorkloadType{ get; set; }

        /// <summary>
        /// 容器运行状态
        /// </summary>
        [JsonProperty("ContainerStatus")]
        public string ContainerStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "FoundTime", this.FoundTime);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "LatestFoundTime", this.LatestFoundTime);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "ClientIP", this.ClientIP);
            this.SetParamSimple(map, prefix + "ContainerNetStatus", this.ContainerNetStatus);
            this.SetParamSimple(map, prefix + "ContainerNetSubStatus", this.ContainerNetSubStatus);
            this.SetParamSimple(map, prefix + "ContainerIsolateOperationSrc", this.ContainerIsolateOperationSrc);
            this.SetParamSimple(map, prefix + "NodeID", this.NodeID);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeSubNetID", this.NodeSubNetID);
            this.SetParamSimple(map, prefix + "NodeSubNetName", this.NodeSubNetName);
            this.SetParamSimple(map, prefix + "NodeSubNetCIDR", this.NodeSubNetCIDR);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "PodIP", this.PodIP);
            this.SetParamSimple(map, prefix + "PodStatus", this.PodStatus);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "NodeUniqueID", this.NodeUniqueID);
            this.SetParamSimple(map, prefix + "HostID", this.HostID);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "WorkloadType", this.WorkloadType);
            this.SetParamSimple(map, prefix + "ContainerStatus", this.ContainerStatus);
        }
    }
}

