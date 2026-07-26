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

    public class CreateAlertCenterRuleAsyncRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>必填的告警方向：0 出向，1 入向，3 内网。用于 HandleIpList 中 IP 目标的处置方向；其它目标也必须传上述有效值。从 DescribeCfwAlerts 复制方向时，将 alerts[].direction 的 outbound、inbound、lateral 分别转换为 JSON 整数 0、1、3。</p>
        /// </summary>
        [JsonProperty("AlertDirection")]
        public long? AlertDirection{ get; set; }

        /// <summary>
        /// <p>必填的处置生效方向。支持空字符串、0（互联网出向）、1（互联网入向）、0,1/1,0（互联网双向）、3（内网访问）、5（内网访问源）、6（内网访问目的）及 5,6/6,5。空字符串表示按告警原方向处置；同一 IP 的已有规则方向会与本次方向合并。</p>
        /// </summary>
        [JsonProperty("HandleDirection")]
        public string HandleDirection{ get; set; }

        /// <summary>
        /// <p>处置有效期：1 表示 1 天，7 表示 7 天，-2 表示永久。</p>
        /// </summary>
        [JsonProperty("HandleTime")]
        public long? HandleTime{ get; set; }

        /// <summary>
        /// <p>必填的处置类型：1 按 HandleIdList 或 HandleEventIdList 封禁，2 按 HandleIdList、HandleEventIdList 或 BlockDomain 加白，3 按 HandleIpList 加白 IP，4 按 HandleIpList 封禁 IP，5 将 HandleIdList 或 HandleEventIdList 对应的安全基线告警地址加入指定方向的安全基线列表，8 按 HandleEventIdList 关联资产或 AssetIdList 新增隔离。五类目标至少提供一类；HandleType=8 未能从事件解析出资产时必须提供 AssetIdList。IsolateType 和 WhiteIpList 仅用于类型 8。</p>
        /// </summary>
        [JsonProperty("HandleType")]
        public long? HandleType{ get; set; }

        /// <summary>
        /// <p>资产隔离目标列表，可省略；仅 HandleType=8 使用。直接按资产隔离时，调用 DescribeCfwAssets，传 AssetType=host 和目标 InstanceId，解析返回结果；仅在唯一 assets[].instance_id 与目标完全相等时将其写入本字段，不使用资产名称。</p>
        /// </summary>
        [JsonProperty("AssetIdList")]
        public string[] AssetIdList{ get; set; }

        /// <summary>
        /// <p>域名加白目标，传合法域名；HandleType 必须为 2，并同时传 TargetEventIdList。</p>
        /// </summary>
        [JsonProperty("BlockDomain")]
        public string BlockDomain{ get; set; }

        /// <summary>
        /// <p>AI操作来源</p><p>枚举值：</p><ul><li>console： 控制台来源值</li><li>wechat： 微信</li></ul>。
        /// </summary>
        [JsonProperty("CfwAiAgentOperationSource")]
        public string CfwAiAgentOperationSource{ get; set; }

        /// <summary>
        /// <p>可选处置说明，最多 50 个 Unicode 字符。</p>
        /// </summary>
        [JsonProperty("HandleComment")]
        public string HandleComment{ get; set; }

        /// <summary>
        /// <p>告警事件 ID 列表，可省略。通过 DescribeCfwAlerts 获取，返回 alerts[].current_event_id 时使用该值，否则使用 alerts[].event_id。事件对应的告警日志会与 HandleIdList 合并后参与处置。</p>
        /// </summary>
        [JsonProperty("HandleEventIdList")]
        public string[] HandleEventIdList{ get; set; }

        /// <summary>
        /// <p>告警日志 ID 列表，可省略；可与 HandleEventIdList 同时使用。调用 DescribeLogs，传 Index=rule_threatinfo 和目标日志的查询条件，解析返回结果，仅使用目标记录的 log_id。告警事件 ID 使用 HandleEventIdList。</p>
        /// </summary>
        [JsonProperty("HandleIdList")]
        public string[] HandleIdList{ get; set; }

        /// <summary>
        /// <p>IP 处置目标列表，每项必须是有效 IP 地址。HandleType=3 表示加白，HandleType=4 表示封禁；可使用 DescribeCfwAlerts 返回的 alerts[].src_ip_list 或 alerts[].dst_ip_list。</p>
        /// </summary>
        [JsonProperty("HandleIpList")]
        public string[] HandleIpList{ get; set; }

        /// <summary>
        /// <p>处置原因，可省略：0 未指定原因，1 重复，2 误报，3 紧急加白；主要用于加白记录。</p>
        /// </summary>
        [JsonProperty("IgnoreReason")]
        public long? IgnoreReason{ get; set; }

        /// <summary>
        /// <p>隔离范围数组，可省略：1 互联网入站，2 互联网出站，4 内网访问。仅 HandleType=8 使用；组合多个范围时传入对应值且不要重复，重复值会改变最终隔离范围。</p>
        /// </summary>
        [JsonProperty("IsolateType")]
        public long?[] IsolateType{ get; set; }

        /// <summary>
        /// <p>处置关联的来源事件 ID 列表，仅用于 HandleIpList 或 BlockDomain。BlockDomain 处置时必填，HandleIpList 处置时可省略；通过 DescribeCfwAlerts 获取，返回 alerts[].current_event_id 时使用该值，否则使用 alerts[].event_id。</p>
        /// </summary>
        [JsonProperty("TargetEventIdList")]
        public string[] TargetEventIdList{ get; set; }

        /// <summary>
        /// <p>隔离后仍允许通信的 IPv4 地址列表，仅 HandleType=8 使用。可省略或传空数组；非空时每项必须是有效 IPv4 地址。</p>
        /// </summary>
        [JsonProperty("WhiteIpList")]
        public string[] WhiteIpList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlertDirection", this.AlertDirection);
            this.SetParamSimple(map, prefix + "HandleDirection", this.HandleDirection);
            this.SetParamSimple(map, prefix + "HandleTime", this.HandleTime);
            this.SetParamSimple(map, prefix + "HandleType", this.HandleType);
            this.SetParamArraySimple(map, prefix + "AssetIdList.", this.AssetIdList);
            this.SetParamSimple(map, prefix + "BlockDomain", this.BlockDomain);
            this.SetParamSimple(map, prefix + "CfwAiAgentOperationSource", this.CfwAiAgentOperationSource);
            this.SetParamSimple(map, prefix + "HandleComment", this.HandleComment);
            this.SetParamArraySimple(map, prefix + "HandleEventIdList.", this.HandleEventIdList);
            this.SetParamArraySimple(map, prefix + "HandleIdList.", this.HandleIdList);
            this.SetParamArraySimple(map, prefix + "HandleIpList.", this.HandleIpList);
            this.SetParamSimple(map, prefix + "IgnoreReason", this.IgnoreReason);
            this.SetParamArraySimple(map, prefix + "IsolateType.", this.IsolateType);
            this.SetParamArraySimple(map, prefix + "TargetEventIdList.", this.TargetEventIdList);
            this.SetParamArraySimple(map, prefix + "WhiteIpList.", this.WhiteIpList);
        }
    }
}

