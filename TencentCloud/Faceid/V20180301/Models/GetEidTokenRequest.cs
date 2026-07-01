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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetEidTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>EID商户ID。</p><ul><li>商户ID通过人脸核身控制台<a href="https://console.cloud.tencent.com/faceid/access">自助接入</a>申请。</li><li>商户ID与您通过腾讯云人脸核身控制台完成自助接入时所使用的腾讯云账号绑定。</li><li>必须使用申请该商户ID时登录的腾讯云账号所对应的腾讯云API密钥调用该接口。</li></ul>
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// <p>身份标识。</p><ul><li>未使用OCR服务时，必须传入。</li><li>规则：a-z，A-Z，0-9组合。</li><li>最长长度32位。</li></ul>
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// <p>姓名。</p><ul><li>未使用OCR服务时，必须传入。</li><li>最长长度32位。</li><li>中文请使用UTF-8编码。</li></ul>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>透传字段，在获取验证结果时返回。</p><ul><li>最长长度1024位。</li></ul>
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// <p>小程序模式配置，包括如何传入姓名身份证的配置，以及是否使用意愿核身。</p>
        /// </summary>
        [JsonProperty("Config")]
        public GetEidTokenConfig Config{ get; set; }

        /// <summary>
        /// <p>用户从Url中进入核身认证结束后重定向的回调链接地址。</p><ul><li>最长长度1024位。</li><li>EidToken会在该链接的query参数中。</li></ul>
        /// </summary>
        [JsonProperty("RedirectUrl")]
        public string RedirectUrl{ get; set; }

        /// <summary>
        /// <p>敏感数据加密信息。</p><ul><li>对传入信息（姓名、身份证号）有加密需求的用户可使用此参数，详情请点击左侧链接。</li></ul>
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

