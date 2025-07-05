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

namespace TencentCloud.Cdwpg.V20201230.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSimpleInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 用集群id搜索
        /// </summary>
        [JsonProperty("SearchInstanceId")]
        public string SearchInstanceId{ get; set; }

        /// <summary>
        /// 用集群名字搜索
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
        /// 用标签列表搜索
        /// </summary>
        [JsonProperty("SearchTags")]
        public string[] SearchTags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SearchInstanceId", this.SearchInstanceId);
            this.SetParamSimple(map, prefix + "SearchInstanceName", this.SearchInstanceName);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "SearchTags.", this.SearchTags);
        }
    }
}

