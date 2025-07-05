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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SwitcherProjectInput : AbstractModel
    {
        
        /// <summary>
        /// 导播台停止时间，格式按照 ISO 8601 标准表示。若不填，该值默认为当前时间加七天。
        /// </summary>
        [JsonProperty("StopTime")]
        public string StopTime{ get; set; }

        /// <summary>
        /// 导播台主监输出配置信息。若不填，默认输出 720P。
        /// </summary>
        [JsonProperty("PgmOutputConfig")]
        public SwitcherPgmOutputConfig PgmOutputConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StopTime", this.StopTime);
            this.SetParamObj(map, prefix + "PgmOutputConfig.", this.PgmOutputConfig);
        }
    }
}

