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

    public class LogFilter : AbstractModel
    {
        
        /// <summary>
        /// 过滤项。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 过滤条件。支持以下条件： WINC-包含（分词维度）， WEXC-不包含（分词维度）, INC - 包含, EXC - 不包含, EQS - 等于, NEQ - 不等于, RA - 范围。
        /// </summary>
        [JsonProperty("Compare")]
        public string Compare{ get; set; }

        /// <summary>
        /// 过滤的值。反向查询时，多个值之前是且的关系，正向查询多个值是或的关系
        /// </summary>
        [JsonProperty("Value")]
        public string[] Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Compare", this.Compare);
            this.SetParamArraySimple(map, prefix + "Value.", this.Value);
        }
    }
}

