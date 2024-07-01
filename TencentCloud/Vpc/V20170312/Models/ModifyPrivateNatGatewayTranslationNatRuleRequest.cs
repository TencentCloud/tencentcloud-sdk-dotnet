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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPrivateNatGatewayTranslationNatRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 私网网关唯一`ID`，形如：`intranat-xxxxxxxx`。
        /// </summary>
        [JsonProperty("NatGatewayId")]
        public string NatGatewayId{ get; set; }

        /// <summary>
        /// 转换规则对象数组。仅支持修改单个转换规则
        /// </summary>
        [JsonProperty("TranslationNatRules")]
        public TranslationNatRuleDiff[] TranslationNatRules{ get; set; }

        /// <summary>
        /// 跨域参数，当VPC为跨域时填写为True。
        /// </summary>
        [JsonProperty("CrossDomain")]
        public bool? CrossDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatGatewayId", this.NatGatewayId);
            this.SetParamArrayObj(map, prefix + "TranslationNatRules.", this.TranslationNatRules);
            this.SetParamSimple(map, prefix + "CrossDomain", this.CrossDomain);
        }
    }
}

