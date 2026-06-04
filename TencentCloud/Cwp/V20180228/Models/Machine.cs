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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Machine : AbstractModel
    {
        
        /// <summary>
        /// <p>主机名称。</p>
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// <p>主机系统。</p>
        /// </summary>
        [JsonProperty("MachineOs")]
        public string MachineOs{ get; set; }

        /// <summary>
        /// <p>主机状态。 <li>OFFLINE: 离线 </li> <li>ONLINE: 在线</li> <li>SHUTDOWN: 已关机</li> <li>UNINSTALLED: 未防护</li></p>
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// <p>ONLINE 防护中; OFFLINE 已离线;UNINStALLED 未安装</p>
        /// </summary>
        [JsonProperty("AgentStatus")]
        public string AgentStatus{ get; set; }

        /// <summary>
        /// <p>RUNNING 运行中; STOPED 已关机; EXPIRED 待回收</p>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// <p>主机安全Uuid，若客户端长时间不在线将返回空字符。</p>
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// <p>CVM或BM机器唯一Uuid。</p>
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// <p>漏洞数。</p>
        /// </summary>
        [JsonProperty("VulNum")]
        public long? VulNum{ get; set; }

        /// <summary>
        /// <p>主机IP。</p>
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// <p>是否是专业版。</p><li>true： 是</li><li>false：否</li>
        /// </summary>
        [JsonProperty("IsProVersion")]
        public bool? IsProVersion{ get; set; }

        /// <summary>
        /// <p>主机外网IP。</p>
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// <p>主机状态。</p><li>POSTPAY: 表示后付费，即按量计费  </li><li>PREPAY: 表示预付费，即包年包月</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>木马数。</p>
        /// </summary>
        [JsonProperty("MalwareNum")]
        public long? MalwareNum{ get; set; }

        /// <summary>
        /// <p>标签信息</p>
        /// </summary>
        [JsonProperty("Tag")]
        public MachineTag[] Tag{ get; set; }

        /// <summary>
        /// <p>基线风险数。</p>
        /// </summary>
        [JsonProperty("BaselineNum")]
        public long? BaselineNum{ get; set; }

        /// <summary>
        /// <p>网络风险数。</p>
        /// </summary>
        [JsonProperty("CyberAttackNum")]
        public long? CyberAttackNum{ get; set; }

        /// <summary>
        /// <p>风险状态。</p><li>SAFE：安全</li><li>RISK：风险</li><li>UNKNOWN：未知</li>
        /// </summary>
        [JsonProperty("SecurityStatus")]
        public string SecurityStatus{ get; set; }

        /// <summary>
        /// <p>入侵事件数</p>
        /// </summary>
        [JsonProperty("InvasionNum")]
        public long? InvasionNum{ get; set; }

        /// <summary>
        /// <p>地域信息</p>
        /// </summary>
        [JsonProperty("RegionInfo")]
        public RegionInfo RegionInfo{ get; set; }

        /// <summary>
        /// <p>实例状态 TERMINATED_PRO_VERSION 已销毁</p>
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// <p>防篡改 授权状态 1 授权 0 未授权</p>
        /// </summary>
        [JsonProperty("LicenseStatus")]
        public ulong? LicenseStatus{ get; set; }

        /// <summary>
        /// <p>项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>是否有资产扫描接口，0无，1有</p>
        /// </summary>
        [JsonProperty("HasAssetScan")]
        public ulong? HasAssetScan{ get; set; }

        /// <summary>
        /// <p>机器所属专区类型 CVM 云服务器, BM 黑石, ECM 边缘计算, LH 轻量应用服务器 ,Other 混合云专区</p>
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// <p>内核版本</p>
        /// </summary>
        [JsonProperty("KernelVersion")]
        public string KernelVersion{ get; set; }

        /// <summary>
        /// <p>防护版本：BASIC_VERSION 基础版， PRO_VERSION 专业版，Flagship 旗舰版，GENERAL_DISCOUNT 轻量版</p>
        /// </summary>
        [JsonProperty("ProtectType")]
        public string ProtectType{ get; set; }

        /// <summary>
        /// <p>云标签信息</p>
        /// </summary>
        [JsonProperty("CloudTags")]
        public Tags[] CloudTags{ get; set; }

        /// <summary>
        /// <p>是否15天内新增的主机 0：非15天内新增的主机，1：15天内增加的主机</p>
        /// </summary>
        [JsonProperty("IsAddedOnTheFifteen")]
        public ulong? IsAddedOnTheFifteen{ get; set; }

        /// <summary>
        /// <p>主机ip列表</p>
        /// </summary>
        [JsonProperty("IpList")]
        public string IpList{ get; set; }

        /// <summary>
        /// <p>所属网络</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>附加信息</p>
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }

        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>备注信息</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>主机安全agent版本</p>
        /// </summary>
        [JsonProperty("AgentVersion")]
        public string AgentVersion{ get; set; }

        /// <summary>
        /// <p>机器对应APPID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>安全中心付费版本</p>
        /// </summary>
        [JsonProperty("CSIPProtectType")]
        public string CSIPProtectType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineOs", this.MachineOs);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "AgentStatus", this.AgentStatus);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "VulNum", this.VulNum);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "IsProVersion", this.IsProVersion);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "MalwareNum", this.MalwareNum);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "BaselineNum", this.BaselineNum);
            this.SetParamSimple(map, prefix + "CyberAttackNum", this.CyberAttackNum);
            this.SetParamSimple(map, prefix + "SecurityStatus", this.SecurityStatus);
            this.SetParamSimple(map, prefix + "InvasionNum", this.InvasionNum);
            this.SetParamObj(map, prefix + "RegionInfo.", this.RegionInfo);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "LicenseStatus", this.LicenseStatus);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "HasAssetScan", this.HasAssetScan);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "KernelVersion", this.KernelVersion);
            this.SetParamSimple(map, prefix + "ProtectType", this.ProtectType);
            this.SetParamArrayObj(map, prefix + "CloudTags.", this.CloudTags);
            this.SetParamSimple(map, prefix + "IsAddedOnTheFifteen", this.IsAddedOnTheFifteen);
            this.SetParamSimple(map, prefix + "IpList", this.IpList);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "AgentVersion", this.AgentVersion);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "CSIPProtectType", this.CSIPProtectType);
        }
    }
}

