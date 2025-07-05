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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResetInstancesPasswordRequest : AbstractModel
    {
        
        /// <summary>
        /// 一个或多个待操作的实例ID。可通过[DescribeInstances](https://cloud.tencent.com/document/api/213/15728) API返回值中的`InstanceId`获取。每次请求允许操作的实例数量上限是100。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 重置后的实例登录密码。不同操作系统类型密码复杂度限制不一样，具体如下：Linux 实例密码必须8-30位，推荐使用12位以上密码，不能以“/”开头，至少包含以下字符中的三种不同字符，字符种类：<br><li>小写字母：[a-z]</li><li>大写字母：[A-Z]</li><li>数字：0-9</li><li>特殊字符： ()\`\~!@#$%^&\*-+=\_|{}[]:;'<>,.?/Windows 实例密码必须12\~30位，不能以“/”开头且不包括用户名，至少包含以下字符中的三种不同字符</li><li>小写字母：[a-z]</li><li>大写字母：[A-Z]</li><li>数字： 0-9</li><li>特殊字符：()\`\~!@#$%^&\*-+=\_|{}[]:;' <>,.?/</li><li>如果实例即包含 `Linux` 实例又包含 `Windows` 实例，则密码复杂度限制按照 `Windows` 实例的限制。</li>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 待重置密码的实例操作系统的用户名。不得超过64个字符。
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 是否对运行中的实例选择强制关机。建议对运行中的实例先手动关机，然后再重置用户密码。取值范围：<br><li>true：表示在正常关机失败后进行强制关机</li><li>false：表示在正常关机失败后不进行强制关机</li>默认取值：false。<br><br>强制关机的效果等同于关闭物理计算机的电源开关。强制关机可能会导致数据丢失或文件系统损坏，请仅在服务器不能正常关机时使用。
        /// </summary>
        [JsonProperty("ForceStop")]
        public bool? ForceStop{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "ForceStop", this.ForceStop);
        }
    }
}

