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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApiAsset : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 请求方法
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// api名称
        /// </summary>
        [JsonProperty("ApiName")]
        public string ApiName{ get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [JsonProperty("Scene")]
        public string Scene{ get; set; }

        /// <summary>
        /// 数据标签
        /// </summary>
        [JsonProperty("Label")]
        public string[] Label{ get; set; }

        /// <summary>
        /// 过去7天是否活跃
        /// </summary>
        [JsonProperty("Active")]
        public bool? Active{ get; set; }

        /// <summary>
        /// 最近更新时间
        /// </summary>
        [JsonProperty("Timestamp")]
        public ulong? Timestamp{ get; set; }

        /// <summary>
        /// api发现时间
        /// </summary>
        [JsonProperty("InsertTime")]
        public ulong? InsertTime{ get; set; }

        /// <summary>
        /// 资产状态，1:新发现，2，确认中，3，已确认，4，已下线，5，已忽略
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 风险等级，100,200,300对应低中高
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 近30天调用量
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 是否鉴权，1标识是，0表示否
        /// </summary>
        [JsonProperty("IsAuth")]
        public long? IsAuth{ get; set; }

        /// <summary>
        /// 如果添加了api入参检测规则，则此id返回值不为0
        /// </summary>
        [JsonProperty("ApiRequestRuleId")]
        public long? ApiRequestRuleId{ get; set; }

        /// <summary>
        /// 如果添加了api限流规则，则此id返回值不为0
        /// </summary>
        [JsonProperty("ApiLimitRuleId")]
        public long? ApiLimitRuleId{ get; set; }

        /// <summary>
        /// 对象接入和泛域名接入时，展示host列表
        /// </summary>
        [JsonProperty("HostList")]
        public string[] HostList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "ApiName", this.ApiName);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamArraySimple(map, prefix + "Label.", this.Label);
            this.SetParamSimple(map, prefix + "Active", this.Active);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "IsAuth", this.IsAuth);
            this.SetParamSimple(map, prefix + "ApiRequestRuleId", this.ApiRequestRuleId);
            this.SetParamSimple(map, prefix + "ApiLimitRuleId", this.ApiLimitRuleId);
            this.SetParamArraySimple(map, prefix + "HostList.", this.HostList);
        }
    }
}

