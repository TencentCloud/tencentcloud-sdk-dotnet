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

namespace TencentCloud.Bsca.V20210811.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LicenseUnion : AbstractModel
    {
        
        /// <summary>
        /// 许可证概览信息
        /// </summary>
        [JsonProperty("LicenseSummary")]
        public LicenseSummary LicenseSummary{ get; set; }

        /// <summary>
        /// 许可证详细信息
        /// </summary>
        [JsonProperty("LicenseDetail")]
        public LicenseDetail LicenseDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "LicenseSummary.", this.LicenseSummary);
            this.SetParamObj(map, prefix + "LicenseDetail.", this.LicenseDetail);
        }
    }
}

