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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTCPListenerAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>监听器ID</p>
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// <p>通道组ID，ProxyId和GroupId必须设置一个，但不能同时设置。</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// <p>通道ID，ProxyId和GroupId必须设置一个，但不能同时设置。</p>
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// <p>监听器名称</p>
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// <p>监听器源站访问策略，其中：rr表示轮询；wrr表示加权轮询；lc表示最小连接数；lrtt表示最小时延。注意：lrtt需要开通白名单；RealServerType 为 DOMAIN 不支持wrr 和 lrtt。</p>
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// <p>源站健康检查时间间隔，单位：秒。时间间隔取值在[5，300]之间。</p>
        /// </summary>
        [JsonProperty("DelayLoop")]
        public ulong? DelayLoop{ get; set; }

        /// <summary>
        /// <p>源站健康检查响应超时时间，单位：秒。超时时间取值在[2，60]之间。超时时间应小于健康检查时间间隔DelayLoop。</p>
        /// </summary>
        [JsonProperty("ConnectTimeout")]
        public ulong? ConnectTimeout{ get; set; }

        /// <summary>
        /// <p>是否开启健康检查，1开启，0关闭。</p>
        /// </summary>
        [JsonProperty("HealthCheck")]
        public ulong? HealthCheck{ get; set; }

        /// <summary>
        /// <p>源站是否开启主备模式：1开启，0关闭，DOMAIN类型源站不支持开启</p>
        /// </summary>
        [JsonProperty("FailoverSwitch")]
        public ulong? FailoverSwitch{ get; set; }

        /// <summary>
        /// <p>健康阈值，表示连续检查成功多少次数后认定源站健康。范围为1到10</p>
        /// </summary>
        [JsonProperty("HealthyThreshold")]
        public ulong? HealthyThreshold{ get; set; }

        /// <summary>
        /// <p>不健康阈值，表示连续检查失败次数后认定源站不健康。范围为1到10</p>
        /// </summary>
        [JsonProperty("UnhealthyThreshold")]
        public ulong? UnhealthyThreshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "DelayLoop", this.DelayLoop);
            this.SetParamSimple(map, prefix + "ConnectTimeout", this.ConnectTimeout);
            this.SetParamSimple(map, prefix + "HealthCheck", this.HealthCheck);
            this.SetParamSimple(map, prefix + "FailoverSwitch", this.FailoverSwitch);
            this.SetParamSimple(map, prefix + "HealthyThreshold", this.HealthyThreshold);
            this.SetParamSimple(map, prefix + "UnhealthyThreshold", this.UnhealthyThreshold);
        }
    }
}

