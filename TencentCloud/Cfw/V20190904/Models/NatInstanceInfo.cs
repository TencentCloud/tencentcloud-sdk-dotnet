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

    public class NatInstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>nat实例id</p>
        /// </summary>
        [JsonProperty("NatinsId")]
        public string NatinsId{ get; set; }

        /// <summary>
        /// <p>nat实例名称</p>
        /// </summary>
        [JsonProperty("NatinsName")]
        public string NatinsName{ get; set; }

        /// <summary>
        /// <p>实例所在地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>0: 新增模式，1:接入模式</p>
        /// </summary>
        [JsonProperty("FwMode")]
        public long? FwMode{ get; set; }

        /// <summary>
        /// <p>实例带宽大小 Mbps</p>
        /// </summary>
        [JsonProperty("BandWidth")]
        public long? BandWidth{ get; set; }

        /// <summary>
        /// <p>入向带宽峰值 bps</p>
        /// </summary>
        [JsonProperty("InFlowMax")]
        public long? InFlowMax{ get; set; }

        /// <summary>
        /// <p>出向带宽峰值 bps</p>
        /// </summary>
        [JsonProperty("OutFlowMax")]
        public ulong? OutFlowMax{ get; set; }

        /// <summary>
        /// <p>地域中文信息</p>
        /// </summary>
        [JsonProperty("RegionZh")]
        public string RegionZh{ get; set; }

        /// <summary>
        /// <p>公网ip数组</p>
        /// </summary>
        [JsonProperty("EipAddress")]
        public string[] EipAddress{ get; set; }

        /// <summary>
        /// <p>内外使用ip数组</p>
        /// </summary>
        [JsonProperty("VpcIp")]
        public string[] VpcIp{ get; set; }

        /// <summary>
        /// <p>实例关联子网数组</p>
        /// </summary>
        [JsonProperty("Subnets")]
        public string[] Subnets{ get; set; }

        /// <summary>
        /// <p>0 :正常 1：正在初始化</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>地域区域信息</p>
        /// </summary>
        [JsonProperty("RegionDetail")]
        public string RegionDetail{ get; set; }

        /// <summary>
        /// <p>实例所在可用区</p>
        /// </summary>
        [JsonProperty("ZoneZh")]
        public string ZoneZh{ get; set; }

        /// <summary>
        /// <p>实例所在可用区</p>
        /// </summary>
        [JsonProperty("ZoneZhBak")]
        public string ZoneZhBak{ get; set; }

        /// <summary>
        /// <p>已使用规则数</p>
        /// </summary>
        [JsonProperty("RuleUsed")]
        public ulong? RuleUsed{ get; set; }

        /// <summary>
        /// <p>实例的规则限制最大规格数</p>
        /// </summary>
        [JsonProperty("RuleMax")]
        public ulong? RuleMax{ get; set; }

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
        /// <p>是的需要升级引擎 支持 nat拨测 1需要 0不需要</p>
        /// </summary>
        [JsonProperty("NeedProbeEngineUpdate")]
        public long? NeedProbeEngineUpdate{ get; set; }

        /// <summary>
        /// <p>引擎运行模式，Normal:正常, OnlyRoute:透明模式</p>
        /// </summary>
        [JsonProperty("TrafficMode")]
        public string TrafficMode{ get; set; }

        /// <summary>
        /// <p>实例主所在可用区</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>实例备所在可用区</p>
        /// </summary>
        [JsonProperty("ZoneBak")]
        public string ZoneBak{ get; set; }

        /// <summary>
        /// <p>引擎预约升级时间</p>
        /// </summary>
        [JsonProperty("ReserveTime")]
        public string ReserveTime{ get; set; }

        /// <summary>
        /// <p>引擎预约升级版本</p>
        /// </summary>
        [JsonProperty("ReserveVersion")]
        public string ReserveVersion{ get; set; }

        /// <summary>
        /// <p>引擎预约升级版本状态 stable:稳定版；previewed:预览版</p>
        /// </summary>
        [JsonProperty("ReserveVersionState")]
        public string ReserveVersionState{ get; set; }

        /// <summary>
        /// <p>弹性开关<br>1 打开<br>0 关闭</p>
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
        /// <p>按流量弹性开关</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("ElasticTrafficSwitch")]
        public long? ElasticTrafficSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NatinsId", this.NatinsId);
            this.SetParamSimple(map, prefix + "NatinsName", this.NatinsName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "FwMode", this.FwMode);
            this.SetParamSimple(map, prefix + "BandWidth", this.BandWidth);
            this.SetParamSimple(map, prefix + "InFlowMax", this.InFlowMax);
            this.SetParamSimple(map, prefix + "OutFlowMax", this.OutFlowMax);
            this.SetParamSimple(map, prefix + "RegionZh", this.RegionZh);
            this.SetParamArraySimple(map, prefix + "EipAddress.", this.EipAddress);
            this.SetParamArraySimple(map, prefix + "VpcIp.", this.VpcIp);
            this.SetParamArraySimple(map, prefix + "Subnets.", this.Subnets);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RegionDetail", this.RegionDetail);
            this.SetParamSimple(map, prefix + "ZoneZh", this.ZoneZh);
            this.SetParamSimple(map, prefix + "ZoneZhBak", this.ZoneZhBak);
            this.SetParamSimple(map, prefix + "RuleUsed", this.RuleUsed);
            this.SetParamSimple(map, prefix + "RuleMax", this.RuleMax);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "UpdateEnable", this.UpdateEnable);
            this.SetParamSimple(map, prefix + "NeedProbeEngineUpdate", this.NeedProbeEngineUpdate);
            this.SetParamSimple(map, prefix + "TrafficMode", this.TrafficMode);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ZoneBak", this.ZoneBak);
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

