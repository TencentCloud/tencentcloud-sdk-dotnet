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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAMQPRouteRelationsRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 查询限制数
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Vhost名称
        /// </summary>
        [JsonProperty("VHostId")]
        public string VHostId{ get; set; }

        /// <summary>
        /// 按源exchange名称过滤查询结果，支持模糊查询
        /// </summary>
        [JsonProperty("FilterSourceExchange")]
        public string FilterSourceExchange{ get; set; }

        /// <summary>
        /// 按绑定的目标类型过滤查询结果，可选值:Exchange、Queue
        /// </summary>
        [JsonProperty("FilterDestType")]
        public string FilterDestType{ get; set; }

        /// <summary>
        /// 按目标名称过滤查询结果，支持模糊查询
        /// </summary>
        [JsonProperty("FilterDestValue")]
        public string FilterDestValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "VHostId", this.VHostId);
            this.SetParamSimple(map, prefix + "FilterSourceExchange", this.FilterSourceExchange);
            this.SetParamSimple(map, prefix + "FilterDestType", this.FilterDestType);
            this.SetParamSimple(map, prefix + "FilterDestValue", this.FilterDestValue);
        }
    }
}

