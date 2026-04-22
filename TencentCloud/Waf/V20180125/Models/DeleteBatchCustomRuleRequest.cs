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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteBatchCustomRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据类型 
        /// "custom-rule"-自定义规则、"custom-white-rule"-精准白名单
        /// </summary>
        [JsonProperty("DataType")]
        public string DataType{ get; set; }

        /// <summary>
        /// 0-指定Id删除、1-删除全部（除部分排除的Id）
        /// </summary>
        [JsonProperty("IsDeleteAll")]
        public long? IsDeleteAll{ get; set; }

        /// <summary>
        /// 具体Ids 由IsDeleteAll而定
        /// </summary>
        [JsonProperty("Ids")]
        public ulong?[] Ids{ get; set; }

        /// <summary>
        /// 筛选条件
        /// </summary>
        [JsonProperty("Filters")]
        public FiltersItemNew[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataType", this.DataType);
            this.SetParamSimple(map, prefix + "IsDeleteAll", this.IsDeleteAll);
            this.SetParamArraySimple(map, prefix + "Ids.", this.Ids);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

