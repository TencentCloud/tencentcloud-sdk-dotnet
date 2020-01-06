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

    public class CreateTCPListenersRequest : AbstractModel
    {
        
        /// <summary>
        /// 监听器名称。
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// 监听器端口列表。
        /// </summary>
        [JsonProperty("Ports")]
        public ulong?[] Ports{ get; set; }

        /// <summary>
        /// 监听器源站调度策略，支持轮询（rr），加权轮询（wrr），最小连接数（lc）。
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// 源站是否开启健康检查：1开启，0关闭，UDP监听器不支持健康检查
        /// </summary>
        [JsonProperty("HealthCheck")]
        public ulong? HealthCheck{ get; set; }

        /// <summary>
        /// 监听器对应源站类型，支持IP或者DOMAIN类型。DOMAIN源站类型不支持wrr的源站调度策略。
        /// </summary>
        [JsonProperty("RealServerType")]
        public string RealServerType{ get; set; }

        /// <summary>
        /// 通道ID，ProxyId和GroupId必须设置一个，但不能同时设置。
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 通道组ID，ProxyId和GroupId必须设置一个，但不能同时设置。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 源站健康检查时间间隔，单位：秒。时间间隔取值在[5，300]之间。
        /// </summary>
        [JsonProperty("DelayLoop")]
        public ulong? DelayLoop{ get; set; }

        /// <summary>
        /// 源站健康检查响应超时时间，单位：秒。超时时间取值在[2，60]之间。超时时间应小于健康检查时间间隔DelayLoop。
        /// </summary>
        [JsonProperty("ConnectTimeout")]
        public ulong? ConnectTimeout{ get; set; }

        /// <summary>
        /// 源站端口列表，该参数仅支持v1版本监听器和通道组监听器。
        /// </summary>
        [JsonProperty("RealServerPorts")]
        public ulong?[] RealServerPorts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamArraySimple(map, prefix + "Ports.", this.Ports);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "HealthCheck", this.HealthCheck);
            this.SetParamSimple(map, prefix + "RealServerType", this.RealServerType);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "DelayLoop", this.DelayLoop);
            this.SetParamSimple(map, prefix + "ConnectTimeout", this.ConnectTimeout);
            this.SetParamArraySimple(map, prefix + "RealServerPorts.", this.RealServerPorts);
        }
    }
}

