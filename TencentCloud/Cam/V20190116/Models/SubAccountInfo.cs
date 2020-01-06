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

    public class SubAccountInfo : AbstractModel
    {
        
        /// <summary>
        /// 子用户用户 ID
        /// </summary>
        [JsonProperty("Uin")]
        public ulong? Uin{ get; set; }

        /// <summary>
        /// 子用户用户名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 子用户 UID
        /// </summary>
        [JsonProperty("Uid")]
        public ulong? Uid{ get; set; }

        /// <summary>
        /// 子用户备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 子用户能否登录控制台
        /// </summary>
        [JsonProperty("ConsoleLogin")]
        public ulong? ConsoleLogin{ get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("PhoneNum")]
        public string PhoneNum{ get; set; }

        /// <summary>
        /// 区号
        /// </summary>
        [JsonProperty("CountryCode")]
        public string CountryCode{ get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ConsoleLogin", this.ConsoleLogin);
            this.SetParamSimple(map, prefix + "PhoneNum", this.PhoneNum);
            this.SetParamSimple(map, prefix + "CountryCode", this.CountryCode);
            this.SetParamSimple(map, prefix + "Email", this.Email);
        }
    }
}

