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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAcctRequest : AbstractModel
    {
        
        /// <summary>
        /// 聚鑫平台分配的支付MidasAppId
        /// </summary>
        [JsonProperty("MidasAppId")]
        public string MidasAppId{ get; set; }

        /// <summary>
        /// 业务平台的子商户Id，唯一
        /// </summary>
        [JsonProperty("SubMchId")]
        public string SubMchId{ get; set; }

        /// <summary>
        /// 子商户名称
        /// </summary>
        [JsonProperty("SubMchName")]
        public string SubMchName{ get; set; }

        /// <summary>
        /// 子商户地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 子商户联系人
        /// <敏感信息>加密详见《商户端接口敏感信息加密说明》
        /// </summary>
        [JsonProperty("Contact")]
        public string Contact{ get; set; }

        /// <summary>
        /// 联系人手机号
        /// <敏感信息>加密详见《商户端接口敏感信息加密说明》
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 邮箱 
        /// <敏感信息>加密详见《商户端接口敏感信息加密说明》
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 聚鑫分配的安全ID
        /// </summary>
        [JsonProperty("MidasSecretId")]
        public string MidasSecretId{ get; set; }

        /// <summary>
        /// 按照聚鑫安全密钥计算的签名
        /// </summary>
        [JsonProperty("MidasSignature")]
        public string MidasSignature{ get; set; }

        /// <summary>
        /// 子商户类型：
        /// 个人: personal
        /// 企业：enterprise
        /// 缺省： enterprise
        /// </summary>
        [JsonProperty("SubMchType")]
        public string SubMchType{ get; set; }

        /// <summary>
        /// 不填则默认子商户名称
        /// </summary>
        [JsonProperty("ShortName")]
        public string ShortName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MidasAppId", this.MidasAppId);
            this.SetParamSimple(map, prefix + "SubMchId", this.SubMchId);
            this.SetParamSimple(map, prefix + "SubMchName", this.SubMchName);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Contact", this.Contact);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "MidasSecretId", this.MidasSecretId);
            this.SetParamSimple(map, prefix + "MidasSignature", this.MidasSignature);
            this.SetParamSimple(map, prefix + "SubMchType", this.SubMchType);
            this.SetParamSimple(map, prefix + "ShortName", this.ShortName);
        }
    }
}

