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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FwGroupSwitchShow : AbstractModel
    {
        
        /// <summary>
        /// 防火墙开关ID
        /// </summary>
        [JsonProperty("SwitchId")]
        public string SwitchId{ get; set; }

        /// <summary>
        /// 防火墙开关NAME
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SwitchName")]
        public string SwitchName{ get; set; }

        /// <summary>
        /// 互通模式
        /// </summary>
        [JsonProperty("SwitchMode")]
        public long? SwitchMode{ get; set; }

        /// <summary>
        /// 开关边连接类型 0：对等连接， 1：云连网
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConnectType")]
        public long? ConnectType{ get; set; }

        /// <summary>
        /// 连接ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConnectId")]
        public string ConnectId{ get; set; }

        /// <summary>
        /// 连接名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConnectName")]
        public string ConnectName{ get; set; }

        /// <summary>
        /// 源实例信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SrcInstancesInfo")]
        public NetInstancesInfo[] SrcInstancesInfo{ get; set; }

        /// <summary>
        /// 目的实例信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DstInstancesInfo")]
        public NetInstancesInfo[] DstInstancesInfo{ get; set; }

        /// <summary>
        /// 防火墙(组)数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FwGroupId")]
        public string FwGroupId{ get; set; }

        /// <summary>
        /// 防火墙(组)名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FwGroupName")]
        public string FwGroupName{ get; set; }

        /// <summary>
        /// 开关状态 0：关 ， 1：开
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// 开关的状态 0：正常， 1：转换中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 0-非sase实例，忽略，1-未绑定状态，2-已绑定
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttachWithEdge")]
        public long? AttachWithEdge{ get; set; }

        /// <summary>
        /// 对等防火墙和开关状态 0：正常， 1：对等未创建防火墙，2：对等已创建防火墙，未打开开关
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CrossEdgeStatus")]
        public long? CrossEdgeStatus{ get; set; }

        /// <summary>
        /// 网络经过VPC防火墙CVM所在地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FwInsRegion")]
        public string[] FwInsRegion{ get; set; }

        /// <summary>
        /// 0 观察 1 拦截 2 严格 3 关闭
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IpsAction")]
        public long? IpsAction{ get; set; }

        /// <summary>
        /// 开关关联的防火墙实例列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FwInsLst")]
        public VpcFwInstanceShow[] FwInsLst{ get; set; }

        /// <summary>
        /// 开关是否处于bypass状态
        /// 0：正常状态
        /// 1：bypass状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BypassStatus")]
        public long? BypassStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SwitchId", this.SwitchId);
            this.SetParamSimple(map, prefix + "SwitchName", this.SwitchName);
            this.SetParamSimple(map, prefix + "SwitchMode", this.SwitchMode);
            this.SetParamSimple(map, prefix + "ConnectType", this.ConnectType);
            this.SetParamSimple(map, prefix + "ConnectId", this.ConnectId);
            this.SetParamSimple(map, prefix + "ConnectName", this.ConnectName);
            this.SetParamArrayObj(map, prefix + "SrcInstancesInfo.", this.SrcInstancesInfo);
            this.SetParamArrayObj(map, prefix + "DstInstancesInfo.", this.DstInstancesInfo);
            this.SetParamSimple(map, prefix + "FwGroupId", this.FwGroupId);
            this.SetParamSimple(map, prefix + "FwGroupName", this.FwGroupName);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AttachWithEdge", this.AttachWithEdge);
            this.SetParamSimple(map, prefix + "CrossEdgeStatus", this.CrossEdgeStatus);
            this.SetParamArraySimple(map, prefix + "FwInsRegion.", this.FwInsRegion);
            this.SetParamSimple(map, prefix + "IpsAction", this.IpsAction);
            this.SetParamArrayObj(map, prefix + "FwInsLst.", this.FwInsLst);
            this.SetParamSimple(map, prefix + "BypassStatus", this.BypassStatus);
        }
    }
}

