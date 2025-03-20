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

    public class DescribeVirusDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 镜像ID
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 木马文件大小
        /// </summary>
        [JsonProperty("Size")]
        public ulong? Size{ get; set; }

        /// <summary>
        /// 木马文件路径
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// 最近生成时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 病毒名称
        /// </summary>
        [JsonProperty("VirusName")]
        public string VirusName{ get; set; }

        /// <summary>
        /// 风险等级 RISK_CRITICAL, RISK_HIGH, RISK_MEDIUM, RISK_LOW, RISK_NOTICE。
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// 容器名称
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// 容器id
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// 主机名称
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 主机id
        /// </summary>
        [JsonProperty("HostId")]
        public string HostId{ get; set; }

        /// <summary>
        /// 进程名称
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// 进程路径
        /// </summary>
        [JsonProperty("ProcessPath")]
        public string ProcessPath{ get; set; }

        /// <summary>
        /// 进程md5
        /// </summary>
        [JsonProperty("ProcessMd5")]
        public string ProcessMd5{ get; set; }

        /// <summary>
        /// 进程id
        /// </summary>
        [JsonProperty("ProcessId")]
        public ulong? ProcessId{ get; set; }

        /// <summary>
        /// 进程参数
        /// </summary>
        [JsonProperty("ProcessArgv")]
        public string ProcessArgv{ get; set; }

        /// <summary>
        /// 进程链
        /// </summary>
        [JsonProperty("ProcessChan")]
        public string ProcessChan{ get; set; }

        /// <summary>
        /// 进程组
        /// </summary>
        [JsonProperty("ProcessAccountGroup")]
        public string ProcessAccountGroup{ get; set; }

        /// <summary>
        /// 进程启动用户
        /// </summary>
        [JsonProperty("ProcessStartAccount")]
        public string ProcessStartAccount{ get; set; }

        /// <summary>
        /// 进程文件权限
        /// </summary>
        [JsonProperty("ProcessFileAuthority")]
        public string ProcessFileAuthority{ get; set; }

        /// <summary>
        /// 来源：0：一键扫描， 1：定时扫描 2：实时监控
        /// </summary>
        [JsonProperty("SourceType")]
        public long? SourceType{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 事件描述
        /// </summary>
        [JsonProperty("HarmDescribe")]
        public string HarmDescribe{ get; set; }

        /// <summary>
        /// 建议方案
        /// </summary>
        [JsonProperty("SuggestScheme")]
        public string SuggestScheme{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Mark")]
        public string Mark{ get; set; }

        /// <summary>
        /// 风险文件名称
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 文件MD5
        /// </summary>
        [JsonProperty("FileMd5")]
        public string FileMd5{ get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// DEAL_NONE:文件待处理
        /// DEAL_IGNORE:已经忽略
        /// DEAL_ADD_WHITELIST:加白
        /// DEAL_DEL:文件已经删除
        /// DEAL_ISOLATE:已经隔离
        /// DEAL_ISOLATING:隔离中
        /// DEAL_ISOLATE_FAILED:隔离失败
        /// DEAL_RECOVERING:恢复中
        /// DEAL_RECOVER_FAILED: 恢复失败
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 失败子状态:
        /// FILE_NOT_FOUND:文件不存在
        /// FILE_ABNORMAL:文件异常
        /// FILE_ABNORMAL_DEAL_RECOVER:恢复文件时，文件异常
        /// BACKUP_FILE_NOT_FOUND:备份文件不存在
        /// CONTAINER_NOT_FOUND_DEAL_ISOLATE:隔离时，容器不存在
        /// CONTAINER_NOT_FOUND_DEAL_RECOVER:恢复时，容器不存在
        /// </summary>
        [JsonProperty("SubStatus")]
        public string SubStatus{ get; set; }

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
        /// 父进程启动用户
        /// </summary>
        [JsonProperty("PProcessStartUser")]
        public string PProcessStartUser{ get; set; }

        /// <summary>
        /// 父进程用户组
        /// </summary>
        [JsonProperty("PProcessUserGroup")]
        public string PProcessUserGroup{ get; set; }

        /// <summary>
        /// 父进程路径
        /// </summary>
        [JsonProperty("PProcessPath")]
        public string PProcessPath{ get; set; }

        /// <summary>
        /// 父进程命令行参数
        /// </summary>
        [JsonProperty("PProcessParam")]
        public string PProcessParam{ get; set; }

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
        /// 事件最后一次处理的时间
        /// </summary>
        [JsonProperty("OperationTime")]
        public string OperationTime{ get; set; }

        /// <summary>
        /// 容器隔离状态
        /// </summary>
        [JsonProperty("ContainerNetStatus")]
        public string ContainerNetStatus{ get; set; }

        /// <summary>
        /// 容器隔离子状态
        /// </summary>
        [JsonProperty("ContainerNetSubStatus")]
        public string ContainerNetSubStatus{ get; set; }

        /// <summary>
        /// 容器隔离操作来源
        /// </summary>
        [JsonProperty("ContainerIsolateOperationSrc")]
        public string ContainerIsolateOperationSrc{ get; set; }

        /// <summary>
        /// 检测平台
        /// 1: 云查杀引擎
        /// 2: tav
        /// 3: binaryAi
        /// 4: 异常行为
        /// 5: 威胁情报
        /// </summary>
        [JsonProperty("CheckPlatform")]
        public string[] CheckPlatform{ get; set; }

        /// <summary>
        /// 文件访问时间
        /// </summary>
        [JsonProperty("FileAccessTime")]
        public string FileAccessTime{ get; set; }

        /// <summary>
        /// 文件修改时间
        /// </summary>
        [JsonProperty("FileModifyTime")]
        public string FileModifyTime{ get; set; }

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
        /// 集群id
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// pod ip
        /// </summary>
        [JsonProperty("PodIP")]
        public string PodIP{ get; set; }

        /// <summary>
        /// pod状态
        /// </summary>
        [JsonProperty("PodStatus")]
        public string PodStatus{ get; set; }

        /// <summary>
        /// 节点唯一ID
        /// </summary>
        [JsonProperty("NodeUniqueID")]
        public string NodeUniqueID{ get; set; }

        /// <summary>
        /// 节点类型：NORMAL普通节点、SUPER超级节点
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 节点ID
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
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "VirusName", this.VirusName);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostId", this.HostId);
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "ProcessPath", this.ProcessPath);
            this.SetParamSimple(map, prefix + "ProcessMd5", this.ProcessMd5);
            this.SetParamSimple(map, prefix + "ProcessId", this.ProcessId);
            this.SetParamSimple(map, prefix + "ProcessArgv", this.ProcessArgv);
            this.SetParamSimple(map, prefix + "ProcessChan", this.ProcessChan);
            this.SetParamSimple(map, prefix + "ProcessAccountGroup", this.ProcessAccountGroup);
            this.SetParamSimple(map, prefix + "ProcessStartAccount", this.ProcessStartAccount);
            this.SetParamSimple(map, prefix + "ProcessFileAuthority", this.ProcessFileAuthority);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "HarmDescribe", this.HarmDescribe);
            this.SetParamSimple(map, prefix + "SuggestScheme", this.SuggestScheme);
            this.SetParamSimple(map, prefix + "Mark", this.Mark);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileMd5", this.FileMd5);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SubStatus", this.SubStatus);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "ClientIP", this.ClientIP);
            this.SetParamSimple(map, prefix + "PProcessStartUser", this.PProcessStartUser);
            this.SetParamSimple(map, prefix + "PProcessUserGroup", this.PProcessUserGroup);
            this.SetParamSimple(map, prefix + "PProcessPath", this.PProcessPath);
            this.SetParamSimple(map, prefix + "PProcessParam", this.PProcessParam);
            this.SetParamSimple(map, prefix + "AncestorProcessStartUser", this.AncestorProcessStartUser);
            this.SetParamSimple(map, prefix + "AncestorProcessUserGroup", this.AncestorProcessUserGroup);
            this.SetParamSimple(map, prefix + "AncestorProcessPath", this.AncestorProcessPath);
            this.SetParamSimple(map, prefix + "AncestorProcessParam", this.AncestorProcessParam);
            this.SetParamSimple(map, prefix + "OperationTime", this.OperationTime);
            this.SetParamSimple(map, prefix + "ContainerNetStatus", this.ContainerNetStatus);
            this.SetParamSimple(map, prefix + "ContainerNetSubStatus", this.ContainerNetSubStatus);
            this.SetParamSimple(map, prefix + "ContainerIsolateOperationSrc", this.ContainerIsolateOperationSrc);
            this.SetParamArraySimple(map, prefix + "CheckPlatform.", this.CheckPlatform);
            this.SetParamSimple(map, prefix + "FileAccessTime", this.FileAccessTime);
            this.SetParamSimple(map, prefix + "FileModifyTime", this.FileModifyTime);
            this.SetParamSimple(map, prefix + "NodeSubNetID", this.NodeSubNetID);
            this.SetParamSimple(map, prefix + "NodeSubNetName", this.NodeSubNetName);
            this.SetParamSimple(map, prefix + "NodeSubNetCIDR", this.NodeSubNetCIDR);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "PodIP", this.PodIP);
            this.SetParamSimple(map, prefix + "PodStatus", this.PodStatus);
            this.SetParamSimple(map, prefix + "NodeUniqueID", this.NodeUniqueID);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NodeID", this.NodeID);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "WorkloadType", this.WorkloadType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

