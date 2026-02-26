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

    public class GetAbuseReportRequest : AbstractModel
    {
        
        /// <summary>
        /// 起始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 限制数量（默认为1000）
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 发信域名
        /// </summary>
        [JsonProperty("FromDomain")]
        public string FromDomain{ get; set; }

        /// <summary>
        /// 发信地址
        /// </summary>
        [JsonProperty("FromAddress")]
        public string FromAddress{ get; set; }

        /// <summary>
        /// 收信域名
        /// </summary>
        [JsonProperty("Mta")]
        public string Mta{ get; set; }

        /// <summary>
        /// 收信地址
        /// </summary>
        [JsonProperty("ToAddress")]
        public string ToAddress{ get; set; }

        /// <summary>
        /// 模版id
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "FromDomain", this.FromDomain);
            this.SetParamSimple(map, prefix + "FromAddress", this.FromAddress);
            this.SetParamSimple(map, prefix + "Mta", this.Mta);
            this.SetParamSimple(map, prefix + "ToAddress", this.ToAddress);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
        }
    }
}

