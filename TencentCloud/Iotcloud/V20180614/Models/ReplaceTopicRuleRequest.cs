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

namespace TencentCloud.Iotcloud.V20180614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReplaceTopicRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 替换的规则包体
        /// </summary>
        [JsonProperty("TopicRulePayload")]
        public TopicRulePayload TopicRulePayload{ get; set; }

        /// <summary>
        /// 修改类型，0：其他，1：创建行为，2：更新行为，3：删除行为
        /// </summary>
        [JsonProperty("ModifyType")]
        public ulong? ModifyType{ get; set; }

        /// <summary>
        /// action增删改变更填对应topicRulePayload里面第几个action
        /// </summary>
        [JsonProperty("ActionIndex")]
        public ulong? ActionIndex{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamObj(map, prefix + "TopicRulePayload.", this.TopicRulePayload);
            this.SetParamSimple(map, prefix + "ModifyType", this.ModifyType);
            this.SetParamSimple(map, prefix + "ActionIndex", this.ActionIndex);
        }
    }
}

