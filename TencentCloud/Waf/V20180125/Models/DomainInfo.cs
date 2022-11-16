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

    public class DomainInfo : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 域名ID
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// cname地址
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// 实例类型
        /// </summary>
        [JsonProperty("Edition")]
        public string Edition{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 实例名
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 日志包
        /// </summary>
        [JsonProperty("ClsStatus")]
        public ulong? ClsStatus{ get; set; }

        /// <summary>
        /// clb模式
        /// </summary>
        [JsonProperty("FlowMode")]
        public ulong? FlowMode{ get; set; }

        /// <summary>
        /// waf开关
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 防御模式
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// AI防御模式
        /// </summary>
        [JsonProperty("Engine")]
        public ulong? Engine{ get; set; }

        /// <summary>
        /// CC列表
        /// </summary>
        [JsonProperty("CCList")]
        public string[] CCList{ get; set; }

        /// <summary>
        /// 回源ip
        /// </summary>
        [JsonProperty("RsList")]
        public string[] RsList{ get; set; }

        /// <summary>
        /// 服务端口配置
        /// </summary>
        [JsonProperty("Ports")]
        public PortInfo[] Ports{ get; set; }

        /// <summary>
        /// 负载均衡器
        /// </summary>
        [JsonProperty("LoadBalancerSet")]
        public LoadBalancerPackageNew[] LoadBalancerSet{ get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// clb状态
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 0关闭 1开启
        /// </summary>
        [JsonProperty("Ipv6Status")]
        public long? Ipv6Status{ get; set; }

        /// <summary>
        /// 0关闭 1开启
        /// </summary>
        [JsonProperty("BotStatus")]
        public long? BotStatus{ get; set; }

        /// <summary>
        /// 版本信息
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 是否开启投递CLS功能
        /// </summary>
        [JsonProperty("PostCLSStatus")]
        public long? PostCLSStatus{ get; set; }

        /// <summary>
        /// 是否开启投递CKafka功能
        /// </summary>
        [JsonProperty("PostCKafkaStatus")]
        public long? PostCKafkaStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "Edition", this.Edition);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "ClsStatus", this.ClsStatus);
            this.SetParamSimple(map, prefix + "FlowMode", this.FlowMode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamArraySimple(map, prefix + "CCList.", this.CCList);
            this.SetParamArraySimple(map, prefix + "RsList.", this.RsList);
            this.SetParamArrayObj(map, prefix + "Ports.", this.Ports);
            this.SetParamArrayObj(map, prefix + "LoadBalancerSet.", this.LoadBalancerSet);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Ipv6Status", this.Ipv6Status);
            this.SetParamSimple(map, prefix + "BotStatus", this.BotStatus);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "PostCLSStatus", this.PostCLSStatus);
            this.SetParamSimple(map, prefix + "PostCKafkaStatus", this.PostCKafkaStatus);
        }
    }
}

