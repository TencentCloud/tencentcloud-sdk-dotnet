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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSlowLogDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 开始时间戳。例如 1585142640 。
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 结束时间戳。例如 1585142640 。
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// 客户端 Host 列表。
        /// </summary>
        [JsonProperty("UserHosts")]
        public string[] UserHosts{ get; set; }

        /// <summary>
        /// 客户端 用户名 列表。
        /// </summary>
        [JsonProperty("UserNames")]
        public string[] UserNames{ get; set; }

        /// <summary>
        /// 访问的 数据库 列表。
        /// </summary>
        [JsonProperty("DataBases")]
        public string[] DataBases{ get; set; }

        /// <summary>
        /// 排序字段。当前支持：Timestamp,QueryTime,LockTime,RowsExamined,RowsSent 。
        /// </summary>
        [JsonProperty("SortBy")]
        public string SortBy{ get; set; }

        /// <summary>
        /// 升序还是降序排列。当前支持：ASC,DESC 。
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }

        /// <summary>
        /// 偏移量，默认为0，最大为9999。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 一次性返回的记录数量，默认为100，最大为400。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 仅在实例为主实例或者灾备实例时生效，可选值：slave，代表拉取从机的日志。
        /// </summary>
        [JsonProperty("InstType")]
        public string InstType{ get; set; }

        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("OpResourceId")]
        public string OpResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "UserHosts.", this.UserHosts);
            this.SetParamArraySimple(map, prefix + "UserNames.", this.UserNames);
            this.SetParamArraySimple(map, prefix + "DataBases.", this.DataBases);
            this.SetParamSimple(map, prefix + "SortBy", this.SortBy);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "InstType", this.InstType);
            this.SetParamSimple(map, prefix + "OpResourceId", this.OpResourceId);
        }
    }
}

