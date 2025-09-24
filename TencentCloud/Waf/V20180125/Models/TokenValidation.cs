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

    public class TokenValidation : AbstractModel
    {
        
        /// <summary>
        /// 是否开启token有效性校验
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// token有效性的校验方式，可选值为：jws、jwe、contains、len、regex
        /// </summary>
        [JsonProperty("VerifyType")]
        public string VerifyType{ get; set; }

        /// <summary>
        /// 有效性校验配置和规则
        /// </summary>
        [JsonProperty("VerifyRule")]
        public TokenVerifyRule VerifyRule{ get; set; }

        /// <summary>
        /// Token显示设置（只有当校验方式为jws/jwe的时候才会有该配置信息）
        /// </summary>
        [JsonProperty("DisplaySetting")]
        public TokenDisplaySetting DisplaySetting{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "VerifyType", this.VerifyType);
            this.SetParamObj(map, prefix + "VerifyRule.", this.VerifyRule);
            this.SetParamObj(map, prefix + "DisplaySetting.", this.DisplaySetting);
        }
    }
}

