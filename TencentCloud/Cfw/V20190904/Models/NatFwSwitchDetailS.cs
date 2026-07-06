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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NatFwSwitchDetailS : AbstractModel
    {
        
        /// <summary>
        /// <p>NAT实例ID</p>
        /// </summary>
        [JsonProperty("InsObj")]
        public string InsObj{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("ObjName")]
        public string ObjName{ get; set; }

        /// <summary>
        /// <p>防火墙类型</p>
        /// </summary>
        [JsonProperty("FwType")]
        public string FwType{ get; set; }

        /// <summary>
        /// <p>资产类型，nat-VPC内防护，nat_ccn-CCN集群模式</p>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// <p>地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>开关接入模式，1-自动接入，2-手动接入</p>
        /// </summary>
        [JsonProperty("SwitchMode")]
        public long? SwitchMode{ get; set; }

        /// <summary>
        /// <p>引流路由方法，0-多路由表，1-策略路由</p>
        /// </summary>
        [JsonProperty("RoutingMode")]
        public long? RoutingMode{ get; set; }

        /// <summary>
        /// <p>开关状态，0-未开启，1-已开启，2-开启中，3-关闭中</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>ip版本，0：ipv4；1：ipv6</p>
        /// </summary>
        [JsonProperty("IpVersion")]
        public long? IpVersion{ get; set; }

        /// <summary>
        /// <p>是否非集群模式，0-集群模式，1-非集群模式</p>
        /// </summary>
        [JsonProperty("NonCluster")]
        public long? NonCluster{ get; set; }

        /// <summary>
        /// <p>入侵防御动作</p>
        /// </summary>
        [JsonProperty("IpsAction")]
        public long? IpsAction{ get; set; }

        /// <summary>
        /// <p>流量监控开关</p>
        /// </summary>
        [JsonProperty("TransEnable")]
        public long? TransEnable{ get; set; }

        /// <summary>
        /// <p>Bypass状态，0-关闭，1-开启</p>
        /// </summary>
        [JsonProperty("Bypass")]
        public long? Bypass{ get; set; }

        /// <summary>
        /// <p>关联ID，nat_ccn资产类型时为云联网实例ID, nat资产类型时为空</p>
        /// </summary>
        [JsonProperty("AttachId")]
        public string AttachId{ get; set; }

        /// <summary>
        /// <p>关联ID的实例名称，nat_ccn资产类型时为云联网名称</p>
        /// </summary>
        [JsonProperty("AttachName")]
        public string AttachName{ get; set; }

        /// <summary>
        /// <p>NAT防火墙所在VPC ID</p>
        /// </summary>
        [JsonProperty("NatVpcId")]
        public string NatVpcId{ get; set; }

        /// <summary>
        /// <p>NAT防火墙所在VPC的VPC名称</p>
        /// </summary>
        [JsonProperty("NatVpcName")]
        public string NatVpcName{ get; set; }

        /// <summary>
        /// <p>CCN关联实例列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttachIns")]
        public AttachInsInfo[] AttachIns{ get; set; }

        /// <summary>
        /// <p>终端节点列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Endpoints")]
        public EndpointInfo[] Endpoints{ get; set; }

        /// <summary>
        /// <p>防火墙开关操作时的进度状态：</p><p>// 开启 — 自动模式（3步）<br>&quot;AUTO_OPEN_ORCHESTRATING&quot;      // 步骤1: 预编排策略路由<br>&quot;AUTO_OPEN_CREATING_RESOURCES&quot; // 步骤2: 创建引流网络和资源<br>&quot;AUTO_OPEN_PUSHING_ROUTES&quot;     // 步骤3: 创建策略路由</p><p>// 开启 — 手动模式（1步）<br>&quot;MANUAL_OPEN_CREATING_RESOURCES&quot; // 步骤1: 创建引流网络和资源</p><p>// 关闭 — 自动模式（2步）<br>&quot;AUTO_CLOSE_DELETING_ROUTES&quot;    // 步骤1: 删除策略路由<br>&quot;AUTO_CLOSE_DELETING_RESOURCES&quot; // 步骤2: 删除引流网络和资源<br>// 关闭 — 手动模式（1步）<br>&quot;MANUAL_CLOSE_DELETING_RESOURCES&quot; // 步骤1: 删除引流网络和资源</p><p>// 修改 — 自动模式（3步）<br>&quot;AUTO_MODIFY_ORCHESTRATING&quot;   // 步骤1: 预编排策略路由<br>&quot;AUTO_MODIFY_DELETING_ROUTES&quot; // 步骤2: 删除旧策略路由<br>&quot;AUTO_MODIFY_PUSHING_ROUTES&quot;  // 步骤3: 创建新策略路由</p><p>// 修改 — 手动模式（1步，仅 VPC 防火墙存在手动模式修改）<br>&quot;MANUAL_MODIFY_UPDATING_RESOURCES&quot; // 步骤1: 更新引流网络和资源</p>
        /// </summary>
        [JsonProperty("Progress")]
        public string Progress{ get; set; }

        /// <summary>
        /// <p>预接入检查结果</p>
        /// </summary>
        [JsonProperty("CheckResult")]
        public ClusterFwPreAccessCheckResult CheckResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InsObj", this.InsObj);
            this.SetParamSimple(map, prefix + "ObjName", this.ObjName);
            this.SetParamSimple(map, prefix + "FwType", this.FwType);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "SwitchMode", this.SwitchMode);
            this.SetParamSimple(map, prefix + "RoutingMode", this.RoutingMode);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
            this.SetParamSimple(map, prefix + "NonCluster", this.NonCluster);
            this.SetParamSimple(map, prefix + "IpsAction", this.IpsAction);
            this.SetParamSimple(map, prefix + "TransEnable", this.TransEnable);
            this.SetParamSimple(map, prefix + "Bypass", this.Bypass);
            this.SetParamSimple(map, prefix + "AttachId", this.AttachId);
            this.SetParamSimple(map, prefix + "AttachName", this.AttachName);
            this.SetParamSimple(map, prefix + "NatVpcId", this.NatVpcId);
            this.SetParamSimple(map, prefix + "NatVpcName", this.NatVpcName);
            this.SetParamArrayObj(map, prefix + "AttachIns.", this.AttachIns);
            this.SetParamArrayObj(map, prefix + "Endpoints.", this.Endpoints);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamObj(map, prefix + "CheckResult.", this.CheckResult);
        }
    }
}

