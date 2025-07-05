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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeWorkspacesRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID列表。通过该参数可以指定需要查询信息的集群列表。<br>如果您不指定该参数，则返回Limit数量以内的集群信息。
        /// </summary>
        [JsonProperty("SpaceIds")]
        public string[] SpaceIds{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于`Offset`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。关于`Limit`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <ul>   <li>     <strong>zone</strong>     <p style="padding-left: 30px;">按照【<strong>可用区</strong>】进行过滤</p>     <p style="padding-left: 30px;">类型：String</p>     <p style="padding-left: 30px;">必选：否</p></li>     <li>     <strong>space-id</strong>     <p style="padding-left: 30px;">按照【<strong>工作空间实例ID</strong>】进行过滤</p>     <p style="padding-left: 30px;">类型：String</p>     <p style="padding-left: 30px;">必选：否</p></li>     <li>     <strong>cvm-instance-id</strong>     <p style="padding-left: 30px;">按照【<strong>CVM实例ID</strong>】进行过滤</p>     <p style="padding-left: 30px;">类型：String</p>     <p style="padding-left: 30px;">必选：否</p></li>     <li>     <strong>space-state</strong>     <p style="padding-left: 30px;">按照【<strong>工作空间状态</strong>】进行过滤</p>     <p style="padding-left: 30px;">类型：String</p>     <p style="padding-left: 30px;">必选：否</p></li>     <li>     <strong>space-name</strong>     <p style="padding-left: 30px;">按照【<strong>工作空间别名</strong>】进行过滤</p>     <p style="padding-left: 30px;">类型：String</p>     <p style="padding-left: 30px;">必选：否</p></li>     <li>     <strong>space-charge-type</strong>     <p style="padding-left: 30px;">按照【<strong>工作空间实例付费模式</strong>】进行过滤</p>     <p style="padding-left: 30px;">类型：String</p>     <p style="padding-left: 30px;">必选：否</p></li>     <li>     <strong>tag-key</strong>     <p style="padding-left: 30px;">按照【<strong>标签键</strong>】进行过滤</p>     <p style="padding-left: 30px;">类型：String</p>     <p style="padding-left: 30px;">必选：否</p></li>     <li>     <strong>tag-value</strong>     <p style="padding-left: 30px;">按照【<strong>标签值</strong>】进行过滤</p>     <p style="padding-left: 30px;">类型：String</p>     <p style="padding-left: 30px;">必选：否</p></li> </ul> <p style="padding-left: 30px;">每次请求的`Filters`的上限为10，`Filter.Values`的上限为5。</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SpaceIds.", this.SpaceIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

