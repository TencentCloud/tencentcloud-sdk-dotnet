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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemplatePolicy : AbstractModel
    {
        
        /// <summary>
        /// 保护策略ID列表
        /// </summary>
        [JsonProperty("TemplatePolicyIdList")]
        public string[] TemplatePolicyIdList{ get; set; }

        /// <summary>
        /// 策略规则
        /// </summary>
        [JsonProperty("TemplatePolicyRule")]
        public string TemplatePolicyRule{ get; set; }

        /// <summary>
        /// 护栏策略生效处理策略 1:顺序执行，2:暂停
        /// </summary>
        [JsonProperty("TemplatePolicyDealType")]
        public long? TemplatePolicyDealType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TemplatePolicyIdList.", this.TemplatePolicyIdList);
            this.SetParamSimple(map, prefix + "TemplatePolicyRule", this.TemplatePolicyRule);
            this.SetParamSimple(map, prefix + "TemplatePolicyDealType", this.TemplatePolicyDealType);
        }
    }
}

