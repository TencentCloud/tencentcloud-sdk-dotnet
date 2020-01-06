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

    public class ModifyL4ListenerRequest : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡实例ID，可通过接口DescribeLoadBalancers查询。
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 四层监听器ID。可通过接口DescribeL4Listeners查询。
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 四层监听器名称。
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// 会话保持时间，单位：秒。可选值：900~3600。
        /// </summary>
        [JsonProperty("SessionExpire")]
        public long? SessionExpire{ get; set; }

        /// <summary>
        /// 是否开启健康检查：1（开启）、0（关闭）。默认值0，表示关闭。
        /// </summary>
        [JsonProperty("HealthSwitch")]
        public long? HealthSwitch{ get; set; }

        /// <summary>
        /// 健康检查的响应超时时间，可选值：2-60，默认值：2，单位:秒。<br><font color="red">响应超时时间要小于检查间隔时间。</font>
        /// </summary>
        [JsonProperty("TimeOut")]
        public long? TimeOut{ get; set; }

        /// <summary>
        /// 健康检查间隔，默认值：5，可选值：5-300，单位：秒。
        /// </summary>
        [JsonProperty("IntervalTime")]
        public long? IntervalTime{ get; set; }

        /// <summary>
        /// 健康阈值，默认值：3，表示当连续探测三次健康则表示该转发正常，可选值：2-10，单位：次。
        /// </summary>
        [JsonProperty("HealthNum")]
        public long? HealthNum{ get; set; }

        /// <summary>
        /// 不健康阈值，默认值：3，表示当连续探测三次不健康则表示该转发不正常，可选值：2-10，单位：次。
        /// </summary>
        [JsonProperty("UnhealthNum")]
        public long? UnhealthNum{ get; set; }

        /// <summary>
        /// 监听器最大带宽值，用于计费模式为固定带宽计费。可选值：0-1000，单位：Mbps。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

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
        /// 是否开启toa。可选值：0（关闭）、1（开启），默认关闭。（该字段在负载均衡为fullnat类型下才生效）
        /// </summary>
        [JsonProperty("ToaFlag")]
        public long? ToaFlag{ get; set; }

        /// <summary>
        /// 四层调度方式。wrr，wlc。
        /// </summary>
        [JsonProperty("BalanceMode")]
        public string BalanceMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "SessionExpire", this.SessionExpire);
            this.SetParamSimple(map, prefix + "HealthSwitch", this.HealthSwitch);
            this.SetParamSimple(map, prefix + "TimeOut", this.TimeOut);
            this.SetParamSimple(map, prefix + "IntervalTime", this.IntervalTime);
            this.SetParamSimple(map, prefix + "HealthNum", this.HealthNum);
            this.SetParamSimple(map, prefix + "UnhealthNum", this.UnhealthNum);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "CustomHealthSwitch", this.CustomHealthSwitch);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "LineSeparatorType", this.LineSeparatorType);
            this.SetParamSimple(map, prefix + "HealthRequest", this.HealthRequest);
            this.SetParamSimple(map, prefix + "HealthResponse", this.HealthResponse);
            this.SetParamSimple(map, prefix + "ToaFlag", this.ToaFlag);
            this.SetParamSimple(map, prefix + "BalanceMode", this.BalanceMode);
        }
    }
}

