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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteNatFwDnatRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 0：cfw新增模式，1：cfw接入模式。
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// 防火墙实例id，该字段必须传递。
        /// </summary>
        [JsonProperty("CfwInstance")]
        public string CfwInstance{ get; set; }

        /// <summary>
        /// 添加或删除操作的Dnat规则列表。
        /// </summary>
        [JsonProperty("DnatRules")]
        public CfwNatDnatRule[] DnatRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "CfwInstance", this.CfwInstance);
            this.SetParamArrayObj(map, prefix + "DnatRules.", this.DnatRules);
        }
    }
}

