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

    public class DescribeDBInstanceNodePropertyRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。请登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 节点 ID。请登录 [MongoDB 控制台的节点管理](https://console.cloud.tencent.com/mongodb)复制节点 ID。
        /// </summary>
        [JsonProperty("NodeIds")]
        public string[] NodeIds{ get; set; }

        /// <summary>
        /// 节点角色。可选值包括：
        /// - PRIMARY：主节点。
        /// - SECONDARY：从节点。
        /// - READONLY：只读节点。
        /// - ARBITER：仲裁节点。
        /// </summary>
        [JsonProperty("Roles")]
        public string[] Roles{ get; set; }

        /// <summary>
        /// 该参数指定节点是否为 Hidden 节点，默认为 false。
        /// </summary>
        [JsonProperty("OnlyHidden")]
        public bool? OnlyHidden{ get; set; }

        /// <summary>
        /// 该参数指定选举新主节点的优先级。其取值范围为[0,100]，数值越高，优先级越高。
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 该参数指定节点投票权。
        /// - 1：具有投票权。
        /// - 0：无投票权。
        /// </summary>
        [JsonProperty("Votes")]
        public long? Votes{ get; set; }

        /// <summary>
        /// 节点标签。
        /// </summary>
        [JsonProperty("Tags")]
        public NodeTag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "NodeIds.", this.NodeIds);
            this.SetParamArraySimple(map, prefix + "Roles.", this.Roles);
            this.SetParamSimple(map, prefix + "OnlyHidden", this.OnlyHidden);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Votes", this.Votes);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

