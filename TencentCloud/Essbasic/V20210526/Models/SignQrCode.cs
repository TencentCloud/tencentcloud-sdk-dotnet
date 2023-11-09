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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SignQrCode : AbstractModel
    {
        
        /// <summary>
        /// 二维码ID，为32位字符串。	
        /// 
        /// 注: 需要保留此二维码ID, 用于后序通过<a href="https://qian.tencent.com/developers/partnerApis/templates/ChannelCancelMultiFlowSignQRCode" target="_blank">取消一码多扫二维码</a>关闭这个二维码的签署功能。	
        /// </summary>
        [JsonProperty("QrCodeId")]
        public string QrCodeId{ get; set; }

        /// <summary>
        /// 二维码URL，可通过转换二维码的工具或代码组件将此URL转化为二维码，以便用户扫描进行流程签署。	
        /// </summary>
        [JsonProperty("QrCodeUrl")]
        public string QrCodeUrl{ get; set; }

        /// <summary>
        /// 二维码的有截止时间，格式为Unix标准时间戳（秒），可以通过入参的QrEffectiveDay来设置有效期，默认为7天有效期。 
        /// 一旦超过二维码的有效期限，该二维码将自动失效。	
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public long? ExpiredTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QrCodeId", this.QrCodeId);
            this.SetParamSimple(map, prefix + "QrCodeUrl", this.QrCodeUrl);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
        }
    }
}

