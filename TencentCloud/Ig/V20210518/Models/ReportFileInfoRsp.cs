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

namespace TencentCloud.Ig.V20210518.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReportFileInfoRsp : AbstractModel
    {
        
        /// <summary>
        /// <p>报告id</p>
        /// </summary>
        [JsonProperty("ReportId")]
        public string ReportId{ get; set; }

        /// <summary>
        /// <p>是否解析成功</p>
        /// </summary>
        [JsonProperty("IsAnalysis")]
        public bool? IsAnalysis{ get; set; }

        /// <summary>
        /// <p>解析错误信息</p>
        /// </summary>
        [JsonProperty("ErrInfo")]
        public string ErrInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReportId", this.ReportId);
            this.SetParamSimple(map, prefix + "IsAnalysis", this.IsAnalysis);
            this.SetParamSimple(map, prefix + "ErrInfo", this.ErrInfo);
        }
    }
}

