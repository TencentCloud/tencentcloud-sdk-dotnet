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

    public class UDPListener : AbstractModel
    {
        
        /// <summary>
        /// 监听器ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 监听器名称
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// 监听器端口
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 监听器转发源站端口，仅V1版本通道或通道组监听器有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RealServerPort")]
        public ulong? RealServerPort{ get; set; }

        /// <summary>
        /// 监听器绑定源站类型
        /// </summary>
        [JsonProperty("RealServerType")]
        public string RealServerType{ get; set; }

        /// <summary>
        /// 监听器协议， UDP
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 监听器状态，其中：
        /// 0表示运行中；
        /// 1表示创建中；
        /// 2表示销毁中；
        /// 3表示源站调整中；
        /// 4表示配置变更中。
        /// </summary>
        [JsonProperty("ListenerStatus")]
        public ulong? ListenerStatus{ get; set; }

        /// <summary>
        /// 监听器源站访问策略，其中：rr表示轮询；wrr表示加权轮询；lc表示最小连接数；lrtt表示最小时延。
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// 监听器绑定源站状态， 0表示正常，1表示IP异常，2表示域名解析异常
        /// </summary>
        [JsonProperty("BindStatus")]
        public ulong? BindStatus{ get; set; }

        /// <summary>
        /// 监听器绑定的源站信息
        /// </summary>
        [JsonProperty("RealServerSet")]
        public BindRealServer[] RealServerSet{ get; set; }

        /// <summary>
        /// 监听器创建时间，Unix时间戳
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 是否开启会话保持选项：0关闭， 非0开启，非0值为会话保持时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionPersist")]
        public ulong? SessionPersist{ get; set; }

        /// <summary>
        /// 源站健康检查时间间隔，单位：秒。时间间隔取值在[5，300]之间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DelayLoop")]
        public ulong? DelayLoop{ get; set; }

        /// <summary>
        /// 源站健康检查响应超时时间，单位：秒。超时时间取值在[2，60]之间。超时时间应小于健康检查时间间隔DelayLoop。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConnectTimeout")]
        public ulong? ConnectTimeout{ get; set; }

        /// <summary>
        /// 健康阈值，表示连续检查成功多少次后认定源站健康。范围为1到10
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthyThreshold")]
        public ulong? HealthyThreshold{ get; set; }

        /// <summary>
        /// 不健康阈值，表示连续检查失败多少次数后认为源站不健康。范围为1到10
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnhealthyThreshold")]
        public ulong? UnhealthyThreshold{ get; set; }

        /// <summary>
        /// 源站是否开启主备模式：1开启，0关闭，DOMAIN类型源站不支持开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailoverSwitch")]
        public long? FailoverSwitch{ get; set; }

        /// <summary>
        /// 源站是否开启健康检查：1开启，0关闭。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthCheck")]
        public ulong? HealthCheck{ get; set; }

        /// <summary>
        /// UDP源站健康类型。PORT表示检查端口，PING表示PING。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckType")]
        public string CheckType{ get; set; }

        /// <summary>
        /// UDP源站健康检查探测端口。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CheckPort")]
        public long? CheckPort{ get; set; }

        /// <summary>
        /// UDP源站健康检查端口探测报文类型：TEXT表示文本。仅在健康检查类型为PORT时使用。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContextType")]
        public string ContextType{ get; set; }

        /// <summary>
        /// UDP源站健康检查端口探测发送报文。仅在健康检查类型为PORT时使用。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SendContext")]
        public string SendContext{ get; set; }

        /// <summary>
        /// UDP源站健康检查端口探测接收报文。仅在健康检查类型为PORT时使用。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecvContext")]
        public string RecvContext{ get; set; }

        /// <summary>
        /// 监听器的通道ID，如果监听器属于通道组，则为null
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// 监听器的通道组ID，如果监听器属于通道，则为null
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "RealServerPort", this.RealServerPort);
            this.SetParamSimple(map, prefix + "RealServerType", this.RealServerType);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "ListenerStatus", this.ListenerStatus);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "BindStatus", this.BindStatus);
            this.SetParamArrayObj(map, prefix + "RealServerSet.", this.RealServerSet);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SessionPersist", this.SessionPersist);
            this.SetParamSimple(map, prefix + "DelayLoop", this.DelayLoop);
            this.SetParamSimple(map, prefix + "ConnectTimeout", this.ConnectTimeout);
            this.SetParamSimple(map, prefix + "HealthyThreshold", this.HealthyThreshold);
            this.SetParamSimple(map, prefix + "UnhealthyThreshold", this.UnhealthyThreshold);
            this.SetParamSimple(map, prefix + "FailoverSwitch", this.FailoverSwitch);
            this.SetParamSimple(map, prefix + "HealthCheck", this.HealthCheck);
            this.SetParamSimple(map, prefix + "CheckType", this.CheckType);
            this.SetParamSimple(map, prefix + "CheckPort", this.CheckPort);
            this.SetParamSimple(map, prefix + "ContextType", this.ContextType);
            this.SetParamSimple(map, prefix + "SendContext", this.SendContext);
            this.SetParamSimple(map, prefix + "RecvContext", this.RecvContext);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
        }
    }
}

