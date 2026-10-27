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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCloudNativeAPIGatewayLLMTokenUsageListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>网关实例Id</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>查询起始时间戳</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// <p>查询结束时间戳</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// <p>聚合维度。枚举值：</p><ul><li>SecretKey：密钥</li><li>Model：模型</li><li>ModelAPI：模型 API</li><li>ModelService：模型服务</li><li>Consumer：消费者</li><li>ConsumerGroup：消费者组（组织节点）</li></ul><p>网关版本不低于 3.9.8 时，ConsumerGroup 表示消费者组（组织节点），按请求发生时的组织归属查询，包含节点自身及全部下属，仅支持 CLS。更早版本的 ConsumerGroup 保留原消费者组查询。OrganizationNode 已移除，传入返回 InvalidParameterValue。</p><p>可选，未传时按消费者与模型服务二维聚合。</p>
        /// </summary>
        [JsonProperty("Dimension")]
        public string Dimension{ get; set; }

        /// <summary>
        /// <p>传入 Dimension 时支持：SecretKeyId、SecretKeyName、ModelName、ModelAPIId、ModelAPIName、ModelServiceId、ModelServiceName、ConsumerId、ConsumerName、ConsumerGroupId、ConsumerGroupName。</p><p>网关版本不低于 3.9.8 时，所有支持的 Dimension（包括可选 Dimension 未传）均支持 ConsumerGroupId、ConsumerGroupName，按请求发生时的消费者组及全部下属归属筛选历史日志，仅支持 CLS；不按当前组成员重算历史。ConsumerGroupId 必须为 UUID，允许显式查询已删除节点历史；ConsumerGroupName 从 Kong CP 当前目录按名称子串解析，包含同步、自定义、禁用及保留中的软删节点。同名节点保留各自身份。OrganizationNodeId / OrganizationNodeName 已移除，旧名称返回 InvalidParameterValue。</p><p>最多 10 项，Name 不重复；新版组筛选的每项 Values 为 1～50 个非空字符串，同项多个值为 OR。名称无匹配返回空结果。</p><p>未传 Dimension 时支持 ConsumerId、ConsumerName、ConsumerGroupId、ConsumerGroupName、ModelServiceId、ModelServiceName；新版组筛选同样走历史归属。更早版本保留原筛选及当前成员算法。</p><p>Dimension=ConsumerGroup 时，组 ID 与名称对候选节点求交，名称展开数量不限 50 个；请求 Values 仍最多 50 个。其他维度按历史日志条件 AND，同一请求只计一次，名称展开每项最多 50 个节点，超过返回 InvalidParameterValue。</p><p>未传 Dimension 时也按日志条件 AND，名称展开每项最多 50 个节点。</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>分页条件，每页条数</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>分页条件，分页偏移量</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Dimension", this.Dimension);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

