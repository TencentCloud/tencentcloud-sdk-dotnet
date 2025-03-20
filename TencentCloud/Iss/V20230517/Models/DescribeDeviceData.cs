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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceData : AbstractModel
    {
        
        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 设备编码（国标设备即我们为设备生成的20位国标编码，rtmp 设备为10 位设备编码）
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 设备接入协议，1:RTMP,2:GB,3:GW 
        /// </summary>
        [JsonProperty("AccessProtocol")]
        public long? AccessProtocol{ get; set; }

        /// <summary>
        /// 设备类型，1:IPC,2:NVR
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 设备接入服务节点id
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 设备接入服务节点名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 设备流传输协议，1:UDP,2:TCP 
        /// </summary>
        [JsonProperty("TransportProtocol")]
        public long? TransportProtocol{ get; set; }

        /// <summary>
        /// 设备密码
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 设备描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// sip服务ID
        /// </summary>
        [JsonProperty("SipId")]
        public string SipId{ get; set; }

        /// <summary>
        /// sip服务域
        /// </summary>
        [JsonProperty("SipDomain")]
        public string SipDomain{ get; set; }

        /// <summary>
        /// sip服务IP地址
        /// </summary>
        [JsonProperty("SipIp")]
        public string SipIp{ get; set; }

        /// <summary>
        /// sip服务端口
        /// </summary>
        [JsonProperty("SipPort")]
        public long? SipPort{ get; set; }

        /// <summary>
        /// Rtmp设备推流地址(仅rtmp设备有效)
        /// </summary>
        [JsonProperty("PushStreamUrl")]
        public string PushStreamUrl{ get; set; }

        /// <summary>
        /// 设备状态，0:未注册,1:在线,2:离线,3:禁用
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 设备所属组织ID
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string OrganizationId{ get; set; }

        /// <summary>
        /// 设备接入网关ID，从查询网关列表接口中获取（仅网关接入需要）
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 设备所属网关名称
        /// </summary>
        [JsonProperty("GatewayName")]
        public string GatewayName{ get; set; }

        /// <summary>
        /// 设备网关协议名称
        /// </summary>
        [JsonProperty("ProtocolTypeName")]
        public string ProtocolTypeName{ get; set; }

        /// <summary>
        /// 网关接入协议类型，1.海康SDK，2.大华SDK，3.宇视SDK，4.Onvif（仅网关接入需要）
        /// </summary>
        [JsonProperty("ProtocolType")]
        public long? ProtocolType{ get; set; }

        /// <summary>
        /// 设备接入IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 设备Port
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 设备用户名
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// 设备地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 设备厂商
        /// </summary>
        [JsonProperty("Manufacturer")]
        public string Manufacturer{ get; set; }

        /// <summary>
        /// 音频关开（0：关闭；1：开启）关闭时丢弃音频	
        /// </summary>
        [JsonProperty("AudioSwitch")]
        public long? AudioSwitch{ get; set; }

        /// <summary>
        /// 订阅开关（0：关闭；1：开启）默认开启，开启状态下会订阅设备通道变化，仅国标NVR设备有效	
        /// </summary>
        [JsonProperty("SubscribeSwitch")]
        public long? SubscribeSwitch{ get; set; }

        /// <summary>
        /// RTMP推流地址自定义appName
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// RTMP推流地址自定义streamName
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// 是否开启静音帧（0：关闭；1 开启）
        /// </summary>
        [JsonProperty("SilentFrameSwitch")]
        public long? SilentFrameSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AccessProtocol", this.AccessProtocol);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "TransportProtocol", this.TransportProtocol);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SipId", this.SipId);
            this.SetParamSimple(map, prefix + "SipDomain", this.SipDomain);
            this.SetParamSimple(map, prefix + "SipIp", this.SipIp);
            this.SetParamSimple(map, prefix + "SipPort", this.SipPort);
            this.SetParamSimple(map, prefix + "PushStreamUrl", this.PushStreamUrl);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "OrganizationId", this.OrganizationId);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "GatewayName", this.GatewayName);
            this.SetParamSimple(map, prefix + "ProtocolTypeName", this.ProtocolTypeName);
            this.SetParamSimple(map, prefix + "ProtocolType", this.ProtocolType);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Manufacturer", this.Manufacturer);
            this.SetParamSimple(map, prefix + "AudioSwitch", this.AudioSwitch);
            this.SetParamSimple(map, prefix + "SubscribeSwitch", this.SubscribeSwitch);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "SilentFrameSwitch", this.SilentFrameSwitch);
        }
    }
}

