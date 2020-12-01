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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdvancedAuthenticationTypeD : AbstractModel
    {
        
        /// <summary>
        /// 用于计算签名的密钥，只允许字母和数字，长度6-32字节。
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// 备份密钥，当使用SecretKey鉴权失败时会使用该密钥重新鉴权。
        /// </summary>
        [JsonProperty("BackupSecretKey")]
        public string BackupSecretKey{ get; set; }

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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "BackupSecretKey", this.BackupSecretKey);
            this.SetParamSimple(map, prefix + "SignParam", this.SignParam);
            this.SetParamSimple(map, prefix + "TimeParam", this.TimeParam);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "TimeFormat", this.TimeFormat);
        }
    }
}

