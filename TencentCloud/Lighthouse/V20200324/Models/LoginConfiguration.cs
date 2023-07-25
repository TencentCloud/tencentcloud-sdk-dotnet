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

    public class LoginConfiguration : AbstractModel
    {
        
        /// <summary>
        /// <li>"YES"代表选择自动生成密码，这时不指定Password字段。</li>
        /// <li>"NO"代表选择自定义密码，这时要指定Password字段。</li>
        /// </summary>
        [JsonProperty("AutoGeneratePassword")]
        public string AutoGeneratePassword{ get; set; }

        /// <summary>
        /// 实例登录密码。具体按照操作系统的复杂度要求。 
        /// `LINUX_UNIX` 实例密码必须 8-30 位，推荐使用 12 位以上密码，不能包含空格, 不能以“/”开头，至少包含以下字符中的三种不同字符，字符种类：<br><li>小写字母：[a-z]<br><li>大写字母：[A-Z]<br><li>数字：0-9<br><li>特殊字符： ()\`\~!@#$%^&\*-+=\_|{}[]:;' <>,.?/</li>
        /// `WINDOWS` 实例密码必须 12-30 位，不能包含空格, 不能以“/”开头且不包括用户名，至少包含以下字符中的三种不同字符<br><li>小写字母：[a-z]<br><li>大写字母：[A-Z]<br><li>数字： 0-9<br><li>特殊字符：()\`~!@#$%^&\*-+=\_|{}[]:;' <>,.?/
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 密钥ID列表，最多同时指定5个密钥。关联密钥后，就可以通过对应的私钥来访问实例。密钥与密码不能同时指定，同时WINDOWS操作系统不支持指定密钥。密钥ID列表可以通过[DescribeKeyPairs](https://cloud.tencent.com/document/product/1207/55540)接口获取。
        /// </summary>
        [JsonProperty("KeyIds")]
        public string[] KeyIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoGeneratePassword", this.AutoGeneratePassword);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamArraySimple(map, prefix + "KeyIds.", this.KeyIds);
        }
    }
}

