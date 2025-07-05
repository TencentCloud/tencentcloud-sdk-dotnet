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

namespace TencentCloud.Aca.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordQuality : AbstractModel
    {
        
        /// <summary>
        /// 病历是否有问题
        /// </summary>
        [JsonProperty("Hit")]
        public bool? Hit{ get; set; }

        /// <summary>
        /// 完整性问题
        /// </summary>
        [JsonProperty("Completeness")]
        public string Completeness{ get; set; }

        /// <summary>
        /// 及时性问题
        /// </summary>
        [JsonProperty("Timeliness")]
        public string Timeliness{ get; set; }

        /// <summary>
        /// 逻辑性问题
        /// </summary>
        [JsonProperty("Logical")]
        public string Logical{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Hit", this.Hit);
            this.SetParamSimple(map, prefix + "Completeness", this.Completeness);
            this.SetParamSimple(map, prefix + "Timeliness", this.Timeliness);
            this.SetParamSimple(map, prefix + "Logical", this.Logical);
        }
    }
}

