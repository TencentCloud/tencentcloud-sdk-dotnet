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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SensitiveDetail : AbstractModel
    {
        
        /// <summary>
        /// 字段分类
        /// </summary>
        [JsonProperty("CategoryRule")]
        public string CategoryRule{ get; set; }

        /// <summary>
        /// 字段分级
        /// </summary>
        [JsonProperty("LevelRisk")]
        public string LevelRisk{ get; set; }

        /// <summary>
        /// 1:敏感信息字段
        /// 0:非敏感字段
        /// </summary>
        [JsonProperty("IsSensitive")]
        public ulong? IsSensitive{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CategoryRule", this.CategoryRule);
            this.SetParamSimple(map, prefix + "LevelRisk", this.LevelRisk);
            this.SetParamSimple(map, prefix + "IsSensitive", this.IsSensitive);
        }
    }
}

