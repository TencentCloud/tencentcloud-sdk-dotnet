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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteIpAccessControlRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名，当操作对象为全局规则时，Domain参数应填写为"global"
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 删除的ip数组
        /// </summary>
        [JsonProperty("Items")]
        public string[] Items{ get; set; }

        /// <summary>
        /// 若IsId字段为True，则Items列表元素需为Id，否则为IP
        /// </summary>
        [JsonProperty("IsId")]
        public bool? IsId{ get; set; }

        /// <summary>
        /// 是否删除对应的域名下的所有黑/白IP名单，true表示全部删除，false表示只删除指定ip名单
        /// </summary>
        [JsonProperty("DeleteAll")]
        public bool? DeleteAll{ get; set; }

        /// <summary>
        /// 用于按数据来源删除黑白名单记录，非必填，默认为custom。 custom（自定义），用户在控制台手动添加的黑白名单规则 cc（CC 防护	），由 CC 防护模块自动添加的 IP 黑白名单 bot（Bot 防护），由 Bot 防护模块自动添加的 IP 黑白名单 batch（批量域名防护），批量域名维度添加的黑白名单规则
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// IP黑白名单类型，40为IP白名单，42为IP黑名单
        /// </summary>
        [JsonProperty("ActionType")]
        public ulong? ActionType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "Items.", this.Items);
            this.SetParamSimple(map, prefix + "IsId", this.IsId);
            this.SetParamSimple(map, prefix + "DeleteAll", this.DeleteAll);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
        }
    }
}

