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

    public class DescribeNetDetectsRequest : AbstractModel
    {
        
        /// <summary>
        /// 网络探测实例`ID`数组。形如：[`netd-12345678`]
        /// </summary>
        [JsonProperty("NetDetectIds")]
        public string[] NetDetectIds{ get; set; }

        /// <summary>
        /// 过滤条件，参数不支持同时指定NetDetectIds和Filters。
        /// <li>vpc-id - String - （过滤条件）VPC实例ID，形如：vpc-12345678</li>
        /// <li>net-detect-id - String - （过滤条件）网络探测实例ID，形如：netd-12345678</li>
        /// <li>subnet-id - String - （过滤条件）子网实例ID，形如：subnet-12345678</li>
        /// <li>net-detect-name - String - （过滤条件）网络探测名称</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "NetDetectIds.", this.NetDetectIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

