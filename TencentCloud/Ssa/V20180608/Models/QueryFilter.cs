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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryFilter : AbstractModel
    {
        
        /// <summary>
        /// 查询的字段
        /// </summary>
        [JsonProperty("FilterKey")]
        public string FilterKey{ get; set; }

        /// <summary>
        /// 查询的值
        /// </summary>
        [JsonProperty("FilterValue")]
        public string FilterValue{ get; set; }

        /// <summary>
        /// 匹配类型，枚举见pb
        /// </summary>
        [JsonProperty("FilterOperatorType")]
        public long? FilterOperatorType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FilterKey", this.FilterKey);
            this.SetParamSimple(map, prefix + "FilterValue", this.FilterValue);
            this.SetParamSimple(map, prefix + "FilterOperatorType", this.FilterOperatorType);
        }
    }
}

