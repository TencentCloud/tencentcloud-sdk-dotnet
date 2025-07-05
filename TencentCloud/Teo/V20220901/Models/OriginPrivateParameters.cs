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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginPrivateParameters : AbstractModel
    {
        
        /// <summary>
        /// 鉴权参数 Access Key ID。
        /// </summary>
        [JsonProperty("AccessKeyId")]
        public string AccessKeyId{ get; set; }

        /// <summary>
        /// 鉴权参数 Secret Access Key。
        /// </summary>
        [JsonProperty("SecretAccessKey")]
        public string SecretAccessKey{ get; set; }

        /// <summary>
        /// 鉴权版本。取值有：
        /// <li>v2：v2版本；</li>
        /// <li>v4：v4版本。</li>
        /// </summary>
        [JsonProperty("SignatureVersion")]
        public string SignatureVersion{ get; set; }

        /// <summary>
        /// 存储桶地域。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessKeyId", this.AccessKeyId);
            this.SetParamSimple(map, prefix + "SecretAccessKey", this.SecretAccessKey);
            this.SetParamSimple(map, prefix + "SignatureVersion", this.SignatureVersion);
            this.SetParamSimple(map, prefix + "Region", this.Region);
        }
    }
}

