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

namespace TencentCloud.Dtf.V20200506.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTransactionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 事务分组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 事务开始时间查询起始时间戳，UTC，精确到毫秒
        /// </summary>
        [JsonProperty("TransactionBeginFrom")]
        public long? TransactionBeginFrom{ get; set; }

        /// <summary>
        /// 事务开始时间查询截止时间戳，UTC，精确到毫秒
        /// </summary>
        [JsonProperty("TransactionBeginTo")]
        public long? TransactionBeginTo{ get; set; }

        /// <summary>
        /// 仅查询异常状态的事务，true：仅查询异常，false或不传入：查询所有
        /// </summary>
        [JsonProperty("SearchError")]
        public bool? SearchError{ get; set; }

        /// <summary>
        /// 主事务ID，不传入时查询全量，高优先级
        /// </summary>
        [JsonProperty("TransactionId")]
        public long? TransactionId{ get; set; }

        /// <summary>
        /// 主事务ID列表，不传入时查询全量，低优先级
        /// </summary>
        [JsonProperty("TransactionIdList")]
        public long?[] TransactionIdList{ get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 起始偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "TransactionBeginFrom", this.TransactionBeginFrom);
            this.SetParamSimple(map, prefix + "TransactionBeginTo", this.TransactionBeginTo);
            this.SetParamSimple(map, prefix + "SearchError", this.SearchError);
            this.SetParamSimple(map, prefix + "TransactionId", this.TransactionId);
            this.SetParamArraySimple(map, prefix + "TransactionIdList.", this.TransactionIdList);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

