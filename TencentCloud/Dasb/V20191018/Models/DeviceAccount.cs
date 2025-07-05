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

namespace TencentCloud.Dasb.V20191018.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceAccount : AbstractModel
    {
        
        /// <summary>
        /// 账号ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 主机ID
        /// </summary>
        [JsonProperty("DeviceId")]
        public ulong? DeviceId{ get; set; }

        /// <summary>
        /// 账号名
        /// </summary>
        [JsonProperty("Account")]
        public string Account{ get; set; }

        /// <summary>
        /// true-已托管密码，false-未托管密码
        /// </summary>
        [JsonProperty("BoundPassword")]
        public bool? BoundPassword{ get; set; }

        /// <summary>
        /// true-已托管私钥，false-未托管私钥
        /// </summary>
        [JsonProperty("BoundPrivateKey")]
        public bool? BoundPrivateKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "Account", this.Account);
            this.SetParamSimple(map, prefix + "BoundPassword", this.BoundPassword);
            this.SetParamSimple(map, prefix + "BoundPrivateKey", this.BoundPrivateKey);
        }
    }
}

