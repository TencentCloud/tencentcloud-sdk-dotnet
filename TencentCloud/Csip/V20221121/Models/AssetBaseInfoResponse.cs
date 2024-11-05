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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssetBaseInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// vpc-id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// vpc-name
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 资产名
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 操作系统
        /// </summary>
        [JsonProperty("Os")]
        public string Os{ get; set; }

        /// <summary>
        /// 公网ip
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 内网ip
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 资产id
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 账号数量
        /// </summary>
        [JsonProperty("AccountNum")]
        public ulong? AccountNum{ get; set; }

        /// <summary>
        /// 端口数量
        /// </summary>
        [JsonProperty("PortNum")]
        public ulong? PortNum{ get; set; }

        /// <summary>
        /// 进程数量
        /// </summary>
        [JsonProperty("ProcessNum")]
        public ulong? ProcessNum{ get; set; }

        /// <summary>
        /// 软件应用数量
        /// </summary>
        [JsonProperty("SoftApplicationNum")]
        public ulong? SoftApplicationNum{ get; set; }

        /// <summary>
        /// 数据库数量
        /// </summary>
        [JsonProperty("DatabaseNum")]
        public ulong? DatabaseNum{ get; set; }

        /// <summary>
        /// Web应用数量
        /// </summary>
        [JsonProperty("WebApplicationNum")]
        public ulong? WebApplicationNum{ get; set; }

        /// <summary>
        /// 服务数量
        /// </summary>
        [JsonProperty("ServiceNum")]
        public ulong? ServiceNum{ get; set; }

        /// <summary>
        /// web框架数量
        /// </summary>
        [JsonProperty("WebFrameworkNum")]
        public ulong? WebFrameworkNum{ get; set; }

        /// <summary>
        /// Web站点数量
        /// </summary>
        [JsonProperty("WebSiteNum")]
        public ulong? WebSiteNum{ get; set; }

        /// <summary>
        /// Jar包数量
        /// </summary>
        [JsonProperty("JarPackageNum")]
        public ulong? JarPackageNum{ get; set; }

        /// <summary>
        /// 启动服务数量
        /// </summary>
        [JsonProperty("StartServiceNum")]
        public ulong? StartServiceNum{ get; set; }

        /// <summary>
        /// 计划任务数量
        /// </summary>
        [JsonProperty("ScheduledTaskNum")]
        public ulong? ScheduledTaskNum{ get; set; }

        /// <summary>
        /// 环境变量数量
        /// </summary>
        [JsonProperty("EnvironmentVariableNum")]
        public ulong? EnvironmentVariableNum{ get; set; }

        /// <summary>
        /// 内核模块数量
        /// </summary>
        [JsonProperty("KernelModuleNum")]
        public ulong? KernelModuleNum{ get; set; }

        /// <summary>
        /// 系统安装包数量
        /// </summary>
        [JsonProperty("SystemInstallationPackageNum")]
        public ulong? SystemInstallationPackageNum{ get; set; }

        /// <summary>
        /// 剩余防护时长
        /// </summary>
        [JsonProperty("SurplusProtectDay")]
        public ulong? SurplusProtectDay{ get; set; }

        /// <summary>
        /// 客户端是否安装  1 已安装 0 未安装
        /// </summary>
        [JsonProperty("CWPStatus")]
        public ulong? CWPStatus{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// 防护等级
        /// </summary>
        [JsonProperty("ProtectLevel")]
        public string ProtectLevel{ get; set; }

        /// <summary>
        /// 防护时长
        /// </summary>
        [JsonProperty("ProtectedDay")]
        public ulong? ProtectedDay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "Os", this.Os);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AccountNum", this.AccountNum);
            this.SetParamSimple(map, prefix + "PortNum", this.PortNum);
            this.SetParamSimple(map, prefix + "ProcessNum", this.ProcessNum);
            this.SetParamSimple(map, prefix + "SoftApplicationNum", this.SoftApplicationNum);
            this.SetParamSimple(map, prefix + "DatabaseNum", this.DatabaseNum);
            this.SetParamSimple(map, prefix + "WebApplicationNum", this.WebApplicationNum);
            this.SetParamSimple(map, prefix + "ServiceNum", this.ServiceNum);
            this.SetParamSimple(map, prefix + "WebFrameworkNum", this.WebFrameworkNum);
            this.SetParamSimple(map, prefix + "WebSiteNum", this.WebSiteNum);
            this.SetParamSimple(map, prefix + "JarPackageNum", this.JarPackageNum);
            this.SetParamSimple(map, prefix + "StartServiceNum", this.StartServiceNum);
            this.SetParamSimple(map, prefix + "ScheduledTaskNum", this.ScheduledTaskNum);
            this.SetParamSimple(map, prefix + "EnvironmentVariableNum", this.EnvironmentVariableNum);
            this.SetParamSimple(map, prefix + "KernelModuleNum", this.KernelModuleNum);
            this.SetParamSimple(map, prefix + "SystemInstallationPackageNum", this.SystemInstallationPackageNum);
            this.SetParamSimple(map, prefix + "SurplusProtectDay", this.SurplusProtectDay);
            this.SetParamSimple(map, prefix + "CWPStatus", this.CWPStatus);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "ProtectLevel", this.ProtectLevel);
            this.SetParamSimple(map, prefix + "ProtectedDay", this.ProtectedDay);
        }
    }
}

