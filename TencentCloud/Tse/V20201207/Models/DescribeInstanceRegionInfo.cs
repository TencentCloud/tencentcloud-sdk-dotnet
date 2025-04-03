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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceRegionInfo : AbstractModel
    {
        
        /// <summary>
        /// 引擎部署地域信息
        /// </summary>
        [JsonProperty("EngineRegion")]
        public string EngineRegion{ get; set; }

        /// <summary>
        /// 引擎在该地域的副本数
        /// </summary>
        [JsonProperty("Replica")]
        public long? Replica{ get; set; }

        /// <summary>
        /// 引擎在该地域的规格id
        /// </summary>
        [JsonProperty("SpecId")]
        public string SpecId{ get; set; }

        /// <summary>
        /// 客户端内网的网络信息
        /// </summary>
        [JsonProperty("IntranetVpcInfos")]
        public VpcInfo[] IntranetVpcInfos{ get; set; }

        /// <summary>
        /// 控制台内网的网络信息
        /// </summary>
        [JsonProperty("ConsoleIntranetVpcInfos")]
        public VpcInfo[] ConsoleIntranetVpcInfos{ get; set; }

        /// <summary>
        /// 是否开公网
        /// </summary>
        [JsonProperty("EnableClientInternet")]
        public bool? EnableClientInternet{ get; set; }

        /// <summary>
        /// 限流客户端内网的网络信息
        /// </summary>
        [JsonProperty("LimiterIntranetVpcInfos")]
        public VpcInfo[] LimiterIntranetVpcInfos{ get; set; }

        /// <summary>
        /// 是否为主地域，仅在服务治理中心多地域有效
        /// </summary>
        [JsonProperty("MainRegion")]
        public bool? MainRegion{ get; set; }

        /// <summary>
        /// 该地域所在的EKS集群
        /// </summary>
        [JsonProperty("EKSClusterID")]
        public string EKSClusterID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineRegion", this.EngineRegion);
            this.SetParamSimple(map, prefix + "Replica", this.Replica);
            this.SetParamSimple(map, prefix + "SpecId", this.SpecId);
            this.SetParamArrayObj(map, prefix + "IntranetVpcInfos.", this.IntranetVpcInfos);
            this.SetParamArrayObj(map, prefix + "ConsoleIntranetVpcInfos.", this.ConsoleIntranetVpcInfos);
            this.SetParamSimple(map, prefix + "EnableClientInternet", this.EnableClientInternet);
            this.SetParamArrayObj(map, prefix + "LimiterIntranetVpcInfos.", this.LimiterIntranetVpcInfos);
            this.SetParamSimple(map, prefix + "MainRegion", this.MainRegion);
            this.SetParamSimple(map, prefix + "EKSClusterID", this.EKSClusterID);
        }
    }
}

