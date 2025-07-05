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

namespace TencentCloud.Ciam.V20220331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryUserFilter : AbstractModel
    {
        
        /// <summary>
        /// 属性key
        /// </summary>
        [JsonProperty("PropertyKey")]
        public string PropertyKey{ get; set; }

        /// <summary>
        /// 属性value
        /// </summary>
        [JsonProperty("PropertyValue")]
        public string PropertyValue{ get; set; }

        /// <summary>
        /// 逻辑值，等于true，不等于false
        /// </summary>
        [JsonProperty("Logic")]
        public bool? Logic{ get; set; }

        /// <summary>
        /// 操作逻辑符（支持> < = >= <=  != between）
        /// </summary>
        [JsonProperty("OperateLogic")]
        public string OperateLogic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PropertyKey", this.PropertyKey);
            this.SetParamSimple(map, prefix + "PropertyValue", this.PropertyValue);
            this.SetParamSimple(map, prefix + "Logic", this.Logic);
            this.SetParamSimple(map, prefix + "OperateLogic", this.OperateLogic);
        }
    }
}

