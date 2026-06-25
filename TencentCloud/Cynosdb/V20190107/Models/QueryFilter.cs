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

    public class QueryFilter : AbstractModel
    {
        
        /// <summary>
        /// 字段值列表，与 Names 一一对应。InstanceId/ClusterId 为精确匹配，InstanceName 默认模糊匹配
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }

        /// <summary>
        /// 搜索字段名称列表，仅支持以下 3 个字段（不区分大小写，多个值为 OR 关系）：ClusterId（按集群 ID 过滤，精确匹配）、InstanceId（按实例 ID 反查所属集群）、InstanceName（按实例名称反查所属集群，默认 LIKE 模糊匹配，ExactMatch=true 时精确匹配）。InstanceId 与 InstanceName 同时传入时取交集（AND 语义）。
        /// </summary>
        [JsonProperty("Names")]
        public string[] Names{ get; set; }

        /// <summary>
        /// 是否精确匹配。仅对 InstanceName 生效：true 精确匹配，false（默认）LIKE 模糊匹配。
        /// </summary>
        [JsonProperty("ExactMatch")]
        public bool? ExactMatch{ get; set; }

        /// <summary>
        /// 搜索字段名称（单个字段模式，与 Names 二选一）。支持：ClusterId、InstanceId、InstanceName
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 操作符（预留字段，当前未启用）。可选值：>、>=、!=、=、<、<=
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
            this.SetParamArraySimple(map, prefix + "Names.", this.Names);
            this.SetParamSimple(map, prefix + "ExactMatch", this.ExactMatch);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

