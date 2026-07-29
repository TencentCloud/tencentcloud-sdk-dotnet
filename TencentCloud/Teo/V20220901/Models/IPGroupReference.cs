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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IPGroupReference : AbstractModel
    {
        
        /// <summary>
        /// <p>站点 ID。</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>实体类型。</p><p>枚举值：</p><ul><li>WebSec.ZonePolicy： 站点级防护策略</li><li>WebSec.HostPolicy： 域名级防护策略</li><li>WebSec.Template： 策略模板</li><li>DDoS.L4Proxy： 四层代理 DDoS 防护</li><li>DDoS.L3Transit： 三层代播 DDoS 防护</li></ul>
        /// </summary>
        [JsonProperty("EntityType")]
        public string EntityType{ get; set; }

        /// <summary>
        /// <p>实体标识，根据 EntityType 不同代表不同的含义：</p><ul><li>WebSec.ZonePolicy：站点 ID；</li><li>WebSec.HostPolicy：域名；</li><li>WebSec.Template：模板 ID；</li><li>DDoS.L4Proxy：实例 ID；</li><li>DDoS.L3Transit：实例 ID。</li></ul>
        /// </summary>
        [JsonProperty("EntityId")]
        public string EntityId{ get; set; }

        /// <summary>
        /// <p>实体标识，根据 EntityType 不同代表不同的含义：</p><ul><li>WebSec.ZonePolicy：空；</li><li>WebSec.HostPolicy：空；</li><li>WebSec.Template：模板名称；</li><li>DDoS.L4Proxy：空；</li><li>DDoS.L3Transit：空。</li></ul>
        /// </summary>
        [JsonProperty("EntityName")]
        public string EntityName{ get; set; }

        /// <summary>
        /// <p>子实体类型。</p><p>枚举值：</p><ul><li>WebSec.ExceptionRule： 防护例外规则</li><li>WebSec.BasicAccessRule： 基础访问管控</li><li>WebSec.PreciseMatchRule： 精确匹配规则</li><li>WebSec.RateLimitRule： 精准速率限制</li><li>WebSec.BotCustomRule： 高级 Bot 管理 - 自定义规则</li><li>DDoS.L4Proxy.IpAccessControl： 四层代理 DDoS 防护 - IP 黑白名单</li><li>DDoS.L3Transit.IpAccessControl： 三层代播 DDoS 防护 - IP 黑白名单</li></ul>
        /// </summary>
        [JsonProperty("SubEntityType")]
        public string SubEntityType{ get; set; }

        /// <summary>
        /// <p>子实体标识，根据 SubEntityType 不同代表不同的含义：</p><ul><li>WebSec.ExceptionRule：规则 ID；</li><li>WebSec.BasicAccessRule：规则 ID；</li><li>WebSec.PreciseMatchRule：规则 ID；</li><li>WebSec.RateLimitRule：规则 ID；</li><li>WebSec.BotCustomRule：规则 ID；</li><li>DDoS.L4Proxy.IpAccessControl：空；</li><li>DDoS.L3Transit.IpAccessControl：空。</li></ul><p>EntityType 与 SubEntityType 为对应关系，不同的 EntityType 支持不同的 SubEntityType。<br>WebSec.ZonePolicy，WebSec.HostPolicy 和 WebSec.Template 支持如下 SubEntityType：</p><ul><li>WebSec.ExceptionRule；</li><li>WebSec.BasicAccessRule；</li><li>WebSec.PreciseMatchRule；</li><li>WebSec.RateLimitRule；</li><li>WebSec.BotCustomRule。</li></ul>DDoS.L4Proxy 支持如下 SubEntityType：<ul><li>DDoS.L4Proxy.IpAccessControl；</li></ul>DDoS.L3Transit 支持如下 SubEntityType：<ul><li>DDoS.L3Transit.IpAccessControl。</li></ul>
        /// </summary>
        [JsonProperty("SubEntityId")]
        public string SubEntityId{ get; set; }

        /// <summary>
        /// <p>子实体名称，根据 SubEntityType 不同代表不同的含义：</p><ul><li>WebSec.ExceptionRule：规则名称；</li><li>WebSec.BasicAccessRule：规则名称；</li><li>WebSec.PreciseMatchRule：规则名称；</li><li>WebSec.RateLimitRule：规则名称；</li><li>WebSec.BotCustomRule：规则名称；</li><li>DDoS.L4Proxy.IpAccessControl：规则名称，block 表示黑名单，allow 表示白名单；</li><li>DDoS.L3Transit.IpAccessControl：规则名称，block 表示黑名单，allow 表示白名单。</li></ul>
        /// </summary>
        [JsonProperty("SubEntityName")]
        public string SubEntityName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "EntityType", this.EntityType);
            this.SetParamSimple(map, prefix + "EntityId", this.EntityId);
            this.SetParamSimple(map, prefix + "EntityName", this.EntityName);
            this.SetParamSimple(map, prefix + "SubEntityType", this.SubEntityType);
            this.SetParamSimple(map, prefix + "SubEntityId", this.SubEntityId);
            this.SetParamSimple(map, prefix + "SubEntityName", this.SubEntityName);
        }
    }
}

