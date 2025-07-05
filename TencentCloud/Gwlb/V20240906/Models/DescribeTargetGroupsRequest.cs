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

namespace TencentCloud.Gwlb.V20240906.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTargetGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 目标组ID。
        /// </summary>
        [JsonProperty("TargetGroupIds")]
        public string[] TargetGroupIds{ get; set; }

        /// <summary>
        /// 显示条数限制，默认为20，最大值为1000。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 显示的偏移起始量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 过滤条件数组。
        /// - TargetGroupVpcId - String - 是否必填：否 - （过滤条件）按照目标组所属的私有网络过滤，可以通过[DescribeVpcs](https://cloud.tencent.com/document/product/215/15778)获取，如“vpc-bhqk****”。
        /// - TargetGroupName - String - 是否必填：否 - （过滤条件）按照目标组的名称过滤，如“tg_name”
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TargetGroupIds.", this.TargetGroupIds);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

