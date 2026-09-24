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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecentLoginItem : AbstractModel
    {
        
        /// <summary>
        /// <p>登录时间</p><p>参数格式：YYYY-MM-DD HH:MM:SS</p>
        /// </summary>
        [JsonProperty("LoginTime")]
        public string LoginTime{ get; set; }

        /// <summary>
        /// <p>登录方式</p><p>枚举值：</p><ul><li>0： 无效用户</li><li>1： 密码错误</li><li>2： 密码登录</li><li>3： 密钥登录</li><li>4： PAM 认证失败（sshd）</li><li>5： PAM 认证失败（tty）</li><li>6： 键盘交互登录</li><li>7： 键盘交互认证失败</li><li>8： PAM 认证失败</li></ul>
        /// </summary>
        [JsonProperty("LoginType")]
        public long? LoginType{ get; set; }

        /// <summary>
        /// <p>登录方式描述</p>
        /// </summary>
        [JsonProperty("LoginTypeDesc")]
        public string LoginTypeDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoginTime", this.LoginTime);
            this.SetParamSimple(map, prefix + "LoginType", this.LoginType);
            this.SetParamSimple(map, prefix + "LoginTypeDesc", this.LoginTypeDesc);
        }
    }
}

