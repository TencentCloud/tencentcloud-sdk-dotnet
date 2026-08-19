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

    public class CreatePodContainerListExportJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集团账号的成员id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Pod唯一ID</p>
        /// </summary>
        [JsonProperty("PodUniqueID")]
        public string PodUniqueID{ get; set; }

        /// <summary>
        /// <p>集群CA证书MD5（用于查节点信息）</p>
        /// </summary>
        [JsonProperty("ClusterCaMD5")]
        public string ClusterCaMD5{ get; set; }

        /// <summary>
        /// <p>通用过滤条件列表。支持的过滤字段：<br>ContainerId：容器ID，精确匹配。<br>ContainerName：容器名称，模糊匹配。<br>RunStatus：容器运行状态，精确匹配。取值：RUNNING、PAUSED、STOPPED、CREATED、DESTROYED、RESTARTING、REMOVING、DEAD、UNKNOWN。<br>ImageId：镜像ID，精确匹配。<br>ImageName：镜像名称，模糊匹配。<br>IsolateStatus：隔离状态，精确匹配。取值：NORMAL（未隔离）、ISOLATED（已隔离）、ISOLATING（隔离中）、ISOLATE_FAILED（隔离失败）、RESTORING（解除隔离中）、RESTORE_FAILED（解除隔离失败）。<br>NodeUniqueId：所属节点唯一ID，精确匹配（NodeAssetId 为等价别名）。<br>UUID：主机UUID，精确匹配。</p>
        /// </summary>
        [JsonProperty("Filter")]
        public Filter Filter{ get; set; }

        /// <summary>
        /// <p>导出字段列表（不传则导出全部字段）<br>枚举值：<br>ContainerId：容器ID<br>ContainerName：容器名称<br>RunStatus：运行状态<br>NodeId：节点ID<br>NodeType：节点类型<br>ImageId：镜像ID<br>ImageName：镜像名称<br>IsolateStatus：隔离状态</p>
        /// </summary>
        [JsonProperty("ExportFields")]
        public string[] ExportFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "PodUniqueID", this.PodUniqueID);
            this.SetParamSimple(map, prefix + "ClusterCaMD5", this.ClusterCaMD5);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamArraySimple(map, prefix + "ExportFields.", this.ExportFields);
        }
    }
}

