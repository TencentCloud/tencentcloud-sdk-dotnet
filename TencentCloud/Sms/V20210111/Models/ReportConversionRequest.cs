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

namespace TencentCloud.Sms.V20210111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReportConversionRequest : AbstractModel
    {
        
        /// <summary>
        /// 短信应用ID。在 [短信控制台](https://console.cloud.tencent.com/smsv2/app-manage)  添加应用后生成的实际 SdkAppId，示例如1400006666。
        /// </summary>
        [JsonProperty("SmsSdkAppId")]
        public string SmsSdkAppId{ get; set; }

        /// <summary>
        /// 发送短信返回的流水号。对应SendSms接口返回的SendStatusSet参数中的SerialNo字段。 
        /// </summary>
        [JsonProperty("SerialNo")]
        public string SerialNo{ get; set; }

        /// <summary>
        /// 用户回填时间，UNIX 时间戳（单位：秒）。
        /// </summary>
        [JsonProperty("ConversionTime")]
        public ulong? ConversionTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SmsSdkAppId", this.SmsSdkAppId);
            this.SetParamSimple(map, prefix + "SerialNo", this.SerialNo);
            this.SetParamSimple(map, prefix + "ConversionTime", this.ConversionTime);
        }
    }
}

