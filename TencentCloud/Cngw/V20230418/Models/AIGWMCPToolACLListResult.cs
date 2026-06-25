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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWMCPToolACLListResult : AbstractModel
    {
        
        /// <summary>
        /// <p>黑白名单鉴权类型</p><p>枚举值：</p><ul><li>None： 不鉴权</li><li>Allow： 白名单</li><li>Deny： 黑名单</li></ul>
        /// </summary>
        [JsonProperty("ACLType")]
        public string ACLType{ get; set; }

        /// <summary>
        /// <p>数据列表</p>
        /// </summary>
        [JsonProperty("DataList")]
        public AIGWMCPToolACLItem[] DataList{ get; set; }

        /// <summary>
        /// <p>计数</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ACLType", this.ACLType);
            this.SetParamArrayObj(map, prefix + "DataList.", this.DataList);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
        }
    }
}

