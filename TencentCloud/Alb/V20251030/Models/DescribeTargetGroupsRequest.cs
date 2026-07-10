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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTargetGroupsRequest : AbstractModel
    {
        
        /// <summary>
        ///  过滤器。通过指定的过滤条件来查询后端服务，支持：
        /// - Name的值为**VpcId**。通过VPC实例来筛选目标组。**Values**的值为VPC唯一ID列表。
        /// - Name的值为**TargetType**。通过后端服务类型来筛选目标组。**Values**的值可以取为**Instance**。
        /// - Name的值为**TargetGroupName**。通过目标组名称来筛选目标组。**Values**的值为目标组名称列表。
        /// - Name的值为**Protocol**。通过目标组后端服务协议来筛选目标组。**Values**的值为目标组后端服务协议列表。
        /// - 通过标签方式筛选。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 返回列表的数量，默认为**20**，最大值为**100**。
        /// </summary>
        [JsonProperty("MaxResults")]
        public long? MaxResults{ get; set; }

        /// <summary>
        /// 下一次查询的Token值。第一次查询和没有下一次查询时，无需填写。
        /// 如果有下一次查询，取值为上一次 API 调用返回的 NextToken 值。
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// 目标组 ID 列表，ID 格式为 lbtg- 后接 8 位字母数字。
        /// </summary>
        [JsonProperty("TargetGroupIds")]
        public string[] TargetGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamArraySimple(map, prefix + "TargetGroupIds.", this.TargetGroupIds);
        }
    }
}

