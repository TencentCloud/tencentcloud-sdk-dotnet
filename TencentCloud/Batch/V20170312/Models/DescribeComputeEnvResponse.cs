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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeComputeEnvResponse : AbstractModel
    {
        
        /// <summary>
        /// 计算环境ID，环境ID通过调用接口 [DescribeComputeEnv](https://cloud.tencent.com/document/api/599/15892)获取。
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 计算环境名称
        /// </summary>
        [JsonProperty("EnvName")]
        public string EnvName{ get; set; }

        /// <summary>
        /// 位置信息
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// 计算环境创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 计算节点列表信息
        /// </summary>
        [JsonProperty("ComputeNodeSet")]
        public ComputeNode[] ComputeNodeSet{ get; set; }

        /// <summary>
        /// 计算节点统计指标
        /// </summary>
        [JsonProperty("ComputeNodeMetrics")]
        public ComputeNodeMetrics ComputeNodeMetrics{ get; set; }

        /// <summary>
        /// 计算节点期望个数
        /// </summary>
        [JsonProperty("DesiredComputeNodeCount")]
        public ulong? DesiredComputeNodeCount{ get; set; }

        /// <summary>
        /// 计算环境管理类型，枚举如下： MANAGED: 由客户在Batch平台主动创建； THPC_QUEUE: 由thpc平台创建，关联thpc平台集群队列。
        /// </summary>
        [JsonProperty("EnvType")]
        public string EnvType{ get; set; }

        /// <summary>
        /// 计算环境资源类型，当前为CVM和CPM（黑石）
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 下一步的动作，枚举如下： DELETING: 删除中
        /// </summary>
        [JsonProperty("NextAction")]
        public string NextAction{ get; set; }

        /// <summary>
        /// 用户添加到计算环境中的计算节点个数
        /// </summary>
        [JsonProperty("AttachedComputeNodeCount")]
        public ulong? AttachedComputeNodeCount{ get; set; }

        /// <summary>
        /// 计算环境绑定的标签列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

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
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "EnvName", this.EnvName);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "ComputeNodeSet.", this.ComputeNodeSet);
            this.SetParamObj(map, prefix + "ComputeNodeMetrics.", this.ComputeNodeMetrics);
            this.SetParamSimple(map, prefix + "DesiredComputeNodeCount", this.DesiredComputeNodeCount);
            this.SetParamSimple(map, prefix + "EnvType", this.EnvType);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "NextAction", this.NextAction);
            this.SetParamSimple(map, prefix + "AttachedComputeNodeCount", this.AttachedComputeNodeCount);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

