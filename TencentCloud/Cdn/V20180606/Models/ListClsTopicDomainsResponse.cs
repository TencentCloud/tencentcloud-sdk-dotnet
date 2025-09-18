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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListClsTopicDomainsResponse : AbstractModel
    {
        
        /// <summary>
        /// 开发者ID
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// 日志集ID
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// 日志主题ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 域名区域配置，其中可能含有已删除的域名，如果要再传回ManageClsTopicDomains接口，需要结合ListCdnDomains接口排除掉已删除的域名
        /// </summary>
        [JsonProperty("DomainAreaConfigs")]
        public DomainAreaConfig[] DomainAreaConfigs{ get; set; }

        /// <summary>
        /// 日志主题名称
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// 日志主题最近更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 是否继承域名标签
        /// </summary>
        [JsonProperty("InheritDomainTags")]
        public bool? InheritDomainTags{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamArrayObj(map, prefix + "DomainAreaConfigs.", this.DomainAreaConfigs);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "InheritDomainTags", this.InheritDomainTags);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

