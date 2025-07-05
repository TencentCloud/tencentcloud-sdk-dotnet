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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OtherAccountInfo : AbstractModel
    {
        
        /// <summary>
        /// 其他账号信息；
        /// AccountType是10004时，填入中国大陆标准11位手机号的MD5值
        /// AccountType是10005时，填入中国大陆标准11位手机号的SHA256值
        /// 注释：
        /// MD5手机号加密方式，使用中国大陆11位手机号进行MD5加密，加密后取32位小写值。
        /// SHA256手机号加密方式，使用中国大陆11位手机号进行SHA256加密，加密后取64位小写值。
        /// </summary>
        [JsonProperty("AccountId")]
        public string AccountId{ get; set; }

        /// <summary>
        /// 账号绑定的MD5或SHA256加密的手机号（该字段已不推荐使用）。
        /// 注释：支持标准中国大陆11位手机号MD5加密后位的32位小写字符串；
        ///      支持标准中国大陆11位手机号SHA256加密后位的64位小写字符串。
        /// </summary>
        [JsonProperty("MobilePhone")]
        public string MobilePhone{ get; set; }

        /// <summary>
        /// 用户设备号（该字段已不推荐使用）。
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccountId", this.AccountId);
            this.SetParamSimple(map, prefix + "MobilePhone", this.MobilePhone);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
        }
    }
}

