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

    public class HTTPServiceCacheKeyParams : AbstractModel
    {
        
        /// <summary>
        /// <p>全 URL 缓存开关</p><p>枚举值：</p><ul><li>on： 开启</li><li>off： 关闭</li></ul>
        /// </summary>
        [JsonProperty("FullURLCache")]
        public string FullURLCache{ get; set; }

        /// <summary>
        /// <p>查询参数是否参与缓存键</p><p>枚举值：</p><ul><li>on： 开启</li><li>off： 关闭</li></ul>
        /// </summary>
        [JsonProperty("QueryStringSwitch")]
        public string QueryStringSwitch{ get; set; }

        /// <summary>
        /// <p>QueryStringSwitch=on 时必填</p><p>枚举值：</p><ul><li>includeCustom： 白名单</li><li>excludeCustom： 黑名单</li></ul>
        /// </summary>
        [JsonProperty("QueryStringAction")]
        public string QueryStringAction{ get; set; }

        /// <summary>
        /// <p>参数名列表</p><p>入参限制：最多 100 项，单项 1~128 字节</p>
        /// </summary>
        [JsonProperty("QueryStringValues")]
        public string[] QueryStringValues{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FullURLCache", this.FullURLCache);
            this.SetParamSimple(map, prefix + "QueryStringSwitch", this.QueryStringSwitch);
            this.SetParamSimple(map, prefix + "QueryStringAction", this.QueryStringAction);
            this.SetParamArraySimple(map, prefix + "QueryStringValues.", this.QueryStringValues);
        }
    }
}

