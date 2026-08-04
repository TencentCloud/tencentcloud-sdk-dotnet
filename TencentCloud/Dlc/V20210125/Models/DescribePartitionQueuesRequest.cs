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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePartitionQueuesRequest : AbstractModel
    {
        
        /// <summary>
        /// 分区编码
        /// </summary>
        [JsonProperty("PartitionCode")]
        public string PartitionCode{ get; set; }

        /// <summary>
        /// 排序字段列表
        /// </summary>
        [JsonProperty("SortFields")]
        public SortField[] SortFields{ get; set; }

        /// <summary>
        /// 筛选条件列表
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }

        /// <summary>
        /// 每页返回数量
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PartitionCode", this.PartitionCode);
            this.SetParamArrayObj(map, prefix + "SortFields.", this.SortFields);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

