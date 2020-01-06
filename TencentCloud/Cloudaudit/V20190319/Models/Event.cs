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

namespace TencentCloud.Cloudaudit.V20190319.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Event : AbstractModel
    {
        
        /// <summary>
        /// 资源对
        /// </summary>
        [JsonProperty("Resources")]
        public Resource Resources{ get; set; }

        /// <summary>
        /// 主账号ID
        /// </summary>
        [JsonProperty("AccountID")]
        public long? AccountID{ get; set; }

        /// <summary>
        /// 日志详情
        /// </summary>
        [JsonProperty("CloudAuditEvent")]
        public string CloudAuditEvent{ get; set; }

        /// <summary>
        /// 鉴权错误码
        /// </summary>
        [JsonProperty("ErrorCode")]
        public long? ErrorCode{ get; set; }

        /// <summary>
        /// 日志ID
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// 事件名称
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// 事件名称中文描述
        /// </summary>
        [JsonProperty("EventNameCn")]
        public string EventNameCn{ get; set; }

        /// <summary>
        /// 事件地域
        /// </summary>
        [JsonProperty("EventRegion")]
        public string EventRegion{ get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [JsonProperty("EventSource")]
        public string EventSource{ get; set; }

        /// <summary>
        /// 事件时间
        /// </summary>
        [JsonProperty("EventTime")]
        public string EventTime{ get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [JsonProperty("RequestID")]
        public string RequestID{ get; set; }

        /// <summary>
        /// 资源类型中文描述
        /// </summary>
        [JsonProperty("ResourceTypeCn")]
        public string ResourceTypeCn{ get; set; }

        /// <summary>
        /// 证书ID
        /// </summary>
        [JsonProperty("SecretId")]
        public string SecretId{ get; set; }

        /// <summary>
        /// 源IP
        /// </summary>
        [JsonProperty("SourceIPAddress")]
        public string SourceIPAddress{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Resources.", this.Resources);
            this.SetParamSimple(map, prefix + "AccountID", this.AccountID);
            this.SetParamSimple(map, prefix + "CloudAuditEvent", this.CloudAuditEvent);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "EventNameCn", this.EventNameCn);
            this.SetParamSimple(map, prefix + "EventRegion", this.EventRegion);
            this.SetParamSimple(map, prefix + "EventSource", this.EventSource);
            this.SetParamSimple(map, prefix + "EventTime", this.EventTime);
            this.SetParamSimple(map, prefix + "RequestID", this.RequestID);
            this.SetParamSimple(map, prefix + "ResourceTypeCn", this.ResourceTypeCn);
            this.SetParamSimple(map, prefix + "SecretId", this.SecretId);
            this.SetParamSimple(map, prefix + "SourceIPAddress", this.SourceIPAddress);
            this.SetParamSimple(map, prefix + "Username", this.Username);
        }
    }
}

