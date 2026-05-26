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

    public class ApiSecSensitiveWhiteRule : AbstractModel
    {
        
        /// <summary>
        /// <p>白名单规则名称</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>加白对象配置</p>
        /// </summary>
        [JsonProperty("ApiNameOp")]
        public ApiNameOp[] ApiNameOp{ get; set; }

        /// <summary>
        /// <p>加白模式</p><p>枚举值：</p><ul><li>1： 对整个API加白</li><li>2： 对指定字段加白</li></ul>
        /// </summary>
        [JsonProperty("WhiteMode")]
        public long? WhiteMode{ get; set; }

        /// <summary>
        /// <p>加白字段配置列表</p>
        /// </summary>
        [JsonProperty("WhiteFields")]
        public ApiSecSensitiveWhiteField[] WhiteFields{ get; set; }

        /// <summary>
        /// <p>规则开关</p><p>枚举值：</p><ul><li>0： 关</li><li>1： 开</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>规则描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>修改时间</p><p>单位：s</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamArrayObj(map, prefix + "ApiNameOp.", this.ApiNameOp);
            this.SetParamSimple(map, prefix + "WhiteMode", this.WhiteMode);
            this.SetParamArrayObj(map, prefix + "WhiteFields.", this.WhiteFields);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

