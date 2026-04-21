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

    public class ClusterSwitchDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>实例对象可以是ccnid类型:ccn-ad21xuds形式;nat网关类型:nat-da12daxd形式;ip类型:1.1.1.1形式等</p>
        /// </summary>
        [JsonProperty("InsObj")]
        public string InsObj{ get; set; }

        /// <summary>
        /// <p>实例对象名称</p>
        /// </summary>
        [JsonProperty("ObjName")]
        public string ObjName{ get; set; }

        /// <summary>
        /// <p>防火墙类型，ew：vpc间防火墙；nat：nat防火墙；border：互联网边界防火墙</p>
        /// </summary>
        [JsonProperty("FwType")]
        public string FwType{ get; set; }

        /// <summary>
        /// <p>资产类型，ccn：ccn实例类型；nat：nat网关类型</p>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// <p>地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>开关状态<br>0 : 关闭<br>1 : 开启<br>2 : 开启中<br>3 : 关闭中<br>4 : 异常</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>开关接入模式，1：自动接入；2，手动接入，0：未选择</p>
        /// </summary>
        [JsonProperty("SwitchMode")]
        public ulong? SwitchMode{ get; set; }

        /// <summary>
        /// <p>实例对象是否处于非集群接入场景（主备模式）</p>
        /// </summary>
        [JsonProperty("NonCluster")]
        public long? NonCluster{ get; set; }

        /// <summary>
        /// <p>ip版本，0：ipv4；1：ipv6</p>
        /// </summary>
        [JsonProperty("IpVersion")]
        public long? IpVersion{ get; set; }

        /// <summary>
        /// <p>关联实例</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttachIns")]
        public AttachInsInfo[] AttachIns{ get; set; }

        /// <summary>
        /// <p>引流私有网络端点信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Endpoints")]
        public EndpointInfo[] Endpoints{ get; set; }

        /// <summary>
        /// <p>入侵防护模式,0:观察;1:拦截;2:严格;3:关闭</p>
        /// </summary>
        [JsonProperty("Idpsaction")]
        public ulong? Idpsaction{ get; set; }

        /// <summary>
        /// <p>//透明模式开关,0:未开启,1:已开启</p>
        /// </summary>
        [JsonProperty("TransEnable")]
        public ulong? TransEnable{ get; set; }

        /// <summary>
        /// <p>开关状态 0关闭 1开启</p>
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// <p>路由模式：0：多路由表，1：策略路由</p>
        /// </summary>
        [JsonProperty("RoutingMode")]
        public long? RoutingMode{ get; set; }

        /// <summary>
        /// <p>是否跨租户开关 1是 0不是</p>
        /// </summary>
        [JsonProperty("IsPeer")]
        public long? IsPeer{ get; set; }

        /// <summary>
        /// <p>跨租户appid</p>
        /// </summary>
        [JsonProperty("PeerAppid")]
        public string PeerAppid{ get; set; }

        /// <summary>
        /// <p>跨租户操作状态 1不允许操作 0可以</p>
        /// </summary>
        [JsonProperty("PeerStatus")]
        public long? PeerStatus{ get; set; }

        /// <summary>
        /// <p>Bypass状态</p>
        /// </summary>
        [JsonProperty("Bypass")]
        public long? Bypass{ get; set; }

        /// <summary>
        /// <p>防火墙开关操作时的进度状态：</p><p>// 开启 — 自动模式（3步）<br>&quot;AUTO_OPEN_ORCHESTRATING&quot; // 步骤1: 预编排策略路由<br>&quot;AUTO_OPEN_CREATING_RESOURCES&quot; // 步骤2: 创建引流网络和资源<br>&quot;AUTO_OPEN_PUSHING_ROUTES&quot; // 步骤3: 创建策略路由</p><p>// 开启 — 手动模式（1步）<br>&quot;MANUAL_OPEN_CREATING_RESOURCES&quot; // 步骤1: 创建引流网络和资源</p><p>// 关闭 — 自动模式（2步）<br>&quot;AUTO_CLOSE_DELETING_ROUTES&quot; // 步骤1: 删除策略路由<br>&quot;AUTO_CLOSE_DELETING_RESOURCES&quot; // 步骤2: 删除引流网络和资源<br>// 关闭 — 手动模式（1步）<br>&quot;MANUAL_CLOSE_DELETING_RESOURCES&quot; // 步骤1: 删除引流网络和资源</p><p>// 修改 — 自动模式（3步）<br>&quot;AUTO_MODIFY_ORCHESTRATING&quot; // 步骤1: 预编排策略路由<br>&quot;AUTO_MODIFY_DELETING_ROUTES&quot; // 步骤2: 删除旧策略路由<br>&quot;AUTO_MODIFY_PUSHING_ROUTES&quot; // 步骤3: 创建新策略路由</p><p>// 修改 — 手动模式（1步，仅 VPC 防火墙存在手动模式修改）<br>&quot;MANUAL_MODIFY_UPDATING_RESOURCES&quot; // 步骤1: 更新引流网络和资源</p>
        /// </summary>
        [JsonProperty("Progress")]
        public string Progress{ get; set; }


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
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SwitchMode", this.SwitchMode);
            this.SetParamSimple(map, prefix + "NonCluster", this.NonCluster);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
            this.SetParamArrayObj(map, prefix + "AttachIns.", this.AttachIns);
            this.SetParamArrayObj(map, prefix + "Endpoints.", this.Endpoints);
            this.SetParamSimple(map, prefix + "Idpsaction", this.Idpsaction);
            this.SetParamSimple(map, prefix + "TransEnable", this.TransEnable);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "RoutingMode", this.RoutingMode);
            this.SetParamSimple(map, prefix + "IsPeer", this.IsPeer);
            this.SetParamSimple(map, prefix + "PeerAppid", this.PeerAppid);
            this.SetParamSimple(map, prefix + "PeerStatus", this.PeerStatus);
            this.SetParamSimple(map, prefix + "Bypass", this.Bypass);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
        }
    }
}

