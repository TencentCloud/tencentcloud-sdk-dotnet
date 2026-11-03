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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleContentK8sAPI : AbstractModel
    {
        
        /// <summary>
        /// <p>请求资源</p>
        /// </summary>
        [JsonProperty("RequestURI")]
        public string RequestURI{ get; set; }

        /// <summary>
        /// <p>操作类型</p>
        /// </summary>
        [JsonProperty("Verb")]
        public string Verb{ get; set; }

        /// <summary>
        /// <p>发起请求用户</p>
        /// </summary>
        [JsonProperty("RequestUser")]
        public string RequestUser{ get; set; }

        /// <summary>
        /// <p>用户代理</p>
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// <p>来源 IP</p>
        /// </summary>
        [JsonProperty("SourceIPS")]
        public string SourceIPS{ get; set; }

        /// <summary>
        /// <p>响应状态码</p>
        /// </summary>
        [JsonProperty("ResponseStatusCode")]
        public string ResponseStatusCode{ get; set; }

        /// <summary>
        /// <p>请求数据</p>
        /// </summary>
        [JsonProperty("RequestObject")]
        public string RequestObject{ get; set; }

        /// <summary>
        /// <p>响应数据</p>
        /// </summary>
        [JsonProperty("ResponseObject")]
        public string ResponseObject{ get; set; }

        /// <summary>
        /// <p>挂载宿主机目录</p>
        /// </summary>
        [JsonProperty("MountHostDir")]
        public string MountHostDir{ get; set; }

        /// <summary>
        /// <p>Pod 名称或 IP</p>
        /// </summary>
        [JsonProperty("PodNameIP")]
        public string PodNameIP{ get; set; }

        /// <summary>
        /// <p>审计日志 ID</p>
        /// </summary>
        [JsonProperty("AuditID")]
        public string AuditID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RequestURI", this.RequestURI);
            this.SetParamSimple(map, prefix + "Verb", this.Verb);
            this.SetParamSimple(map, prefix + "RequestUser", this.RequestUser);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "SourceIPS", this.SourceIPS);
            this.SetParamSimple(map, prefix + "ResponseStatusCode", this.ResponseStatusCode);
            this.SetParamSimple(map, prefix + "RequestObject", this.RequestObject);
            this.SetParamSimple(map, prefix + "ResponseObject", this.ResponseObject);
            this.SetParamSimple(map, prefix + "MountHostDir", this.MountHostDir);
            this.SetParamSimple(map, prefix + "PodNameIP", this.PodNameIP);
            this.SetParamSimple(map, prefix + "AuditID", this.AuditID);
        }
    }
}

