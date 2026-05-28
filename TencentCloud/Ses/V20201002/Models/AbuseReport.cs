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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AbuseReport : AbstractModel
    {
        
        /// <summary>
        /// <p>发送时间</p>
        /// </summary>
        [JsonProperty("DeliverTime")]
        public string DeliverTime{ get; set; }

        /// <summary>
        /// <p>发信地址</p>
        /// </summary>
        [JsonProperty("OriginalMailFrom")]
        public string OriginalMailFrom{ get; set; }

        /// <summary>
        /// <p>收信地址</p>
        /// </summary>
        [JsonProperty("OriginalRcptTo")]
        public string OriginalRcptTo{ get; set; }

        /// <summary>
        /// <p>发信域名</p>
        /// </summary>
        [JsonProperty("FromDomain")]
        public string FromDomain{ get; set; }

        /// <summary>
        /// <p>投诉时间</p>
        /// </summary>
        [JsonProperty("ComplainTime")]
        public string ComplainTime{ get; set; }

        /// <summary>
        /// <p>收信域名</p>
        /// </summary>
        [JsonProperty("Mta")]
        public string Mta{ get; set; }

        /// <summary>
        /// <p>来源ip</p>
        /// </summary>
        [JsonProperty("SourceIp")]
        public string SourceIp{ get; set; }

        /// <summary>
        /// <p>数据时间</p>
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// <p>模板ID</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// <p>bulkId</p>
        /// </summary>
        [JsonProperty("BulkId")]
        public string BulkId{ get; set; }

        /// <summary>
        /// <p>邮件Message-Id</p>
        /// </summary>
        [JsonProperty("MessageId")]
        public string MessageId{ get; set; }

        /// <summary>
        /// <p>投诉时间</p>
        /// </summary>
        [JsonProperty("AbuseTime")]
        public string AbuseTime{ get; set; }

        /// <summary>
        /// <p>邮件主题</p>
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeliverTime", this.DeliverTime);
            this.SetParamSimple(map, prefix + "OriginalMailFrom", this.OriginalMailFrom);
            this.SetParamSimple(map, prefix + "OriginalRcptTo", this.OriginalRcptTo);
            this.SetParamSimple(map, prefix + "FromDomain", this.FromDomain);
            this.SetParamSimple(map, prefix + "ComplainTime", this.ComplainTime);
            this.SetParamSimple(map, prefix + "Mta", this.Mta);
            this.SetParamSimple(map, prefix + "SourceIp", this.SourceIp);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "BulkId", this.BulkId);
            this.SetParamSimple(map, prefix + "MessageId", this.MessageId);
            this.SetParamSimple(map, prefix + "AbuseTime", this.AbuseTime);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
        }
    }
}

