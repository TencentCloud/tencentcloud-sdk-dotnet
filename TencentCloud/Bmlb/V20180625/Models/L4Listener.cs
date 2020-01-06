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

namespace TencentCloud.Bmlb.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class L4Listener : AbstractModel
    {
        
        /// <summary>
        /// 监听器ID。
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 用户自定义的监听器名称。
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// 负载均衡实例监听器协议类型，可选值tcp，udp。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 负载均衡监听器的监听接口，可选值1~65535。
        /// </summary>
        [JsonProperty("LoadBalancerPort")]
        public long? LoadBalancerPort{ get; set; }

        /// <summary>
        /// 用于计费模式为固定带宽计费，指定监听器最大带宽值，可选值：0-1000，单位：Mbps。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 监听器的类别：L4Listener（四层监听器），L7Listener（七层监听器）。
        /// </summary>
        [JsonProperty("ListenerType")]
        public string ListenerType{ get; set; }

        /// <summary>
        /// 会话保持时间。单位：秒
        /// </summary>
        [JsonProperty("SessionExpire")]
        public long? SessionExpire{ get; set; }

        /// <summary>
        /// 是否开启了检查：1（开启）、0（关闭）。
        /// </summary>
        [JsonProperty("HealthSwitch")]
        public long? HealthSwitch{ get; set; }

        /// <summary>
        /// 响应超时时间，单位：秒。
        /// </summary>
        [JsonProperty("TimeOut")]
        public long? TimeOut{ get; set; }

        /// <summary>
        /// 检查间隔，单位：秒。
        /// </summary>
        [JsonProperty("IntervalTime")]
        public long? IntervalTime{ get; set; }

        /// <summary>
        /// 负载均衡监听器健康阈值，默认值：3，表示当连续探测三次健康则表示该转发正常，可选值：2-10，单位：次。
        /// </summary>
        [JsonProperty("HealthNum")]
        public long? HealthNum{ get; set; }

        /// <summary>
        /// 负载均衡监听器不健康阈值，默认值：3，表示当连续探测三次不健康则表示该转发不正常，可选值：2-10，单位：次。
        /// </summary>
        [JsonProperty("UnhealthNum")]
        public long? UnhealthNum{ get; set; }

        /// <summary>
        /// 是否开启自定义健康检查：1（开启）、0（关闭）。默认值0，表示关闭。（该字段在健康检查开启的情况下才生效）
        /// </summary>
        [JsonProperty("CustomHealthSwitch")]
        public long? CustomHealthSwitch{ get; set; }

        /// <summary>
        /// 自定义健康探测内容类型，可选值：text（文本）、hexadecimal（十六进制）。
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// 探测内容类型为文本方式时，针对请求文本中换行替换方式。可选值：1（替换为LF）、2（替换为CR）、3（替换为LF+CR）。
        /// </summary>
        [JsonProperty("LineSeparatorType")]
        public long? LineSeparatorType{ get; set; }

        /// <summary>
        /// 自定义探测请求内容。
        /// </summary>
        [JsonProperty("HealthRequest")]
        public string HealthRequest{ get; set; }

        /// <summary>
        /// 自定义探测返回内容。
        /// </summary>
        [JsonProperty("HealthResponse")]
        public string HealthResponse{ get; set; }

        /// <summary>
        /// 是否开启toa：1（开启）、0（关闭）。
        /// </summary>
        [JsonProperty("ToaFlag")]
        public long? ToaFlag{ get; set; }

        /// <summary>
        /// 监听器当前状态（0代表创建中，1代表正常运行，2代表创建失败，3代表删除中，4代表删除失败）。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 创建时间戳。
        /// </summary>
        [JsonProperty("AddTimestamp")]
        public string AddTimestamp{ get; set; }

        /// <summary>
        /// 转发后端服务器调度类型。
        /// </summary>
        [JsonProperty("BalanceMode")]
        public string BalanceMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "LoadBalancerPort", this.LoadBalancerPort);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "ListenerType", this.ListenerType);
            this.SetParamSimple(map, prefix + "SessionExpire", this.SessionExpire);
            this.SetParamSimple(map, prefix + "HealthSwitch", this.HealthSwitch);
            this.SetParamSimple(map, prefix + "TimeOut", this.TimeOut);
            this.SetParamSimple(map, prefix + "IntervalTime", this.IntervalTime);
            this.SetParamSimple(map, prefix + "HealthNum", this.HealthNum);
            this.SetParamSimple(map, prefix + "UnhealthNum", this.UnhealthNum);
            this.SetParamSimple(map, prefix + "CustomHealthSwitch", this.CustomHealthSwitch);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "LineSeparatorType", this.LineSeparatorType);
            this.SetParamSimple(map, prefix + "HealthRequest", this.HealthRequest);
            this.SetParamSimple(map, prefix + "HealthResponse", this.HealthResponse);
            this.SetParamSimple(map, prefix + "ToaFlag", this.ToaFlag);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AddTimestamp", this.AddTimestamp);
            this.SetParamSimple(map, prefix + "BalanceMode", this.BalanceMode);
        }
    }
}

