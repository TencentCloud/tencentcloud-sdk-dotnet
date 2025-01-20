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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeHighPriorityRouteTablesRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件，参数不支持同时指定HighPriorityRouteTableIds和Filters。
        /// <li>high-priority-route-table-id - String - （过滤条件）高优路由表实例ID。</li>
        /// <li>name - String - （过滤条件）高优路由表名称。</li>
        /// <li>vpc-id - String - （过滤条件）VPC实例ID，形如：vpc-f49l6u0z。</li>
        /// <li>tag-key - String -是否必填：否 - （过滤条件）按照标签键进行过滤。</li>
        /// <li>next-hop-type - String - 是否必填：否 - （过滤条件）按下一跳类型进行过滤。使用next-hop-type进行过滤时，必须同时携带route-table-id与vpc-id。
        /// 目前我们支持的类型有：
        /// HAVIP：高可用虚拟IP；
        /// NORMAL_CVM：普通云服务器；
        /// </li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 高优路由表实例ID，例如：hprtb-18mot1fm。
        /// </summary>
        [JsonProperty("HighPriorityRouteTableIds")]
        public string[] HighPriorityRouteTableIds{ get; set; }

        /// <summary>
        /// 偏移量。
        /// </summary>
        [JsonProperty("Offset")]
        public string Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public string Limit{ get; set; }

        /// <summary>
        /// 是否需要获取路由策略信息，默认获取，当控制台不需要拉取路由策略信息时，改为False。
        /// </summary>
        [JsonProperty("NeedRouterInfo")]
        public bool? NeedRouterInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "HighPriorityRouteTableIds.", this.HighPriorityRouteTableIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "NeedRouterInfo", this.NeedRouterInfo);
        }
    }
}

