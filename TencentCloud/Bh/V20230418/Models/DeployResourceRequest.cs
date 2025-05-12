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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployResourceRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要开通服务的资源ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 需要开通服务的地域
        /// </summary>
        [JsonProperty("ApCode")]
        public string ApCode{ get; set; }

        /// <summary>
        /// 子网所在可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 需要开通服务的VPC
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 需要开通服务的子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 需要开通服务的子网网段
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// 需要开通服务的VPC名称
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 需要开通服务的VPC对应的网段
        /// </summary>
        [JsonProperty("VpcCidrBlock")]
        public string VpcCidrBlock{ get; set; }

        /// <summary>
        /// 需要开通服务的子网名称
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// 需要开通实例所属的CDC集群ID
        /// </summary>
        [JsonProperty("CdcClusterId")]
        public string CdcClusterId{ get; set; }

        /// <summary>
        /// 开通堡垒机指定共享的clbId
        /// </summary>
        [JsonProperty("ShareClbId")]
        public string ShareClbId{ get; set; }

        /// <summary>
        /// 0-关闭web访问堡垒机，1-开启web访问堡垒机
        /// </summary>
        [JsonProperty("WebAccess")]
        public ulong? WebAccess{ get; set; }

        /// <summary>
        /// 0-关闭客户端访问堡垒机，1-开启客户端访问堡垒机
        /// </summary>
        [JsonProperty("ClientAccess")]
        public ulong? ClientAccess{ get; set; }

        /// <summary>
        /// 0-关闭内网访问堡垒机，1-开启内网访问堡垒机
        /// </summary>
        [JsonProperty("IntranetAccess")]
        public ulong? IntranetAccess{ get; set; }

        /// <summary>
        /// 0-关闭公网访问堡垒机，1-开启公网访问堡垒机
        /// </summary>
        [JsonProperty("ExternalAccess")]
        public ulong? ExternalAccess{ get; set; }


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
        }
    }
}

