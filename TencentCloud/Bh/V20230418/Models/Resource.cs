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
        /// 日志投递规格信息
        /// </summary>
        [JsonProperty("LogDeliveryArgs")]
        public string LogDeliveryArgs{ get; set; }

        /// <summary>
        /// 堡垒机资源LB	
        /// </summary>
        [JsonProperty("ClbSet")]
        public Clb[] ClbSet{ get; set; }

        /// <summary>
        /// 网络域个数
        /// </summary>
        [JsonProperty("DomainCount")]
        public ulong? DomainCount{ get; set; }

        /// <summary>
        /// 已经使用的网络域个数
        /// </summary>
        [JsonProperty("UsedDomainCount")]
        public ulong? UsedDomainCount{ get; set; }

        /// <summary>
        /// 0 非试用版，1 试用版
        /// </summary>
        [JsonProperty("Trial")]
        public ulong? Trial{ get; set; }

        /// <summary>
        /// 日志投递规格信息
        /// </summary>
        [JsonProperty("LogDelivery")]
        public string LogDelivery{ get; set; }

        /// <summary>
        /// cdc集群id
        /// </summary>
        [JsonProperty("CdcClusterId")]
        public string CdcClusterId{ get; set; }

        /// <summary>
        /// 部署模式 默认0 0-cvm 1-tke
        /// </summary>
        [JsonProperty("DeployModel")]
        public ulong? DeployModel{ get; set; }

        /// <summary>
        /// 0 默认值，非内网访问，1 内网访问，2 内网访问开通中，3 内网访问关闭中
        /// </summary>
        [JsonProperty("IntranetAccess")]
        public ulong? IntranetAccess{ get; set; }

        /// <summary>
        /// 内网访问的ip
        /// </summary>
        [JsonProperty("IntranetPrivateIpSet")]
        public string[] IntranetPrivateIpSet{ get; set; }

        /// <summary>
        /// 开通内网访问的vpc
        /// </summary>
        [JsonProperty("IntranetVpcId")]
        public string IntranetVpcId{ get; set; }

        /// <summary>
        /// 开通内网访问vpc的网段
        /// </summary>
        [JsonProperty("IntranetVpcCidr")]
        public string IntranetVpcCidr{ get; set; }

        /// <summary>
        /// 是否共享clb，true-共享clb，false-独享clb
        /// </summary>
        [JsonProperty("ShareClb")]
        public bool? ShareClb{ get; set; }

        /// <summary>
        /// 共享clb id
        /// </summary>
        [JsonProperty("OpenClbId")]
        public string OpenClbId{ get; set; }

        /// <summary>
        /// 运营商信息
        /// </summary>
        [JsonProperty("LbVipIsp")]
        public string LbVipIsp{ get; set; }

        /// <summary>
        /// linux资产命令行运维端口
        /// </summary>
        [JsonProperty("TUICmdPort")]
        public long? TUICmdPort{ get; set; }

        /// <summary>
        /// linux资产直连端口
        /// </summary>
        [JsonProperty("TUIDirectPort")]
        public long? TUIDirectPort{ get; set; }

        /// <summary>
        /// 1 默认值，web访问开启，0 web访问关闭，2 web访问开通中，3 web访问关闭中
        /// </summary>
        [JsonProperty("WebAccess")]
        public ulong? WebAccess{ get; set; }

        /// <summary>
        /// 1 默认值，客户单访问开启，0 客户端访问关闭，2 客户端访问开通中，3 客户端访问关闭中
        /// </summary>
        [JsonProperty("ClientAccess")]
        public ulong? ClientAccess{ get; set; }

        /// <summary>
        /// 1 默认值，外网访问开启，0 外网访问关闭，2 外网访问开通中，3 外网访问关闭中
        /// </summary>
        [JsonProperty("ExternalAccess")]
        public ulong? ExternalAccess{ get; set; }

        /// <summary>
        /// 0默认值。0-免费版（试用版）ioa，1-付费版ioa
        /// </summary>
        [JsonProperty("IOAResource")]
        public ulong? IOAResource{ get; set; }

        /// <summary>
        /// 零信任堡垒机用户扩展包个数。1个扩展包对应20个用户数
        /// </summary>
        [JsonProperty("PackageIOAUserCount")]
        public ulong? PackageIOAUserCount{ get; set; }

        /// <summary>
        ///  零信任堡垒机带宽扩展包个数。一个扩展包表示4M带宽
        /// </summary>
        [JsonProperty("PackageIOABandwidth")]
        public ulong? PackageIOABandwidth{ get; set; }


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
            this.SetParamSimple(map, prefix + "LogDeliveryArgs", this.LogDeliveryArgs);
            this.SetParamArrayObj(map, prefix + "ClbSet.", this.ClbSet);
            this.SetParamSimple(map, prefix + "DomainCount", this.DomainCount);
            this.SetParamSimple(map, prefix + "UsedDomainCount", this.UsedDomainCount);
            this.SetParamSimple(map, prefix + "Trial", this.Trial);
            this.SetParamSimple(map, prefix + "LogDelivery", this.LogDelivery);
            this.SetParamSimple(map, prefix + "CdcClusterId", this.CdcClusterId);
            this.SetParamSimple(map, prefix + "DeployModel", this.DeployModel);
            this.SetParamSimple(map, prefix + "IntranetAccess", this.IntranetAccess);
            this.SetParamArraySimple(map, prefix + "IntranetPrivateIpSet.", this.IntranetPrivateIpSet);
            this.SetParamSimple(map, prefix + "IntranetVpcId", this.IntranetVpcId);
            this.SetParamSimple(map, prefix + "IntranetVpcCidr", this.IntranetVpcCidr);
            this.SetParamSimple(map, prefix + "ShareClb", this.ShareClb);
            this.SetParamSimple(map, prefix + "OpenClbId", this.OpenClbId);
            this.SetParamSimple(map, prefix + "LbVipIsp", this.LbVipIsp);
            this.SetParamSimple(map, prefix + "TUICmdPort", this.TUICmdPort);
            this.SetParamSimple(map, prefix + "TUIDirectPort", this.TUIDirectPort);
            this.SetParamSimple(map, prefix + "WebAccess", this.WebAccess);
            this.SetParamSimple(map, prefix + "ClientAccess", this.ClientAccess);
            this.SetParamSimple(map, prefix + "ExternalAccess", this.ExternalAccess);
            this.SetParamSimple(map, prefix + "IOAResource", this.IOAResource);
            this.SetParamSimple(map, prefix + "PackageIOAUserCount", this.PackageIOAUserCount);
            this.SetParamSimple(map, prefix + "PackageIOABandwidth", this.PackageIOABandwidth);
        }
    }
}

