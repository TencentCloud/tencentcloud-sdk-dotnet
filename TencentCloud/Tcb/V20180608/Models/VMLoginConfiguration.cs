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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VMLoginConfiguration : AbstractModel
    {
        
        /// <summary>
        /// 登录方式。扫码登录时指定为 SCAN_LOGIN
        /// </summary>
        [JsonProperty("LoginType")]
        public string LoginType{ get; set; }

        /// <summary>
        /// 是否自动生成密码
        /// </summary>
        [JsonProperty("AutoGeneratePassword")]
        public string AutoGeneratePassword{ get; set; }

        /// <summary>
        /// 指定密码登录
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 绑定密钥ID
        /// </summary>
        [JsonProperty("KeyIds")]
        public string[] KeyIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoginType", this.LoginType);
            this.SetParamSimple(map, prefix + "AutoGeneratePassword", this.AutoGeneratePassword);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamArraySimple(map, prefix + "KeyIds.", this.KeyIds);
        }
    }
}

