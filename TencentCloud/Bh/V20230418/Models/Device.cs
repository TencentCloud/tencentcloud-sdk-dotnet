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

    public class Device : AbstractModel
    {
        
        /// <summary>
        /// 资产ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 实例ID，对应CVM、CDB等实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 资产名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 公网IP
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 内网IP
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// 地域编码
        /// </summary>
        [JsonProperty("ApCode")]
        public string ApCode{ get; set; }

        /// <summary>
        /// 操作系统名称
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// 资产类型 1 - Linux, 2 - Windows, 3 - MySQL, 4 - SQLServer
        /// </summary>
        [JsonProperty("Kind")]
        public ulong? Kind{ get; set; }

        /// <summary>
        /// 管理端口
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 所属资产组列表
        /// </summary>
        [JsonProperty("GroupSet")]
        public Group[] GroupSet{ get; set; }

        /// <summary>
        /// 资产绑定的账号数
        /// </summary>
        [JsonProperty("AccountCount")]
        public ulong? AccountCount{ get; set; }

        /// <summary>
        /// VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 堡垒机服务信息，注意没有绑定服务时为null
        /// </summary>
        [JsonProperty("Resource")]
        public Resource Resource{ get; set; }

        /// <summary>
        /// 资产所属部门
        /// </summary>
        [JsonProperty("Department")]
        public Department Department{ get; set; }

        /// <summary>
        /// 数据库资产的多节点
        /// </summary>
        [JsonProperty("IpPortSet")]
        public string[] IpPortSet{ get; set; }

        /// <summary>
        /// 网络域Id
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// 网络域名称
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 是否启用SSL，仅支持Redis资产。0：禁用 1：启用
        /// </summary>
        [JsonProperty("EnableSSL")]
        public long? EnableSSL{ get; set; }

        /// <summary>
        /// 已上传的SSL证书名称
        /// </summary>
        [JsonProperty("SSLCertName")]
        public string SSLCertName{ get; set; }

        /// <summary>
        /// IOA侧的资源ID
        /// </summary>
        [JsonProperty("IOAId")]
        public long? IOAId{ get; set; }

        /// <summary>
        /// K8S集群托管维度。1-集群，2-命名空间，3-工作负载
        /// </summary>
        [JsonProperty("ManageDimension")]
        public ulong? ManageDimension{ get; set; }

        /// <summary>
        /// K8S集群托管账号id	
        /// </summary>
        [JsonProperty("ManageAccountId")]
        public ulong? ManageAccountId{ get; set; }

        /// <summary>
        /// K8S集群命名空间	
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// K8S集群工作负载	
        /// </summary>
        [JsonProperty("Workload")]
        public string Workload{ get; set; }

        /// <summary>
        /// K8S集群pod已同步数量
        /// </summary>
        [JsonProperty("SyncPodCount")]
        public ulong? SyncPodCount{ get; set; }

        /// <summary>
        /// K8S集群pod总数量	
        /// </summary>
        [JsonProperty("TotalPodCount")]
        public ulong? TotalPodCount{ get; set; }


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
        }
    }
}

