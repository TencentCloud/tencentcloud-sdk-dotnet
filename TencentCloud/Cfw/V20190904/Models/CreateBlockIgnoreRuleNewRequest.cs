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

    public class CreateBlockIgnoreRuleNewRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则类型：1 IP 封禁，2 IP 放通，3 域名放通，4 情报放通，5 资产放通，6 自定义放通。
        /// </summary>
        [JsonProperty("RuleType")]
        public long? RuleType{ get; set; }

        /// <summary>
        /// 待新增规则列表；可为空，空数组返回成功且不新增规则。
        /// </summary>
        [JsonProperty("Rules")]
        public BanAndAllowRule[] Rules{ get; set; }

        /// <summary>
        /// <p>AI操作来源</p><p>枚举值：</p><ul><li>console： 控制台来源值</li><li>wechat： 微信</li></ul>。
        /// </summary>
        [JsonProperty("CfwAiAgentOperationSource")]
        public string CfwAiAgentOperationSource{ get; set; }

        /// <summary>
        /// 互斥列表冲突处理，仅 RuleType=1 或 2 生效。0 表示保留已有互斥规则并跳过冲突新增项；1 表示保留新增项并删除同 IP、同方向的互斥规则；省略时不处理互斥冲突。填写本字段时，同一请求内相同 Ioc 会合并为一项，DirectionList 按输入顺序合并，时间和备注采用首次出现项的值。已有同类型、同 Ioc 规则的方向会与本次方向合并，其它字段按本次请求更新。
        /// </summary>
        [JsonProperty("CoverDuplicate")]
        public long? CoverDuplicate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
            this.SetParamSimple(map, prefix + "CfwAiAgentOperationSource", this.CfwAiAgentOperationSource);
            this.SetParamSimple(map, prefix + "CoverDuplicate", this.CoverDuplicate);
        }
    }
}

