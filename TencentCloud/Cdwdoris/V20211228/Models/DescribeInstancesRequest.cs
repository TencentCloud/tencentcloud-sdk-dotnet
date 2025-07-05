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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 搜索的集群id名称
        /// </summary>
        [JsonProperty("SearchInstanceId")]
        public string SearchInstanceId{ get; set; }

        /// <summary>
        /// 搜索的集群name
        /// </summary>
        [JsonProperty("SearchInstanceName")]
        public string SearchInstanceName{ get; set; }

        /// <summary>
        /// 分页参数，第一页为0，第二页为10
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页参数，分页步长，默认为10
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 搜索标签列表，没匹配到则不过滤集群列表
        /// </summary>
        [JsonProperty("SearchTags")]
        public SearchTags[] SearchTags{ get; set; }

        /// <summary>
        /// 0 : 存算一体,1：存算分离,2:ALL
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SearchInstanceId", this.SearchInstanceId);
            this.SetParamSimple(map, prefix + "SearchInstanceName", this.SearchInstanceName);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "SearchTags.", this.SearchTags);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
        }
    }
}

