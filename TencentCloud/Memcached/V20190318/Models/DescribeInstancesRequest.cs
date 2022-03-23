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

namespace TencentCloud.Memcached.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 枚举范围： AddTimeStamp, InstanceName, ProjectId
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 查找的关键字
        /// </summary>
        [JsonProperty("SearchKeys")]
        public string[] SearchKeys{ get; set; }

        /// <summary>
        /// 子网ID列表
        /// </summary>
        [JsonProperty("UniqSubnetIds")]
        public string[] UniqSubnetIds{ get; set; }

        /// <summary>
        /// VIP列表
        /// </summary>
        [JsonProperty("Vips")]
        public string[] Vips{ get; set; }

        /// <summary>
        /// 0倒序，1正序，默认倒序
        /// </summary>
        [JsonProperty("OrderType")]
        public long? OrderType{ get; set; }

        /// <summary>
        /// 实例名称列表
        /// </summary>
        [JsonProperty("InstanceNames")]
        public string[] InstanceNames{ get; set; }

        /// <summary>
        /// VPC ID列表
        /// </summary>
        [JsonProperty("UniqVpcIds")]
        public string[] UniqVpcIds{ get; set; }

        /// <summary>
        /// 项目ID列表
        /// </summary>
        [JsonProperty("ProjectIds")]
        public long?[] ProjectIds{ get; set; }

        /// <summary>
        /// 偏移量，取Limit整数倍
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 实例列表的大小，参数默认值100
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 实例ID列表
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamArraySimple(map, prefix + "SearchKeys.", this.SearchKeys);
            this.SetParamArraySimple(map, prefix + "UniqSubnetIds.", this.UniqSubnetIds);
            this.SetParamArraySimple(map, prefix + "Vips.", this.Vips);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamArraySimple(map, prefix + "InstanceNames.", this.InstanceNames);
            this.SetParamArraySimple(map, prefix + "UniqVpcIds.", this.UniqVpcIds);
            this.SetParamArraySimple(map, prefix + "ProjectIds.", this.ProjectIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
        }
    }
}

