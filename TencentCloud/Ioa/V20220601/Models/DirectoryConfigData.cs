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

namespace TencentCloud.Ioa.V20220601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DirectoryConfigData : AbstractModel
    {
        
        /// <summary>
        /// <p>企业目录 ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>目录对应身份源类型</p><p>枚举值：</p><ul><li>WeCom： 企业微信</li><li>Lark： 飞书</li><li>DingTalk： 钉钉</li><li>MicrosoftEntraID： 微软 AAD</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>企业目录名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>使用 JSON 字符串表示的配置信息</p>
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// <p>是否开启了定时同步</p>
        /// </summary>
        [JsonProperty("SyncEnable")]
        public bool? SyncEnable{ get; set; }

        /// <summary>
        /// <p>定时同步的策略</p><p>枚举值：</p><ul><li>4hours： 按创建时间开始的每 4 小时</li><li>daily： 每日</li><li>weekly： 每周</li></ul>
        /// </summary>
        [JsonProperty("SyncPolicy")]
        public string SyncPolicy{ get; set; }

        /// <summary>
        /// <p>JSON 字符串，针对不同类型的同步策略，提取对应不同的值</p>
        /// </summary>
        [JsonProperty("SyncPolicyParams")]
        public string SyncPolicyParams{ get; set; }

        /// <summary>
        /// <p>是否配置了同步创建认证配置</p>
        /// </summary>
        [JsonProperty("CreateAuthConfig")]
        public bool? CreateAuthConfig{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>对应 Config 的配置 ID</p>
        /// </summary>
        [JsonProperty("SourceId")]
        public string SourceId{ get; set; }

        /// <summary>
        /// <p>是否在登录页展示</p>
        /// </summary>
        [JsonProperty("DisplayOnLoginPage")]
        public bool? DisplayOnLoginPage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "SyncEnable", this.SyncEnable);
            this.SetParamSimple(map, prefix + "SyncPolicy", this.SyncPolicy);
            this.SetParamSimple(map, prefix + "SyncPolicyParams", this.SyncPolicyParams);
            this.SetParamSimple(map, prefix + "CreateAuthConfig", this.CreateAuthConfig);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SourceId", this.SourceId);
            this.SetParamSimple(map, prefix + "DisplayOnLoginPage", this.DisplayOnLoginPage);
        }
    }
}

