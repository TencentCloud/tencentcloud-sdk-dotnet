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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GroupMemberInfo : AbstractModel
    {
        
        /// <summary>
        /// 子用户 Uid。
        /// </summary>
        [JsonProperty("Uid")]
        public ulong? Uid{ get; set; }

        /// <summary>
        /// 子用户 Uin。
        /// </summary>
        [JsonProperty("Uin")]
        public ulong? Uin{ get; set; }

        /// <summary>
        /// 子用户名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 手机号。
        /// </summary>
        [JsonProperty("PhoneNum")]
        public string PhoneNum{ get; set; }

        /// <summary>
        /// 手机区域代码。
        /// </summary>
        [JsonProperty("CountryCode")]
        public string CountryCode{ get; set; }

        /// <summary>
        /// 是否已验证手机。
        /// </summary>
        [JsonProperty("PhoneFlag")]
        public ulong? PhoneFlag{ get; set; }

        /// <summary>
        /// 邮箱地址。
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 是否已验证邮箱。
        /// </summary>
        [JsonProperty("EmailFlag")]
        public ulong? EmailFlag{ get; set; }

        /// <summary>
        /// 用户类型。
        /// </summary>
        [JsonProperty("UserType")]
        public ulong? UserType{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 是否为主消息接收人。
        /// </summary>
        [JsonProperty("IsReceiverOwner")]
        public ulong? IsReceiverOwner{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PhoneNum", this.PhoneNum);
            this.SetParamSimple(map, prefix + "CountryCode", this.CountryCode);
            this.SetParamSimple(map, prefix + "PhoneFlag", this.PhoneFlag);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "EmailFlag", this.EmailFlag);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "IsReceiverOwner", this.IsReceiverOwner);
        }
    }
}

