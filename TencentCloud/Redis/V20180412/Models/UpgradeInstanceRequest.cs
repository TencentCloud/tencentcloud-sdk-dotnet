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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 待变更实例 ID。请登录[Redis控制台](https://console.cloud.tencent.com/redis/instance/list)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 指实例每个分片内存变更后的大小。
        /// - 单位 MB。
        /// - 每次只能修改参数MemSize、RedisShardNum和RedisReplicasNum其中的一个，不能同时修改。且修改其中一个参数时，其他两个参数需输入实例原有的配置规格。
        /// - 缩容时，缩容后的规格务必要大于等于使用容量的1.3倍，否则将执行失败。
        /// </summary>
        [JsonProperty("MemSize")]
        public ulong? MemSize{ get; set; }

        /// <summary>
        /// 指实例变更后的分片数量。
        /// - 标准架构不需要配置该参数，集群架构为必填参数。
        /// - 集群架构，每次只能修改参数RedisShardNum、MemSize和RedisReplicasNum其中的一个，不能同时修改。且修改其中一个参数时，其他两个参数需输入实例原有的配置规格。
        /// </summary>
        [JsonProperty("RedisShardNum")]
        public ulong? RedisShardNum{ get; set; }

        /// <summary>
        /// 指实例变更后的副本数量。
        /// - 每次只能修改参数 RedisReplicasNum、MemSize 和 RedisShardNum 其中的一个，不能同时修改。且修改其中一个参数时，其他两个参数需输入实例原有的配置规格。
        /// - 多AZ实例修改副本时必须要传入 NodeSet。
        /// </summary>
        [JsonProperty("RedisReplicasNum")]
        public ulong? RedisReplicasNum{ get; set; }

        /// <summary>
        /// 多AZ实例，增加副本时的节点信息，包括副本的 ID 编号及可用区信息。非多AZ实例不需要配置该参数。
        /// </summary>
        [JsonProperty("NodeSet")]
        public RedisNodeInfo[] NodeSet{ get; set; }

        /// <summary>
        /// 切换时间。 
        /// - 1：维护时间窗操作：指升级规格在设置的维护时间窗内执行。请通过接口[DescribeMaintenanceWindow](https://cloud.tencent.com/document/product/239/46336)查询设置的维护时间窗时间段。增减副本、增减分片、扩缩内存均支持在维护时间窗执行操作。维护时间窗升级规格正在分地域逐步测试发布中，部分区域已支持，未覆盖地域若需紧急接入，请[提交工单](https://console.cloud.tencent.com/workorder/category)申请白名单。
        /// - 2：立即操作：操作将立即执行，无需等待维护时间窗。系统默认设置为立即操作。
        /// </summary>
        [JsonProperty("SwitchOption")]
        public ulong? SwitchOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "RedisShardNum", this.RedisShardNum);
            this.SetParamSimple(map, prefix + "RedisReplicasNum", this.RedisReplicasNum);
            this.SetParamArrayObj(map, prefix + "NodeSet.", this.NodeSet);
            this.SetParamSimple(map, prefix + "SwitchOption", this.SwitchOption);
        }
    }
}

