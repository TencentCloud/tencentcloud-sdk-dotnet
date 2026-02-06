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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateQualityRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 规则创建场景
        /// 1：单表多规则
        /// 2：多表单规则
        /// 3：克隆创建规则
        /// </summary>
        [JsonProperty("CreateRuleScene")]
        public long? CreateRuleScene{ get; set; }

        /// <summary>
        /// 单条规则信息集合	
        /// </summary>
        [JsonProperty("RuleBOList")]
        public QualityRuleInfo[] RuleBOList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "CreateRuleScene", this.CreateRuleScene);
            this.SetParamArrayObj(map, prefix + "RuleBOList.", this.RuleBOList);
        }
    }
}

