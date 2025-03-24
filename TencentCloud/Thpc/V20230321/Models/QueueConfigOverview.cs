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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueueConfigOverview : AbstractModel
    {
        
        /// <summary>
        /// 队列名称。
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// 队列中弹性节点数量最小值。取值范围0～200。
        /// </summary>
        [JsonProperty("MinSize")]
        public long? MinSize{ get; set; }

        /// <summary>
        /// 队列中弹性节点数量最大值。取值范围0～200。
        /// </summary>
        [JsonProperty("MaxSize")]
        public long? MaxSize{ get; set; }

        /// <summary>
        /// 是否开启自动扩容。
        /// </summary>
        [JsonProperty("EnableAutoExpansion")]
        public bool? EnableAutoExpansion{ get; set; }

        /// <summary>
        /// 是否开启自动缩容。
        /// </summary>
        [JsonProperty("EnableAutoShrink")]
        public bool? EnableAutoShrink{ get; set; }

        /// <summary>
        /// 扩容节点配置信息。
        /// </summary>
        [JsonProperty("ExpansionNodeConfigs")]
        public ExpansionNodeConfigOverview[] ExpansionNodeConfigs{ get; set; }

        /// <summary>
        /// 队列中期望的空闲节点数量（包含弹性节点和静态节点）。默认值：0。队列中，处于空闲状态的节点小于此值，集群会扩容弹性节点；处于空闲状态的节点大于此值，集群会缩容弹性节点。
        /// </summary>
        [JsonProperty("DesiredIdleNodeCapacity")]
        public long? DesiredIdleNodeCapacity{ get; set; }

        /// <summary>
        /// 队列中期望的总节点数。
        /// </summary>
        [JsonProperty("DesiredNodeCount")]
        public long? DesiredNodeCount{ get; set; }

        /// <summary>
        /// 扩容比例。默认值：100。取值范围：1～100。
        /// 如果扩容比例为50，那么每轮只会扩容当前作业负载所需的50%数量的节点。
        /// </summary>
        [JsonProperty("ScaleOutRatio")]
        public long? ScaleOutRatio{ get; set; }

        /// <summary>
        /// 比例扩容阈值。默认值：0。取值范围：0～200。
        /// 当作业负载需要扩容节点数量大于此值，当前扩容轮次按照ScaleOutRatio配置的的比例进行扩容。当作业负载需要扩容节点数量小于此值，当前扩容轮次扩容当前作业负载所需数量的节点。
        /// 此参数配合ScaleOutRatio参数进行使用，用于比例扩容场景下，在作业负载所需节点数量较小时，加快收敛速度。
        /// </summary>
        [JsonProperty("ScaleOutNodeThreshold")]
        public long? ScaleOutNodeThreshold{ get; set; }

        /// <summary>
        /// 每轮扩容最大节点个数。
        /// </summary>
        [JsonProperty("MaxNodesPerCycle")]
        public long? MaxNodesPerCycle{ get; set; }

        /// <summary>
        /// 扩容过程中，作业的内存在匹配实例机型时增大比例（不会影响作业提交的内存大小，只影响匹配计算过程）。<br/>
        /// 针对场景：由于实例机型的总内存会大于实例内部的可用内存，16GB内存规格的实例，实例操作系统内的可用内存只有约14.9GB内存。假设此时提交一个需要15GB内存的作业，
        /// 
        /// - 当ScaleUpMemRatio=0时，会匹配到16GB内存规格的实例,但是由于操作系统内的可用内存为14.9GB小于作业所需的15GB，扩容出来的实例作业无法运行起来。
        /// - 当ScaleUpMemRatio=10时，匹配实例规格会按照15*(1+10%)=16.5GB来进行实例规格匹配，则不会匹配到16GB的实例，而是更大内存规格的实例来保证作业能够被运行起来。
        /// </summary>
        [JsonProperty("ScaleUpMemRatio")]
        public long? ScaleUpMemRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "EnableAutoExpansion", this.EnableAutoExpansion);
            this.SetParamSimple(map, prefix + "EnableAutoShrink", this.EnableAutoShrink);
            this.SetParamArrayObj(map, prefix + "ExpansionNodeConfigs.", this.ExpansionNodeConfigs);
            this.SetParamSimple(map, prefix + "DesiredIdleNodeCapacity", this.DesiredIdleNodeCapacity);
            this.SetParamSimple(map, prefix + "DesiredNodeCount", this.DesiredNodeCount);
            this.SetParamSimple(map, prefix + "ScaleOutRatio", this.ScaleOutRatio);
            this.SetParamSimple(map, prefix + "ScaleOutNodeThreshold", this.ScaleOutNodeThreshold);
            this.SetParamSimple(map, prefix + "MaxNodesPerCycle", this.MaxNodesPerCycle);
            this.SetParamSimple(map, prefix + "ScaleUpMemRatio", this.ScaleUpMemRatio);
        }
    }
}

