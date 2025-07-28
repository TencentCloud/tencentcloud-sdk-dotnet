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

    public class DescribeBaseBackupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 备份的最小结束时间，形如2018-01-01 00:00:00。默认为7天前。
        /// </summary>
        [JsonProperty("MinFinishTime")]
        public string MinFinishTime{ get; set; }

        /// <summary>
        /// 备份的最大结束时间，形如2018-01-01 00:00:00。默认为当前时间。
        /// </summary>
        [JsonProperty("MaxFinishTime")]
        public string MaxFinishTime{ get; set; }

        /// <summary>
        /// 按照一个或者多个过滤条件进行查询，目前支持的过滤条件有：
        /// db-instance-id：按照实例ID过滤，类型为string。
        /// db-instance-name：按照实例名过滤，支持模糊匹配，类型为string。
        /// db-instance-ip：按照实例私有网络IP地址过滤，类型为string。
        /// base-backup-id：按照备份集ID过滤，类型为string。
        /// db-instance-status：按实例状态过滤，类型为string。取值参考[DBInstance](https://cloud.tencent.com/document/api/409/16778#DBInstance)结构的DBInstanceStatus字段。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 每页显示数量，取值范围为1-100，默认为返回10条。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 数据偏移量，从0开始。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 排序字段，支持StartTime,FinishTime,Size。默认值：StartTime。
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 排序方式，包括升序：asc，降序：desc。默认值：desc。
        /// </summary>
        [JsonProperty("OrderByType")]
        public string OrderByType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinFinishTime", this.MinFinishTime);
            this.SetParamSimple(map, prefix + "MaxFinishTime", this.MaxFinishTime);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderByType", this.OrderByType);
        }
    }
}

