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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDetailedSlowLogsRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。请登录 [MongoDB 控制台](https://console.cloud.tencent.com/mongodb)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 指定查询慢日志的开始时间。- 格式：yyyy-mm-dd hh:mm:ss，如：2019-06-01 10:00:00。- 查询起止时间间隔不能超过24小时，只允许查询最近7天内慢日志。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 指定查询慢日志的结束时间。
        /// - 格式：yyyy-mm-dd hh:mm:ss，如：2019-06-02 12:00:00。
        /// - 查询起止时间间隔不能超过24小时，只允许查询最近7天内慢日志。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 指定慢日志查询阈值，即查询执行时间大于此值的慢日志。单位：ms，默认值：100。
        /// </summary>
        [JsonProperty("ExecTime")]
        public long? ExecTime{ get; set; }

        /// <summary>
        /// 指定查询慢日志的命令类型。
        /// </summary>
        [JsonProperty("Commands")]
        public string[] Commands{ get; set; }

        /// <summary>
        /// 全文搜索关键字，多个关键字间为或关系。
        /// </summary>
        [JsonProperty("Texts")]
        public string[] Texts{ get; set; }

        /// <summary>
        /// 指定查询慢日志的节点名称。请通过接口 [DescribeDBInstanceNodeProperty](https://cloud.tencent.com/document/product/240/82022) 查询节点名称。
        /// </summary>
        [JsonProperty("NodeNames")]
        public string[] NodeNames{ get; set; }

        /// <summary>
        /// 指定查询 queryHash 值。
        /// </summary>
        [JsonProperty("QueryHash")]
        public string[] QueryHash{ get; set; }

        /// <summary>
        /// 分页偏移量。默认值：0。取值范围：[0,100]。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回条数。默认值：20。取值范围：[0,10000]
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 指定慢日志排序条件。
        /// - StartTime：按照慢日志生成时间排序。
        /// - ExecTime：按照慢日志执行时间排序。
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 指定排序方式。
        /// - desc：倒序。
        /// - asc：顺序。
        /// </summary>
        [JsonProperty("OrderByType")]
        public string OrderByType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ExecTime", this.ExecTime);
            this.SetParamArraySimple(map, prefix + "Commands.", this.Commands);
            this.SetParamArraySimple(map, prefix + "Texts.", this.Texts);
            this.SetParamArraySimple(map, prefix + "NodeNames.", this.NodeNames);
            this.SetParamArraySimple(map, prefix + "QueryHash.", this.QueryHash);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "OrderByType", this.OrderByType);
        }
    }
}

