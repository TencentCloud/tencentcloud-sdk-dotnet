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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAutoScalingGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 按照一个或者多个伸缩组ID查询。伸缩组ID形如：`asg-nkdwoui0`。每次请求的上限为100。参数不支持同时指定`AutoScalingGroupIds`和`Filters`。
        /// </summary>
        [JsonProperty("AutoScalingGroupIds")]
        public string[] AutoScalingGroupIds{ get; set; }

        /// <summary>
        /// 过滤条件。
        /// <li> auto-scaling-group-id - String - 是否必填：否 -（过滤条件）按照伸缩组ID过滤。</li>
        /// <li> auto-scaling-group-name - String - 是否必填：否 -（过滤条件）按照伸缩组名称过滤。</li>
        /// <li> vague-auto-scaling-group-name - String - 是否必填：否 -（过滤条件）按照伸缩组名称模糊搜索。</li>
        /// <li> launch-configuration-id - String - 是否必填：否 -（过滤条件）按照启动配置ID过滤。</li>
        /// <li> tag-key - String - 是否必填：否 -（过滤条件）按照标签键进行过滤。</li>
        /// <li> tag-value - String - 是否必填：否 -（过滤条件）按照标签值进行过滤。</li>
        /// <li> tag:tag-key - String - 是否必填：否 -（过滤条件）按照标签键值对进行过滤。 tag-key使用具体的标签键进行替换。使用请参考示例2</li>
        /// 每次请求的`Filters`的上限为10，`Filter.Values`的上限为5。参数不支持同时指定`AutoScalingGroupIds`和`Filters`。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。关于`Limit`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于`Offset`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AutoScalingGroupIds.", this.AutoScalingGroupIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

