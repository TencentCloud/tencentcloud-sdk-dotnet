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

    public class AccessControlEventInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>进程名称</p>
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// <p>命中规则名称</p>
        /// </summary>
        [JsonProperty("MatchRuleName")]
        public string MatchRuleName{ get; set; }

        /// <summary>
        /// <p>生成时间</p>
        /// </summary>
        [JsonProperty("FoundTime")]
        public string FoundTime{ get; set; }

        /// <summary>
        /// <p>容器名</p>
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// <p>镜像名</p>
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// <p>动作执行结果，   BEHAVIOR_NONE: 无<br>    BEHAVIOR_ALERT: 告警<br>    BEHAVIOR_RELEASE：放行<br>    BEHAVIOR_HOLDUP_FAILED:拦截失败<br>    BEHAVIOR_HOLDUP_SUCCESSED：拦截失败</p>
        /// </summary>
        [JsonProperty("Behavior")]
        public string Behavior{ get; set; }

        /// <summary>
        /// <p>状态0:未处理  “EVENT_UNDEAL”:事件未处理<br>    &quot;EVENT_DEALED&quot;:事件已经处理<br>    &quot;EVENT_INGNORE&quot;：事件已经忽略</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>事件记录的唯一id</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>文件名称</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>事件类型， FILE_ABNORMAL_READ:文件异常读取</p>
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// <p>镜像id, 用于跳转</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>容器id, 用于跳转</p>
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// <p>事件解决方案</p>
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// <p>事件详细描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>命中策略id</p>
        /// </summary>
        [JsonProperty("MatchRuleId")]
        public string MatchRuleId{ get; set; }

        /// <summary>
        /// <p>命中规则行为：<br>RULE_MODE_RELEASE 放行<br>RULE_MODE_ALERT  告警<br>RULE_MODE_HOLDUP 拦截</p>
        /// </summary>
        [JsonProperty("MatchAction")]
        public string MatchAction{ get; set; }

        /// <summary>
        /// <p>命中规则进程信息</p>
        /// </summary>
        [JsonProperty("MatchProcessPath")]
        public string MatchProcessPath{ get; set; }

        /// <summary>
        /// <p>命中规则文件信息</p>
        /// </summary>
        [JsonProperty("MatchFilePath")]
        public string MatchFilePath{ get; set; }

        /// <summary>
        /// <p>文件路径，包含名字</p>
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// <p>规则是否存在</p>
        /// </summary>
        [JsonProperty("RuleExist")]
        public bool? RuleExist{ get; set; }

        /// <summary>
        /// <p>事件数量</p>
        /// </summary>
        [JsonProperty("EventCount")]
        public long? EventCount{ get; set; }

        /// <summary>
        /// <p>最近生成时间</p>
        /// </summary>
        [JsonProperty("LatestFoundTime")]
        public string LatestFoundTime{ get; set; }

        /// <summary>
        /// <p>规则组id</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// <p>网络状态<br>未隔离      NORMAL<br>已隔离        ISOLATED<br>隔离中        ISOLATING<br>隔离失败    ISOLATE_FAILED<br>解除隔离中  RESTORING<br>解除隔离失败 RESTORE_FAILED</p>
        /// </summary>
        [JsonProperty("ContainerNetStatus")]
        public string ContainerNetStatus{ get; set; }

        /// <summary>
        /// <p>容器子状态<br>&quot;AGENT_OFFLINE&quot;       //Agent离线<br>&quot;NODE_DESTROYED&quot;      //节点已销毁<br>&quot;CONTAINER_EXITED&quot;    //容器已退出<br>&quot;CONTAINER_DESTROYED&quot; //容器已销毁<br>&quot;SHARED_HOST&quot;         // 容器与主机共享网络<br>&quot;RESOURCE_LIMIT&quot;      //隔离操作资源超限<br>&quot;UNKNOW&quot;              // 原因未知</p>
        /// </summary>
        [JsonProperty("ContainerNetSubStatus")]
        public string ContainerNetSubStatus{ get; set; }

        /// <summary>
        /// <p>容器隔离操作来源</p>
        /// </summary>
        [JsonProperty("ContainerIsolateOperationSrc")]
        public string ContainerIsolateOperationSrc{ get; set; }

        /// <summary>
        /// <p>容器状态<br>正在运行: RUNNING<br>暂停: PAUSED<br>停止: STOPPED<br>已经创建: CREATED<br>已经销毁: DESTROYED<br>正在重启中: RESTARTING<br>迁移中: REMOVING</p>
        /// </summary>
        [JsonProperty("ContainerStatus")]
        public string ContainerStatus{ get; set; }

        /// <summary>
        /// <p>节点名称：如果是超级节点，展示的实质上是它的node_id</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>pod名称</p>
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

        /// <summary>
        /// <p>pod ip</p>
        /// </summary>
        [JsonProperty("PodIP")]
        public string PodIP{ get; set; }

        /// <summary>
        /// <p>节点类型：NORMAL普通节点、SUPER超级节点</p>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>集群id</p>
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// <p>节点的唯一id，主要是超级节点使用</p>
        /// </summary>
        [JsonProperty("NodeUniqueID")]
        public string NodeUniqueID{ get; set; }

        /// <summary>
        /// <p>节点公网IP</p>
        /// </summary>
        [JsonProperty("PublicIP")]
        public string PublicIP{ get; set; }

        /// <summary>
        /// <p>节点id</p>
        /// </summary>
        [JsonProperty("NodeID")]
        public string NodeID{ get; set; }

        /// <summary>
        /// <p>uuid</p>
        /// </summary>
        [JsonProperty("HostID")]
        public string HostID{ get; set; }

        /// <summary>
        /// <p>节点内网ip</p>
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// <p>集群名称</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>命令行参数</p>
        /// </summary>
        [JsonProperty("CmdLine")]
        public string CmdLine{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "MatchRuleName", this.MatchRuleName);
            this.SetParamSimple(map, prefix + "FoundTime", this.FoundTime);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "Behavior", this.Behavior);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "Solution", this.Solution);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "MatchRuleId", this.MatchRuleId);
            this.SetParamSimple(map, prefix + "MatchAction", this.MatchAction);
            this.SetParamSimple(map, prefix + "MatchProcessPath", this.MatchProcessPath);
            this.SetParamSimple(map, prefix + "MatchFilePath", this.MatchFilePath);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "RuleExist", this.RuleExist);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "LatestFoundTime", this.LatestFoundTime);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "ContainerNetStatus", this.ContainerNetStatus);
            this.SetParamSimple(map, prefix + "ContainerNetSubStatus", this.ContainerNetSubStatus);
            this.SetParamSimple(map, prefix + "ContainerIsolateOperationSrc", this.ContainerIsolateOperationSrc);
            this.SetParamSimple(map, prefix + "ContainerStatus", this.ContainerStatus);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "PodIP", this.PodIP);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "NodeUniqueID", this.NodeUniqueID);
            this.SetParamSimple(map, prefix + "PublicIP", this.PublicIP);
            this.SetParamSimple(map, prefix + "NodeID", this.NodeID);
            this.SetParamSimple(map, prefix + "HostID", this.HostID);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "CmdLine", this.CmdLine);
        }
    }
}

