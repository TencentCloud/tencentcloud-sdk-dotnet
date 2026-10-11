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

    public class Device : AbstractModel
    {
        
        /// <summary>
        /// <p>资产ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>实例ID，对应CVM、CDB等实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>资产名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>公网IP</p>
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// <p>内网IP</p>
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// <p>地域编码</p>
        /// </summary>
        [JsonProperty("ApCode")]
        public string ApCode{ get; set; }

        /// <summary>
        /// <p>地域名称</p>
        /// </summary>
        [JsonProperty("ApName")]
        public string ApName{ get; set; }

        /// <summary>
        /// <p>操作系统名称</p>
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// <p>资产类型 1 - Linux, 2 - Windows, 3 - MySQL, 4 - SQLServer</p>
        /// </summary>
        [JsonProperty("Kind")]
        public ulong? Kind{ get; set; }

        /// <summary>
        /// <p>管理端口</p>
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// <p>所属资产组列表</p>
        /// </summary>
        [JsonProperty("GroupSet")]
        public Group[] GroupSet{ get; set; }

        /// <summary>
        /// <p>资产绑定的账号数</p>
        /// </summary>
        [JsonProperty("AccountCount")]
        public ulong? AccountCount{ get; set; }

        /// <summary>
        /// <p>VPC ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>子网ID</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>堡垒机服务信息，注意没有绑定服务时为null</p>
        /// </summary>
        [JsonProperty("Resource")]
        public Resource Resource{ get; set; }

        /// <summary>
        /// <p>资产所属部门</p>
        /// </summary>
        [JsonProperty("Department")]
        public Department Department{ get; set; }

        /// <summary>
        /// <p>数据库资产的多节点</p>
        /// </summary>
        [JsonProperty("IpPortSet")]
        public string[] IpPortSet{ get; set; }

        /// <summary>
        /// <p>网络域Id</p>
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// <p>网络域名称</p>
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// <p>是否启用SSL，仅支持Redis资产。0：禁用 1：启用</p>
        /// </summary>
        [JsonProperty("EnableSSL")]
        public long? EnableSSL{ get; set; }

        /// <summary>
        /// <p>已上传的SSL证书名称</p>
        /// </summary>
        [JsonProperty("SSLCertName")]
        public string SSLCertName{ get; set; }

        /// <summary>
        /// <p>IOA侧的资源ID</p>
        /// </summary>
        [JsonProperty("IOAId")]
        public long? IOAId{ get; set; }

        /// <summary>
        /// <p>K8S集群托管维度。1-集群，2-命名空间，3-工作负载</p>
        /// </summary>
        [JsonProperty("ManageDimension")]
        public ulong? ManageDimension{ get; set; }

        /// <summary>
        /// <p>K8S集群托管账号id</p>
        /// </summary>
        [JsonProperty("ManageAccountId")]
        public ulong? ManageAccountId{ get; set; }

        /// <summary>
        /// <p>K8S集群命名空间</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>K8S集群工作负载</p>
        /// </summary>
        [JsonProperty("Workload")]
        public string Workload{ get; set; }

        /// <summary>
        /// <p>K8S集群pod已同步数量</p>
        /// </summary>
        [JsonProperty("SyncPodCount")]
        public ulong? SyncPodCount{ get; set; }

        /// <summary>
        /// <p>K8S集群pod总数量</p>
        /// </summary>
        [JsonProperty("TotalPodCount")]
        public ulong? TotalPodCount{ get; set; }

        /// <summary>
        /// <p>云账号id</p>
        /// </summary>
        [JsonProperty("CloudAccountId")]
        public ulong? CloudAccountId{ get; set; }

        /// <summary>
        /// <p>云账号名称</p>
        /// </summary>
        [JsonProperty("CloudAccountName")]
        public string CloudAccountName{ get; set; }

        /// <summary>
        /// <p>云厂商类型1-腾讯云，2-阿里云</p>
        /// </summary>
        [JsonProperty("ProviderType")]
        public ulong? ProviderType{ get; set; }

        /// <summary>
        /// <p>云厂商名称</p>
        /// </summary>
        [JsonProperty("ProviderName")]
        public string ProviderName{ get; set; }

        /// <summary>
        /// <p>同步的云资产状态，标记同步的资产的状态情况，0-已删除,1-正常,2-已隔离,3-已过期</p>
        /// </summary>
        [JsonProperty("SyncCloudDeviceStatus")]
        public ulong? SyncCloudDeviceStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "ApCode", this.ApCode);
            this.SetParamSimple(map, prefix + "ApName", this.ApName);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamArrayObj(map, prefix + "GroupSet.", this.GroupSet);
            this.SetParamSimple(map, prefix + "AccountCount", this.AccountCount);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamObj(map, prefix + "Resource.", this.Resource);
            this.SetParamObj(map, prefix + "Department.", this.Department);
            this.SetParamArraySimple(map, prefix + "IpPortSet.", this.IpPortSet);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "EnableSSL", this.EnableSSL);
            this.SetParamSimple(map, prefix + "SSLCertName", this.SSLCertName);
            this.SetParamSimple(map, prefix + "IOAId", this.IOAId);
            this.SetParamSimple(map, prefix + "ManageDimension", this.ManageDimension);
            this.SetParamSimple(map, prefix + "ManageAccountId", this.ManageAccountId);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Workload", this.Workload);
            this.SetParamSimple(map, prefix + "SyncPodCount", this.SyncPodCount);
            this.SetParamSimple(map, prefix + "TotalPodCount", this.TotalPodCount);
            this.SetParamSimple(map, prefix + "CloudAccountId", this.CloudAccountId);
            this.SetParamSimple(map, prefix + "CloudAccountName", this.CloudAccountName);
            this.SetParamSimple(map, prefix + "ProviderType", this.ProviderType);
            this.SetParamSimple(map, prefix + "ProviderName", this.ProviderName);
            this.SetParamSimple(map, prefix + "SyncCloudDeviceStatus", this.SyncCloudDeviceStatus);
        }
    }
}

