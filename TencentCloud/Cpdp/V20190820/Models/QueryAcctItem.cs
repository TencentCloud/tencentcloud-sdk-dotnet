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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryAcctItem : AbstractModel
    {
        
        /// <summary>
        /// 子商户类型：
        /// 个人: personal
        /// 企业：enterprise
        /// 缺省： enterprise
        /// </summary>
        [JsonProperty("SubMchType")]
        public string SubMchType{ get; set; }

        /// <summary>
        /// 子商户名称
        /// </summary>
        [JsonProperty("SubMchName")]
        public string SubMchName{ get; set; }

        /// <summary>
        /// 子账号
        /// </summary>
        [JsonProperty("SubAcctNo")]
        public string SubAcctNo{ get; set; }

        /// <summary>
        /// 不填则默认子商户名称
        /// </summary>
        [JsonProperty("ShortName")]
        public string ShortName{ get; set; }

        /// <summary>
        /// 业务平台的子商户Id，唯一
        /// </summary>
        [JsonProperty("SubMchId")]
        public string SubMchId{ get; set; }

        /// <summary>
        /// 聚鑫计费SubAppId，代表子商户
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// 子商户联系人
        /// <敏感信息>
        /// </summary>
        [JsonProperty("Contact")]
        public string Contact{ get; set; }

        /// <summary>
        /// 子商户地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 联系人手机号
        /// <敏感信息>
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 邮箱 
        /// <敏感信息>
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 子商户会员类型：
        /// general:普通子账户
        /// merchant:商户子账户
        /// 缺省： general
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubMerchantMemberType")]
        public string SubMerchantMemberType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubMchType", this.SubMchType);
            this.SetParamSimple(map, prefix + "SubMchName", this.SubMchName);
            this.SetParamSimple(map, prefix + "SubAcctNo", this.SubAcctNo);
            this.SetParamSimple(map, prefix + "ShortName", this.ShortName);
            this.SetParamSimple(map, prefix + "SubMchId", this.SubMchId);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Contact", this.Contact);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "SubMerchantMemberType", this.SubMerchantMemberType);
        }
    }
}

