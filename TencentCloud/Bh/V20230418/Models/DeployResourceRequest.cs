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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployResourceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>需要开通服务的资源ID</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>需要开通服务的地域</p>
        /// </summary>
        [JsonProperty("ApCode")]
        public string ApCode{ get; set; }

        /// <summary>
        /// <p>子网所在可用区</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>需要开通服务的VPC</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>需要开通服务的子网ID</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>需要开通服务的子网网段</p>
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// <p>需要开通服务的VPC名称</p>
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// <p>需要开通服务的VPC对应的网段</p>
        /// </summary>
        [JsonProperty("VpcCidrBlock")]
        public string VpcCidrBlock{ get; set; }

        /// <summary>
        /// <p>需要开通服务的子网名称</p>
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// <p>需要开通实例所属的CDC集群ID</p>
        /// </summary>
        [JsonProperty("CdcClusterId")]
        public string CdcClusterId{ get; set; }

        /// <summary>
        /// <p>开通堡垒机指定共享的clbId</p>
        /// </summary>
        [JsonProperty("ShareClbId")]
        public string ShareClbId{ get; set; }

        /// <summary>
        /// <p>0-关闭web访问堡垒机，1-开启web访问堡垒机</p>
        /// </summary>
        [JsonProperty("WebAccess")]
        public ulong? WebAccess{ get; set; }

        /// <summary>
        /// <p>0-关闭客户端访问堡垒机，1-开启客户端访问堡垒机</p>
        /// </summary>
        [JsonProperty("ClientAccess")]
        public ulong? ClientAccess{ get; set; }

        /// <summary>
        /// <p>0-关闭内网访问堡垒机，1-开启内网访问堡垒机</p>
        /// </summary>
        [JsonProperty("IntranetAccess")]
        public ulong? IntranetAccess{ get; set; }

        /// <summary>
        /// <p>0-关闭公网访问堡垒机，1-开启公网访问堡垒机</p>
        /// </summary>
        [JsonProperty("ExternalAccess")]
        public ulong? ExternalAccess{ get; set; }

        /// <summary>
        /// <p>开通堡垒机的子网信息</p>
        /// </summary>
        [JsonProperty("DeploySubnets")]
        public ParamInitResourceSubnet[] DeploySubnets{ get; set; }

        /// <summary>
        /// <p>开通内网访问的VPC ID</p>
        /// </summary>
        [JsonProperty("IntranetVpcId")]
        public string IntranetVpcId{ get; set; }

        /// <summary>
        /// <p>开通内网访问的VPC 网段</p>
        /// </summary>
        [JsonProperty("IntranetVpcCidrBlock")]
        public string IntranetVpcCidrBlock{ get; set; }

        /// <summary>
        /// <p>开通内网访问的VPC名称</p>
        /// </summary>
        [JsonProperty("IntranetVpcName")]
        public string IntranetVpcName{ get; set; }

        /// <summary>
        /// <p>开通内网访问的子网信息</p>
        /// </summary>
        [JsonProperty("IntranetSubnets")]
        public ParamInitResourceSubnet[] IntranetSubnets{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ApCode", this.ApCode);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "VpcCidrBlock", this.VpcCidrBlock);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "CdcClusterId", this.CdcClusterId);
            this.SetParamSimple(map, prefix + "ShareClbId", this.ShareClbId);
            this.SetParamSimple(map, prefix + "WebAccess", this.WebAccess);
            this.SetParamSimple(map, prefix + "ClientAccess", this.ClientAccess);
            this.SetParamSimple(map, prefix + "IntranetAccess", this.IntranetAccess);
            this.SetParamSimple(map, prefix + "ExternalAccess", this.ExternalAccess);
            this.SetParamArrayObj(map, prefix + "DeploySubnets.", this.DeploySubnets);
            this.SetParamSimple(map, prefix + "IntranetVpcId", this.IntranetVpcId);
            this.SetParamSimple(map, prefix + "IntranetVpcCidrBlock", this.IntranetVpcCidrBlock);
            this.SetParamSimple(map, prefix + "IntranetVpcName", this.IntranetVpcName);
            this.SetParamArrayObj(map, prefix + "IntranetSubnets.", this.IntranetSubnets);
        }
    }
}

