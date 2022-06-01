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

namespace TencentCloud.Dasb.V20191018.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Resource : AbstractModel
    {
        
        /// <summary>
        /// 服务实例ID，如bh-saas-s3ed4r5e
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 地域编码
        /// </summary>
        [JsonProperty("ApCode")]
        public string ApCode{ get; set; }

        /// <summary>
        /// 服务实例规格信息
        /// </summary>
        [JsonProperty("SvArgs")]
        public string SvArgs{ get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 服务规格对应的资产数
        /// </summary>
        [JsonProperty("Nodes")]
        public ulong? Nodes{ get; set; }

        /// <summary>
        /// 自动续费标记，0 - 表示默认状态，1 - 表示自动续费，2 - 表示明确不自动续费
        /// </summary>
        [JsonProperty("RenewFlag")]
        public ulong? RenewFlag{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 资源状态，0 - 未初始化，1 - 正常，2 - 隔离，3 - 销毁，4 - 初始化失败，5 - 初始化中
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 服务实例名，如T-Sec-堡垒机（SaaS型）
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 定价模型ID
        /// </summary>
        [JsonProperty("Pid")]
        public ulong? Pid{ get; set; }

        /// <summary>
        /// 资源创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 商品码, p_cds_dasb
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode{ get; set; }

        /// <summary>
        /// 子商品码, sp_cds_dasb_bh_saas
        /// </summary>
        [JsonProperty("SubProductCode")]
        public string SubProductCode{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 是否过期，true-过期，false-未过期
        /// </summary>
        [JsonProperty("Expired")]
        public bool? Expired{ get; set; }

        /// <summary>
        /// 是否开通，true-开通，false-未开通
        /// </summary>
        [JsonProperty("Deployed")]
        public bool? Deployed{ get; set; }

        /// <summary>
        /// 开通服务的 VPC 名称
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 开通服务的 VPC 对应的网段
        /// </summary>
        [JsonProperty("VpcCidrBlock")]
        public string VpcCidrBlock{ get; set; }

        /// <summary>
        /// 开通服务的子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 开通服务的子网名称
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// 开通服务的子网网段
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// 外部IP
        /// </summary>
        [JsonProperty("PublicIpSet")]
        public string[] PublicIpSet{ get; set; }

        /// <summary>
        /// 内部IP
        /// </summary>
        [JsonProperty("PrivateIpSet")]
        public string[] PrivateIpSet{ get; set; }

        /// <summary>
        /// 服务开通的高级功能列表，如:[DB]
        /// </summary>
        [JsonProperty("ModuleSet")]
        public string[] ModuleSet{ get; set; }

        /// <summary>
        /// 已使用的授权点数
        /// </summary>
        [JsonProperty("UsedNodes")]
        public ulong? UsedNodes{ get; set; }

        /// <summary>
        /// 扩展点数
        /// </summary>
        [JsonProperty("ExtendPoints")]
        public ulong? ExtendPoints{ get; set; }

        /// <summary>
        /// 带宽扩展包个数(4M)
        /// </summary>
        [JsonProperty("PackageBandwidth")]
        public ulong? PackageBandwidth{ get; set; }

        /// <summary>
        /// 授权点数扩展包个数(50点)
        /// </summary>
        [JsonProperty("PackageNode")]
        public ulong? PackageNode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ApCode", this.ApCode);
            this.SetParamSimple(map, prefix + "SvArgs", this.SvArgs);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Nodes", this.Nodes);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ProductCode", this.ProductCode);
            this.SetParamSimple(map, prefix + "SubProductCode", this.SubProductCode);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Expired", this.Expired);
            this.SetParamSimple(map, prefix + "Deployed", this.Deployed);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "VpcCidrBlock", this.VpcCidrBlock);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamArraySimple(map, prefix + "PublicIpSet.", this.PublicIpSet);
            this.SetParamArraySimple(map, prefix + "PrivateIpSet.", this.PrivateIpSet);
            this.SetParamArraySimple(map, prefix + "ModuleSet.", this.ModuleSet);
            this.SetParamSimple(map, prefix + "UsedNodes", this.UsedNodes);
            this.SetParamSimple(map, prefix + "ExtendPoints", this.ExtendPoints);
            this.SetParamSimple(map, prefix + "PackageBandwidth", this.PackageBandwidth);
            this.SetParamSimple(map, prefix + "PackageNode", this.PackageNode);
        }
    }
}

