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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SearchFileBySidRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>若入参为Id，则其他入参字段不作为搜索依据，仅按照Id来搜索会话</p>
        /// </summary>
        [JsonProperty("Sid")]
        public string Sid{ get; set; }

        /// <summary>
        /// <p>是否创建审计日志,通过查看按钮调用时为true,其他为false</p>
        /// </summary>
        [JsonProperty("AuditLog")]
        public bool? AuditLog{ get; set; }

        /// <summary>
        /// <p>分页的页内记录数，默认为20，最大200</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>可填写路径名或文件名</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>分页用偏移量</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>1-已放行，  2-已阻断</p>
        /// </summary>
        [JsonProperty("AuditAction")]
        public long? AuditAction{ get; set; }

        /// <summary>
        /// <p>1-已放行，  2-已阻断</p>
        /// </summary>
        [JsonProperty("AuditActionSet")]
        public long?[] AuditActionSet{ get; set; }

        /// <summary>
        /// <p>以Protocol和Method为条件查询</p>
        /// </summary>
        [JsonProperty("TypeFilters")]
        public SearchFileTypeFilter[] TypeFilters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Sid", this.Sid);
            this.SetParamSimple(map, prefix + "AuditLog", this.AuditLog);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "AuditAction", this.AuditAction);
            this.SetParamArraySimple(map, prefix + "AuditActionSet.", this.AuditActionSet);
            this.SetParamArrayObj(map, prefix + "TypeFilters.", this.TypeFilters);
        }
    }
}

