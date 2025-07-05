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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LevelItem : AbstractModel
    {
        
        /// <summary>
        /// 分级ID
        /// </summary>
        [JsonProperty("LevelId")]
        public ulong? LevelId{ get; set; }

        /// <summary>
        /// 分级组ID
        /// </summary>
        [JsonProperty("LevelGroupId")]
        public ulong? LevelGroupId{ get; set; }

        /// <summary>
        /// 分级标识名称，支持内置分级，内置分级取值：高，中，低，也可以自定义
        /// </summary>
        [JsonProperty("LevelRiskName")]
        public string LevelRiskName{ get; set; }

        /// <summary>
        /// 分级风险分数，1-10，最小值为1，最大值为10
        /// </summary>
        [JsonProperty("LevelRiskScore")]
        public ulong? LevelRiskScore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LevelId", this.LevelId);
            this.SetParamSimple(map, prefix + "LevelGroupId", this.LevelGroupId);
            this.SetParamSimple(map, prefix + "LevelRiskName", this.LevelRiskName);
            this.SetParamSimple(map, prefix + "LevelRiskScore", this.LevelRiskScore);
        }
    }
}

