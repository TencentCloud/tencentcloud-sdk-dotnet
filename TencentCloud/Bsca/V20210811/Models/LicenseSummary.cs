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

namespace TencentCloud.Bsca.V20210811.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LicenseSummary : AbstractModel
    {
        
        /// <summary>
        /// 许可证标识符
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 许可证的SPDX标识符，见 https://spdx.org/licenses/
        /// </summary>
        [JsonProperty("SPDXKey")]
        public string SPDXKey{ get; set; }

        /// <summary>
        /// 许可证短名称
        /// </summary>
        [JsonProperty("ShortName")]
        public string ShortName{ get; set; }

        /// <summary>
        /// 许可证完整名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// License风险等级
        /// <li>NotDefined</li>
        /// <li>LowRisk</li>
        /// <li>MediumRisk</li>
        /// <li>HighRisk</li>
        /// </summary>
        [JsonProperty("Risk")]
        public string Risk{ get; set; }

        /// <summary>
        /// 许可证来源URL
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "SPDXKey", this.SPDXKey);
            this.SetParamSimple(map, prefix + "ShortName", this.ShortName);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Risk", this.Risk);
            this.SetParamSimple(map, prefix + "Source", this.Source);
        }
    }
}

