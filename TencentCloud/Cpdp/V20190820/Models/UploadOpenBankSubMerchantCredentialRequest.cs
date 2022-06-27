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

    public class UploadOpenBankSubMerchantCredentialRequest : AbstractModel
    {
        
        /// <summary>
        /// 渠道商户ID。
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 渠道子商户ID。
        /// </summary>
        [JsonProperty("ChannelSubMerchantId")]
        public string ChannelSubMerchantId{ get; set; }

        /// <summary>
        /// 渠道名称。详见附录-枚举类型-ChannelName。
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 外部序列进件号。
        /// </summary>
        [JsonProperty("OutApplyId")]
        public string OutApplyId{ get; set; }

        /// <summary>
        /// 资质类型，详见附录-枚举类型-CredentialType。
        /// </summary>
        [JsonProperty("CredentialType")]
        public string CredentialType{ get; set; }

        /// <summary>
        /// 文件类型。
        /// 合利宝渠道，文件类型为PNG/JPG格式。
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// 支付方式。
        /// 合利宝渠道不需要传。
        /// </summary>
        [JsonProperty("PaymentMethod")]
        public string PaymentMethod{ get; set; }

        /// <summary>
        /// 资质文件内容。Base64编码，资质文件内容和链接二选一。
        /// 合利宝渠道，文件限制大小5M以内。
        /// </summary>
        [JsonProperty("CredentialContent")]
        public string CredentialContent{ get; set; }

        /// <summary>
        /// 资质文件链接。资质文件内容和链接二选一。
        /// 合利宝渠道，文件限制大小5M以内。
        /// </summary>
        [JsonProperty("CredentialUrl")]
        public string CredentialUrl{ get; set; }

        /// <summary>
        /// 环境类型。
        /// __release__:生产环境
        /// __sandbox__:沙箱环境
        /// _不填默认为生产环境_
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelMerchantId", this.ChannelMerchantId);
            this.SetParamSimple(map, prefix + "ChannelSubMerchantId", this.ChannelSubMerchantId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "OutApplyId", this.OutApplyId);
            this.SetParamSimple(map, prefix + "CredentialType", this.CredentialType);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "PaymentMethod", this.PaymentMethod);
            this.SetParamSimple(map, prefix + "CredentialContent", this.CredentialContent);
            this.SetParamSimple(map, prefix + "CredentialUrl", this.CredentialUrl);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

