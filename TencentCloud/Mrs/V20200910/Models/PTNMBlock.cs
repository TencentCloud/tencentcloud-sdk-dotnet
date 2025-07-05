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

    public class PTNMBlock : AbstractModel
    {
        
        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 原文
        /// </summary>
        [JsonProperty("Src")]
        public string Src{ get; set; }

        /// <summary>
        /// PTNM分期
        /// </summary>
        [JsonProperty("PTNMM")]
        public string PTNMM{ get; set; }

        /// <summary>
        /// PTNM分期
        /// </summary>
        [JsonProperty("PTNMN")]
        public string PTNMN{ get; set; }

        /// <summary>
        /// PTNM分期
        /// </summary>
        [JsonProperty("PTNMT")]
        public string PTNMT{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Src", this.Src);
            this.SetParamSimple(map, prefix + "PTNMM", this.PTNMM);
            this.SetParamSimple(map, prefix + "PTNMN", this.PTNMN);
            this.SetParamSimple(map, prefix + "PTNMT", this.PTNMT);
        }
    }
}

