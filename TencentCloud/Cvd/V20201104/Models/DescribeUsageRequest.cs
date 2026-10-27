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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUsageRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询起始时间，最小不能超过当前时间 90 天前，取 unix 时间戳
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 查询截止时间，取 unix 时间戳
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 每页查询信息条数，默认 20，最大 100
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 页号，起始页为 1，不填默认为 1
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 查询key，每次查询会返回
        /// </summary>
        [JsonProperty("QueryKey")]
        public string QueryKey{ get; set; }

        /// <summary>
        /// 查询条件，Name可选为：
        /// InstanceId按照实例ID搜索
        /// UserName按照绑定的用户搜索，只取Values的第一个值
        /// ChareType按照计费类型搜索
        /// InstanceType按照实例类型搜索
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 指定的排序方式，默认不排序
        /// 1:使用时间，升序
        /// 2:使用时间，降序
        /// 3:空闲时间，升序
        /// 4:空闲时间，降序
        /// </summary>
        [JsonProperty("SortType")]
        public long? SortType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "QueryKey", this.QueryKey);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "SortType", this.SortType);
        }
    }
}

