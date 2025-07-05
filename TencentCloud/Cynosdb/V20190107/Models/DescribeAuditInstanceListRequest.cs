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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAuditInstanceListRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例审计开启的状态。1-已开启审计；0-未开启审计。
        /// </summary>
        [JsonProperty("AuditSwitch")]
        public long? AuditSwitch{ get; set; }

        /// <summary>
        /// 查询实例列表的过滤条件。
        /// </summary>
        [JsonProperty("Filters")]
        public AuditInstanceFilters[] Filters{ get; set; }

        /// <summary>
        /// 实例的审计规则模式。1-规则审计；0-全审计。
        /// </summary>
        [JsonProperty("AuditMode")]
        public long? AuditMode{ get; set; }

        /// <summary>
        /// 单次请求返回的数量。默认值为30，最大值为 100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认值为 0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuditSwitch", this.AuditSwitch);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "AuditMode", this.AuditMode);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

