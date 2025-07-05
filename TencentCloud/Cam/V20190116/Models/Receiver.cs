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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Receiver : AbstractModel
    {
        
        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("Uid")]
        public ulong? Uid{ get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// 手机号码是否验证
        /// </summary>
        [JsonProperty("PhoneFlag")]
        public long? PhoneFlag{ get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 邮箱是否验证
        /// </summary>
        [JsonProperty("EmailFlag")]
        public long? EmailFlag{ get; set; }

        /// <summary>
        /// 是否主联系人
        /// </summary>
        [JsonProperty("IsReceiverOwner")]
        public long? IsReceiverOwner{ get; set; }

        /// <summary>
        /// 是否允许微信接收通知
        /// </summary>
        [JsonProperty("WechatFlag")]
        public long? WechatFlag{ get; set; }

        /// <summary>
        /// 账号uin
        /// </summary>
        [JsonProperty("Uin")]
        public long? Uin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "PhoneFlag", this.PhoneFlag);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "EmailFlag", this.EmailFlag);
            this.SetParamSimple(map, prefix + "IsReceiverOwner", this.IsReceiverOwner);
            this.SetParamSimple(map, prefix + "WechatFlag", this.WechatFlag);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
        }
    }
}

