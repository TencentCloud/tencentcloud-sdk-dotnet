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

    public class CreateAcctRequest : AbstractModel
    {
        
        /// <summary>
        /// 聚鑫平台分配的支付MidasAppId
        /// </summary>
        [JsonProperty("MidasAppId")]
        public string MidasAppId{ get; set; }

        /// <summary>
        /// 业务平台的子商户ID，唯一
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
        /// <敏感信息>加密详见<a href="https://cloud.tencent.com/document/product/1122/48979" target="_blank">《商户端接口敏感信息加密说明》</a>
        /// </summary>
        [JsonProperty("Contact")]
        public string Contact{ get; set; }

        /// <summary>
        /// 联系人手机号
        /// <敏感信息>加密详见<a href="https://cloud.tencent.com/document/product/1122/48979" target="_blank">《商户端接口敏感信息加密说明》</a>
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 邮箱 
        /// <敏感信息>加密详见<a href="https://cloud.tencent.com/document/product/1122/48979" target="_blank">《商户端接口敏感信息加密说明》</a>
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
        /// 企业: enterprise
        /// 个体工商户: individual
        /// 缺省: enterprise
        /// </summary>
        [JsonProperty("SubMchType")]
        public string SubMchType{ get; set; }

        /// <summary>
        /// 不填则默认子商户名称
        /// </summary>
        [JsonProperty("ShortName")]
        public string ShortName{ get; set; }

        /// <summary>
        /// 子商户会员类型：
        /// general: 普通子账户
        /// merchant: 商户子账户
        /// 缺省: general
        /// </summary>
        [JsonProperty("SubMerchantMemberType")]
        public string SubMerchantMemberType{ get; set; }

        /// <summary>
        /// 子商户密钥
        /// <敏感信息>加密详见<a href="https://cloud.tencent.com/document/product/1122/48979" target="_blank">《商户端接口敏感信息加密说明》</a>
        /// </summary>
        [JsonProperty("SubMerchantKey")]
        public string SubMerchantKey{ get; set; }

        /// <summary>
        /// 子商户私钥
        /// <敏感信息>加密详见<a href="https://cloud.tencent.com/document/product/1122/48979" target="_blank">《商户端接口敏感信息加密说明》</a>
        /// </summary>
        [JsonProperty("SubMerchantPrivateKey")]
        public string SubMerchantPrivateKey{ get; set; }

        /// <summary>
        /// 敏感信息加密类型:
        /// RSA: rsa非对称加密，使用RSA-PKCS1-v1_5
        /// AES: aes对称加密，使用AES256-CBC-PCKS7padding
        /// 缺省: RSA
        /// </summary>
        [JsonProperty("EncryptType")]
        public string EncryptType{ get; set; }

        /// <summary>
        /// 银行生成的子商户账户，已开户的场景需要录入
        /// </summary>
        [JsonProperty("SubAcctNo")]
        public string SubAcctNo{ get; set; }

        /// <summary>
        /// 环境名:
        /// release: 现网环境
        /// sandbox: 沙箱环境
        /// development: 开发环境
        /// 缺省: release
        /// </summary>
        [JsonProperty("MidasEnvironment")]
        public string MidasEnvironment{ get; set; }

        /// <summary>
        /// 店铺名称
        /// 企业、个体工商户必输
        /// </summary>
        [JsonProperty("SubMerchantStoreName")]
        public string SubMerchantStoreName{ get; set; }

        /// <summary>
        /// 公司信息
        /// </summary>
        [JsonProperty("OrganizationInfo")]
        public OrganizationInfo OrganizationInfo{ get; set; }

        /// <summary>
        /// 子商户证件类型
        /// 1 - 身份证
        /// 3 - 回乡证
        /// 4 - 中国护照
        /// 5 - 台胞证
        /// 19 - 外国护照
        /// 52 - 组织机构代码证
        /// 68 - 营业执照 
        /// 73 - 统一社会信用代码
        /// </summary>
        [JsonProperty("SubMerchantIdType")]
        public string SubMerchantIdType{ get; set; }

        /// <summary>
        /// 子商户证件号码
        /// <敏感信息>加密详见<a href="https://cloud.tencent.com/document/product/1122/48979" target="_blank">《商户端接口敏感信息加密说明》</a>
        /// </summary>
        [JsonProperty("SubMerchantIdCode")]
        public string SubMerchantIdCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
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
            this.SetParamSimple(map, prefix + "SubMerchantMemberType", this.SubMerchantMemberType);
            this.SetParamSimple(map, prefix + "SubMerchantKey", this.SubMerchantKey);
            this.SetParamSimple(map, prefix + "SubMerchantPrivateKey", this.SubMerchantPrivateKey);
            this.SetParamSimple(map, prefix + "EncryptType", this.EncryptType);
            this.SetParamSimple(map, prefix + "SubAcctNo", this.SubAcctNo);
            this.SetParamSimple(map, prefix + "MidasEnvironment", this.MidasEnvironment);
            this.SetParamSimple(map, prefix + "SubMerchantStoreName", this.SubMerchantStoreName);
            this.SetParamObj(map, prefix + "OrganizationInfo.", this.OrganizationInfo);
            this.SetParamSimple(map, prefix + "SubMerchantIdType", this.SubMerchantIdType);
            this.SetParamSimple(map, prefix + "SubMerchantIdCode", this.SubMerchantIdCode);
        }
    }
}

