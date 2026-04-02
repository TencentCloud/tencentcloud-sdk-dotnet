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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HTTPServiceHeaderToAdd : AbstractModel
    {
        
        /// <summary>
        /// 添加头部的key
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 添加头部的值
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// 添加头部的处理行为。默认：OVERWRITE_IF_EXISTS_OR_ADD。APPEND_IF_EXISTS_OR_ADD: 已存在时追加值，不存在时添加，ADD_IF_ABSENT:  仅在 header 不存在时添加，已存在时不做任何操作，OVERWRITE_IF_EXISTS_OR_ADD: 已存在时覆盖值，不存在时添加（默认值），OVERWRITE_IF_EXISTS: 仅在 header 已存在时覆盖值，不存在时不做任何操作
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Action", this.Action);
        }
    }
}

