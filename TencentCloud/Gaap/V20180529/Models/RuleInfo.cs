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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleInfo : AbstractModel
    {
        
        /// <summary>
        /// 规则信息
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 监听器信息
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 规则域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 规则路径
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 源站类型
        /// </summary>
        [JsonProperty("RealServerType")]
        public string RealServerType{ get; set; }

        /// <summary>
        /// 转发源站策略
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// 是否开启健康检查标志，1开启，0关闭
        /// </summary>
        [JsonProperty("HealthCheck")]
        public ulong? HealthCheck{ get; set; }

        /// <summary>
        /// 规则状态，0运行中，1创建中，2销毁中，3绑定解绑源站中，4配置更新中
        /// </summary>
        [JsonProperty("RuleStatus")]
        public ulong? RuleStatus{ get; set; }

        /// <summary>
        /// 健康检查相关参数
        /// </summary>
        [JsonProperty("CheckParams")]
        public RuleCheckParams CheckParams{ get; set; }

        /// <summary>
        /// 已绑定的源站相关信息
        /// </summary>
        [JsonProperty("RealServerSet")]
        public BindRealServer[] RealServerSet{ get; set; }

        /// <summary>
        /// 源站的服务状态，0：异常，1：正常。
        /// 未开启健康检查时，该状态始终未正常。
        /// 只要有一个源站健康状态为异常时，该状态为异常，具体源站的状态请查看RealServerSet。
        /// </summary>
        [JsonProperty("BindStatus")]
        public ulong? BindStatus{ get; set; }

        /// <summary>
        /// 通道转发到源站的请求所携带的host，其中default表示直接转发接收到的host。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ForwardHost")]
        public string ForwardHost{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "RealServerType", this.RealServerType);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "HealthCheck", this.HealthCheck);
            this.SetParamSimple(map, prefix + "RuleStatus", this.RuleStatus);
            this.SetParamObj(map, prefix + "CheckParams.", this.CheckParams);
            this.SetParamArrayObj(map, prefix + "RealServerSet.", this.RealServerSet);
            this.SetParamSimple(map, prefix + "BindStatus", this.BindStatus);
            this.SetParamSimple(map, prefix + "ForwardHost", this.ForwardHost);
        }
    }
}

