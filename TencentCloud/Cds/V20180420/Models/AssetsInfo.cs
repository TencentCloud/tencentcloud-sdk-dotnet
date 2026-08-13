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

namespace TencentCloud.Cds.V20180420.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssetsInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("AddTime")]
        public ulong? AddTime{ get; set; }

        /// <summary>
        /// <p>资产 ID</p>
        /// </summary>
        [JsonProperty("Aid")]
        public ulong? Aid{ get; set; }

        /// <summary>
        /// <p>数据资产 IP</p>
        /// </summary>
        [JsonProperty("AssetsIp")]
        public string AssetsIp{ get; set; }

        /// <summary>
        /// <p>数据资产名称</p>
        /// </summary>
        [JsonProperty("AssetsName")]
        public string AssetsName{ get; set; }

        /// <summary>
        /// <p>数据资产端口</p>
        /// </summary>
        [JsonProperty("AssetsPort")]
        public ulong? AssetsPort{ get; set; }

        /// <summary>
        /// <p>数据资产类型</p>
        /// </summary>
        [JsonProperty("AssetsType")]
        public string AssetsType{ get; set; }

        /// <summary>
        /// <p>资产版本</p>
        /// </summary>
        [JsonProperty("AssetsVersion")]
        public string AssetsVersion{ get; set; }

        /// <summary>
        /// <p>是否动态</p>
        /// </summary>
        [JsonProperty("AssetsAddType")]
        public ulong? AssetsAddType{ get; set; }

        /// <summary>
        /// <p>是否删除</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>最后一次修改时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public ulong? UpdateTime{ get; set; }

        /// <summary>
        /// <p>资产的vpc</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>地域</p>
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// <p>审计权限</p>
        /// </summary>
        [JsonProperty("Permission")]
        public long? Permission{ get; set; }

        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>用来区分自建资产是已通过cvm还是添加ip的方式</p>
        /// </summary>
        [JsonProperty("AddType")]
        public ulong? AddType{ get; set; }

        /// <summary>
        /// <p>子网Id</p>
        /// </summary>
        [JsonProperty("AssetSubnetId")]
        public string AssetSubnetId{ get; set; }

        /// <summary>
        /// <p>是否已上传数据库私钥（0 否，1 是）</p>
        /// </summary>
        [JsonProperty("UploadPem")]
        public long? UploadPem{ get; set; }

        /// <summary>
        /// <p>资产状态栏 0:正常 1:已删除（目前仅对tencentDB有效）</p>
        /// </summary>
        [JsonProperty("AliveStatus")]
        public long? AliveStatus{ get; set; }

        /// <summary>
        /// <p>开启agent(0:关闭;1:开启)</p>
        /// </summary>
        [JsonProperty("AgentOn")]
        public ulong? AgentOn{ get; set; }

        /// <summary>
        /// <p>开启agent(0:关闭;1:开启)</p>
        /// </summary>
        [JsonProperty("CasbOn")]
        public ulong? CasbOn{ get; set; }

        /// <summary>
        /// <p>只读组/集群ID</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// <p>PROXY_OFF: 未开启Casb代理;PROXY_ERROR:Casb代理接口返回异常;PROXY_BOUND:已绑定;PROXY_UNBOUND:未绑定;UNPAID:未购买;UNSUPPORTED:类型不支持;METADATA_NOT_FOUND:元数据不存在;QUOTA_EXCEEDED:Casb额度不足</p>
        /// </summary>
        [JsonProperty("Available")]
        public string Available{ get; set; }

        /// <summary>
        /// <p>cdbOn</p>
        /// </summary>
        [JsonProperty("CdbOn")]
        public ulong? CdbOn{ get; set; }

        /// <summary>
        /// <p>平台位数 32位 64位</p>
        /// </summary>
        [JsonProperty("DbPlatform")]
        public string DbPlatform{ get; set; }

        /// <summary>
        /// <p>编码</p>
        /// </summary>
        [JsonProperty("DbCharset")]
        public string DbCharset{ get; set; }

        /// <summary>
        /// <p>操作系统</p>
        /// </summary>
        [JsonProperty("OsPolicy")]
        public string OsPolicy{ get; set; }

        /// <summary>
        /// <p>是否开启双向审计</p>
        /// </summary>
        [JsonProperty("BidirectionOn")]
        public long? BidirectionOn{ get; set; }

        /// <summary>
        /// <p>最大返回行数</p>
        /// </summary>
        [JsonProperty("BidirectionMaxLine")]
        public long? BidirectionMaxLine{ get; set; }

        /// <summary>
        /// <p>最大返回大小</p>
        /// </summary>
        [JsonProperty("BidirectionMaxStorage")]
        public long? BidirectionMaxStorage{ get; set; }

        /// <summary>
        /// <p>是否允许开通双向审计(1.允许；0不允许)</p>
        /// </summary>
        [JsonProperty("BidirectionAllow")]
        public long? BidirectionAllow{ get; set; }

        /// <summary>
        /// <p>启双向审计的日志投递(1.开启;0.关闭)</p>
        /// </summary>
        [JsonProperty("BidirectionDelivery")]
        public ulong? BidirectionDelivery{ get; set; }

        /// <summary>
        /// <p>只读状态</p>
        /// </summary>
        [JsonProperty("RoStatus")]
        public string RoStatus{ get; set; }

        /// <summary>
        /// <p>当前资产是否开启了对当前Agent的采集策略</p>
        /// </summary>
        [JsonProperty("AgentBound")]
        public bool? AgentBound{ get; set; }

        /// <summary>
        /// <p>错误信息</p>
        /// </summary>
        [JsonProperty("CdbErrorMsg")]
        public string CdbErrorMsg{ get; set; }

        /// <summary>
        /// <p>资产 DSGC 绑定信息</p>
        /// </summary>
        [JsonProperty("DsgcBindingInfo")]
        public DsgcBindingInfo DsgcBindingInfo{ get; set; }

        /// <summary>
        /// <p>绑定的规则Ids</p>
        /// </summary>
        [JsonProperty("BindingRules")]
        public IdWithName[] BindingRules{ get; set; }

        /// <summary>
        /// <p>绑定的模型Ids</p>
        /// </summary>
        [JsonProperty("BindingModels")]
        public IdWithName[] BindingModels{ get; set; }

        /// <summary>
        /// <p>所属组名</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>资产组Id</p>
        /// </summary>
        [JsonProperty("AssetGroupId")]
        public ulong? AssetGroupId{ get; set; }

        /// <summary>
        /// <p>是否是新云原生审计流程</p>
        /// </summary>
        [JsonProperty("IsNewCloudAudit")]
        public bool? IsNewCloudAudit{ get; set; }

        /// <summary>
        /// <p>1</p><p>取值范围：[0, 1]</p>
        /// </summary>
        [JsonProperty("TrafficMirrorOn")]
        public long? TrafficMirrorOn{ get; set; }

        /// <summary>
        /// <p>流量镜像审计范围</p><p>枚举值：</p><ul><li>ALL： 全地域</li><li>REGION： 资产所在地域</li><li>VPC： 资产所在VPC</li></ul><p>默认值：REGION</p>
        /// </summary>
        [JsonProperty("AuditScope")]
        public string AuditScope{ get; set; }

        /// <summary>
        /// <p>实例集群ID</p>
        /// </summary>
        [JsonProperty("InstanceGroupId")]
        public string InstanceGroupId{ get; set; }

        /// <summary>
        /// <p>该资产所在的资产组</p>
        /// </summary>
        [JsonProperty("AssetGroups")]
        public IdWithName[] AssetGroups{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "Aid", this.Aid);
            this.SetParamSimple(map, prefix + "AssetsIp", this.AssetsIp);
            this.SetParamSimple(map, prefix + "AssetsName", this.AssetsName);
            this.SetParamSimple(map, prefix + "AssetsPort", this.AssetsPort);
            this.SetParamSimple(map, prefix + "AssetsType", this.AssetsType);
            this.SetParamSimple(map, prefix + "AssetsVersion", this.AssetsVersion);
            this.SetParamSimple(map, prefix + "AssetsAddType", this.AssetsAddType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "Permission", this.Permission);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "AddType", this.AddType);
            this.SetParamSimple(map, prefix + "AssetSubnetId", this.AssetSubnetId);
            this.SetParamSimple(map, prefix + "UploadPem", this.UploadPem);
            this.SetParamSimple(map, prefix + "AliveStatus", this.AliveStatus);
            this.SetParamSimple(map, prefix + "AgentOn", this.AgentOn);
            this.SetParamSimple(map, prefix + "CasbOn", this.CasbOn);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Available", this.Available);
            this.SetParamSimple(map, prefix + "CdbOn", this.CdbOn);
            this.SetParamSimple(map, prefix + "DbPlatform", this.DbPlatform);
            this.SetParamSimple(map, prefix + "DbCharset", this.DbCharset);
            this.SetParamSimple(map, prefix + "OsPolicy", this.OsPolicy);
            this.SetParamSimple(map, prefix + "BidirectionOn", this.BidirectionOn);
            this.SetParamSimple(map, prefix + "BidirectionMaxLine", this.BidirectionMaxLine);
            this.SetParamSimple(map, prefix + "BidirectionMaxStorage", this.BidirectionMaxStorage);
            this.SetParamSimple(map, prefix + "BidirectionAllow", this.BidirectionAllow);
            this.SetParamSimple(map, prefix + "BidirectionDelivery", this.BidirectionDelivery);
            this.SetParamSimple(map, prefix + "RoStatus", this.RoStatus);
            this.SetParamSimple(map, prefix + "AgentBound", this.AgentBound);
            this.SetParamSimple(map, prefix + "CdbErrorMsg", this.CdbErrorMsg);
            this.SetParamObj(map, prefix + "DsgcBindingInfo.", this.DsgcBindingInfo);
            this.SetParamArrayObj(map, prefix + "BindingRules.", this.BindingRules);
            this.SetParamArrayObj(map, prefix + "BindingModels.", this.BindingModels);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "AssetGroupId", this.AssetGroupId);
            this.SetParamSimple(map, prefix + "IsNewCloudAudit", this.IsNewCloudAudit);
            this.SetParamSimple(map, prefix + "TrafficMirrorOn", this.TrafficMirrorOn);
            this.SetParamSimple(map, prefix + "AuditScope", this.AuditScope);
            this.SetParamSimple(map, prefix + "InstanceGroupId", this.InstanceGroupId);
            this.SetParamArrayObj(map, prefix + "AssetGroups.", this.AssetGroups);
        }
    }
}

