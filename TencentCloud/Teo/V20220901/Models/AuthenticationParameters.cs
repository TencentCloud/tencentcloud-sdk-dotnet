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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AuthenticationParameters : AbstractModel
    {
        
        /// <summary>
        /// 鉴权类型。取值有：
        /// 
        /// <li>TypeA：鉴权方式 A 类型，具体含义请参考 [鉴权方式 A](https://cloud.tencent.com/document/product/1552/109329)；</li>
        /// <li>TypeB：鉴权方式 B 类型，具体含义请参考 [鉴权方式 B](https://cloud.tencent.com/document/product/1552/109330)；</li>
        /// <li>TypeC：鉴权方式 C 类型，具体含义请参考 [鉴权方式 C](https://cloud.tencent.com/document/product/1552/109331)；</li>
        /// <li>TypeD：鉴权方式 D 类型，具体含义请参考 [鉴权方式 D](https://cloud.tencent.com/document/product/1552/109332)；</li>
        /// <li>TypeVOD：鉴权方式 V 类型，具体含义请参考 [鉴权方式 V](https://cloud.tencent.com/document/product/1552/109333)。</li>
        /// </summary>
        [JsonProperty("AuthType")]
        public string AuthType{ get; set; }

        /// <summary>
        /// 主鉴权密钥，由 6～40 位大小写英文字母或数字组成，不能包含 " 和 $。
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// 鉴权 URL 的有效时长，单位为秒，取值：1～630720000。用于判断客户端访问请求是否过期：
        /// <li>若当前时间超过 “timestamp + 有效时长” 时间，则为过期请求，直接返回 403。</li>
        /// <li>若当前时间未超过 “timestamp + 有效时长” 时间，则请求未过期，继续校验 md5 字符串。</li>注意：当 AuthType 为 TypeA、TypeB、TypeC、TypeD 之一时，此字段必填。
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// 备鉴权密钥，由 6～40 位大小写英文字母或数字组成，不能包含 " 和 $。
        /// </summary>
        [JsonProperty("BackupSecretKey")]
        public string BackupSecretKey{ get; set; }

        /// <summary>
        /// 鉴权参数名称，节点将校验此参数名对应的值。由 1～100 位大小写字母、数字或下划线组成。<br>注意：当 AuthType 为 TypeA、TypeD 之一时，此字段必填。
        /// </summary>
        [JsonProperty("AuthParam")]
        public string AuthParam{ get; set; }

        /// <summary>
        /// 鉴权时间戳，和 AuthParam 字段的值不能相同。<br>注意：当 AuthType 为 TypeD 时，此字段必填。
        /// </summary>
        [JsonProperty("TimeParam")]
        public string TimeParam{ get; set; }

        /// <summary>
        /// 鉴权时间格式，取值有：
        /// <li>dec：十进制；</li>
        /// <li>hex：十六进制。</li>注意：当 AuthType 为 TypeD 时，此字段必填。默认为 hex。
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "BackupSecretKey", this.BackupSecretKey);
            this.SetParamSimple(map, prefix + "AuthParam", this.AuthParam);
            this.SetParamSimple(map, prefix + "TimeParam", this.TimeParam);
            this.SetParamSimple(map, prefix + "TimeFormat", this.TimeFormat);
        }
    }
}

