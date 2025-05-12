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

    public class ClbObject : AbstractModel
    {
        
        /// <summary>
        /// 对象ID
        /// </summary>
        [JsonProperty("ObjectId")]
        public string ObjectId{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 精准域名列表
        /// </summary>
        [JsonProperty("PreciseDomains")]
        public string[] PreciseDomains{ get; set; }

        /// <summary>
        /// WAF功能开关状态，0关闭1开启
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// WAF日志开关状态，0关闭1开启
        /// </summary>
        [JsonProperty("ClsStatus")]
        public long? ClsStatus{ get; set; }

        /// <summary>
        /// CLB对象对应的虚拟域名
        /// </summary>
        [JsonProperty("VirtualDomain")]
        public string VirtualDomain{ get; set; }

        /// <summary>
        /// 对象名称
        /// </summary>
        [JsonProperty("ObjectName")]
        public string ObjectName{ get; set; }

        /// <summary>
        /// 公网地址
        /// </summary>
        [JsonProperty("PublicIp")]
        public string[] PublicIp{ get; set; }

        /// <summary>
        /// 内网地址
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string[] PrivateIp{ get; set; }

        /// <summary>
        /// VPC名称
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("Vpc")]
        public string Vpc{ get; set; }

        /// <summary>
        /// waf实例等级，如果未绑定实例为0
        /// </summary>
        [JsonProperty("InstanceLevel")]
        public long? InstanceLevel{ get; set; }

        /// <summary>
        /// clb投递开关
        /// </summary>
        [JsonProperty("PostCLSStatus")]
        public long? PostCLSStatus{ get; set; }

        /// <summary>
        /// kafka投递开关
        /// </summary>
        [JsonProperty("PostCKafkaStatus")]
        public long? PostCKafkaStatus{ get; set; }

        /// <summary>
        /// 对象类型：CLB:负载均衡器，TSE:云原生网关
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 对象地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 代理状态: 0:不开启,1:以XFF的第一个IP地址作为客户端IP,2:以remote_addr作为客户端IP,3:从指定的头部字段获取客户端IP，字段通过IpHeaders字段给出
        /// </summary>
        [JsonProperty("Proxy")]
        public ulong? Proxy{ get; set; }

        /// <summary>
        /// 指定获取客户端IP的头部字段列表。IsCdn为3时有效
        /// </summary>
        [JsonProperty("IpHeaders")]
        public string[] IpHeaders{ get; set; }

        /// <summary>
        /// bot防护开关
        /// </summary>
        [JsonProperty("BotStatus")]
        public long? BotStatus{ get; set; }

        /// <summary>
        /// api防护开关
        /// </summary>
        [JsonProperty("ApiStatus")]
        public long? ApiStatus{ get; set; }

        /// <summary>
        /// 对象接入模式，0表示镜像模式，1表示清洗模式，2表示体检模式，默认为清洗模式
        /// </summary>
        [JsonProperty("ObjectFlowMode")]
        public long? ObjectFlowMode{ get; set; }

        /// <summary>
        /// 数值形式的私有网络 ID
        /// </summary>
        [JsonProperty("NumericalVpcId")]
        public long? NumericalVpcId{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ObjectId", this.ObjectId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamArraySimple(map, prefix + "PreciseDomains.", this.PreciseDomains);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ClsStatus", this.ClsStatus);
            this.SetParamSimple(map, prefix + "VirtualDomain", this.VirtualDomain);
            this.SetParamSimple(map, prefix + "ObjectName", this.ObjectName);
            this.SetParamArraySimple(map, prefix + "PublicIp.", this.PublicIp);
            this.SetParamArraySimple(map, prefix + "PrivateIp.", this.PrivateIp);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "Vpc", this.Vpc);
            this.SetParamSimple(map, prefix + "InstanceLevel", this.InstanceLevel);
            this.SetParamSimple(map, prefix + "PostCLSStatus", this.PostCLSStatus);
            this.SetParamSimple(map, prefix + "PostCKafkaStatus", this.PostCKafkaStatus);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Proxy", this.Proxy);
            this.SetParamArraySimple(map, prefix + "IpHeaders.", this.IpHeaders);
            this.SetParamSimple(map, prefix + "BotStatus", this.BotStatus);
            this.SetParamSimple(map, prefix + "ApiStatus", this.ApiStatus);
            this.SetParamSimple(map, prefix + "ObjectFlowMode", this.ObjectFlowMode);
            this.SetParamSimple(map, prefix + "NumericalVpcId", this.NumericalVpcId);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
        }
    }
}

