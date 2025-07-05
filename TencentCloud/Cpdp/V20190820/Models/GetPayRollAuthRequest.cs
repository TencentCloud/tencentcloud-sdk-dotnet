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

    public class GetPayRollAuthRequest : AbstractModel
    {
        
        /// <summary>
        /// 用户在商户对应appid下的唯一标识
        /// </summary>
        [JsonProperty("OpenId")]
        public string OpenId{ get; set; }

        /// <summary>
        /// 微信服务商下特约商户的商户号，由微信支付生成并下发
        /// </summary>
        [JsonProperty("SubMerchantId")]
        public string SubMerchantId{ get; set; }

        /// <summary>
        /// 是服务商在微信申请公众号/小程序或移动应用成功后分配的账号ID（与服务商主体一致）
        /// 当输入服务商Appid时，会校验其与服务商商户号的绑定关系。服务商APPID和与特约商户APPID至少输入一个，且必须要有拉起领薪卡小程序时使用的APPID
        /// </summary>
        [JsonProperty("WechatAppId")]
        public string WechatAppId{ get; set; }

        /// <summary>
        /// 特约商户在微信申请公众号/小程序或移动应用成功后分配的账号ID（与特约商户主体一致）
        /// 当输入特约商户Appid时，会校验其与特约商户号的绑定关系。服务商APPID和与特约商户APPID至少输入一个，且必须要有拉起领薪卡小程序时使用的APPID
        /// </summary>
        [JsonProperty("WechatSubAppId")]
        public string WechatSubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpenId", this.OpenId);
            this.SetParamSimple(map, prefix + "SubMerchantId", this.SubMerchantId);
            this.SetParamSimple(map, prefix + "WechatAppId", this.WechatAppId);
            this.SetParamSimple(map, prefix + "WechatSubAppId", this.WechatSubAppId);
        }
    }
}

