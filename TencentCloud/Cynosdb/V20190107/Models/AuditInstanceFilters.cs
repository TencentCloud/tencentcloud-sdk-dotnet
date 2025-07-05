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

    public class AuditInstanceFilters : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件值。支持InstanceId-实例ID，InstanceName-实例名称，ProjectId-项目ID，TagKey-标签键，Tag-标签（以竖线分割，例：Tagkey|Tagvalue）。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// true表示精确查找，false表示模糊匹配。
        /// </summary>
        [JsonProperty("ExactMatch")]
        public bool? ExactMatch{ get; set; }

        /// <summary>
        /// 筛选值
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ExactMatch", this.ExactMatch);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
        }
    }
}

