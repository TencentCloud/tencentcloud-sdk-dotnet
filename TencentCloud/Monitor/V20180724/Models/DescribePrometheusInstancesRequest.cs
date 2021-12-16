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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePrometheusInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 按照一个或者多个实例ID查询。实例ID形如：prom-xxxxxxxx。请求的实例的上限为100。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 按照【实例状态】进行过滤。
        /// <ul>
        /// <li>1：正在创建</li>
        /// <li>2：运行中</li>
        /// <li>3：异常</li>
        /// <li>4：重建中</li>
        /// <li>5：销毁中</li>
        /// <li>6：已停服</li>
        /// <li>8：欠费停服中</li>
        /// <li>9：欠费已停服</li>
        /// </ul>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public long?[] InstanceStatus{ get; set; }

        /// <summary>
        /// 按照【实例名称】进行过滤。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 按照【可用区】进行过滤。可用区形如：ap-guangzhou-1。
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// 按照【标签键值对】进行过滤。tag-key使用具体的标签键进行替换。
        /// </summary>
        [JsonProperty("TagFilters")]
        public PrometheusTag[] TagFilters{ get; set; }

        /// <summary>
        /// 按照【实例的IPv4地址】进行过滤。
        /// </summary>
        [JsonProperty("IPv4Address")]
        public string[] IPv4Address{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArraySimple(map, prefix + "InstanceStatus.", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamArrayObj(map, prefix + "TagFilters.", this.TagFilters);
            this.SetParamArraySimple(map, prefix + "IPv4Address.", this.IPv4Address);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

