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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdvancedAuthenticationTypeB : AbstractModel
    {
        
        /// <summary>
        /// alpha键名。
        /// </summary>
        [JsonProperty("KeyAlpha")]
        public string KeyAlpha{ get; set; }

        /// <summary>
        /// beta键名。
        /// </summary>
        [JsonProperty("KeyBeta")]
        public string KeyBeta{ get; set; }

        /// <summary>
        /// gamma键名。
        /// </summary>
        [JsonProperty("KeyGamma")]
        public string KeyGamma{ get; set; }

        /// <summary>
        /// uri串中签名的字段名，字母，数字或下划线构成，同时必须以字母开头。
        /// </summary>
        [JsonProperty("SignParam")]
        public string SignParam{ get; set; }

        /// <summary>
        /// uri串中时间的字段名，字母，数字或下划线构成，同时必须以字母开头。
        /// </summary>
        [JsonProperty("TimeParam")]
        public string TimeParam{ get; set; }

        /// <summary>
        /// 过期时间，单位秒。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public long? ExpireTime{ get; set; }

        /// <summary>
        /// 时间格式，dec，hex分别表示十进制，十六进制。
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }

        /// <summary>
        /// 鉴权失败时返回的状态码。
        /// </summary>
        [JsonProperty("FailCode")]
        public long? FailCode{ get; set; }

        /// <summary>
        /// 链接过期时返回的状态码。
        /// </summary>
        [JsonProperty("ExpireCode")]
        public long? ExpireCode{ get; set; }

        /// <summary>
        /// 需要鉴权的url路径列表。
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyAlpha", this.KeyAlpha);
            this.SetParamSimple(map, prefix + "KeyBeta", this.KeyBeta);
            this.SetParamSimple(map, prefix + "KeyGamma", this.KeyGamma);
            this.SetParamSimple(map, prefix + "SignParam", this.SignParam);
            this.SetParamSimple(map, prefix + "TimeParam", this.TimeParam);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "TimeFormat", this.TimeFormat);
            this.SetParamSimple(map, prefix + "FailCode", this.FailCode);
            this.SetParamSimple(map, prefix + "ExpireCode", this.ExpireCode);
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
        }
    }
}

