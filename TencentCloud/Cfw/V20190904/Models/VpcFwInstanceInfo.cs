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

    public class VpcFwInstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>VPC防火墙实例名称</p>
        /// </summary>
        [JsonProperty("FwInsName")]
        public string FwInsName{ get; set; }

        /// <summary>
        /// <p>VPC防火墙实例ID</p>
        /// </summary>
        [JsonProperty("FwInsId")]
        public string FwInsId{ get; set; }

        /// <summary>
        /// <p>VPC防火墙实例模式 0: 旧VPC模式防火墙 1: CCN模式防火墙</p>
        /// </summary>
        [JsonProperty("FwMode")]
        public long? FwMode{ get; set; }

        /// <summary>
        /// <p>VPC防火墙接入网络实例个数</p>
        /// </summary>
        [JsonProperty("JoinInsNum")]
        public long? JoinInsNum{ get; set; }

        /// <summary>
        /// <p>VPC防火墙开关个数</p>
        /// </summary>
        [JsonProperty("FwSwitchNum")]
        public long? FwSwitchNum{ get; set; }

        /// <summary>
        /// <p>VPC防火墙状态 0:正常 ， 1：创建中 2: 变更中</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>VPC防火墙创建时间</p>
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// <p>VPC 相关云联网ID列表</p>
        /// </summary>
        [JsonProperty("CcnId")]
        public string[] CcnId{ get; set; }

        /// <summary>
        /// <p>VPC 相关云联网名称列表</p>
        /// </summary>
        [JsonProperty("CcnName")]
        public string[] CcnName{ get; set; }

        /// <summary>
        /// <p>VPC 相关对等连接ID列表</p>
        /// </summary>
        [JsonProperty("PeerConnectionId")]
        public string[] PeerConnectionId{ get; set; }

        /// <summary>
        /// <p>VPC 相关对等连接名称列表</p>
        /// </summary>
        [JsonProperty("PeerConnectionName")]
        public string[] PeerConnectionName{ get; set; }

        /// <summary>
        /// <p>VPC防火墙CVM的列表</p>
        /// </summary>
        [JsonProperty("FwCvmLst")]
        public VpcFwCvmInsInfo[] FwCvmLst{ get; set; }

        /// <summary>
        /// <p>VPC防火墙接入网络实例类型列表</p>
        /// </summary>
        [JsonProperty("JoinInsLst")]
        public VpcFwJoinInstanceType[] JoinInsLst{ get; set; }

        /// <summary>
        /// <p>防火墙网关信息</p>
        /// </summary>
        [JsonProperty("FwGateway")]
        public FwGateway[] FwGateway{ get; set; }

        /// <summary>
        /// <p>防火墙(组)ID</p>
        /// </summary>
        [JsonProperty("FwGroupId")]
        public string FwGroupId{ get; set; }

        /// <summary>
        /// <p>已使用规则数</p>
        /// </summary>
        [JsonProperty("RuleUsed")]
        public long? RuleUsed{ get; set; }

        /// <summary>
        /// <p>最大规则数</p>
        /// </summary>
        [JsonProperty("RuleMax")]
        public long? RuleMax{ get; set; }

        /// <summary>
        /// <p>防火墙实例带宽</p>
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// <p>用户VPC墙总带宽</p>
        /// </summary>
        [JsonProperty("UserVpcWidth")]
        public long? UserVpcWidth{ get; set; }

        /// <summary>
        /// <p>接入的vpc列表</p>
        /// </summary>
        [JsonProperty("JoinInsIdLst")]
        public string[] JoinInsIdLst{ get; set; }

        /// <summary>
        /// <p>内网间峰值带宽 (单位 bps )</p>
        /// </summary>
        [JsonProperty("FlowMax")]
        public long? FlowMax{ get; set; }

        /// <summary>
        /// <p>实例引擎版本</p>
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// <p>引擎是否可升级：0，不可升级；1，可升级</p>
        /// </summary>
        [JsonProperty("UpdateEnable")]
        public long? UpdateEnable{ get; set; }

        /// <summary>
        /// <p>引擎运行模式，Normal:正常, OnlyRoute:透明模式</p>
        /// </summary>
        [JsonProperty("TrafficMode")]
        public string TrafficMode{ get; set; }

        /// <summary>
        /// <p>引擎预约升级时间</p>
        /// </summary>
        [JsonProperty("ReserveTime")]
        public string ReserveTime{ get; set; }

        /// <summary>
        /// <p>预约引擎升级版本</p>
        /// </summary>
        [JsonProperty("ReserveVersion")]
        public string ReserveVersion{ get; set; }

        /// <summary>
        /// <p>引擎预约升级版本状态</p>
        /// </summary>
        [JsonProperty("ReserveVersionState")]
        public string ReserveVersionState{ get; set; }

        /// <summary>
        /// <p>弹性开关 1打开 0关闭</p>
        /// </summary>
        [JsonProperty("ElasticSwitch")]
        public long? ElasticSwitch{ get; set; }

        /// <summary>
        /// <p>弹性带宽，单位Mbps</p>
        /// </summary>
        [JsonProperty("ElasticBandwidth")]
        public long? ElasticBandwidth{ get; set; }

        /// <summary>
        /// <p>是否首次开通按量付费<br>1 是<br>0 不是</p>
        /// </summary>
        [JsonProperty("IsFirstAfterPay")]
        public long? IsFirstAfterPay{ get; set; }

        /// <summary>
        /// <p>按流量弹性开关</p><p>取值范围：[0, 1]</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("ElasticTrafficSwitch")]
        public long? ElasticTrafficSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FwInsName", this.FwInsName);
            this.SetParamSimple(map, prefix + "FwInsId", this.FwInsId);
            this.SetParamSimple(map, prefix + "FwMode", this.FwMode);
            this.SetParamSimple(map, prefix + "JoinInsNum", this.JoinInsNum);
            this.SetParamSimple(map, prefix + "FwSwitchNum", this.FwSwitchNum);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamArraySimple(map, prefix + "CcnId.", this.CcnId);
            this.SetParamArraySimple(map, prefix + "CcnName.", this.CcnName);
            this.SetParamArraySimple(map, prefix + "PeerConnectionId.", this.PeerConnectionId);
            this.SetParamArraySimple(map, prefix + "PeerConnectionName.", this.PeerConnectionName);
            this.SetParamArrayObj(map, prefix + "FwCvmLst.", this.FwCvmLst);
            this.SetParamArrayObj(map, prefix + "JoinInsLst.", this.JoinInsLst);
            this.SetParamArrayObj(map, prefix + "FwGateway.", this.FwGateway);
            this.SetParamSimple(map, prefix + "FwGroupId", this.FwGroupId);
            this.SetParamSimple(map, prefix + "RuleUsed", this.RuleUsed);
            this.SetParamSimple(map, prefix + "RuleMax", this.RuleMax);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "UserVpcWidth", this.UserVpcWidth);
            this.SetParamArraySimple(map, prefix + "JoinInsIdLst.", this.JoinInsIdLst);
            this.SetParamSimple(map, prefix + "FlowMax", this.FlowMax);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "UpdateEnable", this.UpdateEnable);
            this.SetParamSimple(map, prefix + "TrafficMode", this.TrafficMode);
            this.SetParamSimple(map, prefix + "ReserveTime", this.ReserveTime);
            this.SetParamSimple(map, prefix + "ReserveVersion", this.ReserveVersion);
            this.SetParamSimple(map, prefix + "ReserveVersionState", this.ReserveVersionState);
            this.SetParamSimple(map, prefix + "ElasticSwitch", this.ElasticSwitch);
            this.SetParamSimple(map, prefix + "ElasticBandwidth", this.ElasticBandwidth);
            this.SetParamSimple(map, prefix + "IsFirstAfterPay", this.IsFirstAfterPay);
            this.SetParamSimple(map, prefix + "ElasticTrafficSwitch", this.ElasticTrafficSwitch);
        }
    }
}

