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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WechatPreAuthResult : AbstractModel
    {
        
        /// <summary>
        /// 商户核身单号
        /// </summary>
        [JsonProperty("AuthNo")]
        public string AuthNo{ get; set; }

        /// <summary>
        /// 微信用户标识
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty("MchId")]
        public string MchId{ get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        [JsonProperty("SubMchId")]
        public string SubMchId{ get; set; }

        /// <summary>
        /// 预核身token值
        /// </summary>
        [JsonProperty("Token")]
        public string Token{ get; set; }

        /// <summary>
        /// token有效期时间，单位：秒
        /// </summary>
        [JsonProperty("Expire")]
        public long? Expire{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuthNo", this.AuthNo);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "MchId", this.MchId);
            this.SetParamSimple(map, prefix + "SubMchId", this.SubMchId);
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "Expire", this.Expire);
        }
    }
}

