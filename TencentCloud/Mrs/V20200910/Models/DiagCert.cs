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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiagCert : AbstractModel
    {
        
        /// <summary>
        /// 建议
        /// </summary>
        [JsonProperty("Advice")]
        public Advice Advice{ get; set; }

        /// <summary>
        /// 诊断
        /// </summary>
        [JsonProperty("Diagnosis")]
        public DiagCertItem[] Diagnosis{ get; set; }

        /// <summary>
        /// 数据在原PDF文件中的第几页
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Advice.", this.Advice);
            this.SetParamArrayObj(map, prefix + "Diagnosis.", this.Diagnosis);
            this.SetParamSimple(map, prefix + "Page", this.Page);
        }
    }
}

