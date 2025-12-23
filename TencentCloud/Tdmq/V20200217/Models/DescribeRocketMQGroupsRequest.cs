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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRocketMQGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 消费组所在的命名空间，4.x 通用集群命名空间固定为: tdmq_default
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 单次查询最大条数。取值范围：[0~100]，默认值为20
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 主题名称，输入此参数可查询该主题下所有的订阅组
        /// </summary>
        [JsonProperty("FilterTopic")]
        public string FilterTopic{ get; set; }

        /// <summary>
        /// 按消费组名称查询消费组，支持模糊查询
        /// </summary>
        [JsonProperty("FilterGroup")]
        public string FilterGroup{ get; set; }

        /// <summary>
        /// 按照指定字段排序，可选值为 subscribeNum: 订阅 Topic 个数
        /// </summary>
        [JsonProperty("SortedBy")]
        public string SortedBy{ get; set; }

        /// <summary>
        /// 按升序或降序排列，可选值为asc，desc
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }

        /// <summary>
        /// 订阅组名称，指定此参数后将只返回该订阅组信息
        /// </summary>
        [JsonProperty("FilterOneGroup")]
        public string FilterOneGroup{ get; set; }

        /// <summary>
        /// group类型
        /// </summary>
        [JsonProperty("Types")]
        public string[] Types{ get; set; }

        /// <summary>
        /// 标签过滤器
        /// </summary>
        [JsonProperty("TagFilters")]
        public TagFilter[] TagFilters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "FilterTopic", this.FilterTopic);
            this.SetParamSimple(map, prefix + "FilterGroup", this.FilterGroup);
            this.SetParamSimple(map, prefix + "SortedBy", this.SortedBy);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
            this.SetParamSimple(map, prefix + "FilterOneGroup", this.FilterOneGroup);
            this.SetParamArraySimple(map, prefix + "Types.", this.Types);
            this.SetParamArrayObj(map, prefix + "TagFilters.", this.TagFilters);
        }
    }
}

