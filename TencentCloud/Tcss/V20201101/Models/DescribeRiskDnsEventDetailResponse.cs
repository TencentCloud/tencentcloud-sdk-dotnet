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

    public class DescribeRiskDnsEventDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 事件ID
        /// </summary>
        [JsonProperty("EventID")]
        public ulong? EventID{ get; set; }

        /// <summary>
        /// 事件类型，恶意域名请求：DOMAIN，恶意IP请求：IP
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// 恶意请求次数
        /// </summary>
        [JsonProperty("EventCount")]
        public ulong? EventCount{ get; set; }

        /// <summary>
        /// 首次发现时间
        /// </summary>
        [JsonProperty("FoundTime")]
        public string FoundTime{ get; set; }

        /// <summary>
        /// 最近生成时间
        /// </summary>
        [JsonProperty("LatestFoundTime")]
        public string LatestFoundTime{ get; set; }

        /// <summary>
        /// 容器ID
        /// </summary>
        [JsonProperty("ContainerID")]
        public string ContainerID{ get; set; }

        /// <summary>
        /// 容器名称
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// 隔离状态
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
        /// 容器状态
        /// 正在运行: RUNNING
        /// 暂停: PAUSED
        /// 停止: STOPPED
        /// 已经创建: CREATED
        /// 已经销毁: DESTROYED
        /// 正在重启中: RESTARTING
        /// 迁移中: REMOVING
        /// </summary>
        [JsonProperty("ContainerStatus")]
        public string ContainerStatus{ get; set; }

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
        /// 主机名称
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 内网IP
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// 外网IP
        /// </summary>
        [JsonProperty("PublicIP")]
        public string PublicIP{ get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// 事件描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 解决方案
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// 参考链接
        /// </summary>
        [JsonProperty("Reference")]
        public string[] Reference{ get; set; }

        /// <summary>
        /// 恶意域名或IP
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 恶意IP所属城市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 命中规则类型
        /// SYSTEM：系统规则
        ///  USER：用户自定义
        /// </summary>
        [JsonProperty("MatchRuleType")]
        public string MatchRuleType{ get; set; }

        /// <summary>
        /// 标签特征
        /// </summary>
        [JsonProperty("FeatureLabel")]
        public string FeatureLabel{ get; set; }

        /// <summary>
        /// 进程权限
        /// </summary>
        [JsonProperty("ProcessAuthority")]
        public string ProcessAuthority{ get; set; }

        /// <summary>
        /// 进程md5
        /// </summary>
        [JsonProperty("ProcessMd5")]
        public string ProcessMd5{ get; set; }

        /// <summary>
        /// 进程启动用户
        /// </summary>
        [JsonProperty("ProcessStartUser")]
        public string ProcessStartUser{ get; set; }

        /// <summary>
        /// 进程用户组
        /// </summary>
        [JsonProperty("ProcessUserGroup")]
        public string ProcessUserGroup{ get; set; }

        /// <summary>
        /// 进程路径
        /// </summary>
        [JsonProperty("ProcessPath")]
        public string ProcessPath{ get; set; }

        /// <summary>
        /// 进程树
        /// </summary>
        [JsonProperty("ProcessTree")]
        public string ProcessTree{ get; set; }

        /// <summary>
        /// 进程命令行参数
        /// </summary>
        [JsonProperty("ProcessParam")]
        public string ProcessParam{ get; set; }

        /// <summary>
        /// 父进程启动用户
        /// </summary>
        [JsonProperty("ParentProcessStartUser")]
        public string ParentProcessStartUser{ get; set; }

        /// <summary>
        /// 父进程用户组
        /// </summary>
        [JsonProperty("ParentProcessUserGroup")]
        public string ParentProcessUserGroup{ get; set; }

        /// <summary>
        /// 父进程路径
        /// </summary>
        [JsonProperty("ParentProcessPath")]
        public string ParentProcessPath{ get; set; }

        /// <summary>
        /// 父进程命令行参数
        /// </summary>
        [JsonProperty("ParentProcessParam")]
        public string ParentProcessParam{ get; set; }

        /// <summary>
        /// 祖先进程启动用户
        /// </summary>
        [JsonProperty("AncestorProcessStartUser")]
        public string AncestorProcessStartUser{ get; set; }

        /// <summary>
        /// 祖先进程用户组
        /// </summary>
        [JsonProperty("AncestorProcessUserGroup")]
        public string AncestorProcessUserGroup{ get; set; }

        /// <summary>
        /// 祖先进程路径
        /// </summary>
        [JsonProperty("AncestorProcessPath")]
        public string AncestorProcessPath{ get; set; }

        /// <summary>
        /// 祖先进程命令行参数
        /// </summary>
        [JsonProperty("AncestorProcessParam")]
        public string AncestorProcessParam{ get; set; }

        /// <summary>
        /// 主机ID
        /// </summary>
        [JsonProperty("HostID")]
        public string HostID{ get; set; }

        /// <summary>
        /// 事件状态
        /// EVENT_UNDEAL： 待处理
        /// EVENT_DEALED：已处理
        /// EVENT_IGNORE： 已忽略
        /// EVENT_ADD_WHITE：已加白
        /// </summary>
        [JsonProperty("EventStatus")]
        public string EventStatus{ get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [JsonProperty("OperationTime")]
        public string OperationTime{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

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
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// podip
        /// </summary>
        [JsonProperty("PodIP")]
        public string PodIP{ get; set; }

        /// <summary>
        /// pod状态
        /// </summary>
        [JsonProperty("PodStatus")]
        public string PodStatus{ get; set; }

        /// <summary>
        /// 节点唯一id
        /// </summary>
        [JsonProperty("NodeUniqueID")]
        public string NodeUniqueID{ get; set; }

        /// <summary>
        /// 节点ID名称
        /// </summary>
        [JsonProperty("NodeID")]
        public string NodeID{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Namespace
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 工作负载类型
        /// </summary>
        [JsonProperty("WorkloadType")]
        public string WorkloadType{ get; set; }

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
            this.SetParamSimple(map, prefix + "EventID", this.EventID);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "FoundTime", this.FoundTime);
            this.SetParamSimple(map, prefix + "LatestFoundTime", this.LatestFoundTime);
            this.SetParamSimple(map, prefix + "ContainerID", this.ContainerID);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "ContainerNetStatus", this.ContainerNetStatus);
            this.SetParamSimple(map, prefix + "ContainerStatus", this.ContainerStatus);
            this.SetParamSimple(map, prefix + "ContainerNetSubStatus", this.ContainerNetSubStatus);
            this.SetParamSimple(map, prefix + "ContainerIsolateOperationSrc", this.ContainerIsolateOperationSrc);
            this.SetParamSimple(map, prefix + "ImageID", this.ImageID);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "PublicIP", this.PublicIP);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Solution", this.Solution);
            this.SetParamArraySimple(map, prefix + "Reference.", this.Reference);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "MatchRuleType", this.MatchRuleType);
            this.SetParamSimple(map, prefix + "FeatureLabel", this.FeatureLabel);
            this.SetParamSimple(map, prefix + "ProcessAuthority", this.ProcessAuthority);
            this.SetParamSimple(map, prefix + "ProcessMd5", this.ProcessMd5);
            this.SetParamSimple(map, prefix + "ProcessStartUser", this.ProcessStartUser);
            this.SetParamSimple(map, prefix + "ProcessUserGroup", this.ProcessUserGroup);
            this.SetParamSimple(map, prefix + "ProcessPath", this.ProcessPath);
            this.SetParamSimple(map, prefix + "ProcessTree", this.ProcessTree);
            this.SetParamSimple(map, prefix + "ProcessParam", this.ProcessParam);
            this.SetParamSimple(map, prefix + "ParentProcessStartUser", this.ParentProcessStartUser);
            this.SetParamSimple(map, prefix + "ParentProcessUserGroup", this.ParentProcessUserGroup);
            this.SetParamSimple(map, prefix + "ParentProcessPath", this.ParentProcessPath);
            this.SetParamSimple(map, prefix + "ParentProcessParam", this.ParentProcessParam);
            this.SetParamSimple(map, prefix + "AncestorProcessStartUser", this.AncestorProcessStartUser);
            this.SetParamSimple(map, prefix + "AncestorProcessUserGroup", this.AncestorProcessUserGroup);
            this.SetParamSimple(map, prefix + "AncestorProcessPath", this.AncestorProcessPath);
            this.SetParamSimple(map, prefix + "AncestorProcessParam", this.AncestorProcessParam);
            this.SetParamSimple(map, prefix + "HostID", this.HostID);
            this.SetParamSimple(map, prefix + "EventStatus", this.EventStatus);
            this.SetParamSimple(map, prefix + "OperationTime", this.OperationTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "NodeSubNetID", this.NodeSubNetID);
            this.SetParamSimple(map, prefix + "NodeSubNetName", this.NodeSubNetName);
            this.SetParamSimple(map, prefix + "NodeSubNetCIDR", this.NodeSubNetCIDR);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "PodIP", this.PodIP);
            this.SetParamSimple(map, prefix + "PodStatus", this.PodStatus);
            this.SetParamSimple(map, prefix + "NodeUniqueID", this.NodeUniqueID);
            this.SetParamSimple(map, prefix + "NodeID", this.NodeID);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "WorkloadType", this.WorkloadType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

