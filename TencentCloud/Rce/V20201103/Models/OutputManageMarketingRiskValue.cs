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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutputManageMarketingRiskValue : AbstractModel
    {
        
        /// <summary>
        /// <p>账号ID：对应输入参数。<br>当AccountType为1时，对应QQ的OpenId；<br>当AccountType为2时，对应微信的OpenId/UnionId；<br>当AccountType为10004时，对应手机号的MD5值；<br>当AccountType为10005时，对应手机号的SHA256值。</p>
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// <p>操作时间戳，单位秒（对应输入参数）。</p>
        /// </summary>
        [JsonProperty("PostTime")]
        public ulong? PostTime{ get; set; }

        /// <summary>
        /// <p>业务预留参数（暂无实际业务含义， 无需关注返回值）</p>
        /// </summary>
        [JsonProperty("AssociateAccount")]
        public string AssociateAccount{ get; set; }

        /// <summary>
        /// <p>操作来源的外网IP（对应输入参数）。</p>
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// <p>风险等级<br>pass：无恶意<br>review：低风险，需要人工审核<br>reject：高风险，建议拦截</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// <p>风险类型，可能同时命中多个风险类型<br>1: 账号信用低。<br>11: 疑似低活跃账号。<br>2: 垃圾账号。<br>21: 疑似小号。<br>22: 疑似违规账号。<br>3: 无效账号。<br>4: 黑名单。<br>5: 白名单。<br>101: 批量操作。<br>1011: 疑似 IP 属性聚集。<br>1012: 疑似设备属性聚集。<br>102: 自动机。<br>103: 恶意行为。<br>104: 登录态无效。<br>201: 环境风险。<br>2011: 疑似非常用IP。<br>2012: 疑似 IP 异常。<br>205: 非公网有效 IP。</p>
        /// </summary>
        [JsonProperty("RiskType")]
        public long?[] RiskType{ get; set; }

        /// <summary>
        /// <p>设备指纹ID，如果集成了设备指纹，并传入了正确的DeviceToken和Platform，该字段正常输出；如果DeviceToken异常（校验不通过），则会在RiskType中返回&quot;-1&quot;标签，ConstId字段为空；如果没有集成设备指纹ConstId字段默认为空。</p>
        /// </summary>
        [JsonProperty("ConstId")]
        public string ConstId{ get; set; }

        /// <summary>
        /// <p>风险扩展数据。</p>
        /// </summary>
        [JsonProperty("RiskInformation")]
        public string RiskInformation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "PostTime", this.PostTime);
            this.SetParamSimple(map, prefix + "AssociateAccount", this.AssociateAccount);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamArraySimple(map, prefix + "RiskType.", this.RiskType);
            this.SetParamSimple(map, prefix + "ConstId", this.ConstId);
            this.SetParamSimple(map, prefix + "RiskInformation", this.RiskInformation);
        }
    }
}

