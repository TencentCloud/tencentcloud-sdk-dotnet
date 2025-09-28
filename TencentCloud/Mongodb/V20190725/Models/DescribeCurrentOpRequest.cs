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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCurrentOpRequest : AbstractModel
    {
        
        /// <summary>
        /// 指定要查询的实例 ID。请登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 操作所属的命名空间 namespace，格式为 db.collection。
        /// </summary>
        [JsonProperty("Ns")]
        public string Ns{ get; set; }

        /// <summary>
        /// 设置查询筛选条件为操作任务已经执行的时间。
        /// - 默认值为0，取值范围为[0, 3600000]，单位：毫秒。
        /// - 结果将返回超过设置时间的操作。
        /// </summary>
        [JsonProperty("MillisecondRunning")]
        public ulong? MillisecondRunning{ get; set; }

        /// <summary>
        /// 设置查询筛选条件为操作任务类型。取值包括：
        /// - none：特殊状态，空闲连接或内部任务等。
        /// - update：更新数据。
        /// - insert：插入操作。
        /// - query：查询操作。
        /// - command：命令操作。
        /// - getmore：获取更多数据。
        /// - remove：删除操作。
        /// - killcursors：释放查询游标的操作。
        /// </summary>
        [JsonProperty("Op")]
        public string Op{ get; set; }

        /// <summary>
        /// 筛选条件，分片名称。
        /// </summary>
        [JsonProperty("ReplicaSetName")]
        public string ReplicaSetName{ get; set; }

        /// <summary>
        /// 设置查询筛选条件为节点角色。
        /// - primary：主节点。
        /// - secondary：从节点。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 单次请求返回的数量，默认值为100，取值范围为[0,100]。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认值为0，取值范围为[0,10000]。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回结果集排序的字段，目前支持按照 MicrosecsRunning（操作任务已执行的时间）排序。
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 返回结果集排序方式。
        /// - ASC：升序。默认为 ASC，按照升序排序。
        /// - DESC：降序。
        /// </summary>
        [JsonProperty("OrderByType")]
        public string OrderByType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Ns", this.Ns);
            this.SetParamSimple(map, prefix + "MillisecondRunning", this.MillisecondRunning);
            this.SetParamSimple(map, prefix + "Op", this.Op);
            this.SetParamSimple(map, prefix + "ReplicaSetName", this.ReplicaSetName);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderByType", this.OrderByType);
        }
    }
}

