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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySecurityWafGroupPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点Id。当使用ZoneId和Entity时可不填写TemplateId，否则必须填写TemplateId。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 子域名。当使用ZoneId和Entity时可不填写TemplateId，否则必须填写TemplateId。
        /// </summary>
        [JsonProperty("Entity")]
        public string Entity{ get; set; }

        /// <summary>
        /// 总开关，取值有：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>不填默认为上次的配置。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 规则等级，取值有：
        /// <li> loose：宽松；</li>
        /// <li> normal：正常；</li>
        /// <li> strict：严格；</li>
        /// <li> stricter：超严格；</li>
        /// <li> custom：自定义。</li>不填默认为上次的配置。
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 处置方式，取值有：
        /// <li> block：阻断；</li>
        /// <li> observe：观察。</li>不填默认为上次的配置。
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 托管规则。不填默认为上次的配置。
        /// </summary>
        [JsonProperty("WafRules")]
        public WafRule WafRules{ get; set; }

        /// <summary>
        /// AI引擎模式。不填默认为上次的配置。
        /// </summary>
        [JsonProperty("AiRule")]
        public AiRule AiRule{ get; set; }

        /// <summary>
        /// 托管规则等级组。不填默认为上次的配置。
        /// </summary>
        [JsonProperty("WafGroups")]
        public WafGroup[] WafGroups{ get; set; }

        /// <summary>
        /// 模板Id。当使用模板Id时可不填ZoneId和Entity，否则必须填写ZoneId和Entity。
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Entity", this.Entity);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamObj(map, prefix + "WafRules.", this.WafRules);
            this.SetParamObj(map, prefix + "AiRule.", this.AiRule);
            this.SetParamArrayObj(map, prefix + "WafGroups.", this.WafGroups);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
        }
    }
}

