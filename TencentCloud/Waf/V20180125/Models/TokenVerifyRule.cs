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

    public class TokenVerifyRule : AbstractModel
    {
        
        /// <summary>
        /// JWS、JWE专用校验规则
        /// </summary>
        [JsonProperty("JWTRule")]
        public JWTConfig JWTRule{ get; set; }

        /// <summary>
        /// 其他会话有效性校验方式(contains、length、regex)的校验规则
        /// </summary>
        [JsonProperty("GeneralRule")]
        public TokenRuleEntry GeneralRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "JWTRule.", this.JWTRule);
            this.SetParamObj(map, prefix + "GeneralRule.", this.GeneralRule);
        }
    }
}

