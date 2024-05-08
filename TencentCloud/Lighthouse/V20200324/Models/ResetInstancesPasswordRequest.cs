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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResetInstancesPasswordRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID 列表。每次请求批量实例的上限为 100。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 实例登录密码。不同操作系统类型密码复杂度限制不一样，具体如下：</br> `LINUX_UNIX` 实例密码必须 8-30 位，推荐使用 12 位以上密码，不能以“/”开头，至少包含以下字符中的三种不同字符，字符种类：</br> <li>小写字母：[a-z]</br></li> <li>大写字母：[A-Z]</br></li> <li>数字：0-9</br></li> <li>特殊字符： ()\`\~!@#$%^&\*-+=\_|{}[]:;' <>,.?/</li></br> `WINDOWS` 实例密码必须 12-30 位，不能以“/”开头且不包括用户名，至少包含以下字符中的三种不同字符</br> <li>小写字母：[a-z]</br></li> <li>大写字母：[A-Z]</br></li> <li>数字： 0-9</br></li> <li>特殊字符：()\`~!@#$%^&\*-+=\_|{}[]:;' <>,.?/</br></li> <li>如果实例即包含 `LINUX_UNIX` 实例又包含 `WINDOWS` 实例，则密码复杂度限制按照 `WINDOWS` 实例的限制。</li>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 待重置密码的实例操作系统用户名。不得超过 64 个字符。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
        }
    }
}

