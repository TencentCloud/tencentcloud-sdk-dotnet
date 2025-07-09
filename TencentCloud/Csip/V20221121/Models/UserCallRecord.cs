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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserCallRecord : AbstractModel
    {
        
        /// <summary>
        /// 调用源IP
        /// </summary>
        [JsonProperty("SourceIP")]
        public string SourceIP{ get; set; }

        /// <summary>
        /// 调用类型
        /// 0:控制台调用
        /// 1:API
        /// </summary>
        [JsonProperty("EventType")]
        public long? EventType{ get; set; }

        /// <summary>
        /// 调用次数
        /// </summary>
        [JsonProperty("CallCount")]
        public long? CallCount{ get; set; }

        /// <summary>
        /// 调用错误码
        /// 0表示成功
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// 首次调用时间
        /// </summary>
        [JsonProperty("FirstCallTime")]
        public string FirstCallTime{ get; set; }

        /// <summary>
        /// 最后调用时间
        /// </summary>
        [JsonProperty("LastCallTime")]
        public string LastCallTime{ get; set; }

        /// <summary>
        /// 调用源IP备注
        /// </summary>
        [JsonProperty("SourceIPRemark")]
        public string SourceIPRemark{ get; set; }

        /// <summary>
        /// 调用源IP地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 用户/角色名称
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 聚合日期
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// appid
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// 运营商
        /// </summary>
        [JsonProperty("ISP")]
        public string ISP{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceIP", this.SourceIP);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "CallCount", this.CallCount);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "FirstCallTime", this.FirstCallTime);
            this.SetParamSimple(map, prefix + "LastCallTime", this.LastCallTime);
            this.SetParamSimple(map, prefix + "SourceIPRemark", this.SourceIPRemark);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "ISP", this.ISP);
        }
    }
}

