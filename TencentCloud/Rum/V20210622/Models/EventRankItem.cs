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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EventRankItem : AbstractModel
    {
        
        /// <summary>
        /// <p>错误指纹</p>
        /// </summary>
        [JsonProperty("Fingerprint")]
        public string Fingerprint{ get; set; }

        /// <summary>
        /// <p>事件类型</p>
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// <p>崩溃类型</p>
        /// </summary>
        [JsonProperty("CrashType")]
        public string CrashType{ get; set; }

        /// <summary>
        /// <p>错误类型</p>
        /// </summary>
        [JsonProperty("ErrorType")]
        public string ErrorType{ get; set; }

        /// <summary>
        /// <p>错误值</p>
        /// </summary>
        [JsonProperty("ErrorValue")]
        public string ErrorValue{ get; set; }

        /// <summary>
        /// <p>问题单 ID</p>
        /// </summary>
        [JsonProperty("IssueId")]
        public string IssueId{ get; set; }

        /// <summary>
        /// <p>问题单状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>API 或资源 URL</p>
        /// </summary>
        [JsonProperty("URL")]
        public string URL{ get; set; }

        /// <summary>
        /// <p>次数</p>
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// <p>影响用户数</p>
        /// </summary>
        [JsonProperty("AffectedUser")]
        public long? AffectedUser{ get; set; }

        /// <summary>
        /// <p>失败次数</p>
        /// </summary>
        [JsonProperty("Fail")]
        public long? Fail{ get; set; }

        /// <summary>
        /// <p>耗时</p>
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// <p>连接时长</p>
        /// </summary>
        [JsonProperty("ConnectTime")]
        public float? ConnectTime{ get; set; }

        /// <summary>
        /// <p>DNS 时长</p>
        /// </summary>
        [JsonProperty("DomainLookupTime")]
        public float? DomainLookupTime{ get; set; }

        /// <summary>
        /// <p>时序</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Series")]
        public EventRankPoint[] Series{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Fingerprint", this.Fingerprint);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "CrashType", this.CrashType);
            this.SetParamSimple(map, prefix + "ErrorType", this.ErrorType);
            this.SetParamSimple(map, prefix + "ErrorValue", this.ErrorValue);
            this.SetParamSimple(map, prefix + "IssueId", this.IssueId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "URL", this.URL);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "AffectedUser", this.AffectedUser);
            this.SetParamSimple(map, prefix + "Fail", this.Fail);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "ConnectTime", this.ConnectTime);
            this.SetParamSimple(map, prefix + "DomainLookupTime", this.DomainLookupTime);
            this.SetParamArrayObj(map, prefix + "Series.", this.Series);
        }
    }
}

