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

    public class PayRollAuthResult : AbstractModel
    {
        
        /// <summary>
        /// 结果为核身失败时的原因描述，仅在失败记录返回，空字符串等同null
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthFailedReason")]
        public string AuthFailedReason{ get; set; }

        /// <summary>
        /// 商户系统内部的商家核身单号，要求此参数只能由数字、大小写字母组成，在服务商内部唯一
        /// </summary>
        [JsonProperty("AuthNumber")]
        public string AuthNumber{ get; set; }

        /// <summary>
        /// 核身渠道，发起核身时的来源渠道，如通过小程序，硬件设备等
        /// FROM_MINI_APP：来自小程序方式核身
        /// FROM_HARDWARE：来自硬件设备方式核身
        /// </summary>
        [JsonProperty("AuthScene")]
        public string AuthScene{ get; set; }

        /// <summary>
        /// 核身渠道标识，用于定位渠道具体来源，如果是扫码打卡渠道标识就是具体的小程序appid，若是硬件设备，则是设备的序列号等
        /// </summary>
        [JsonProperty("AuthSource")]
        public string AuthSource{ get; set; }

        /// <summary>
        /// 核身状态
        /// AUTHENTICATE_PROCESSING：核身中
        /// AUTHENTICATE_SUCCESS：核身成功
        /// AUTHENTICATE_FAILED：核身失败
        /// </summary>
        [JsonProperty("AuthStatus")]
        public string AuthStatus{ get; set; }

        /// <summary>
        /// 核身时间，遵循[rfc3339](https://datatracker.ietf.org/doc/html/rfc3339)标准格式，格式为YYYY-MM-DDTHH:mm:ss.sss+TIMEZONE
        /// </summary>
        [JsonProperty("AuthTime")]
        public string AuthTime{ get; set; }

        /// <summary>
        /// 该用户所属的单位名称
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// 微信服务商商户的商户号，由微信支付生成并下发
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId{ get; set; }

        /// <summary>
        /// 用户在商户对应appid下的唯一标识
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 该项目的名称
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 微信服务商下特约商户的商户号，由微信支付生成并下发
        /// </summary>
        [JsonProperty("SubMerchantId")]
        public string SubMerchantId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuthFailedReason", this.AuthFailedReason);
            this.SetParamSimple(map, prefix + "AuthNumber", this.AuthNumber);
            this.SetParamSimple(map, prefix + "AuthScene", this.AuthScene);
            this.SetParamSimple(map, prefix + "AuthSource", this.AuthSource);
            this.SetParamSimple(map, prefix + "AuthStatus", this.AuthStatus);
            this.SetParamSimple(map, prefix + "AuthTime", this.AuthTime);
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamSimple(map, prefix + "MerchantId", this.MerchantId);
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "SubMerchantId", this.SubMerchantId);
        }
    }
}

