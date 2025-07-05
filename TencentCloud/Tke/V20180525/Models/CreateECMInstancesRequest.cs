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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateECMInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群id，边缘集群需要先开启公网访问才能添加ecm节点
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// 边缘模块id
        /// </summary>
        [JsonProperty("ModuleId")]
        public string ModuleId{ get; set; }

        /// <summary>
        /// 需要创建实例的可用区及创建数目及运营商的列表
        /// </summary>
        [JsonProperty("ZoneInstanceCountISPSet")]
        public ECMZoneInstanceCountISP[] ZoneInstanceCountISPSet{ get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 公网带宽
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public long? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// 镜像id
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 主机名称
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 增强服务，包括云镜和云监控
        /// </summary>
        [JsonProperty("EnhancedService")]
        public ECMEnhancedService EnhancedService{ get; set; }

        /// <summary>
        /// 用户自定义脚本
        /// </summary>
        [JsonProperty("UserData")]
        public string UserData{ get; set; }

        /// <summary>
        /// 实例扩展信息
        /// </summary>
        [JsonProperty("External")]
        public string External{ get; set; }

        /// <summary>
        /// 实例所属安全组
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "ModuleId", this.ModuleId);
            this.SetParamArrayObj(map, prefix + "ZoneInstanceCountISPSet.", this.ZoneInstanceCountISPSet);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamObj(map, prefix + "EnhancedService.", this.EnhancedService);
            this.SetParamSimple(map, prefix + "UserData", this.UserData);
            this.SetParamSimple(map, prefix + "External", this.External);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
        }
    }
}

