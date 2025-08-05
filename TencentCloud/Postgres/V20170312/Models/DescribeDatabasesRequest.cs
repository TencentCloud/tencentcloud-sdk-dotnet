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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDatabasesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。可通过[DescribeDBInstances](https://cloud.tencent.com/document/product/409/16773)接口获取
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// 按照一个或者多个过滤条件进行查询，目前支持的过滤条件有：database-name：按照数据库名称过滤，类型为string。此处使用模糊匹配搜索符合条件的数据库。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 数据偏移量，从0开始。	
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 单次显示数量。建议最大取值100。
        /// 默认值：20
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

