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

namespace TencentCloud.Trdp.V20220726.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户外网IP地址
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 来源渠道编码
        /// </summary>
        [JsonProperty("ChannelSource")]
        public string ChannelSource{ get; set; }

        /// <summary>
        /// 用户登录平台。1：Android 2：iOS 3：H5 4：小程序
        /// </summary>
        [JsonProperty("Platform")]
        public long? Platform{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        [JsonProperty("Age")]
        public long? Age{ get; set; }

        /// <summary>
        /// 性别：
        /// male（男）
        /// female（女）
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonProperty("ResidentIdentityCard")]
        public string ResidentIdentityCard{ get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 用户地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "ChannelSource", this.ChannelSource);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "ResidentIdentityCard", this.ResidentIdentityCard);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
        }
    }
}

