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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EditAuthConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境id
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 手机号登录配置 "TRUE",  "FALSE", "LOGIN_ONLY"
        /// </summary>
        [JsonProperty("PhoneNumberLogin")]
        public string PhoneNumberLogin{ get; set; }

        /// <summary>
        /// 匿名登录配置 "TRUE",  "FALSE"
        /// </summary>
        [JsonProperty("AnonymousLogin")]
        public string AnonymousLogin{ get; set; }

        /// <summary>
        /// 用户名密码登录配置 "TRUE",  "FALSE"
        /// </summary>
        [JsonProperty("UsernameLogin")]
        public string UsernameLogin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "PhoneNumberLogin", this.PhoneNumberLogin);
            this.SetParamSimple(map, prefix + "AnonymousLogin", this.AnonymousLogin);
            this.SetParamSimple(map, prefix + "UsernameLogin", this.UsernameLogin);
        }
    }
}

