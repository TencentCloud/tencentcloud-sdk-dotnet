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

namespace TencentCloud.Sms.V20190711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PullSmsSendStatus : AbstractModel
    {
        
        /// <summary>
        /// 用户实际接收到短信的时间。
        /// </summary>
        [JsonProperty("UserReceiveTime")]
        public string UserReceiveTime{ get; set; }

        /// <summary>
        /// 用户实际接收到短信的时间，UNIX 时间戳（单位：秒）。
        /// </summary>
        [JsonProperty("UserReceiveUnixTime")]
        public ulong? UserReceiveUnixTime{ get; set; }

        /// <summary>
        /// 国家（或地区）码。
        /// </summary>
        [JsonProperty("NationCode")]
        public string NationCode{ get; set; }

        /// <summary>
        /// 手机号码,e.164标准，+[国家或地区码][手机号] ，示例如：+8618501234444， 其中前面有一个+号 ，86为国家码，18501234444为手机号。
        /// </summary>
        [JsonProperty("PurePhoneNumber")]
        public string PurePhoneNumber{ get; set; }

        /// <summary>
        /// 手机号码，普通格式，示例如：18501234444。
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// 本次发送标识 ID。
        /// </summary>
        [JsonProperty("SerialNo")]
        public string SerialNo{ get; set; }

        /// <summary>
        /// 实际是否收到的短信接收状态，SUCCESS（下发成功）、FAIL（下发失败）。
        /// 注：仅当运营商有返回短信接收状态时回包中才会有状态数据。
        /// </summary>
        [JsonProperty("ReportStatus")]
        public string ReportStatus{ get; set; }

        /// <summary>
        /// 用户接收短信状态描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserReceiveTime", this.UserReceiveTime);
            this.SetParamSimple(map, prefix + "UserReceiveUnixTime", this.UserReceiveUnixTime);
            this.SetParamSimple(map, prefix + "NationCode", this.NationCode);
            this.SetParamSimple(map, prefix + "PurePhoneNumber", this.PurePhoneNumber);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "SerialNo", this.SerialNo);
            this.SetParamSimple(map, prefix + "ReportStatus", this.ReportStatus);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

