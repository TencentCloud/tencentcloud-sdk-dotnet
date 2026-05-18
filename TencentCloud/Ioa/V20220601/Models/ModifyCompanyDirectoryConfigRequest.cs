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

    public class ModifyCompanyDirectoryConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>企业目录类型</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>企业目录名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>使用 JSON 字符串表示的配置信息</p><p>调用此接口前，需要先调用DescribeCompanyDirectoryConfig获取完整的配置，然后对里面需要更新的配置进行修改，请求的时候必须传完整配置，否则可能导致配置缺失出现错误。如果是脱敏的信息，保持原样的脱敏格式提交，如果和脱敏格式不一致，会认为是新的配置值更新原有配置</p>
        /// </summary>
        [JsonProperty("Config")]
        public string Config{ get; set; }

        /// <summary>
        /// <p>是否开启定时同步</p>
        /// </summary>
        [JsonProperty("SyncEnable")]
        public bool? SyncEnable{ get; set; }

        /// <summary>
        /// <p>定时同步的策略，枚举值：支持每4小时（4hours）/每日定时（daily）/每周定时（weekly）</p>
        /// </summary>
        [JsonProperty("SyncPolicy")]
        public string SyncPolicy{ get; set; }

        /// <summary>
        /// <p>JSON 字符串，针对不同类型的同步策略，提取对应不同的值</p>
        /// </summary>
        [JsonProperty("SyncPolicyParams")]
        public string SyncPolicyParams{ get; set; }

        /// <summary>
        /// <p>是否同步创建认证源</p>
        /// </summary>
        [JsonProperty("CreateAuthConfig")]
        public bool? CreateAuthConfig{ get; set; }

        /// <summary>
        /// <p>是否在登录页展示</p>
        /// </summary>
        [JsonProperty("DisplayOnLoginPage")]
        public bool? DisplayOnLoginPage{ get; set; }

        /// <summary>
        /// <p>企业目录 ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Config", this.Config);
            this.SetParamSimple(map, prefix + "SyncEnable", this.SyncEnable);
            this.SetParamSimple(map, prefix + "SyncPolicy", this.SyncPolicy);
            this.SetParamSimple(map, prefix + "SyncPolicyParams", this.SyncPolicyParams);
            this.SetParamSimple(map, prefix + "CreateAuthConfig", this.CreateAuthConfig);
            this.SetParamSimple(map, prefix + "DisplayOnLoginPage", this.DisplayOnLoginPage);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

