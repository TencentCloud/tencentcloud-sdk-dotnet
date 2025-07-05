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

    public class SensitiveLevel : AbstractModel
    {
        
        /// <summary>
        /// 分级标识ID
        /// </summary>
        [JsonProperty("LevelId")]
        public long? LevelId{ get; set; }

        /// <summary>
        /// 分级标识统计
        /// </summary>
        [JsonProperty("LevelCnt")]
        public long? LevelCnt{ get; set; }

        /// <summary>
        /// 分级标识名称
        /// </summary>
        [JsonProperty("LevelRiskName")]
        public string LevelRiskName{ get; set; }

        /// <summary>
        /// 分级标识分数
        /// </summary>
        [JsonProperty("LevelRiskScore")]
        public long? LevelRiskScore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LevelId", this.LevelId);
            this.SetParamSimple(map, prefix + "LevelCnt", this.LevelCnt);
            this.SetParamSimple(map, prefix + "LevelRiskName", this.LevelRiskName);
            this.SetParamSimple(map, prefix + "LevelRiskScore", this.LevelRiskScore);
        }
    }
}

