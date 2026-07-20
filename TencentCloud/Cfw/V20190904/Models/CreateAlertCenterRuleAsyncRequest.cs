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
        /// <p>处置时间<br>1  1天<br>7   7天<br>-2 永久</p>
        /// </summary>
        [JsonProperty("HandleTime")]
        public long? HandleTime{ get; set; }

        /// <summary>
        /// <p>处置类型<br>当HandleIdList 不为空时：1封禁 2放通<br>当HandleIpList 不为空时：3放通 4封禁</p>
        /// </summary>
        [JsonProperty("HandleType")]
        public long? HandleType{ get; set; }

        /// <summary>
        /// <p>当前日志方向： 0 出向 1 入向</p>
        /// </summary>
        [JsonProperty("AlertDirection")]
        public long? AlertDirection{ get; set; }

        /// <summary>
        /// <p>处置方向： 0出向 1入向 0,1出入向 3内网</p>
        /// </summary>
        [JsonProperty("HandleDirection")]
        public string HandleDirection{ get; set; }

        /// <summary>
        /// <p>AI操作来源</p><p>枚举值：</p><ul><li>console： 控制台来源值</li><li>wechat： 微信</li></ul>
        /// </summary>
        [JsonProperty("CfwAiAgentOperationSource")]
        public string CfwAiAgentOperationSource{ get; set; }

        /// <summary>
        /// <p>处置对象,ID列表，  IdLists,IpList,EventIdList三选一</p>
        /// </summary>
        [JsonProperty("HandleIdList")]
        public string[] HandleIdList{ get; set; }

        /// <summary>
        /// <p>处置对象,IP列表，  IdLists,IpList,EventIdList三选一</p>
        /// </summary>
        [JsonProperty("HandleIpList")]
        public string[] HandleIpList{ get; set; }

        /// <summary>
        /// <p>处置描述</p>
        /// </summary>
        [JsonProperty("HandleComment")]
        public string HandleComment{ get; set; }

        /// <summary>
        /// <p>放通原因:<br>0默认 1重复 2误报 3紧急放通</p>
        /// </summary>
        [JsonProperty("IgnoreReason")]
        public long? IgnoreReason{ get; set; }

        /// <summary>
        /// <p>封禁域名-保留字段</p>
        /// </summary>
        [JsonProperty("BlockDomain")]
        public string BlockDomain{ get; set; }

        /// <summary>
        /// <p>处置对象,事件ID列表，  IdLists,IpList,EventIdList三选一</p>
        /// </summary>
        [JsonProperty("HandleEventIdList")]
        public string[] HandleEventIdList{ get; set; }

        /// <summary>
        /// <p>加白IP列表 隔离时放通的ip列表</p>
        /// </summary>
        [JsonProperty("WhiteIpList")]
        public string[] WhiteIpList{ get; set; }

        /// <summary>
        /// <p>隔离类型 1 互联网入站 2 互联网出站 4 内网访问</p>
        /// </summary>
        [JsonProperty("IsolateType")]
        public long?[] IsolateType{ get; set; }

        /// <summary>
        /// <p>隔离资产列表</p>
        /// </summary>
        [JsonProperty("AssetIdList")]
        public string[] AssetIdList{ get; set; }

        /// <summary>
        /// <p>处置HandleIpList，属于的告警事件ID</p>
        /// </summary>
        [JsonProperty("TargetEventIdList")]
        public string[] TargetEventIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HandleTime", this.HandleTime);
            this.SetParamSimple(map, prefix + "HandleType", this.HandleType);
            this.SetParamSimple(map, prefix + "AlertDirection", this.AlertDirection);
            this.SetParamSimple(map, prefix + "HandleDirection", this.HandleDirection);
            this.SetParamSimple(map, prefix + "CfwAiAgentOperationSource", this.CfwAiAgentOperationSource);
            this.SetParamArraySimple(map, prefix + "HandleIdList.", this.HandleIdList);
            this.SetParamArraySimple(map, prefix + "HandleIpList.", this.HandleIpList);
            this.SetParamSimple(map, prefix + "HandleComment", this.HandleComment);
            this.SetParamSimple(map, prefix + "IgnoreReason", this.IgnoreReason);
            this.SetParamSimple(map, prefix + "BlockDomain", this.BlockDomain);
            this.SetParamArraySimple(map, prefix + "HandleEventIdList.", this.HandleEventIdList);
            this.SetParamArraySimple(map, prefix + "WhiteIpList.", this.WhiteIpList);
            this.SetParamArraySimple(map, prefix + "IsolateType.", this.IsolateType);
            this.SetParamArraySimple(map, prefix + "AssetIdList.", this.AssetIdList);
            this.SetParamArraySimple(map, prefix + "TargetEventIdList.", this.TargetEventIdList);
        }
    }
}

