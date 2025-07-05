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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CallInSkillGroupMetrics : AbstractModel
    {
        
        /// <summary>
        /// 技能组ID
        /// </summary>
        [JsonProperty("SkillGroupId")]
        public long? SkillGroupId{ get; set; }

        /// <summary>
        /// 数据指标
        /// </summary>
        [JsonProperty("Metrics")]
        public CallInMetrics Metrics{ get; set; }

        /// <summary>
        /// 技能组名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SkillGroupId", this.SkillGroupId);
            this.SetParamObj(map, prefix + "Metrics.", this.Metrics);
            this.SetParamSimple(map, prefix + "Name", this.Name);
        }
    }
}

