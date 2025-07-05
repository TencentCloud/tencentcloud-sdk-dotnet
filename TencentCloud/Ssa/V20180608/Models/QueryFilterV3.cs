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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryFilterV3 : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件
        /// </summary>
        [JsonProperty("Filter")]
        public QueryFilter Filter{ get; set; }

        /// <summary>
        /// 有无子条件
        /// </summary>
        [JsonProperty("HasSub")]
        public bool? HasSub{ get; set; }

        /// <summary>
        /// 查询条件
        /// </summary>
        [JsonProperty("SubFilters")]
        public QueryFilter[] SubFilters{ get; set; }

        /// <summary>
        /// 逻辑操作(只支持32位)
        /// </summary>
        [JsonProperty("Logic")]
        public ulong? Logic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamSimple(map, prefix + "HasSub", this.HasSub);
            this.SetParamArrayObj(map, prefix + "SubFilters.", this.SubFilters);
            this.SetParamSimple(map, prefix + "Logic", this.Logic);
        }
    }
}

