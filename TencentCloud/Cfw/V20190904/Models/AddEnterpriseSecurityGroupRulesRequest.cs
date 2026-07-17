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

    public class AddEnterpriseSecurityGroupRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>创建规则数据</p>
        /// </summary>
        [JsonProperty("Data")]
        public SecurityGroupRule[] Data{ get; set; }

        /// <summary>
        /// <p>AI操作来源</p><p>枚举值：</p><ul><li>console： 控制台来源值</li><li>wechat： 微信</li></ul>
        /// </summary>
        [JsonProperty("CfwAiAgentOperationSource")]
        public string CfwAiAgentOperationSource{ get; set; }

        /// <summary>
        /// <p>添加类型，0：添加到最后，1：添加到最前；2：中间插入；默认0添加到最后</p>
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// <p>保证请求幂等性。从您的客户端生成一个参数值，确保不同请求间该参数值唯一。ClientToken只支持ASCII字符，且不能超过64个字符。</p>
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// <p>（IsDelay为老版参数，新版无需输入）是否延迟下发，1则延迟下发，否则立即下发</p>
        /// </summary>
        [JsonProperty("IsDelay")]
        public ulong? IsDelay{ get; set; }

        /// <summary>
        /// <p>来源 默认空 覆盖导入是 batch_import_cover</p>
        /// </summary>
        [JsonProperty("From")]
        public string From{ get; set; }

        /// <summary>
        /// <p>是否复用rule id，1为是，默认不需要</p>
        /// </summary>
        [JsonProperty("IsUseId")]
        public long? IsUseId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "CfwAiAgentOperationSource", this.CfwAiAgentOperationSource);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "IsDelay", this.IsDelay);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "IsUseId", this.IsUseId);
        }
    }
}

