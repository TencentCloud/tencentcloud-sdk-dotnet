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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OtherAccountInfo : AbstractModel
    {
        
        /// <summary>
        /// 其它账号信息：  
        /// AccountType 是 4 时，填入真实的手机号（如 13123456789）。 
        /// AccountType 是 8 时，支持 imei、idfa、imeiMD5、idfaMD5入参。  
        /// AccountType 是 0 时，填入账号信息。  
        /// AccountType 是 10004 时，填入手机号的 MD5 值。 
        /// 注：imeiMd5 加密方式为：  
        /// imei 明文小写后，进行 MD5 加密，加密后取小写值。  
        /// IdfaMd5 加密方式为：idfa 明文大写后，进行 MD5 加密，加密后取小写值。
        /// </summary>
        [JsonProperty("AccountId")]
        public string AccountId{ get; set; }

        /// <summary>
        /// 手机号，若 AccountType 是 4（手机号）、或 10004（手机号 MD5），则无需重复填写 
        /// 否则填入对应的手机号（如 13123456789）。
        /// </summary>
        [JsonProperty("MobilePhone")]
        public string MobilePhone{ get; set; }

        /// <summary>
        /// 用户设备号。若 AccountType 是 8（设备号），则无需重复填写，否则填入对应的设备 
        /// 号。 
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

