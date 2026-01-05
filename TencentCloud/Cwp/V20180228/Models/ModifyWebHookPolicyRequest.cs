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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyWebHookPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [JsonProperty("Events")]
        public WebHookEventKv[] Events{ get; set; }

        /// <summary>
        /// 主机范围
        /// </summary>
        [JsonProperty("HostLabels")]
        public WebHookHostLabel[] HostLabels{ get; set; }

        /// <summary>
        /// 接收人
        /// </summary>
        [JsonProperty("Receivers")]
        public WebHookReceiver[] Receivers{ get; set; }

        /// <summary>
        /// 格式 0text 1json
        /// </summary>
        [JsonProperty("Format")]
        public long? Format{ get; set; }

        /// <summary>
        /// 自定义透传字段
        /// </summary>
        [JsonProperty("CustomFields")]
        public WebHookCustomField[] CustomFields{ get; set; }

        /// <summary>
        /// 是否启用[1:禁用|0:启用]
        /// </summary>
        [JsonProperty("IsDisabled")]
        public long? IsDisabled{ get; set; }

        /// <summary>
        /// 主机列表
        /// </summary>
        [JsonProperty("Quuids")]
        public string[] Quuids{ get; set; }

        /// <summary>
        /// 需排除的机器列表	
        /// </summary>
        [JsonProperty("ExcludedQuuids")]
        public string[] ExcludedQuuids{ get; set; }

        /// <summary>
        /// 推送语言类型，中文zh，英文en
        /// </summary>
        [JsonProperty("MsgLanguage")]
        public string MsgLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "Events.", this.Events);
            this.SetParamArrayObj(map, prefix + "HostLabels.", this.HostLabels);
            this.SetParamArrayObj(map, prefix + "Receivers.", this.Receivers);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamArrayObj(map, prefix + "CustomFields.", this.CustomFields);
            this.SetParamSimple(map, prefix + "IsDisabled", this.IsDisabled);
            this.SetParamArraySimple(map, prefix + "Quuids.", this.Quuids);
            this.SetParamArraySimple(map, prefix + "ExcludedQuuids.", this.ExcludedQuuids);
            this.SetParamSimple(map, prefix + "MsgLanguage", this.MsgLanguage);
        }
    }
}

