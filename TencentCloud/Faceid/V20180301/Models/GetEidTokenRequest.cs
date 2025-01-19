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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetEidTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// EID商户ID。通过人脸核身控制台[自助接入](https://console.cloud.tencent.com/faceid/access)申请。
        /// - 字段长度最长50位。
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 身份标识。
        /// - 未使用OCR服务时，必须传入。
        /// - 规则：a-z，A-Z，0-9组合。
        /// - 最长长度32位。
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// 姓名。
        /// - 未使用OCR服务时，必须传入。
        /// - 最长长度32位。
        /// - 中文请使用UTF-8编码。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 透传字段，在获取验证结果时返回。
        /// - 最长长度1024位。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// 小程序模式配置，包括如何传入姓名身份证的配置，以及是否使用意愿核身。
        /// </summary>
        [JsonProperty("Config")]
        public GetEidTokenConfig Config{ get; set; }

        /// <summary>
        /// 用户从Url中进入核身认证结束后重定向的回调链接地址。
        /// - 最长长度1024位。
        /// - EidToken会在该链接的query参数中。
        /// </summary>
        [JsonProperty("RedirectUrl")]
        public string RedirectUrl{ get; set; }

        /// <summary>
        /// 敏感数据加密信息。
        /// - 对传入信息（姓名、身份证号）有加密需求的用户可使用此参数，详情请点击左侧链接。
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamSimple(map, prefix + "RedirectUrl", this.RedirectUrl);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
        }
    }
}

