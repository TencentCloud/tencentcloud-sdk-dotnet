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

namespace TencentCloud.Vod.V20240718.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Credentials : AbstractModel
    {
        
        /// <summary>
        /// 秘钥 ID。
        /// </summary>
        [JsonProperty("AccessKeyId")]
        public string AccessKeyId{ get; set; }

        /// <summary>
        /// 秘钥 Key。
        /// </summary>
        [JsonProperty("SecretAccessKey")]
        public string SecretAccessKey{ get; set; }

        /// <summary>
        /// token。token长度和绑定的策略有关，最长不超过4096字节。
        /// </summary>
        [JsonProperty("SessionToken")]
        public string SessionToken{ get; set; }

        /// <summary>
        /// 凭据的过期时间。
        /// </summary>
        [JsonProperty("Expiration")]
        public string Expiration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessKeyId", this.AccessKeyId);
            this.SetParamSimple(map, prefix + "SecretAccessKey", this.SecretAccessKey);
            this.SetParamSimple(map, prefix + "SessionToken", this.SessionToken);
            this.SetParamSimple(map, prefix + "Expiration", this.Expiration);
        }
    }
}

