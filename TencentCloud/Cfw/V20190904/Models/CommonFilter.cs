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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommonFilter : AbstractModel
    {
        
        /// <summary>
        /// 检索的键值
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 枚举类型，代表Name与Values之间的匹配关系
        /// enum FilterOperatorType {
        ///     //等于
        ///     FILTER_OPERATOR_TYPE_EQUAL = 1;
        ///     //大于
        ///     FILTER_OPERATOR_TYPE_GREATER = 2;
        ///     //小于
        ///     FILTER_OPERATOR_TYPE_LESS = 3;
        ///     //大于等于
        ///     FILTER_OPERATOR_TYPE_GREATER_EQ = 4;
        ///     //小于等于
        ///     FILTER_OPERATOR_TYPE_LESS_EQ = 5;
        ///     //不等于
        ///     FILTER_OPERATOR_TYPE_NO_EQ = 6;
        ///     //not in
        ///     FILTER_OPERATOR_TYPE_NOT_IN = 8;
        ///     //模糊匹配
        ///     FILTER_OPERATOR_TYPE_FUZZINESS = 9;
        /// }
        /// </summary>
        [JsonProperty("OperatorType")]
        public long? OperatorType{ get; set; }

        /// <summary>
        /// 检索的值，各检索值间为OR关系
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "OperatorType", this.OperatorType);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
        }
    }
}

