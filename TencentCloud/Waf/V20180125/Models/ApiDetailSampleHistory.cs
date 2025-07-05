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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApiDetailSampleHistory : AbstractModel
    {
        
        /// <summary>
        /// 样例名称
        /// </summary>
        [JsonProperty("SampleNme")]
        public string SampleNme{ get; set; }

        /// <summary>
        /// 请求样例
        /// </summary>
        [JsonProperty("RepLog")]
        public string RepLog{ get; set; }

        /// <summary>
        /// 响应样例
        /// </summary>
        [JsonProperty("RspLog")]
        public string RspLog{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SampleNme", this.SampleNme);
            this.SetParamSimple(map, prefix + "RepLog", this.RepLog);
            this.SetParamSimple(map, prefix + "RspLog", this.RspLog);
        }
    }
}

