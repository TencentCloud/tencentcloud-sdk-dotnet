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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ForwardRule : AbstractModel
    {
        
        /// <summary>
        /// 私有域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 转发规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 转发规则类型：云上到云下DOWN、云下到云上DOWN
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// 终端节点名称
        /// </summary>
        [JsonProperty("EndPointName")]
        public string EndPointName{ get; set; }

        /// <summary>
        /// 终端节点ID
        /// </summary>
        [JsonProperty("EndPointId")]
        public string EndPointId{ get; set; }

        /// <summary>
        /// 转发地址
        /// </summary>
        [JsonProperty("ForwardAddress")]
        public string[] ForwardAddress{ get; set; }

        /// <summary>
        /// 私有域绑定的vpc列表
        /// </summary>
        [JsonProperty("VpcSet")]
        public VpcInfo[] VpcSet{ get; set; }

        /// <summary>
        /// 绑定的私有域ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "EndPointName", this.EndPointName);
            this.SetParamSimple(map, prefix + "EndPointId", this.EndPointId);
            this.SetParamArraySimple(map, prefix + "ForwardAddress.", this.ForwardAddress);
            this.SetParamArrayObj(map, prefix + "VpcSet.", this.VpcSet);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

