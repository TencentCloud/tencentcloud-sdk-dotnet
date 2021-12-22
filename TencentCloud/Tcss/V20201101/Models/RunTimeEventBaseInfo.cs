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
        /// Pod名称
        /// </summary>
        [JsonProperty("PodName")]
        public string PodName{ get; set; }

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
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// 外网ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClientIP")]
        public string ClientIP{ get; set; }


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
            this.SetParamSimple(map, prefix + "PodName", this.PodName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "LatestFoundTime", this.LatestFoundTime);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "ClientIP", this.ClientIP);
        }
    }
}

