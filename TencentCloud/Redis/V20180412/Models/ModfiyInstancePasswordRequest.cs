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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModfiyInstancePasswordRequest : AbstractModel
    {
        
        /// <summary>
        /// 指定实例 ID。例如：crs-xjhsdj****。请登录[Redis控制台](https://console.cloud.tencent.com/redis)在实例列表复制实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例旧密码。
        /// </summary>
        [JsonProperty("OldPassword")]
        public string OldPassword{ get; set; }

        /// <summary>
        /// 实例新密码。密码复杂度要求如下：
        /// - 长度8 - 64位, 推荐使用12位以上的密码。
        /// - 不能以"/"开头。
        /// - 至少包含小写字母a - z、大写字母A - Z、数字0 - 9、特殊字符 ()~!@#$%^&*-+=_|{}[]:;<>,.?/中的两项。
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 是否加密密码
        /// </summary>
        [JsonProperty("EncryptPassword")]
        public bool? EncryptPassword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "OldPassword", this.OldPassword);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "EncryptPassword", this.EncryptPassword);
        }
    }
}

