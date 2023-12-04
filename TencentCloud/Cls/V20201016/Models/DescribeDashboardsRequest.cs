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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDashboardsRequest : AbstractModel
    {
        
        /// <summary>
        /// 分页的偏移量，默认值为0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页单页限制数目，默认值为20，最大值100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <br><li>dashboardId
        /// 
        /// 按照【仪表盘id】进行过滤。
        /// 类型：String
        /// 
        /// 必选：否</li>
        /// 
        /// <br><li> dashboardName
        /// 
        /// 按照【仪表盘名字】进行模糊搜索过滤。
        /// 类型：String
        /// 
        /// 必选：否</li>
        /// 
        /// <br><li> dashboardRegion
        /// 
        /// 按照【仪表盘地域】进行过滤，为了兼容老的仪表盘，通过云API创建的仪表盘没有地域属性
        /// 类型：String
        /// 
        /// 必选：否</li>
        /// 
        /// <br><li> tagKey
        /// 
        /// 按照【标签键】进行过滤。
        /// 
        /// 类型：String
        /// 
        /// 必选：否</li>
        /// 
        /// <br><li> tag:tagKey
        /// 
        /// 按照【标签键值对】进行过滤。tag-key使用具体的标签键进行替换。使用请参考示例2。
        /// 
        /// 类型：String
        /// 
        /// 必选：否</li>
        /// 
        /// 每次请求的Filters的上限为10，Filter.Values的上限为100。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 按照topicId和regionId过滤。
        /// </summary>
        [JsonProperty("TopicIdRegionFilter")]
        public TopicIdAndRegion[] TopicIdRegionFilter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "TopicIdRegionFilter.", this.TopicIdRegionFilter);
        }
    }
}

