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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceDetail : AbstractModel
    {
        
        /// <summary>
        /// 设备ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 设备唯一标识码，在ioa中每个设备有唯一标识码
        /// </summary>
        [JsonProperty("Mid")]
        public string Mid{ get; set; }

        /// <summary>
        /// 终端名（设备名）
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 设备所在分组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// OS平台，0：Windows 、1： Linux、 2：macOS 、4： Android、 5: iOS。默认是0
        /// </summary>
        [JsonProperty("OsType")]
        public long? OsType{ get; set; }

        /// <summary>
        /// 设备IP地址（出口IP）
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 在线状态，2：在线、0或者1:离线
        /// </summary>
        [JsonProperty("OnlineStatus")]
        public long? OnlineStatus{ get; set; }

        /// <summary>
        /// 客户端版本号-大整数
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 客户端版本号-点分字符串
        /// </summary>
        [JsonProperty("StrVersion")]
        public string StrVersion{ get; set; }

        /// <summary>
        /// 首次在线时间
        /// </summary>
        [JsonProperty("Itime")]
        public string Itime{ get; set; }

        /// <summary>
        /// 最后一次在线时间
        /// </summary>
        [JsonProperty("ConnActiveTime")]
        public string ConnActiveTime{ get; set; }

        /// <summary>
        /// 设备是否加锁 ，1：锁定 0或者2：未锁定。
        /// </summary>
        [JsonProperty("Locked")]
        public long? Locked{ get; set; }

        /// <summary>
        /// 设备本地IP列表, 包括IP
        /// </summary>
        [JsonProperty("LocalIpList")]
        public string LocalIpList{ get; set; }

        /// <summary>
        /// 宿主机id（需要宿主机也安装iOA才能显示）
        /// </summary>
        [JsonProperty("HostId")]
        public long? HostId{ get; set; }

        /// <summary>
        /// 设备所属分组名
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 设备所属分组路径
        /// </summary>
        [JsonProperty("GroupNamePath")]
        public string GroupNamePath{ get; set; }

        /// <summary>
        /// 未修复高危漏洞数(只支持32位)
        /// </summary>
        [JsonProperty("CriticalVulListCount")]
        public long? CriticalVulListCount{ get; set; }

        /// <summary>
        /// 操作系统名称
        /// </summary>
        [JsonProperty("Os")]
        public string Os{ get; set; }

        /// <summary>
        /// 操作系统位数
        /// </summary>
        [JsonProperty("OsBits")]
        public long? OsBits{ get; set; }

        /// <summary>
        /// 操作系统版本
        /// </summary>
        [JsonProperty("OsVersion")]
        public string OsVersion{ get; set; }

        /// <summary>
        /// 操作系统语言
        /// </summary>
        [JsonProperty("OsLanguage")]
        public string OsLanguage{ get; set; }

        /// <summary>
        /// 操作系统安装时间
        /// </summary>
        [JsonProperty("OsInstallDate")]
        public string OsInstallDate{ get; set; }

        /// <summary>
        /// 设备名，和Name相同
        /// </summary>
        [JsonProperty("ComputerName")]
        public string ComputerName{ get; set; }

        /// <summary>
        /// 登录域名
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// MAC地址
        /// </summary>
        [JsonProperty("MacAddr")]
        public string MacAddr{ get; set; }

        /// <summary>
        /// 漏洞数
        /// </summary>
        [JsonProperty("VulCount")]
        public long? VulCount{ get; set; }

        /// <summary>
        /// 病毒风险数
        /// </summary>
        [JsonProperty("RiskCount")]
        public long? RiskCount{ get; set; }

        /// <summary>
        /// 病毒库版本
        /// </summary>
        [JsonProperty("VirusVer")]
        public string VirusVer{ get; set; }

        /// <summary>
        /// 漏洞库版本
        /// </summary>
        [JsonProperty("VulVersion")]
        public string VulVersion{ get; set; }

        /// <summary>
        /// 系统修复引擎版本
        /// </summary>
        [JsonProperty("SysRepVersion")]
        public string SysRepVersion{ get; set; }

        /// <summary>
        /// 高危补丁列表
        /// </summary>
        [JsonProperty("VulCriticalList")]
        public string[] VulCriticalList{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public string Tags{ get; set; }

        /// <summary>
        /// 终端用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 防火墙状态，不等于0表示开启
        /// </summary>
        [JsonProperty("FirewallStatus")]
        public long? FirewallStatus{ get; set; }

        /// <summary>
        /// SN序列号
        /// </summary>
        [JsonProperty("SerialNum")]
        public string SerialNum{ get; set; }

        /// <summary>
        /// 设备管控策略版本
        /// </summary>
        [JsonProperty("DeviceStrategyVer")]
        public string DeviceStrategyVer{ get; set; }

        /// <summary>
        /// NGN策略版本
        /// </summary>
        [JsonProperty("NGNStrategyVer")]
        public string NGNStrategyVer{ get; set; }

        /// <summary>
        /// 最近登录账户的账号(账号系统用户账号)
        /// </summary>
        [JsonProperty("IOAUserName")]
        public string IOAUserName{ get; set; }

        /// <summary>
        /// 设备管控新策略
        /// </summary>
        [JsonProperty("DeviceNewStrategyVer")]
        public string DeviceNewStrategyVer{ get; set; }

        /// <summary>
        /// NGN策略新版本
        /// </summary>
        [JsonProperty("NGNNewStrategyVer")]
        public string NGNNewStrategyVer{ get; set; }

        /// <summary>
        /// 宿主机名称（需要宿主机也安装iOA才能显示）
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 主板序列号
        /// </summary>
        [JsonProperty("BaseBoardSn")]
        public string BaseBoardSn{ get; set; }

        /// <summary>
        /// 绑定账户名称
        /// </summary>
        [JsonProperty("AccountUsers")]
        public string AccountUsers{ get; set; }

        /// <summary>
        /// 身份策略版本
        /// </summary>
        [JsonProperty("IdentityStrategyVer")]
        public string IdentityStrategyVer{ get; set; }

        /// <summary>
        /// 身份策略新版本
        /// </summary>
        [JsonProperty("IdentityNewStrategyVer")]
        public string IdentityNewStrategyVer{ get; set; }

        /// <summary>
        /// 最近登录账号部门
        /// </summary>
        [JsonProperty("AccountGroupName")]
        public string AccountGroupName{ get; set; }

        /// <summary>
        /// 最近登录账户的姓名(账号系统用户姓名)
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// 账号组id
        /// </summary>
        [JsonProperty("AccountGroupId")]
        public long? AccountGroupId{ get; set; }

        /// <summary>
        /// 终端备注名
        /// </summary>
        [JsonProperty("RemarkName")]
        public string RemarkName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Mid", this.Mid);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "OnlineStatus", this.OnlineStatus);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "StrVersion", this.StrVersion);
            this.SetParamSimple(map, prefix + "Itime", this.Itime);
            this.SetParamSimple(map, prefix + "ConnActiveTime", this.ConnActiveTime);
            this.SetParamSimple(map, prefix + "Locked", this.Locked);
            this.SetParamSimple(map, prefix + "LocalIpList", this.LocalIpList);
            this.SetParamSimple(map, prefix + "HostId", this.HostId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupNamePath", this.GroupNamePath);
            this.SetParamSimple(map, prefix + "CriticalVulListCount", this.CriticalVulListCount);
            this.SetParamSimple(map, prefix + "Os", this.Os);
            this.SetParamSimple(map, prefix + "OsBits", this.OsBits);
            this.SetParamSimple(map, prefix + "OsVersion", this.OsVersion);
            this.SetParamSimple(map, prefix + "OsLanguage", this.OsLanguage);
            this.SetParamSimple(map, prefix + "OsInstallDate", this.OsInstallDate);
            this.SetParamSimple(map, prefix + "ComputerName", this.ComputerName);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "MacAddr", this.MacAddr);
            this.SetParamSimple(map, prefix + "VulCount", this.VulCount);
            this.SetParamSimple(map, prefix + "RiskCount", this.RiskCount);
            this.SetParamSimple(map, prefix + "VirusVer", this.VirusVer);
            this.SetParamSimple(map, prefix + "VulVersion", this.VulVersion);
            this.SetParamSimple(map, prefix + "SysRepVersion", this.SysRepVersion);
            this.SetParamArraySimple(map, prefix + "VulCriticalList.", this.VulCriticalList);
            this.SetParamSimple(map, prefix + "Tags", this.Tags);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "FirewallStatus", this.FirewallStatus);
            this.SetParamSimple(map, prefix + "SerialNum", this.SerialNum);
            this.SetParamSimple(map, prefix + "DeviceStrategyVer", this.DeviceStrategyVer);
            this.SetParamSimple(map, prefix + "NGNStrategyVer", this.NGNStrategyVer);
            this.SetParamSimple(map, prefix + "IOAUserName", this.IOAUserName);
            this.SetParamSimple(map, prefix + "DeviceNewStrategyVer", this.DeviceNewStrategyVer);
            this.SetParamSimple(map, prefix + "NGNNewStrategyVer", this.NGNNewStrategyVer);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "BaseBoardSn", this.BaseBoardSn);
            this.SetParamSimple(map, prefix + "AccountUsers", this.AccountUsers);
            this.SetParamSimple(map, prefix + "IdentityStrategyVer", this.IdentityStrategyVer);
            this.SetParamSimple(map, prefix + "IdentityNewStrategyVer", this.IdentityNewStrategyVer);
            this.SetParamSimple(map, prefix + "AccountGroupName", this.AccountGroupName);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "AccountGroupId", this.AccountGroupId);
            this.SetParamSimple(map, prefix + "RemarkName", this.RemarkName);
        }
    }
}

